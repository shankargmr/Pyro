﻿using System;
using System.Collections.Generic;
using System.Linq;
using Pyro.Common.Interfaces.Dto;
using Pyro.Common.Tools.UriSupport;
using Pyro.Common.Interfaces.Service;
using Pyro.Common.Interfaces.Repositories;
using Pyro.Common.Enum;
using Pyro.Common.Tools;
using Hl7.Fhir.Model;
using Pyro.Common.CompositionRoot;
using Pyro.Common.Interfaces.ITools;
using Pyro.Common.Exceptions;
using System.Net;
using Hl7.Fhir.Utility;
using Pyro.Common.Search;
using Pyro.Common.Service;
using Pyro.Common.Tools.Headers;

namespace Pyro.Engine.Services
{
  public class ResourceServicesBase : CommonServices, IResourceServicesBase
  {
    protected IResourceRepository _ResourceRepository = null;
    protected readonly ICommonFactory ICommonFactory;
    private readonly IRepositorySwitcher IRepositorySwitcher;

    //Constructor for dependency injection
    public ResourceServicesBase(IUnitOfWork IUnitOfWork, IRepositorySwitcher IRepositorySwitcher, ICommonFactory ICommonFactory)
      : base(IUnitOfWork)
    {
      this.ICommonFactory = ICommonFactory;
      this.IRepositorySwitcher = IRepositorySwitcher;
    }

    public void SetCurrentResourceType(FHIRAllTypes ResourceType)
    {
      _CurrentResourceType = ResourceType;
      _ResourceRepository = IRepositorySwitcher.GetRepository(_CurrentResourceType);
    }

    public void SetCurrentResourceType(ResourceType ResourceType)
    {
      SetCurrentResourceType(ResourceType.GetLiteral());
    }

    public void SetCurrentResourceType(string ResourceName)
    {
      Type ResourceType = ModelInfo.GetTypeForFhirType(ResourceName);
      if (ResourceType != null && ModelInfo.IsKnownResource(ResourceType))
      {
        this.SetCurrentResourceType((FHIRAllTypes)ModelInfo.FhirTypeNameToFhirType(ResourceName));
      }
      else
      {
        string ErrorMessage = string.Empty;
        ResourceType = ModelInfo.GetTypeForFhirType(StringSupport.UppercaseFirst(ResourceName));
        if (ResourceType != null && ModelInfo.IsKnownResource(ResourceType))
        {
          ErrorMessage = $"The Resource name given '{ResourceName}' must begin with a capital letter, e.g ({StringSupport.UppercaseFirst(ResourceName)})";
        }
        else
        {
          ErrorMessage = $"The Resource name given '{ResourceName}' is not a Resource supported by the .net FHIR API Version: {ModelInfo.Version}.";
        }
        var OpOutCome = Common.Tools.FhirOperationOutcomeSupport.Create(OperationOutcome.IssueSeverity.Fatal, OperationOutcome.IssueType.Invalid, ErrorMessage);
        OpOutCome.Issue[0].Details = new CodeableConcept("http://hl7.org/fhir/operation-outcome", "MSG_UNKNOWN_TYPE", String.Format("Resource Type '{0}' not recognised", ResourceName));
        throw new PyroException(HttpStatusCode.BadRequest, OpOutCome, ErrorMessage);
      }
    }


    protected FHIRAllTypes _CurrentResourceType = FHIRAllTypes.AuditEvent;

    public FHIRAllTypes ServiceResourceType
    {
      get
      {
        return _CurrentResourceType;
      }
    }

