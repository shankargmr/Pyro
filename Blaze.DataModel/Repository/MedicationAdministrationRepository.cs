﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Linq.Expressions;
using Blaze.DataModel.DatabaseModel;
using Blaze.DataModel.DatabaseModel.Base;
using Blaze.DataModel.Support;
using Hl7.Fhir.Model;
using Blaze.Common.BusinessEntities;
using Blaze.Common.Interfaces;
using Blaze.Common.Interfaces.Repositories;
using Blaze.Common.Interfaces.UriSupport;
using Hl7.Fhir.Introspection;

namespace Blaze.DataModel.Repository
{
  public partial class MedicationAdministrationRepository : CommonRepository, IResourceRepository
  {

    public MedicationAdministrationRepository(DataModel.DatabaseModel.DatabaseContext Context) : base(Context) { }

    public IDatabaseOperationOutcome AddResource(Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceTyped = Resource as MedicationAdministration;
      var ResourceEntity = new Res_MedicationAdministration();
      this.PopulateResourceEntity(ResourceEntity, "1", ResourceTyped, FhirRequestUri);
      this.DbAddEntity<Res_MedicationAdministration>(ResourceEntity);
      IDatabaseOperationOutcome DatabaseOperationOutcome = new DatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = true;     
      DatabaseOperationOutcome.ResourceMatchingSearch = IndexSettingSupport.SetDtoResource(ResourceEntity);
      DatabaseOperationOutcome.ResourcesMatchingSearchCount = 1;
      return DatabaseOperationOutcome;
    }

    public IDatabaseOperationOutcome UpdateResource(string ResourceVersion, Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceTyped = Resource as MedicationAdministration;
      var ResourceEntity = LoadCurrentResourceEntity(Resource.Id);
      var ResourceHistoryEntity = new Res_MedicationAdministration_History();  
      IndexSettingSupport.SetHistoryResourceEntity(ResourceEntity, ResourceHistoryEntity);
      ResourceEntity.Res_MedicationAdministration_History_List.Add(ResourceHistoryEntity); 
      this.ResetResourceEntity(ResourceEntity);
      this.PopulateResourceEntity(ResourceEntity, ResourceVersion, ResourceTyped, FhirRequestUri);            
      this.Save();            
      IDatabaseOperationOutcome DatabaseOperationOutcome = new DatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = true;
      DatabaseOperationOutcome.ResourceMatchingSearch = IndexSettingSupport.SetDtoResource(ResourceEntity);
      DatabaseOperationOutcome.ResourcesMatchingSearchCount = 1;
      return DatabaseOperationOutcome;
    }

    public void UpdateResouceAsDeleted(string FhirResourceId, string ResourceVersion)
    {
      var ResourceEntity = this.LoadCurrentResourceEntity(FhirResourceId);
      var ResourceHistoryEntity = new Res_MedicationAdministration_History();
      IndexSettingSupport.SetHistoryResourceEntity(ResourceEntity, ResourceHistoryEntity);
      ResourceEntity.Res_MedicationAdministration_History_List.Add(ResourceHistoryEntity);
      this.ResetResourceEntity(ResourceEntity);
      ResourceEntity.IsDeleted = true;
      ResourceEntity.versionId = ResourceVersion;
      this.Save();      
    }

    public IDatabaseOperationOutcome GetResourceByFhirIDAndVersionNumber(string FhirResourceId, string ResourceVersionNumber)
    {
      IDatabaseOperationOutcome DatabaseOperationOutcome = new DatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = true;
      var ResourceHistoryEntity = DbGet<Res_MedicationAdministration_History>(x => x.FhirId == FhirResourceId && x.versionId == ResourceVersionNumber);
      if (ResourceHistoryEntity != null)
      {
        DatabaseOperationOutcome.ResourceMatchingSearch = IndexSettingSupport.SetDtoResource(ResourceHistoryEntity);
      }
      else
      {
        var ResourceEntity = DbGet<Res_MedicationAdministration>(x => x.FhirId == FhirResourceId && x.versionId == ResourceVersionNumber);
        if (ResourceEntity != null)
          DatabaseOperationOutcome.ResourceMatchingSearch = IndexSettingSupport.SetDtoResource(ResourceEntity);        
      }
      return DatabaseOperationOutcome;
    }

    public IDatabaseOperationOutcome GetResourceByFhirID(string FhirResourceId, bool WithXml = false)
    {
      IDatabaseOperationOutcome DatabaseOperationOutcome = new DatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = true;
      Blaze.Common.BusinessEntities.Dto.DtoResource DtoResource = null;
      if (WithXml)
      {        
        DtoResource = DbGetALL<Res_MedicationAdministration>(x => x.FhirId == FhirResourceId).Select(x => new Blaze.Common.BusinessEntities.Dto.DtoResource { FhirId = x.FhirId, IsDeleted = x.IsDeleted, IsCurrent = true, Version = x.versionId, Received = x.lastUpdated, Xml = x.XmlBlob }).SingleOrDefault();       
      }
      else
      {
        DtoResource = DbGetALL<Res_MedicationAdministration>(x => x.FhirId == FhirResourceId).Select(x => new Blaze.Common.BusinessEntities.Dto.DtoResource { FhirId = x.FhirId, IsDeleted = x.IsDeleted, IsCurrent = true, Version = x.versionId, Received = x.lastUpdated }).SingleOrDefault();        
      }
      DatabaseOperationOutcome.ResourceMatchingSearch = DtoResource;
      return DatabaseOperationOutcome;
    }

