﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure.Annotations;

//This is an Auto generated file do not change it's contents!!.

namespace Blaze.DataModel.DatabaseModel
{
  public class Res_DeviceUseRequest_Configuration : EntityTypeConfiguration<Res_DeviceUseRequest>
  {

    public Res_DeviceUseRequest_Configuration()
    {
      HasKey(x => x.Res_DeviceUseRequestID).Property(x => x.Res_DeviceUseRequestID).IsRequired();
      Property(x => x.IsDeleted).IsRequired();
      Property(x => x.FhirId).IsRequired().HasMaxLength(500).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_FhirId") { IsUnique = true }));
      Property(x => x.lastUpdated).IsRequired();
      Property(x => x.versionId).IsRequired();
      Property(x => x.XmlBlob).IsRequired();
      Property(x => x.author_date_DateTimeOffset).IsOptional();
      Property(x => x.device_VersionId).IsOptional();
      Property(x => x.device_FhirId).IsOptional();
      Property(x => x.device_Type).IsOptional();
      HasOptional(x => x.device_Url);
      HasOptional<ServiceRootURL_Store>(x => x.device_Url).WithMany().HasForeignKey(x => x.device_ServiceRootURL_StoreID);
      Property(x => x.encounter_VersionId).IsOptional();
      Property(x => x.encounter_FhirId).IsOptional();
      Property(x => x.encounter_Type).IsOptional();
      HasOptional(x => x.encounter_Url);
      HasOptional<ServiceRootURL_Store>(x => x.encounter_Url).WithMany().HasForeignKey(x => x.encounter_ServiceRootURL_StoreID);
      Property(x => x.event_date_DateTimeOffsetLow).IsOptional();
      Property(x => x.event_date_DateTimeOffsetHigh).IsOptional();
      Property(x => x.filler_VersionId).IsOptional();
      Property(x => x.filler_FhirId).IsOptional();
      Property(x => x.filler_Type).IsOptional();
      HasOptional(x => x.filler_Url);
      HasOptional<ServiceRootURL_Store>(x => x.filler_Url).WithMany().HasForeignKey(x => x.filler_ServiceRootURL_StoreID);
      Property(x => x.patient_VersionId).IsOptional();
      Property(x => x.patient_FhirId).IsOptional();
      Property(x => x.patient_Type).IsOptional();
      HasOptional(x => x.patient_Url);
      HasOptional<ServiceRootURL_Store>(x => x.patient_Url).WithMany().HasForeignKey(x => x.patient_ServiceRootURL_StoreID);
      Property(x => x.requester_VersionId).IsOptional();
      Property(x => x.requester_FhirId).IsOptional();
      Property(x => x.requester_Type).IsOptional();
      HasOptional(x => x.requester_Url);
      HasOptional<ServiceRootURL_Store>(x => x.requester_Url).WithMany().HasForeignKey(x => x.requester_ServiceRootURL_StoreID);
      Property(x => x.requisition_Code).IsOptional();
      Property(x => x.requisition_System).IsOptional();
      Property(x => x.status_Code).IsOptional();
      Property(x => x.status_System).IsOptional();
      Property(x => x.subject_VersionId).IsOptional();
      Property(x => x.subject_FhirId).IsOptional();
      Property(x => x.subject_Type).IsOptional();
      HasOptional(x => x.subject_Url);
      HasOptional<ServiceRootURL_Store>(x => x.subject_Url).WithMany().HasForeignKey(x => x.subject_ServiceRootURL_StoreID);
    }
  }
}