    public IResourceServiceOutcome SetResourceCollectionAsDeleted(ICollection<string> ResourceIdCollection)
    {
      IResourceServiceOutcome oPyroServiceOperationOutcome = ICommonFactory.CreateResourceServiceOutcome();
      if (ResourceIdCollection.Count == 1)
      {
        //Delete one resource that is not already deleted 
        IDatabaseOperationOutcome DatabaseOperationOutcomeDelete = _ResourceRepository.UpdateResouceIdAsDeleted(ResourceIdCollection.First());
        oPyroServiceOperationOutcome.ResourceResult = null;
        oPyroServiceOperationOutcome.FhirResourceId = DatabaseOperationOutcomeDelete.ReturnedResourceList[0].FhirId;
        oPyroServiceOperationOutcome.LastModified = DatabaseOperationOutcomeDelete.ReturnedResourceList[0].Received;
        oPyroServiceOperationOutcome.IsDeleted = DatabaseOperationOutcomeDelete.ReturnedResourceList[0].IsDeleted;
        oPyroServiceOperationOutcome.OperationType = RestEnum.CrudOperationType.Delete;
        oPyroServiceOperationOutcome.ResourceVersionNumber = DatabaseOperationOutcomeDelete.ReturnedResourceList[0].Version;
        oPyroServiceOperationOutcome.RequestUri = null;
        oPyroServiceOperationOutcome.FormatMimeType = null;
        oPyroServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.NoContent;
        return oPyroServiceOperationOutcome;
      }
      else if (ResourceIdCollection.Count > 1)
      {
        //Delete many resources that are not already deleted 
        IDatabaseOperationOutcome DatabaseOperationOutcomeDeleteMany = _ResourceRepository.UpdateResouceIdColectionAsDeleted(ResourceIdCollection);
      }
      //Nothing to delete at all or many were deleted.
      oPyroServiceOperationOutcome.ResourceResult = null;
      oPyroServiceOperationOutcome.FhirResourceId = null;
      oPyroServiceOperationOutcome.LastModified = null;
      oPyroServiceOperationOutcome.IsDeleted = null;
      oPyroServiceOperationOutcome.OperationType = RestEnum.CrudOperationType.Delete;
      oPyroServiceOperationOutcome.ResourceVersionNumber = null;
      oPyroServiceOperationOutcome.RequestUri = null;
      oPyroServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.NoContent;

      return oPyroServiceOperationOutcome;
    }

    public IResourceServiceOutcome SetResource(Resource Resource, IPyroRequestUri RequestUri, RestEnum.CrudOperationType CrudOperationType)
    {
      if (CrudOperationType == RestEnum.CrudOperationType.Update && (Resource.Meta == null || string.IsNullOrWhiteSpace(Resource.Meta.VersionId)))
        throw new ArgumentNullException("Internal Server Error:Resource's Version can not be null when CrudOperationType = Update");
      if ((CrudOperationType != RestEnum.CrudOperationType.Create) && (CrudOperationType != RestEnum.CrudOperationType.Update))
        throw new FormatException("Internal Server Error: CrudOperationType must be Update or Create");
      if (CrudOperationType == RestEnum.CrudOperationType.Update && string.IsNullOrWhiteSpace(Resource.Id))
        throw new ArgumentNullException("Internal Server Error: Resource Id must be populated for CrudOperationType = Update");

      IResourceServiceOutcome ServiceOperationOutcome = ICommonFactory.CreateResourceServiceOutcome();

      //Assign GUID as FHIR id;
      if (string.IsNullOrWhiteSpace(Resource.Id))
        Resource.Id = Guid.NewGuid().ToString();

      string ResourceVersionNumber = string.Empty;
      if (Resource.Meta == null)
      {
        Resource.Meta = new Meta();
      }
      if (CrudOperationType == RestEnum.CrudOperationType.Create)
      {
        ResourceVersionNumber = Common.Tools.ResourceVersionNumber.FirstVersion();
        Resource.Meta.VersionId = ResourceVersionNumber;
      }
      else if (CrudOperationType == RestEnum.CrudOperationType.Update)
      {
        ResourceVersionNumber = Resource.Meta.VersionId;
      }
      Resource.Meta.LastUpdated = DateTimeOffset.Now;

      IDatabaseOperationOutcome DatabaseOperationOutcome = null;

      if (CrudOperationType == RestEnum.CrudOperationType.Update)
      {
        DatabaseOperationOutcome = _ResourceRepository.UpdateResource(ResourceVersionNumber, Resource, RequestUri);
      }
      else if (CrudOperationType == RestEnum.CrudOperationType.Create)
      {
        DatabaseOperationOutcome = _ResourceRepository.AddResource(Resource, RequestUri);
      }

      if (DatabaseOperationOutcome.ReturnedResourceList != null && DatabaseOperationOutcome.ReturnedResourceList.Count == 1)
      {
        ServiceOperationOutcome.ResourceResult = FhirResourceSerializationSupport.DeSerializeFromXml(DatabaseOperationOutcome.ReturnedResourceList[0].Xml);
        ServiceOperationOutcome.FhirResourceId = DatabaseOperationOutcome.ReturnedResourceList[0].FhirId;
        ServiceOperationOutcome.LastModified = DatabaseOperationOutcome.ReturnedResourceList[0].Received;
        ServiceOperationOutcome.IsDeleted = DatabaseOperationOutcome.ReturnedResourceList[0].IsDeleted;
        ServiceOperationOutcome.OperationType = CrudOperationType;
        ServiceOperationOutcome.ResourceVersionNumber = DatabaseOperationOutcome.ReturnedResourceList[0].Version;
        ServiceOperationOutcome.RequestUri = RequestUri.FhirRequestUri;
        //ServiceOperationOutcome.ServiceRootUri = RequestUri.PrimaryRootUrlStore.RootUri;
        ServiceOperationOutcome.FormatMimeType = null;
        if (CrudOperationType == RestEnum.CrudOperationType.Create)
          ServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.Created;
        if (CrudOperationType == RestEnum.CrudOperationType.Update)
          ServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.OK;
      }
      else
      {
        ServiceOperationOutcome.ResourceResult = null;
        ServiceOperationOutcome.FhirResourceId = string.Empty;
        ServiceOperationOutcome.LastModified = null;
        ServiceOperationOutcome.IsDeleted = null;
        ServiceOperationOutcome.OperationType = CrudOperationType;
        ServiceOperationOutcome.ResourceVersionNumber = string.Empty;
        ServiceOperationOutcome.RequestUri = RequestUri.FhirRequestUri;
        ServiceOperationOutcome.FormatMimeType = null;
        ServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.BadRequest;
      }
      return ServiceOperationOutcome;
    }

