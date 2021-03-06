﻿using System;
using System.Linq;
using System.Collections.Generic;
using Pyro.Common.Enum;
using Pyro.Common.DtoEntity;
using Pyro.Common.Tools;
using Hl7.Fhir.Model;
using Pyro.Common.CompositionRoot;
using Pyro.Common.Service.ResourceService;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Rest;
using Pyro.Common.Service.SearchParameters;
using Pyro.Common.Search.SearchParameterEntity;
using Pyro.Common.ServiceSearchParameter;

namespace Pyro.Common.Search
{
  public class SearchParameterFactory : ISearchParameterFactory
  {
    private readonly char _ParameterNameParameterValueDilimeter = '=';
    private readonly char _ParameterNameModifierDilimeter = ':';
    private string _RawSearchParameterAndValueString = string.Empty;

    private readonly ISearchParameterServiceFactory ISearchParameterServiceFactory;
    private readonly ISearchParameterGenericFactory ISearchParameterGenericFactory;
    private readonly ISearchParameterReferanceFactory ISearchParameterReferanceFactory;
    private readonly IServiceSearchParameterCache IServiceSearchParameterCache;

    public SearchParameterFactory(ISearchParameterServiceFactory ISearchParameterServiceFactory, ISearchParameterGenericFactory ISearchParameterGenericFactory, ISearchParameterReferanceFactory ISearchParameterReferanceFactory, IServiceSearchParameterCache IServiceSearchParameterCache)
    {
      this.ISearchParameterServiceFactory = ISearchParameterServiceFactory;
      this.ISearchParameterGenericFactory = ISearchParameterGenericFactory;
      this.ISearchParameterReferanceFactory = ISearchParameterReferanceFactory;
      this.IServiceSearchParameterCache = IServiceSearchParameterCache;
    }

    public ISearchParameterBase CreateSearchParameter(DtoServiceSearchParameterLight DtoSupportedSearchParametersResource, Tuple<string, string> Parameter, bool IsChainedReferance = false)
    {


      ISearchParameterBase oSearchParameter = InitalizeSearchParameter(DtoSupportedSearchParametersResource.Type);

      string ParameterName = Parameter.Item1;
      string ParameterValue = Parameter.Item2;
      oSearchParameter.Id = DtoSupportedSearchParametersResource.Id;
      oSearchParameter.Resource = DtoSupportedSearchParametersResource.Resource;
      oSearchParameter.Name = DtoSupportedSearchParametersResource.Name;
      oSearchParameter.TargetResourceTypeList = DtoSupportedSearchParametersResource.TargetResourceTypeList;
      oSearchParameter.CompositeList = DtoSupportedSearchParametersResource.CompositeList;
      if (IsChainedReferance)
        oSearchParameter.RawValue = ParameterName + SearchParams.SEARCH_CHAINSEPARATOR;
      else
        oSearchParameter.RawValue = ParameterName + _ParameterNameParameterValueDilimeter + ParameterValue;
      _RawSearchParameterAndValueString = oSearchParameter.RawValue;

      if (!ParseModifier(ParameterName, oSearchParameter))
      {
        oSearchParameter.IsValid = false;
        oSearchParameter.InvalidMessage = $"Unable to parse the given search parameter's Modifier: {ParameterName}', ";
      }

      if (oSearchParameter.Type == SearchParamType.Reference)
      {
        (oSearchParameter as SearchParameterReferance).AllowedReferanceResourceList = ServiceSearchParameterFactory.GetSearchParameterTargetResourceList(oSearchParameter);
        (oSearchParameter as SearchParameterReferance).IsChained = IsChainedReferance;
      }

     
      if (oSearchParameter.Modifier == SearchParameter.SearchModifierCode.Type)
      {
        if (!oSearchParameter.TryParseValue($"{oSearchParameter.TypeModifierResource}/{ParameterValue}"))
        {
          oSearchParameter.IsValid = false;
        }
      }
      else if (DtoSupportedSearchParametersResource.Type == SearchParamType.Composite)
      {
        var SearchParameterComposite = oSearchParameter as SearchParameterComposite; 
        List<ISearchParameterBase> SearchParameterBaseList = new List<ISearchParameterBase>();
        var SearchListForResource = IServiceSearchParameterCache.GetSearchParameterForResource(DtoSupportedSearchParametersResource.Resource);
        //Note we OrderBy SequentialOrder as they must be processed in this specific order
        foreach (DtoServiceSearchParameterComposite Composite in DtoSupportedSearchParametersResource.CompositeList.OrderBy(x => x.SequentialOrder))        
        {
          DtoServiceSearchParameterLight CompositeSearchParamter = SearchListForResource.SingleOrDefault(x => x.Id == Composite.ChildServiceSearchParameterId);
          if (CompositeSearchParamter != null)
          {
            ISearchParameterBase CompositeSubSearchParameter = InitalizeSearchParameter(CompositeSearchParamter.Type);
            CompositeSubSearchParameter.Id = CompositeSearchParamter.Id;
            CompositeSubSearchParameter.Resource = CompositeSearchParamter.Resource;
            CompositeSubSearchParameter.Name = CompositeSearchParamter.Name;
            CompositeSubSearchParameter.TargetResourceTypeList = CompositeSearchParamter.TargetResourceTypeList;
            CompositeSubSearchParameter.CompositeList = CompositeSearchParamter.CompositeList;                        
            SearchParameterBaseList.Add(CompositeSubSearchParameter);
          }
          else
          {
            //This should not ever happen, but have message in case it does. We should never have a Composite
            //search parameter loaded like this as on load it is checked, but you never know!
            string Message =
                $"Unable to locate one of the SearchParameters referenced in a Composite SearchParametrer type. " +
                $"The Composite SearchParametrer name was '{DtoSupportedSearchParametersResource.Name}' for the resource type '{DtoSupportedSearchParametersResource.Resource}'. " +
                $"This SearchParamter references another SearchParamter with the Canonical Url of {Composite.Url}. " +
                $"This SearchParamter can not be located in the FHIR Server. This is most likely a server error that will require investigation to resolve";
            var OpOut = Common.Tools.FhirOperationOutcomeSupport.Create(OperationOutcome.IssueSeverity.Fatal, OperationOutcome.IssueType.Informational, Message);
            throw new Common.Exceptions.PyroException(System.Net.HttpStatusCode.InternalServerError, OpOut, Message);
          }       
        }
        if (!SearchParameterComposite.TryParseCompositeValue(SearchParameterBaseList, ParameterValue))
        {          
          oSearchParameter.IsValid = false;
        }
      }
      else
      {
        if (!oSearchParameter.TryParseValue(ParameterValue))
        {
          oSearchParameter.IsValid = false;
        }
      }

      return oSearchParameter;
    }

