﻿using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Source;
using System.Collections.Generic;
using System.Linq;
using Pyro.Common.Interfaces.Service;
using Hl7.Fhir.Utility;

namespace Pyro.Common.Tools.FhirResourceValidation
{
  public class InternalServerProfileResolver : IResourceResolver
  {
    private IResourceServices _ResourceServices;
    private Common.Cache.CacheCommon _Cache;

    public InternalServerProfileResolver(IResourceServices ResourceServices)
    {
      _ResourceServices = ResourceServices;
      _ResourceServices.SetCurrentResourceType(FHIRAllTypes.StructureDefinition);
      _Cache = new Common.Cache.CacheCommon();
    }
    public Resource ResolveByCanonicalUri(string uri)
    {
      Interfaces.Dto.IDtoRootUrlStore PrimaryRootUrlStore = _Cache.GetPrimaryRootUrlStore(_ResourceServices);
      string PrimaryServiceRoot = PrimaryRootUrlStore.Url;
      string RequestUriString = $"{PrimaryServiceRoot}/{ResourceType.StructureDefinition.GetLiteral()}/?url={uri}";
      Interfaces.UriSupport.IFhirRequestUri FhirRequestUri = CommonFactory.GetFhirRequestUri(PrimaryServiceRoot, RequestUriString);
      Interfaces.UriSupport.IDtoRequestUri RequestUri = CommonFactory.GetRequestUri(PrimaryRootUrlStore, FhirRequestUri);
      Interfaces.Dto.IDtoSearchParameterGeneric SearchParameterGeneric = Common.CommonFactory.GetDtoSearchParameterGeneric($"url={ uri}");
      IResourceServiceRequestGetSearch ResourceServiceRequestGetSearch = Common.CommonFactory.GetResourceServiceRequestGetSearch(RequestUri, SearchParameterGeneric);
      IResourceServiceOutcome ResourceServiceOutcome = _ResourceServices.GetSearch(ResourceServiceRequestGetSearch);
      if (ResourceServiceOutcome.ResourceResult != null && (ResourceServiceOutcome.ResourceResult as Bundle).Entry.Count > 1)
      {
        throw new System.Exception($"More than a single {ResourceType.StructureDefinition.GetLiteral()} instance was found with the Canonical Uri of {uri} at the endpoint {PrimaryServiceRoot + "/" + ResourceType.StructureDefinition.GetLiteral()}.");
      }
      else if (ResourceServiceOutcome.ResourceResult != null && ResourceServiceOutcome.ResourceResult is Bundle bundle && bundle.Entry.Count == 1)
      {
        return bundle.Entry[0].Resource;
      }
      else
      {
        return null;
      }
    }

    public Resource ResolveByUri(string uri)
    {
      string PrimaryServiceRoot = _Cache.GetPrimaryRootUrlStore(_ResourceServices).Url;
      string RequestUriString = System.IO.Path.Combine(PrimaryServiceRoot, uri);
      var DtoRequestHeaders = new Pyro.Common.BusinessEntities.Dto.Headers.DtoRequestHeaders();
      Interfaces.UriSupport.IFhirRequestUri FhirRequestUri = CommonFactory.GetFhirRequestUri(PrimaryServiceRoot, RequestUriString);
      Interfaces.UriSupport.IDtoRequestUri RequestUri = CommonFactory.GetRequestUri(_Cache.GetPrimaryRootUrlStore(_ResourceServices), FhirRequestUri);
      Interfaces.Dto.IDtoSearchParameterGeneric SearchParameterGeneric = Common.CommonFactory.GetDtoSearchParameterGeneric();
      IResourceServiceRequestGetRead ResourceServiceRequestGetSearch = Common.CommonFactory.GetResourceServiceRequestGetRead(FhirRequestUri.ResourceId, RequestUri, SearchParameterGeneric, DtoRequestHeaders);
      IResourceServiceOutcome ResourceServiceOutcome = _ResourceServices.GetRead(ResourceServiceRequestGetSearch);
      return ResourceServiceOutcome.ResourceResult;

    }
  }
}