    public IResourceServiceOutcome GetResourceHistoryInFull(string ResourceId, IPyroRequestUri RequestUri, ISearchParametersServiceOutcome SearchParametersServiceOutcome, IResourceServiceOutcome oPyroServiceOperationOutcome)
    {
      IDatabaseOperationOutcome DatabaseOperationOutcome = _ResourceRepository.GetResourceHistoryByFhirID(ResourceId, SearchParametersServiceOutcome.SearchParameters);

      Uri SupportedSearchSelfLink = null;
      Uri.TryCreate(RequestUri.FhirRequestUri.OriginalString, UriKind.Absolute, out SupportedSearchSelfLink);

      oPyroServiceOperationOutcome.ResourceResult = Common.Tools.Bundles.FhirBundleSupport.CreateBundle(DatabaseOperationOutcome.ReturnedResourceList,
                                                                                           Bundle.BundleType.History,
                                                                                           RequestUri,
                                                                                           DatabaseOperationOutcome.SearchTotal,
                                                                                           DatabaseOperationOutcome.PagesTotal,
                                                                                           DatabaseOperationOutcome.PageRequested,
                                                                                           SupportedSearchSelfLink);
      oPyroServiceOperationOutcome.FhirResourceId = string.Empty;
      oPyroServiceOperationOutcome.LastModified = null;
      oPyroServiceOperationOutcome.IsDeleted = null;
      oPyroServiceOperationOutcome.OperationType = RestEnum.CrudOperationType.Read;
      oPyroServiceOperationOutcome.ResourceVersionNumber = string.Empty;
      oPyroServiceOperationOutcome.RequestUri = RequestUri.FhirRequestUri;
      oPyroServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.OK;

      return oPyroServiceOperationOutcome;
    }

    public IResourceServiceOutcome GetResourceHistoryInstance(string ResourceId, string Version, IPyroRequestUri RequestUri, IResourceServiceOutcome oPyroServiceOperationOutcome)
    {
      IDatabaseOperationOutcome DatabaseOperationOutcome = _ResourceRepository.GetResourceByFhirIDAndVersionNumber(ResourceId, Version);
      if (DatabaseOperationOutcome.ReturnedResourceList != null && DatabaseOperationOutcome.ReturnedResourceList.Count == 1)
      {
        if (!DatabaseOperationOutcome.ReturnedResourceList[0].IsDeleted)
          oPyroServiceOperationOutcome.ResourceResult = FhirResourceSerializationSupport.DeSerializeFromXml(DatabaseOperationOutcome.ReturnedResourceList[0].Xml);
        oPyroServiceOperationOutcome.FhirResourceId = DatabaseOperationOutcome.ReturnedResourceList[0].FhirId;
        oPyroServiceOperationOutcome.LastModified = DatabaseOperationOutcome.ReturnedResourceList[0].Received;
        oPyroServiceOperationOutcome.IsDeleted = DatabaseOperationOutcome.ReturnedResourceList[0].IsDeleted;
        oPyroServiceOperationOutcome.OperationType = RestEnum.CrudOperationType.Read;
        oPyroServiceOperationOutcome.ResourceVersionNumber = DatabaseOperationOutcome.ReturnedResourceList[0].Version;
        oPyroServiceOperationOutcome.RequestUri = RequestUri.FhirRequestUri;
        oPyroServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.OK;
      }
      else
      {
        oPyroServiceOperationOutcome.ResourceResult = null;
        oPyroServiceOperationOutcome.FhirResourceId = string.Empty;
        oPyroServiceOperationOutcome.LastModified = null;
        oPyroServiceOperationOutcome.IsDeleted = null;
        oPyroServiceOperationOutcome.OperationType = RestEnum.CrudOperationType.Read;
        oPyroServiceOperationOutcome.ResourceVersionNumber = string.Empty;
        oPyroServiceOperationOutcome.RequestUri = RequestUri.FhirRequestUri;
        oPyroServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.NotFound;
      }
      return oPyroServiceOperationOutcome;
    }