    private ISearchParameterBase InitalizeSearchParameter(SearchParamType DbSearchParameterType)
    {
      switch (DbSearchParameterType)
      {
        case SearchParamType.Number:
          return new SearchParameterNumber();
        case SearchParamType.Date:
          return new SearchParameterDateTime();
        case SearchParamType.String:
          return new SearchParameterString();
        case SearchParamType.Token:
          return new SearchParameterToken();
        case SearchParamType.Reference:
          return ISearchParameterReferanceFactory.CreateDtoSearchParameterReferance();
        case SearchParamType.Composite:
          return new SearchParameterComposite();        
        case SearchParamType.Quantity:
          return new SearchParameterQuantity();
        case SearchParamType.Uri:
          return new SearchParameterUri();
        default:
          throw new System.ComponentModel.InvalidEnumArgumentException(DbSearchParameterType.ToString(), (int)DbSearchParameterType, typeof(SearchParamType));
      }
    }
    private bool ParseModifier(string Name, ISearchParameterBase oSearchParameter)
    {
      if (Name.Contains(_ParameterNameModifierDilimeter))
      {
        return ParseModifierType(oSearchParameter, Name.Split(_ParameterNameModifierDilimeter)[1]);
      }
      else
      {
        oSearchParameter.Modifier = null;
        oSearchParameter.TypeModifierResource = null;
        return true;
      }
    }
    private bool ParseModifierType(ISearchParameterBase SearchParameter, string value)
    {
      var SearchModifierTypeDic = FhirSearchEnum.GetSearchModifierTypeDictionary();
      string ValueCaseCorrectly = StringSupport.ToLowerFast(value);
      if (SearchModifierTypeDic.ContainsKey(ValueCaseCorrectly))
      {
        SearchParameter.Modifier = SearchModifierTypeDic[ValueCaseCorrectly];
        return true;
      }
      else
      {
        string TypedResourceName = value;
        if (value.Contains("."))
        {
          char[] delimiters = { '.' };
          TypedResourceName = value.Split(delimiters)[0].Trim();
        }

        Type ResourceType = ModelInfo.GetTypeForFhirType(TypedResourceName);
        if (ResourceType != null && ModelInfo.IsKnownResource(ResourceType))
        {
          SearchParameter.TypeModifierResource = TypedResourceName;
          SearchParameter.Modifier = Hl7.Fhir.Model.SearchParameter.SearchModifierCode.Type;
          return true;
        }
        return false;
      }
    }

  }
}