    private Res_MedicationAdministration LoadCurrentResourceEntity(string FhirId)
    {

      var IncludeList = new List<Expression<Func<Res_MedicationAdministration, object>>>();
      IncludeList.Add(x => x.code_List);
      IncludeList.Add(x => x.device_List);
      IncludeList.Add(x => x.identifier_List);
      IncludeList.Add(x => x.profile_List);
      IncludeList.Add(x => x.security_List);
      IncludeList.Add(x => x.tag_List);
    
      var ResourceEntity = DbQueryEntityWithInclude<Res_MedicationAdministration>(x => x.FhirId == FhirId, IncludeList);

      return ResourceEntity;
    }


    private void ResetResourceEntity(Res_MedicationAdministration ResourceEntity)
    {
      ResourceEntity.effectivetime_DateTimeOffset = null;      
      ResourceEntity.encounter_FhirId = null;      
      ResourceEntity.encounter_Type = null;      
      ResourceEntity.encounter_Url = null;      
      ResourceEntity.encounter_Url_Blaze_RootUrlStoreID = null;      
      ResourceEntity.medication_FhirId = null;      
      ResourceEntity.medication_Type = null;      
      ResourceEntity.medication_Url = null;      
      ResourceEntity.medication_Url_Blaze_RootUrlStoreID = null;      
      ResourceEntity.patient_FhirId = null;      
      ResourceEntity.patient_Type = null;      
      ResourceEntity.patient_Url = null;      
      ResourceEntity.patient_Url_Blaze_RootUrlStoreID = null;      
      ResourceEntity.practitioner_FhirId = null;      
      ResourceEntity.practitioner_Type = null;      
      ResourceEntity.practitioner_Url = null;      
      ResourceEntity.practitioner_Url_Blaze_RootUrlStoreID = null;      
      ResourceEntity.prescription_FhirId = null;      
      ResourceEntity.prescription_Type = null;      
      ResourceEntity.prescription_Url = null;      
      ResourceEntity.prescription_Url_Blaze_RootUrlStoreID = null;      
      ResourceEntity.status_Code = null;      
      ResourceEntity.status_System = null;      
      ResourceEntity.wasnotgiven_Code = null;      
      ResourceEntity.wasnotgiven_System = null;      
      ResourceEntity.XmlBlob = null;      
 
      
      _Context.Res_MedicationAdministration_Index_code.RemoveRange(ResourceEntity.code_List);            
      _Context.Res_MedicationAdministration_Index_device.RemoveRange(ResourceEntity.device_List);            
      _Context.Res_MedicationAdministration_Index_identifier.RemoveRange(ResourceEntity.identifier_List);            
      _Context.Res_MedicationAdministration_Index_profile.RemoveRange(ResourceEntity.profile_List);            
      _Context.Res_MedicationAdministration_Index_security.RemoveRange(ResourceEntity.security_List);            
      _Context.Res_MedicationAdministration_Index_tag.RemoveRange(ResourceEntity.tag_List);            
 
    }

    private void PopulateResourceEntity(Res_MedicationAdministration ResourseEntity, string ResourceVersion, MedicationAdministration ResourceTyped, IDtoFhirRequestUri FhirRequestUri)
    {
       IndexSettingSupport.SetResourceBaseAddOrUpdate(ResourceTyped, ResourseEntity, ResourceVersion, false);

          if (ResourceTyped.EffectiveTime != null)
      {
        var Index = IndexSettingSupport.SetIndex<DateIndex>(new DateIndex(), ResourceTyped.EffectiveTime);
        if (Index != null)
        {
          ResourseEntity.effectivetime_DateTimeOffset = Index.DateTimeOffset;
        }
      }

      if (ResourceTyped.Encounter != null)
      {
        {
          var Index = IndexSettingSupport.SetIndex<ReferenceIndex>(new ReferenceIndex(), ResourceTyped.Encounter, FhirRequestUri, this);
          if (Index != null)
          {
            ResourseEntity.encounter_Type = Index.Type;
            ResourseEntity.encounter_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.encounter_Url = Index.Url;
            }
            else
            {
              ResourseEntity.encounter_Url_Blaze_RootUrlStoreID = Index.Url_Blaze_RootUrlStoreID;
            }
          }
        }
      }