    public IResourceServiceOutcome GetResourceInstance(string ResourceId, IPyroRequestUri RequestUri, IResourceServiceOutcome oPyroServiceOperationOutcome, IRequestHeader RequestHeaders = null)
    {
      IDatabaseOperationOutcome DatabaseOperationOutcome = _ResourceRepository.GetResourceByFhirID(ResourceId, true);

      if (DatabaseOperationOutcome.ReturnedResourceList.Count == 1 && !DatabaseOperationOutcome.ReturnedResourceList[0].IsDeleted)
      {
        if (RequestHeaders != null &&
          (!string.IsNullOrWhiteSpace(RequestHeaders.IfNoneMatch) ||
          !string.IsNullOrWhiteSpace(RequestHeaders.IfModifiedSince)))
        {
          if (!HttpHeaderSupport.IsModifiedOrNoneMatch(RequestHeaders.IfNoneMatch,
            RequestHeaders.IfModifiedSince,
            DatabaseOperationOutcome.ReturnedResourceList[0].Version,
            DatabaseOperationOutcome.ReturnedResourceList[0].Received))
          {
            oPyroServiceOperationOutcome.ResourceResult = null;
            oPyroServiceOperationOutcome.FhirResourceId = DatabaseOperationOutcome.ReturnedResourceList[0].FhirId;
            oPyroServiceOperationOutcome.LastModified = DatabaseOperationOutcome.ReturnedResourceList[0].Received;
            oPyroServiceOperationOutcome.IsDeleted = DatabaseOperationOutcome.ReturnedResourceList[0].IsDeleted;
            oPyroServiceOperationOutcome.OperationType = RestEnum.CrudOperationType.Read;
            oPyroServiceOperationOutcome.ResourceVersionNumber = DatabaseOperationOutcome.ReturnedResourceList[0].Version;
            oPyroServiceOperationOutcome.RequestUri = RequestUri.FhirRequestUri;
            oPyroServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.NotModified;
            return oPyroServiceOperationOutcome;
          }
        }

        oPyroServiceOperationOutcome.ResourceResult = FhirResourceSerializationSupport.DeSerializeFromXml(DatabaseOperationOutcome.ReturnedResourceList[0].Xml);
        oPyroServiceOperationOutcome.FhirResourceId = DatabaseOperationOutcome.ReturnedResourceList[0].FhirId;
        oPyroServiceOperationOutcome.LastModified = DatabaseOperationOutcome.ReturnedResourceList[0].Received;
        oPyroServiceOperationOutcome.IsDeleted = DatabaseOperationOutcome.ReturnedResourceList[0].IsDeleted;
        oPyroServiceOperationOutcome.OperationType = RestEnum.CrudOperationType.Read;
        oPyroServiceOperationOutcome.ResourceVersionNumber = DatabaseOperationOutcome.ReturnedResourceList[0].Version;
        oPyroServiceOperationOutcome.RequestUri = RequestUri.FhirRequestUri;
        oPyroServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.OK;
      }
      else if (DatabaseOperationOutcome.ReturnedResourceList.Count == 1 && DatabaseOperationOutcome.ReturnedResourceList[0].IsDeleted)
      {
        oPyroServiceOperationOutcome.ResourceResult = null;
        oPyroServiceOperationOutcome.FhirResourceId = DatabaseOperationOutcome.ReturnedResourceList[0].FhirId;
        oPyroServiceOperationOutcome.LastModified = DatabaseOperationOutcome.ReturnedResourceList[0].Received;
        oPyroServiceOperationOutcome.IsDeleted = DatabaseOperationOutcome.ReturnedResourceList[0].IsDeleted;
        oPyroServiceOperationOutcome.OperationType = RestEnum.CrudOperationType.Read;
        oPyroServiceOperationOutcome.ResourceVersionNumber = DatabaseOperationOutcome.ReturnedResourceList[0].Version;
        oPyroServiceOperationOutcome.RequestUri = RequestUri.FhirRequestUri;
        oPyroServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.Gone;
      }
      else
      {
        oPyroServiceOperationOutcome.ResourceResult = null;
        oPyroServiceOperationOutcome.FhirResourceId = null;
        oPyroServiceOperationOutcome.LastModified = null;
        oPyroServiceOperationOutcome.IsDeleted = null;
        oPyroServiceOperationOutcome.OperationType = RestEnum.CrudOperationType.Read;
        oPyroServiceOperationOutcome.ResourceVersionNumber = null;
        oPyroServiceOperationOutcome.RequestUri = RequestUri.FhirRequestUri;
        oPyroServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.NotFound;
      }
      return oPyroServiceOperationOutcome;
    }

