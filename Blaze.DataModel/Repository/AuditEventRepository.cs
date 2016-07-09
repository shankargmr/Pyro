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
  public partial class AuditEventRepository : CommonRepository, IResourceRepository
  {

    public AuditEventRepository(DataModel.DatabaseModel.DatabaseContext Context) : base(Context) { }

    public IDatabaseOperationOutcome AddResource(Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceTyped = Resource as AuditEvent;
      var ResourceEntity = new Res_AuditEvent();
      this.PopulateResourceEntity(ResourceEntity, "1", ResourceTyped, FhirRequestUri);
      this.DbAddEntity<Res_AuditEvent>(ResourceEntity);
      IDatabaseOperationOutcome DatabaseOperationOutcome = new DatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = true;     
      DatabaseOperationOutcome.ResourceMatchingSearch = IndexSettingSupport.SetDtoResource(ResourceEntity);
      DatabaseOperationOutcome.ResourcesMatchingSearchCount = 1;
      return DatabaseOperationOutcome;
    }

    public IDatabaseOperationOutcome UpdateResource(string ResourceVersion, Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceTyped = Resource as AuditEvent;
      var ResourceEntity = LoadCurrentResourceEntity(Resource.Id);
      var ResourceHistoryEntity = new Res_AuditEvent_History();  
      IndexSettingSupport.SetHistoryResourceEntity(ResourceEntity, ResourceHistoryEntity);
      ResourceEntity.Res_AuditEvent_History_List.Add(ResourceHistoryEntity); 
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
      var ResourceHistoryEntity = new Res_AuditEvent_History();
      IndexSettingSupport.SetHistoryResourceEntity(ResourceEntity, ResourceHistoryEntity);
      ResourceEntity.Res_AuditEvent_History_List.Add(ResourceHistoryEntity);
      this.ResetResourceEntity(ResourceEntity);
      ResourceEntity.IsDeleted = true;
      ResourceEntity.versionId = ResourceVersion;
      this.Save();      
    }

    public IDatabaseOperationOutcome GetResourceByFhirIDAndVersionNumber(string FhirResourceId, string ResourceVersionNumber)
    {
      IDatabaseOperationOutcome DatabaseOperationOutcome = new DatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = true;
      var ResourceHistoryEntity = DbGet<Res_AuditEvent_History>(x => x.FhirId == FhirResourceId && x.versionId == ResourceVersionNumber);
      if (ResourceHistoryEntity != null)
      {
        DatabaseOperationOutcome.ResourceMatchingSearch = IndexSettingSupport.SetDtoResource(ResourceHistoryEntity);
      }
      else
      {
        var ResourceEntity = DbGet<Res_AuditEvent>(x => x.FhirId == FhirResourceId && x.versionId == ResourceVersionNumber);
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
        DtoResource = DbGetALL<Res_AuditEvent>(x => x.FhirId == FhirResourceId).Select(x => new Blaze.Common.BusinessEntities.Dto.DtoResource { FhirId = x.FhirId, IsDeleted = x.IsDeleted, IsCurrent = true, Version = x.versionId, Received = x.lastUpdated, Xml = x.XmlBlob }).SingleOrDefault();       
      }
      else
      {
        DtoResource = DbGetALL<Res_AuditEvent>(x => x.FhirId == FhirResourceId).Select(x => new Blaze.Common.BusinessEntities.Dto.DtoResource { FhirId = x.FhirId, IsDeleted = x.IsDeleted, IsCurrent = true, Version = x.versionId, Received = x.lastUpdated }).SingleOrDefault();        
      }
      DatabaseOperationOutcome.ResourceMatchingSearch = DtoResource;
      return DatabaseOperationOutcome;
    }

    private Res_AuditEvent LoadCurrentResourceEntity(string FhirId)
    {

      var IncludeList = new List<Expression<Func<Res_AuditEvent, object>>>();
      IncludeList.Add(x => x.address_List);
      IncludeList.Add(x => x.agent_List);
      IncludeList.Add(x => x.agent_name_List);
      IncludeList.Add(x => x.altid_List);
      IncludeList.Add(x => x.entity_List);
      IncludeList.Add(x => x.entity_id_List);
      IncludeList.Add(x => x.entity_name_List);
      IncludeList.Add(x => x.entity_type_List);
      IncludeList.Add(x => x.patient_List);
      IncludeList.Add(x => x.policy_List);
      IncludeList.Add(x => x.subtype_List);
      IncludeList.Add(x => x.user_List);
      IncludeList.Add(x => x.profile_List);
      IncludeList.Add(x => x.security_List);
      IncludeList.Add(x => x.tag_List);
    
      var ResourceEntity = DbQueryEntityWithInclude<Res_AuditEvent>(x => x.FhirId == FhirId, IncludeList);

      return ResourceEntity;
    }


    private void ResetResourceEntity(Res_AuditEvent ResourceEntity)
    {
      ResourceEntity.action_Code = null;      
      ResourceEntity.action_System = null;      
      ResourceEntity.date_DateTimeOffset = null;      
      ResourceEntity.site_Code = null;      
      ResourceEntity.site_System = null;      
      ResourceEntity.source_Code = null;      
      ResourceEntity.source_System = null;      
      ResourceEntity.type_Code = null;      
      ResourceEntity.type_System = null;      
      ResourceEntity.XmlBlob = null;      
 
      
      _Context.Res_AuditEvent_Index_address.RemoveRange(ResourceEntity.address_List);            
      _Context.Res_AuditEvent_Index_agent.RemoveRange(ResourceEntity.agent_List);            
      _Context.Res_AuditEvent_Index_agent_name.RemoveRange(ResourceEntity.agent_name_List);            
      _Context.Res_AuditEvent_Index_altid.RemoveRange(ResourceEntity.altid_List);            
      _Context.Res_AuditEvent_Index_entity.RemoveRange(ResourceEntity.entity_List);            
      _Context.Res_AuditEvent_Index_entity_id.RemoveRange(ResourceEntity.entity_id_List);            
      _Context.Res_AuditEvent_Index_entity_name.RemoveRange(ResourceEntity.entity_name_List);            
      _Context.Res_AuditEvent_Index_entity_type.RemoveRange(ResourceEntity.entity_type_List);            
      _Context.Res_AuditEvent_Index_patient.RemoveRange(ResourceEntity.patient_List);            
      _Context.Res_AuditEvent_Index_policy.RemoveRange(ResourceEntity.policy_List);            
      _Context.Res_AuditEvent_Index_subtype.RemoveRange(ResourceEntity.subtype_List);            
      _Context.Res_AuditEvent_Index_user.RemoveRange(ResourceEntity.user_List);            
      _Context.Res_AuditEvent_Index_profile.RemoveRange(ResourceEntity.profile_List);            
      _Context.Res_AuditEvent_Index_security.RemoveRange(ResourceEntity.security_List);            
      _Context.Res_AuditEvent_Index_tag.RemoveRange(ResourceEntity.tag_List);            
 
    }

    private void PopulateResourceEntity(Res_AuditEvent ResourseEntity, string ResourceVersion, AuditEvent ResourceTyped, IDtoFhirRequestUri FhirRequestUri)
    {
       IndexSettingSupport.SetResourceBaseAddOrUpdate(ResourceTyped, ResourseEntity, ResourceVersion, false);

          if (ResourceTyped.Action != null)
      {
        var Index = IndexSettingSupport.SetIndex<TokenIndex>(new TokenIndex(), ResourceTyped.ActionElement);
        if (Index != null)
        {
          ResourseEntity.action_Code = Index.Code;
          ResourseEntity.action_System = Index.System;
        }
      }

      if (ResourceTyped.Recorded != null)
      {
        var Index = IndexSettingSupport.SetIndex<DateIndex>(new DateIndex(), ResourceTyped.RecordedElement);
        if (Index != null)
        {
          ResourseEntity.date_DateTimeOffset = Index.DateTimeOffset;
        }
      }

      if (ResourceTyped.Source != null)
      {
        if (ResourceTyped.Source.Site != null)
        {
          var Index = IndexSettingSupport.SetIndex<TokenIndex>(new TokenIndex(), ResourceTyped.Source.SiteElement);
          if (Index != null)
          {
            ResourseEntity.site_Code = Index.Code;
            ResourseEntity.site_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Source != null)
      {
        if (ResourceTyped.Source.Identifier != null)
        {
          var Index = IndexSettingSupport.SetIndex<TokenIndex>(new TokenIndex(), ResourceTyped.Source.Identifier);
          if (Index != null)
          {
            ResourseEntity.source_Code = Index.Code;
            ResourseEntity.source_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Type != null)
      {
        var Index = IndexSettingSupport.SetIndex<TokenIndex>(new TokenIndex(), ResourceTyped.Type);
        if (Index != null)
        {
          ResourseEntity.type_Code = Index.Code;
          ResourseEntity.type_System = Index.System;
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.Network != null)
        {
          if (item1.Network.Address != null)
          {
            var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_AuditEvent_Index_address(), item1.Network.AddressElement) as Res_AuditEvent_Index_address;
            ResourseEntity.address_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.Reference != null)
        {
          var Index = IndexSettingSupport.SetIndex<ReferenceIndex>(new Res_AuditEvent_Index_agent(), item1.Reference, FhirRequestUri, this) as Res_AuditEvent_Index_agent;
          if (Index != null)
          {
            ResourseEntity.agent_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.Name != null)
        {
          var Index = IndexSettingSupport.SetIndex<StringIndex>(new Res_AuditEvent_Index_agent_name(), item1.NameElement) as Res_AuditEvent_Index_agent_name;
          ResourseEntity.agent_name_List.Add(Index);
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.AltId != null)
        {
          var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_AuditEvent_Index_altid(), item1.AltIdElement) as Res_AuditEvent_Index_altid;
          ResourseEntity.altid_List.Add(Index);
        }
      }

      foreach (var item1 in ResourceTyped.Entity)
      {
        if (item1.Reference != null)
        {
          var Index = IndexSettingSupport.SetIndex<ReferenceIndex>(new Res_AuditEvent_Index_entity(), item1.Reference, FhirRequestUri, this) as Res_AuditEvent_Index_entity;
          if (Index != null)
          {
            ResourseEntity.entity_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Entity)
      {
        if (item1.Identifier != null)
        {
          var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_AuditEvent_Index_entity_id(), item1.Identifier) as Res_AuditEvent_Index_entity_id;
          ResourseEntity.entity_id_List.Add(Index);
        }
      }

      foreach (var item1 in ResourceTyped.Entity)
      {
        if (item1.Name != null)
        {
          var Index = IndexSettingSupport.SetIndex<StringIndex>(new Res_AuditEvent_Index_entity_name(), item1.NameElement) as Res_AuditEvent_Index_entity_name;
          ResourseEntity.entity_name_List.Add(Index);
        }
      }

      foreach (var item1 in ResourceTyped.Entity)
      {
        if (item1.Type != null)
        {
          var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_AuditEvent_Index_entity_type(), item1.Type) as Res_AuditEvent_Index_entity_type;
          ResourseEntity.entity_type_List.Add(Index);
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.Reference != null)
        {
          var Index = IndexSettingSupport.SetIndex<ReferenceIndex>(new Res_AuditEvent_Index_patient(), item1.Reference, FhirRequestUri, this) as Res_AuditEvent_Index_patient;
          if (Index != null)
          {
            ResourseEntity.patient_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.Policy != null)
        {
          foreach (var item4 in item1.PolicyElement)
          {
            var Index = IndexSettingSupport.SetIndex<UriIndex>(new Res_AuditEvent_Index_policy(), item4) as Res_AuditEvent_Index_policy;
            ResourseEntity.policy_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.Subtype != null)
      {
        foreach (var item3 in ResourceTyped.Subtype)
        {
          var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_AuditEvent_Index_subtype(), item3) as Res_AuditEvent_Index_subtype;
          ResourseEntity.subtype_List.Add(Index);
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.UserId != null)
        {
          var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_AuditEvent_Index_user(), item1.UserId) as Res_AuditEvent_Index_user;
          ResourseEntity.user_List.Add(Index);
        }
      }

      if (ResourceTyped.Meta != null)
      {
        if (ResourceTyped.Meta.Profile != null)
        {
          foreach (var item4 in ResourceTyped.Meta.ProfileElement)
          {
            var Index = IndexSettingSupport.SetIndex<UriIndex>(new Res_AuditEvent_Index_profile(), item4) as Res_AuditEvent_Index_profile;
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
            var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_AuditEvent_Index_security(), item4) as Res_AuditEvent_Index_security;
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
            var Index = IndexSettingSupport.SetIndex<TokenIndex>(new Res_AuditEvent_Index_tag(), item4) as Res_AuditEvent_Index_tag;
            ResourseEntity.tag_List.Add(Index);
          }
        }
      }


      

    }


  }
} 