      if (ResourceTyped.Medication != null)
      {
        {
          var Index = IndexSettingSupport.SetIndex<ReferenceIndex>(new ReferenceIndex(), ResourceTyped.Medication, FhirRequestUri, this);
          if (Index != null)
          {
            ResourseEntity.medication_Type = Index.Type;
            ResourseEntity.medication_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.medication_Url = Index.Url;
            }
            else
            {
              ResourseEntity.medication_Url_Blaze_RootUrlStoreID = Index.Url_Blaze_RootUrlStoreID;
            }
          }
        }
      }

      if (ResourceTyped.Patient != null)
      {
        {
          var Index = IndexSettingSupport.SetIndex<ReferenceIndex>(new ReferenceIndex(), ResourceTyped.Patient, FhirRequestUri, this);
          if (Index != null)
          {
            ResourseEntity.patient_Type = Index.Type;
            ResourseEntity.patient_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.patient_Url = Index.Url;
            }
            else
            {
              ResourseEntity.patient_Url_Blaze_RootUrlStoreID = Index.Url_Blaze_RootUrlStoreID;
            }
          }
        }
      }

      if (ResourceTyped.Practitioner != null)
      {
        {
          var Index = IndexSettingSupport.SetIndex<ReferenceIndex>(new ReferenceIndex(), ResourceTyped.Practitioner, FhirRequestUri, this);
          if (Index != null)
          {
            ResourseEntity.practitioner_Type = Index.Type;
            ResourseEntity.practitioner_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.practitioner_Url = Index.Url;
            }
            else
            {
              ResourseEntity.practitioner_Url_Blaze_RootUrlStoreID = Index.Url_Blaze_RootUrlStoreID;
            }
          }
        }
      }

      if (ResourceTyped.Prescription != null)
      {
        {
          var Index = IndexSettingSupport.SetIndex<ReferenceIndex>(new ReferenceIndex(), ResourceTyped.Prescription, FhirRequestUri, this);
          if (Index != null)
          {
            ResourseEntity.prescription_Type = Index.Type;
            ResourseEntity.prescription_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.prescription_Url = Index.Url;
            }
            else
            {
              ResourseEntity.prescription_Url_Blaze_RootUrlStoreID = Index.Url_Blaze_RootUrlStoreID;
            }
          }
        }
      }

      if (ResourceTyped.Status != null)
      {
        var Index = IndexSettingSupport.SetIndex<TokenIndex>(new TokenIndex(), ResourceTyped.StatusElement);
        if (Index != null)
        {
          ResourseEntity.status_Code = Index.Code;
          ResourseEntity.status_System = Index.System;
        }
      }

      if (ResourceTyped.WasNotGiven != null)
      {
        var Index = IndexSettingSupport.SetIndex<TokenIndex>(new TokenIndex(), ResourceTyped.WasNotGivenElement);
        if (Index != null)
        {
          ResourseEntity.wasnotgiven_Code = Index.Code;
          ResourseEntity.wasnotgiven_System = Index.System;
        }
      }

      if (ResourceTyped.Medication != null)
      {
        if (ResourceTyped.Medication is CodeableConcept)
        {
          CodeableConcept CodeableConcept = ResourceTyped.Medication as CodeableConcept;
          foreach (var item3 in CodeableConcept.Coding)
          {
            var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_MedicationAdministration_Index_code(), item3) as Res_MedicationAdministration_Index_code;
            ResourseEntity.code_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.Device != null)
      {
        foreach (var item in ResourceTyped.Device)
        {
          var Index = IndexSettingSupport.SetIndex<ReferenceIndex>(new Res_MedicationAdministration_Index_device(), item, FhirRequestUri, this) as Res_MedicationAdministration_Index_device;
          if (Index != null)
          {
            ResourseEntity.device_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.Identifier != null)
      {
        foreach (var item3 in ResourceTyped.Identifier)
        {
          var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_MedicationAdministration_Index_identifier(), item3) as Res_MedicationAdministration_Index_identifier;
          ResourseEntity.identifier_List.Add(Index);
        }
      }

      if (ResourceTyped.Meta != null)
      {
        if (ResourceTyped.Meta.Profile != null)
        {
          foreach (var item4 in ResourceTyped.Meta.ProfileElement)
          {
            var Index = IndexSettingSupport.SetIndex<UriIndex>(new Res_MedicationAdministration_Index_profile(), item4) as Res_MedicationAdministration_Index_profile;
            ResourseEntity.profile_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.Meta != null)
      {
        if (ResourceTyped.Meta.Security != null)
        {
          foreach (var item4 in ResourceTyped.Meta.Security)
          {
            var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_MedicationAdministration_Index_security(), item4) as Res_MedicationAdministration_Index_security;
            ResourseEntity.security_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.Meta != null)
      {
        if (ResourceTyped.Meta.Tag != null)
        {
          foreach (var item4 in ResourceTyped.Meta.Tag)
          {
            var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_MedicationAdministration_Index_tag(), item4) as Res_MedicationAdministration_Index_tag;
            ResourseEntity.tag_List.Add(Index);
          }
        }
      }


      

    }


  }
} 