    private List<Common.BusinessEntities.Dto.DtoResource> ResolveIncludeResourceList(List<SearchParameterInclude> IncludeList, List<Common.BusinessEntities.Dto.DtoResource> SearchResourceList, bool Recursive = false)
    {
      if (IncludeList == null)
        throw new NullReferenceException("IncludeList cannot be null");

      if (SearchResourceList == null)
        throw new NullReferenceException("SearchResourceList cannot be null");

      var IncludeResourceList = new List<Common.BusinessEntities.Dto.DtoResource>();
      HashSet<string> CacheResourceIDsAlreadyCollected = null;

      IEnumerable<SearchParameterInclude> IncludeListToProcess = null;
      if (Recursive)
      {
        IncludeListToProcess = IncludeList.Where(x => x.IsRecurse);
      }
      else
      {
        CacheResourceIDsAlreadyCollected = new HashSet<string>();
        //Add all the source resources to the Cache list as their is no reason to get them again as they are in the bundle list
        SearchResourceList.ForEach(x => CacheResourceIDsAlreadyCollected.Add($"{x.ResourceType.GetLiteral()}-{x.FhirId}"));
        IncludeListToProcess = IncludeList;
      }

      foreach (var Resource in SearchResourceList)
      {
        //Only add when not recursive as this adds the source resource from initial search
        if (!Recursive)
          IncludeResourceList.Add(Resource);

        //Now process each include
        foreach (var include in IncludeListToProcess)
        {
          if (Resource.ResourceType.Value == include.SourceResourceType)
          {
            SetCurrentResourceType(Resource.ResourceType.Value);

            //We only want to get the include target Resources
            if (include.SearchParameterTargetResourceType.HasValue)
            {
              //Get the Search parameter Ids where the search parameter target list can contain the include's Resource target type
              int[] IdArray = include.SearchParameterList.Where(z => z.TargetResourceTypeList.Any(c => c.ResourceType.GetLiteral() == include.SearchParameterTargetResourceType.Value.GetLiteral())).Select(x => x.Id).ToArray();
              //Now only get the FhirId of the resources that have Search Index References that have these include target resource
              string[] FhirIdList = _ResourceRepository.GetResourceFhirIdByResourceIdAndIndexReferance2(Resource.Id, IdArray, include.SearchParameterTargetResourceType.Value.GetLiteral());
              //Set the repository to the include's target resource in order to get the include resources
              SetCurrentResourceType(include.SearchParameterTargetResourceType.Value);
              //Get each as long as it is not already gotten based on CacheResourceIDsAlreadyCollected list
              foreach (string FhirId in FhirIdList)
              {
                AddIncludeResourceInstance(IncludeResourceList, CacheResourceIDsAlreadyCollected, FhirId);
              }
            }
            else
            {
              //There is no include target so try and get all
              foreach (var IncludeItemSearchParameter in include.SearchParameterList)
              {
                foreach (var SearchParameterResourceTarget in IncludeItemSearchParameter.TargetResourceTypeList)
                {
                  //Switch source resource repository to get reference FhirIds
                  SetCurrentResourceType(Resource.ResourceType.Value);
                  string[] FhirIdList = _ResourceRepository.GetResourceFhirIdByResourceIdAndIndexReferance2(Resource.Id, new int[] { IncludeItemSearchParameter.Id }, SearchParameterResourceTarget.ResourceType.GetLiteral());
                  if (FhirIdList.Count() > 0)
                  {
                    //Switch to SearchParameterResourceTarget resource repository to get the include resource if found
                    SetCurrentResourceType(SearchParameterResourceTarget.ResourceType);
                    foreach (string FhirId in FhirIdList)
                    {
                      //Don't source the same resource again from the Database if we already have it
                      AddIncludeResourceInstance(IncludeResourceList, CacheResourceIDsAlreadyCollected, FhirId);
                    }
                  }
                }
              }
            }
          }
        }
      }
      return IncludeResourceList;
    }

