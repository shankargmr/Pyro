﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fhir = Hl7.Fhir;
using System.Net;
using System.Net.Http;
using Pyro.Common.Interfaces.Service;
using Pyro.Common.BusinessEntities.Dto;
using Hl7.Fhir.Model;
using System.Data.Entity;

namespace Pyro.Web.Services
{
  /// <summary>
  /// Negotiates the required Resource server based on the Resource name provided 
  /// </summary>
  public class ServiceNegotiator : IServiceNegotiator
  {
    private readonly SimpleInjector.Container _Container = null;
    private IDefaultResourceServices _DefaultResourceServices = null;    

    public ServiceNegotiator(SimpleInjector.Container Container)
    {
      _Container = Container;
    }

    public DbContextTransaction BeginTransaction()
    {
      if (_DefaultResourceServices == null)
        _DefaultResourceServices = _Container.GetInstance<IDefaultResourceServices>();
      return _DefaultResourceServices.BeginTransaction();      
    }

    public ICommonServices GetCommonService()
    {
      if (_DefaultResourceServices == null)
        _DefaultResourceServices = _Container.GetInstance<IDefaultResourceServices>();
      return _DefaultResourceServices as ICommonServices;      
    }
    public IResourceServicesBase GetResourceServiceBase(string ResourceName)
    {
      if (_DefaultResourceServices == null)
        _DefaultResourceServices = _Container.GetInstance<IDefaultResourceServices>();
      return TransactionalResourceService(ResourceName) as IResourceServicesBase;
    }

    public IResourceServices GetResourceService(string ResourceName)
    {
      return TransactionalResourceService(ResourceName);
    }

    private IResourceServices TransactionalResourceService(string ResourceName)
    {      
      Type ResourceType = ModelInfo.GetTypeForFhirType(ResourceName);
      if (ResourceType != null && ModelInfo.IsKnownResource(ResourceType))
      {
        if (_DefaultResourceServices == null)
          _DefaultResourceServices = _Container.GetInstance<IDefaultResourceServices>();
        FHIRAllTypes FHIRAllTypes = (FHIRAllTypes)ModelInfo.FhirTypeNameToFhirType(ResourceName);
        _DefaultResourceServices.SetCurrentResourceType = FHIRAllTypes;        
        return _DefaultResourceServices;
      }
      else
      {
        string ErrorMessage = $"The Resource name given '{ResourceName}' is not a Resource supported by the .net FHIR API Version: {ModelInfo.Version}.";
        var OpOutCome = Common.Tools.FhirOperationOutcomeSupport.Create(OperationOutcome.IssueSeverity.Fatal, OperationOutcome.IssueType.Invalid, ErrorMessage);
        OpOutCome.Issue[0].Details = new CodeableConcept("http://hl7.org/fhir/operation-outcome", "MSG_UNKNOWN_TYPE", String.Format("Resource Type '{0}' not recognised", ResourceName));
        throw new DtoPyroException(HttpStatusCode.BadRequest, OpOutCome, ErrorMessage);
      }
    }
    
  }
}