    private void AddIncludeResourceInstance(List<Common.BusinessEntities.Dto.DtoResource> IncludeResourceList, HashSet<string> CacheResourceIDsAlreadyCollected, string FhirId)
    {
      //Don't source the same resource again from the Database if we already have it
      if (!CacheResourceIDsAlreadyCollected.Contains($"{this._CurrentResourceType.GetLiteral()}-{FhirId}"))
      {
        IDatabaseOperationOutcome DatabaseOperationOutcomeIncludes = _ResourceRepository.GetResourceByFhirID(FhirId, true, false);
        var DtoIncludeResourceList = new List<Common.BusinessEntities.Dto.DtoIncludeResource>();
        DatabaseOperationOutcomeIncludes.ReturnedResourceList.ForEach(x => DtoIncludeResourceList.Add(new Common.BusinessEntities.Dto.DtoIncludeResource(x)));
        IncludeResourceList.AddRange(DtoIncludeResourceList);
        CacheResourceIDsAlreadyCollected.Add($"{this._CurrentResourceType.GetLiteral()}-{FhirId}");
      }
    }

    public IResourceServiceOutcome GetResourcesBySearch(IPyroRequestUri RequestUri, ISearchParametersServiceOutcome SearchParametersServiceOutcome, IResourceServiceOutcome oPyroServiceOperationOutcome)
    {
      Uri SelfLink = SearchParametersServiceOutcome.SearchParameters.SupportedSearchUrl(RequestUri.FhirRequestUri.UriPrimaryServiceRoot.OriginalString);

      IDatabaseOperationOutcome DatabaseOperationOutcome = _ResourceRepository.GetResourceBySearch(SearchParametersServiceOutcome.SearchParameters, true);

      //Add any _include Resources
      if (SearchParametersServiceOutcome.SearchParameters != null && SearchParametersServiceOutcome.SearchParameters.IncludeList != null && DatabaseOperationOutcome.ReturnedResourceList != null)
      {
        DatabaseOperationOutcome.ReturnedResourceList = ResolveIncludeResourceList(SearchParametersServiceOutcome.SearchParameters.IncludeList, DatabaseOperationOutcome.ReturnedResourceList);
      }

      oPyroServiceOperationOutcome.ResourceResult = Common.Tools.Bundles.FhirBundleSupport.CreateBundle(DatabaseOperationOutcome.ReturnedResourceList,
                                                                                             Bundle.BundleType.Searchset,
                                                                                             RequestUri,
                                                                                             DatabaseOperationOutcome.SearchTotal,
                                                                                             DatabaseOperationOutcome.PagesTotal,
                                                                                             DatabaseOperationOutcome.PageRequested,
                                                                                             SelfLink);
      oPyroServiceOperationOutcome.FhirResourceId = string.Empty;
      oPyroServiceOperationOutcome.LastModified = null;
      oPyroServiceOperationOutcome.IsDeleted = null;
      oPyroServiceOperationOutcome.OperationType = RestEnum.CrudOperationType.Read;
      oPyroServiceOperationOutcome.ResourceVersionNumber = string.Empty;
      oPyroServiceOperationOutcome.RequestUri = RequestUri.FhirRequestUri;
      oPyroServiceOperationOutcome.FormatMimeType = SearchParametersServiceOutcome.SearchParameters.Format;
      oPyroServiceOperationOutcome.HttpStatusCode = System.Net.HttpStatusCode.OK;

      return oPyroServiceOperationOutcome;
    }

  }
}
