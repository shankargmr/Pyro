﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure.Annotations;

//This is an Auto generated file do not change it's contents!!.

namespace Blaze.DataModel.DatabaseModel
{

  public class DatabaseContext: DbContext
  {
    public DatabaseContext()
      : base("BlazeConnectionString")
    {
      this.Database.CreateIfNotExists();      
    }

    public DbSet<ServiceRootURL_Store> ServiceRootURL_Store { get; set; }
    public DbSet<Res_Account> Res_Account { get; set; }
    public DbSet<Res_Account_History> Res_Account_History { get; set; }
    public DbSet<Res_Account_Index_identifier> Res_Account_Index_identifier { get; set; }
    public DbSet<Res_Account_Index_type> Res_Account_Index_type { get; set; }
    public DbSet<Res_Account_Index__profile> Res_Account_Index__profile { get; set; }
    public DbSet<Res_Account_Index__security> Res_Account_Index__security { get; set; }
    public DbSet<Res_Account_Index__tag> Res_Account_Index__tag { get; set; }
    public DbSet<Res_ActivityDefinition> Res_ActivityDefinition { get; set; }
    public DbSet<Res_ActivityDefinition_History> Res_ActivityDefinition_History { get; set; }
    public DbSet<Res_ActivityDefinition_Index_identifier> Res_ActivityDefinition_Index_identifier { get; set; }
    public DbSet<Res_ActivityDefinition_Index_topic> Res_ActivityDefinition_Index_topic { get; set; }
    public DbSet<Res_ActivityDefinition_Index__profile> Res_ActivityDefinition_Index__profile { get; set; }
    public DbSet<Res_ActivityDefinition_Index__security> Res_ActivityDefinition_Index__security { get; set; }
    public DbSet<Res_ActivityDefinition_Index__tag> Res_ActivityDefinition_Index__tag { get; set; }
    public DbSet<Res_AllergyIntolerance> Res_AllergyIntolerance { get; set; }
    public DbSet<Res_AllergyIntolerance_History> Res_AllergyIntolerance_History { get; set; }
    public DbSet<Res_AllergyIntolerance_Index_code> Res_AllergyIntolerance_Index_code { get; set; }
    public DbSet<Res_AllergyIntolerance_Index_identifier> Res_AllergyIntolerance_Index_identifier { get; set; }
    public DbSet<Res_AllergyIntolerance_Index_manifestation> Res_AllergyIntolerance_Index_manifestation { get; set; }
    public DbSet<Res_AllergyIntolerance_Index_onset> Res_AllergyIntolerance_Index_onset { get; set; }
    public DbSet<Res_AllergyIntolerance_Index_route> Res_AllergyIntolerance_Index_route { get; set; }
    public DbSet<Res_AllergyIntolerance_Index_severity> Res_AllergyIntolerance_Index_severity { get; set; }
    public DbSet<Res_AllergyIntolerance_Index__profile> Res_AllergyIntolerance_Index__profile { get; set; }
    public DbSet<Res_AllergyIntolerance_Index__security> Res_AllergyIntolerance_Index__security { get; set; }
    public DbSet<Res_AllergyIntolerance_Index__tag> Res_AllergyIntolerance_Index__tag { get; set; }
    public DbSet<Res_Appointment> Res_Appointment { get; set; }
    public DbSet<Res_Appointment_History> Res_Appointment_History { get; set; }
    public DbSet<Res_Appointment_Index_actor> Res_Appointment_Index_actor { get; set; }
    public DbSet<Res_Appointment_Index_appointment_type> Res_Appointment_Index_appointment_type { get; set; }
    public DbSet<Res_Appointment_Index_identifier> Res_Appointment_Index_identifier { get; set; }
    public DbSet<Res_Appointment_Index_location> Res_Appointment_Index_location { get; set; }
    public DbSet<Res_Appointment_Index_part_status> Res_Appointment_Index_part_status { get; set; }
    public DbSet<Res_Appointment_Index_patient> Res_Appointment_Index_patient { get; set; }
    public DbSet<Res_Appointment_Index_practitioner> Res_Appointment_Index_practitioner { get; set; }
    public DbSet<Res_Appointment_Index_service_type> Res_Appointment_Index_service_type { get; set; }
    public DbSet<Res_Appointment_Index__profile> Res_Appointment_Index__profile { get; set; }
    public DbSet<Res_Appointment_Index__security> Res_Appointment_Index__security { get; set; }
    public DbSet<Res_Appointment_Index__tag> Res_Appointment_Index__tag { get; set; }
    public DbSet<Res_AppointmentResponse> Res_AppointmentResponse { get; set; }
    public DbSet<Res_AppointmentResponse_History> Res_AppointmentResponse_History { get; set; }
    public DbSet<Res_AppointmentResponse_Index_identifier> Res_AppointmentResponse_Index_identifier { get; set; }
    public DbSet<Res_AppointmentResponse_Index__profile> Res_AppointmentResponse_Index__profile { get; set; }
    public DbSet<Res_AppointmentResponse_Index__security> Res_AppointmentResponse_Index__security { get; set; }
    public DbSet<Res_AppointmentResponse_Index__tag> Res_AppointmentResponse_Index__tag { get; set; }
    public DbSet<Res_AuditEvent> Res_AuditEvent { get; set; }
    public DbSet<Res_AuditEvent_History> Res_AuditEvent_History { get; set; }
    public DbSet<Res_AuditEvent_Index_address> Res_AuditEvent_Index_address { get; set; }
    public DbSet<Res_AuditEvent_Index_agent> Res_AuditEvent_Index_agent { get; set; }
    public DbSet<Res_AuditEvent_Index_agent_name> Res_AuditEvent_Index_agent_name { get; set; }
    public DbSet<Res_AuditEvent_Index_altid> Res_AuditEvent_Index_altid { get; set; }
    public DbSet<Res_AuditEvent_Index_entity> Res_AuditEvent_Index_entity { get; set; }
    public DbSet<Res_AuditEvent_Index_entity_id> Res_AuditEvent_Index_entity_id { get; set; }
    public DbSet<Res_AuditEvent_Index_entity_name> Res_AuditEvent_Index_entity_name { get; set; }
    public DbSet<Res_AuditEvent_Index_entity_type> Res_AuditEvent_Index_entity_type { get; set; }
    public DbSet<Res_AuditEvent_Index_patient> Res_AuditEvent_Index_patient { get; set; }
    public DbSet<Res_AuditEvent_Index_policy> Res_AuditEvent_Index_policy { get; set; }
    public DbSet<Res_AuditEvent_Index_role> Res_AuditEvent_Index_role { get; set; }
    public DbSet<Res_AuditEvent_Index_subtype> Res_AuditEvent_Index_subtype { get; set; }
    public DbSet<Res_AuditEvent_Index_user> Res_AuditEvent_Index_user { get; set; }
    public DbSet<Res_AuditEvent_Index__profile> Res_AuditEvent_Index__profile { get; set; }
    public DbSet<Res_AuditEvent_Index__security> Res_AuditEvent_Index__security { get; set; }
    public DbSet<Res_AuditEvent_Index__tag> Res_AuditEvent_Index__tag { get; set; }
    public DbSet<Res_Basic> Res_Basic { get; set; }
    public DbSet<Res_Basic_History> Res_Basic_History { get; set; }
    public DbSet<Res_Basic_Index_code> Res_Basic_Index_code { get; set; }
    public DbSet<Res_Basic_Index_identifier> Res_Basic_Index_identifier { get; set; }
    public DbSet<Res_Basic_Index__profile> Res_Basic_Index__profile { get; set; }
    public DbSet<Res_Basic_Index__security> Res_Basic_Index__security { get; set; }
    public DbSet<Res_Basic_Index__tag> Res_Basic_Index__tag { get; set; }
    public DbSet<Res_Binary> Res_Binary { get; set; }
    public DbSet<Res_Binary_History> Res_Binary_History { get; set; }
    public DbSet<Res_Binary_Index__profile> Res_Binary_Index__profile { get; set; }
    public DbSet<Res_Binary_Index__security> Res_Binary_Index__security { get; set; }
    public DbSet<Res_Binary_Index__tag> Res_Binary_Index__tag { get; set; }
    public DbSet<Res_BodySite> Res_BodySite { get; set; }
    public DbSet<Res_BodySite_History> Res_BodySite_History { get; set; }
    public DbSet<Res_BodySite_Index_code> Res_BodySite_Index_code { get; set; }
    public DbSet<Res_BodySite_Index_identifier> Res_BodySite_Index_identifier { get; set; }
    public DbSet<Res_BodySite_Index__profile> Res_BodySite_Index__profile { get; set; }
    public DbSet<Res_BodySite_Index__security> Res_BodySite_Index__security { get; set; }
    public DbSet<Res_BodySite_Index__tag> Res_BodySite_Index__tag { get; set; }
    public DbSet<Res_Bundle> Res_Bundle { get; set; }
    public DbSet<Res_Bundle_History> Res_Bundle_History { get; set; }
    public DbSet<Res_Bundle_Index__profile> Res_Bundle_Index__profile { get; set; }
    public DbSet<Res_Bundle_Index__security> Res_Bundle_Index__security { get; set; }
    public DbSet<Res_Bundle_Index__tag> Res_Bundle_Index__tag { get; set; }
    public DbSet<Res_CarePlan> Res_CarePlan { get; set; }
    public DbSet<Res_CarePlan_History> Res_CarePlan_History { get; set; }
    public DbSet<Res_CarePlan_Index_activitycode> Res_CarePlan_Index_activitycode { get; set; }
    public DbSet<Res_CarePlan_Index_activitydate> Res_CarePlan_Index_activitydate { get; set; }
    public DbSet<Res_CarePlan_Index_activityreference> Res_CarePlan_Index_activityreference { get; set; }
    public DbSet<Res_CarePlan_Index_careteam> Res_CarePlan_Index_careteam { get; set; }
    public DbSet<Res_CarePlan_Index_category> Res_CarePlan_Index_category { get; set; }
    public DbSet<Res_CarePlan_Index_condition> Res_CarePlan_Index_condition { get; set; }
    public DbSet<Res_CarePlan_Index_goal> Res_CarePlan_Index_goal { get; set; }
    public DbSet<Res_CarePlan_Index_performer> Res_CarePlan_Index_performer { get; set; }
    public DbSet<Res_CarePlan_Index_relatedcode> Res_CarePlan_Index_relatedcode { get; set; }
    public DbSet<Res_CarePlan_Index_relatedplan> Res_CarePlan_Index_relatedplan { get; set; }
    public DbSet<Res_CarePlan_Index__profile> Res_CarePlan_Index__profile { get; set; }
    public DbSet<Res_CarePlan_Index__security> Res_CarePlan_Index__security { get; set; }
    public DbSet<Res_CarePlan_Index__tag> Res_CarePlan_Index__tag { get; set; }
    public DbSet<Res_CareTeam> Res_CareTeam { get; set; }
    public DbSet<Res_CareTeam_History> Res_CareTeam_History { get; set; }
    public DbSet<Res_CareTeam_Index_identifier> Res_CareTeam_Index_identifier { get; set; }
    public DbSet<Res_CareTeam_Index_participant> Res_CareTeam_Index_participant { get; set; }
    public DbSet<Res_CareTeam_Index_status> Res_CareTeam_Index_status { get; set; }
    public DbSet<Res_CareTeam_Index_type> Res_CareTeam_Index_type { get; set; }
    public DbSet<Res_CareTeam_Index__profile> Res_CareTeam_Index__profile { get; set; }
    public DbSet<Res_CareTeam_Index__security> Res_CareTeam_Index__security { get; set; }
    public DbSet<Res_CareTeam_Index__tag> Res_CareTeam_Index__tag { get; set; }
    public DbSet<Res_Claim> Res_Claim { get; set; }
    public DbSet<Res_Claim_History> Res_Claim_History { get; set; }
    public DbSet<Res_Claim_Index_identifier> Res_Claim_Index_identifier { get; set; }
    public DbSet<Res_Claim_Index__profile> Res_Claim_Index__profile { get; set; }
    public DbSet<Res_Claim_Index__security> Res_Claim_Index__security { get; set; }
    public DbSet<Res_Claim_Index__tag> Res_Claim_Index__tag { get; set; }
    public DbSet<Res_ClaimResponse> Res_ClaimResponse { get; set; }
    public DbSet<Res_ClaimResponse_History> Res_ClaimResponse_History { get; set; }
    public DbSet<Res_ClaimResponse_Index_identifier> Res_ClaimResponse_Index_identifier { get; set; }
    public DbSet<Res_ClaimResponse_Index__profile> Res_ClaimResponse_Index__profile { get; set; }
    public DbSet<Res_ClaimResponse_Index__security> Res_ClaimResponse_Index__security { get; set; }
    public DbSet<Res_ClaimResponse_Index__tag> Res_ClaimResponse_Index__tag { get; set; }
    public DbSet<Res_ClinicalImpression> Res_ClinicalImpression { get; set; }
    public DbSet<Res_ClinicalImpression_History> Res_ClinicalImpression_History { get; set; }
    public DbSet<Res_ClinicalImpression_Index_action> Res_ClinicalImpression_Index_action { get; set; }
    public DbSet<Res_ClinicalImpression_Index_finding_code> Res_ClinicalImpression_Index_finding_code { get; set; }
    public DbSet<Res_ClinicalImpression_Index_finding_ref> Res_ClinicalImpression_Index_finding_ref { get; set; }
    public DbSet<Res_ClinicalImpression_Index_investigation> Res_ClinicalImpression_Index_investigation { get; set; }
    public DbSet<Res_ClinicalImpression_Index_plan> Res_ClinicalImpression_Index_plan { get; set; }
    public DbSet<Res_ClinicalImpression_Index_problem> Res_ClinicalImpression_Index_problem { get; set; }
    public DbSet<Res_ClinicalImpression_Index__profile> Res_ClinicalImpression_Index__profile { get; set; }
    public DbSet<Res_ClinicalImpression_Index__security> Res_ClinicalImpression_Index__security { get; set; }
    public DbSet<Res_ClinicalImpression_Index__tag> Res_ClinicalImpression_Index__tag { get; set; }
    public DbSet<Res_CodeSystem> Res_CodeSystem { get; set; }
    public DbSet<Res_CodeSystem_History> Res_CodeSystem_History { get; set; }
    public DbSet<Res_CodeSystem_Index_code> Res_CodeSystem_Index_code { get; set; }
    public DbSet<Res_CodeSystem_Index_context> Res_CodeSystem_Index_context { get; set; }
    public DbSet<Res_CodeSystem_Index_language> Res_CodeSystem_Index_language { get; set; }
    public DbSet<Res_CodeSystem_Index__profile> Res_CodeSystem_Index__profile { get; set; }
    public DbSet<Res_CodeSystem_Index__security> Res_CodeSystem_Index__security { get; set; }
    public DbSet<Res_CodeSystem_Index__tag> Res_CodeSystem_Index__tag { get; set; }
    public DbSet<Res_Communication> Res_Communication { get; set; }
    public DbSet<Res_Communication_History> Res_Communication_History { get; set; }
    public DbSet<Res_Communication_Index_based_on> Res_Communication_Index_based_on { get; set; }
    public DbSet<Res_Communication_Index_category> Res_Communication_Index_category { get; set; }
    public DbSet<Res_Communication_Index_identifier> Res_Communication_Index_identifier { get; set; }
    public DbSet<Res_Communication_Index_medium> Res_Communication_Index_medium { get; set; }
    public DbSet<Res_Communication_Index_recipient> Res_Communication_Index_recipient { get; set; }
    public DbSet<Res_Communication_Index__profile> Res_Communication_Index__profile { get; set; }
    public DbSet<Res_Communication_Index__security> Res_Communication_Index__security { get; set; }
    public DbSet<Res_Communication_Index__tag> Res_Communication_Index__tag { get; set; }
    public DbSet<Res_CommunicationRequest> Res_CommunicationRequest { get; set; }
    public DbSet<Res_CommunicationRequest_History> Res_CommunicationRequest_History { get; set; }
    public DbSet<Res_CommunicationRequest_Index_category> Res_CommunicationRequest_Index_category { get; set; }
    public DbSet<Res_CommunicationRequest_Index_identifier> Res_CommunicationRequest_Index_identifier { get; set; }
    public DbSet<Res_CommunicationRequest_Index_medium> Res_CommunicationRequest_Index_medium { get; set; }
    public DbSet<Res_CommunicationRequest_Index_priority> Res_CommunicationRequest_Index_priority { get; set; }
    public DbSet<Res_CommunicationRequest_Index_recipient> Res_CommunicationRequest_Index_recipient { get; set; }
    public DbSet<Res_CommunicationRequest_Index__profile> Res_CommunicationRequest_Index__profile { get; set; }
    public DbSet<Res_CommunicationRequest_Index__security> Res_CommunicationRequest_Index__security { get; set; }
    public DbSet<Res_CommunicationRequest_Index__tag> Res_CommunicationRequest_Index__tag { get; set; }
    public DbSet<Res_CompartmentDefinition> Res_CompartmentDefinition { get; set; }
    public DbSet<Res_CompartmentDefinition_History> Res_CompartmentDefinition_History { get; set; }
    public DbSet<Res_CompartmentDefinition_Index_resource> Res_CompartmentDefinition_Index_resource { get; set; }
    public DbSet<Res_CompartmentDefinition_Index__profile> Res_CompartmentDefinition_Index__profile { get; set; }
    public DbSet<Res_CompartmentDefinition_Index__security> Res_CompartmentDefinition_Index__security { get; set; }
    public DbSet<Res_CompartmentDefinition_Index__tag> Res_CompartmentDefinition_Index__tag { get; set; }
    public DbSet<Res_Composition> Res_Composition { get; set; }
    public DbSet<Res_Composition_History> Res_Composition_History { get; set; }
    public DbSet<Res_Composition_Index_attester> Res_Composition_Index_attester { get; set; }
    public DbSet<Res_Composition_Index_author> Res_Composition_Index_author { get; set; }
    public DbSet<Res_Composition_Index_class> Res_Composition_Index_class { get; set; }
    public DbSet<Res_Composition_Index_context> Res_Composition_Index_context { get; set; }
    public DbSet<Res_Composition_Index_entry> Res_Composition_Index_entry { get; set; }
    public DbSet<Res_Composition_Index_period> Res_Composition_Index_period { get; set; }
    public DbSet<Res_Composition_Index_section> Res_Composition_Index_section { get; set; }
    public DbSet<Res_Composition_Index_type> Res_Composition_Index_type { get; set; }
    public DbSet<Res_Composition_Index__profile> Res_Composition_Index__profile { get; set; }
    public DbSet<Res_Composition_Index__security> Res_Composition_Index__security { get; set; }
    public DbSet<Res_Composition_Index__tag> Res_Composition_Index__tag { get; set; }
    public DbSet<Res_ConceptMap> Res_ConceptMap { get; set; }
    public DbSet<Res_ConceptMap_History> Res_ConceptMap_History { get; set; }
    public DbSet<Res_ConceptMap_Index_context> Res_ConceptMap_Index_context { get; set; }
    public DbSet<Res_ConceptMap_Index_dependson> Res_ConceptMap_Index_dependson { get; set; }
    public DbSet<Res_ConceptMap_Index_product> Res_ConceptMap_Index_product { get; set; }
    public DbSet<Res_ConceptMap_Index_source_code> Res_ConceptMap_Index_source_code { get; set; }
    public DbSet<Res_ConceptMap_Index_source_system> Res_ConceptMap_Index_source_system { get; set; }
    public DbSet<Res_ConceptMap_Index_target_code> Res_ConceptMap_Index_target_code { get; set; }
    public DbSet<Res_ConceptMap_Index_target_system> Res_ConceptMap_Index_target_system { get; set; }
    public DbSet<Res_ConceptMap_Index__profile> Res_ConceptMap_Index__profile { get; set; }
    public DbSet<Res_ConceptMap_Index__security> Res_ConceptMap_Index__security { get; set; }
    public DbSet<Res_ConceptMap_Index__tag> Res_ConceptMap_Index__tag { get; set; }
    public DbSet<Res_Condition> Res_Condition { get; set; }
    public DbSet<Res_Condition_History> Res_Condition_History { get; set; }
    public DbSet<Res_Condition_Index_body_site> Res_Condition_Index_body_site { get; set; }
    public DbSet<Res_Condition_Index_category> Res_Condition_Index_category { get; set; }
    public DbSet<Res_Condition_Index_code> Res_Condition_Index_code { get; set; }
    public DbSet<Res_Condition_Index_evidence> Res_Condition_Index_evidence { get; set; }
    public DbSet<Res_Condition_Index_identifier> Res_Condition_Index_identifier { get; set; }
    public DbSet<Res_Condition_Index_severity> Res_Condition_Index_severity { get; set; }
    public DbSet<Res_Condition_Index_stage> Res_Condition_Index_stage { get; set; }
    public DbSet<Res_Condition_Index__profile> Res_Condition_Index__profile { get; set; }
    public DbSet<Res_Condition_Index__security> Res_Condition_Index__security { get; set; }
    public DbSet<Res_Condition_Index__tag> Res_Condition_Index__tag { get; set; }
    public DbSet<Res_Conformance> Res_Conformance { get; set; }
    public DbSet<Res_Conformance_History> Res_Conformance_History { get; set; }
    public DbSet<Res_Conformance_Index_context> Res_Conformance_Index_context { get; set; }
    public DbSet<Res_Conformance_Index_event> Res_Conformance_Index_event { get; set; }
    public DbSet<Res_Conformance_Index_format> Res_Conformance_Index_format { get; set; }
    public DbSet<Res_Conformance_Index_mode> Res_Conformance_Index_mode { get; set; }
    public DbSet<Res_Conformance_Index_resource> Res_Conformance_Index_resource { get; set; }
    public DbSet<Res_Conformance_Index_resourceprofile> Res_Conformance_Index_resourceprofile { get; set; }
    public DbSet<Res_Conformance_Index_securityservice> Res_Conformance_Index_securityservice { get; set; }
    public DbSet<Res_Conformance_Index_supported_profile> Res_Conformance_Index_supported_profile { get; set; }
    public DbSet<Res_Conformance_Index__profile> Res_Conformance_Index__profile { get; set; }
    public DbSet<Res_Conformance_Index__security> Res_Conformance_Index__security { get; set; }
    public DbSet<Res_Conformance_Index__tag> Res_Conformance_Index__tag { get; set; }
    public DbSet<Res_Consent> Res_Consent { get; set; }
    public DbSet<Res_Consent_History> Res_Consent_History { get; set; }
    public DbSet<Res_Consent_Index_action> Res_Consent_Index_action { get; set; }
    public DbSet<Res_Consent_Index_actor> Res_Consent_Index_actor { get; set; }
    public DbSet<Res_Consent_Index_category> Res_Consent_Index_category { get; set; }
    public DbSet<Res_Consent_Index_consentor> Res_Consent_Index_consentor { get; set; }
    public DbSet<Res_Consent_Index_data> Res_Consent_Index_data { get; set; }
    public DbSet<Res_Consent_Index_purpose> Res_Consent_Index_purpose { get; set; }
    public DbSet<Res_Consent_Index_recipient> Res_Consent_Index_recipient { get; set; }
    public DbSet<Res_Consent_Index_security> Res_Consent_Index_security { get; set; }
    public DbSet<Res_Consent_Index__profile> Res_Consent_Index__profile { get; set; }
    public DbSet<Res_Consent_Index__security> Res_Consent_Index__security { get; set; }
    public DbSet<Res_Consent_Index__tag> Res_Consent_Index__tag { get; set; }
    public DbSet<Res_Contract> Res_Contract { get; set; }
    public DbSet<Res_Contract_History> Res_Contract_History { get; set; }
    public DbSet<Res_Contract_Index_agent> Res_Contract_Index_agent { get; set; }
    public DbSet<Res_Contract_Index_authority> Res_Contract_Index_authority { get; set; }
    public DbSet<Res_Contract_Index_domain> Res_Contract_Index_domain { get; set; }
    public DbSet<Res_Contract_Index_patient> Res_Contract_Index_patient { get; set; }
    public DbSet<Res_Contract_Index_signer> Res_Contract_Index_signer { get; set; }
    public DbSet<Res_Contract_Index_subject> Res_Contract_Index_subject { get; set; }
    public DbSet<Res_Contract_Index_topic> Res_Contract_Index_topic { get; set; }
    public DbSet<Res_Contract_Index_ttopic> Res_Contract_Index_ttopic { get; set; }
    public DbSet<Res_Contract_Index__profile> Res_Contract_Index__profile { get; set; }
    public DbSet<Res_Contract_Index__security> Res_Contract_Index__security { get; set; }
    public DbSet<Res_Contract_Index__tag> Res_Contract_Index__tag { get; set; }
    public DbSet<Res_Coverage> Res_Coverage { get; set; }
    public DbSet<Res_Coverage_History> Res_Coverage_History { get; set; }
    public DbSet<Res_Coverage_Index_identifier> Res_Coverage_Index_identifier { get; set; }
    public DbSet<Res_Coverage_Index__profile> Res_Coverage_Index__profile { get; set; }
    public DbSet<Res_Coverage_Index__security> Res_Coverage_Index__security { get; set; }
    public DbSet<Res_Coverage_Index__tag> Res_Coverage_Index__tag { get; set; }
    public DbSet<Res_DataElement> Res_DataElement { get; set; }
    public DbSet<Res_DataElement_History> Res_DataElement_History { get; set; }
    public DbSet<Res_DataElement_Index_code> Res_DataElement_Index_code { get; set; }
    public DbSet<Res_DataElement_Index_context> Res_DataElement_Index_context { get; set; }
    public DbSet<Res_DataElement_Index_description> Res_DataElement_Index_description { get; set; }
    public DbSet<Res_DataElement_Index_identifier> Res_DataElement_Index_identifier { get; set; }
    public DbSet<Res_DataElement_Index__profile> Res_DataElement_Index__profile { get; set; }
    public DbSet<Res_DataElement_Index__security> Res_DataElement_Index__security { get; set; }
    public DbSet<Res_DataElement_Index__tag> Res_DataElement_Index__tag { get; set; }
    public DbSet<Res_DecisionSupportServiceModule> Res_DecisionSupportServiceModule { get; set; }
    public DbSet<Res_DecisionSupportServiceModule_History> Res_DecisionSupportServiceModule_History { get; set; }
    public DbSet<Res_DecisionSupportServiceModule_Index_identifier> Res_DecisionSupportServiceModule_Index_identifier { get; set; }
    public DbSet<Res_DecisionSupportServiceModule_Index_topic> Res_DecisionSupportServiceModule_Index_topic { get; set; }
    public DbSet<Res_DecisionSupportServiceModule_Index__profile> Res_DecisionSupportServiceModule_Index__profile { get; set; }
    public DbSet<Res_DecisionSupportServiceModule_Index__security> Res_DecisionSupportServiceModule_Index__security { get; set; }
    public DbSet<Res_DecisionSupportServiceModule_Index__tag> Res_DecisionSupportServiceModule_Index__tag { get; set; }
    public DbSet<Res_DetectedIssue> Res_DetectedIssue { get; set; }
    public DbSet<Res_DetectedIssue_History> Res_DetectedIssue_History { get; set; }
    public DbSet<Res_DetectedIssue_Index_category> Res_DetectedIssue_Index_category { get; set; }
    public DbSet<Res_DetectedIssue_Index_implicated> Res_DetectedIssue_Index_implicated { get; set; }
    public DbSet<Res_DetectedIssue_Index__profile> Res_DetectedIssue_Index__profile { get; set; }
    public DbSet<Res_DetectedIssue_Index__security> Res_DetectedIssue_Index__security { get; set; }
    public DbSet<Res_DetectedIssue_Index__tag> Res_DetectedIssue_Index__tag { get; set; }
    public DbSet<Res_Device> Res_Device { get; set; }
    public DbSet<Res_Device_History> Res_Device_History { get; set; }
    public DbSet<Res_Device_Index_identifier> Res_Device_Index_identifier { get; set; }
    public DbSet<Res_Device_Index_type> Res_Device_Index_type { get; set; }
    public DbSet<Res_Device_Index__profile> Res_Device_Index__profile { get; set; }
    public DbSet<Res_Device_Index__security> Res_Device_Index__security { get; set; }
    public DbSet<Res_Device_Index__tag> Res_Device_Index__tag { get; set; }
    public DbSet<Res_DeviceComponent> Res_DeviceComponent { get; set; }
    public DbSet<Res_DeviceComponent_History> Res_DeviceComponent_History { get; set; }
    public DbSet<Res_DeviceComponent_Index_type> Res_DeviceComponent_Index_type { get; set; }
    public DbSet<Res_DeviceComponent_Index__profile> Res_DeviceComponent_Index__profile { get; set; }
    public DbSet<Res_DeviceComponent_Index__security> Res_DeviceComponent_Index__security { get; set; }
    public DbSet<Res_DeviceComponent_Index__tag> Res_DeviceComponent_Index__tag { get; set; }
    public DbSet<Res_DeviceMetric> Res_DeviceMetric { get; set; }
    public DbSet<Res_DeviceMetric_History> Res_DeviceMetric_History { get; set; }
    public DbSet<Res_DeviceMetric_Index_type> Res_DeviceMetric_Index_type { get; set; }
    public DbSet<Res_DeviceMetric_Index__profile> Res_DeviceMetric_Index__profile { get; set; }
    public DbSet<Res_DeviceMetric_Index__security> Res_DeviceMetric_Index__security { get; set; }
    public DbSet<Res_DeviceMetric_Index__tag> Res_DeviceMetric_Index__tag { get; set; }
    public DbSet<Res_DeviceUseRequest> Res_DeviceUseRequest { get; set; }
    public DbSet<Res_DeviceUseRequest_History> Res_DeviceUseRequest_History { get; set; }
    public DbSet<Res_DeviceUseRequest_Index_based_on> Res_DeviceUseRequest_Index_based_on { get; set; }
    public DbSet<Res_DeviceUseRequest_Index_code> Res_DeviceUseRequest_Index_code { get; set; }
    public DbSet<Res_DeviceUseRequest_Index_definition> Res_DeviceUseRequest_Index_definition { get; set; }
    public DbSet<Res_DeviceUseRequest_Index_identifier> Res_DeviceUseRequest_Index_identifier { get; set; }
    public DbSet<Res_DeviceUseRequest_Index_replaces> Res_DeviceUseRequest_Index_replaces { get; set; }
    public DbSet<Res_DeviceUseRequest_Index_stage> Res_DeviceUseRequest_Index_stage { get; set; }
    public DbSet<Res_DeviceUseRequest_Index__profile> Res_DeviceUseRequest_Index__profile { get; set; }
    public DbSet<Res_DeviceUseRequest_Index__security> Res_DeviceUseRequest_Index__security { get; set; }
    public DbSet<Res_DeviceUseRequest_Index__tag> Res_DeviceUseRequest_Index__tag { get; set; }
    public DbSet<Res_DeviceUseStatement> Res_DeviceUseStatement { get; set; }
    public DbSet<Res_DeviceUseStatement_History> Res_DeviceUseStatement_History { get; set; }
    public DbSet<Res_DeviceUseStatement_Index__profile> Res_DeviceUseStatement_Index__profile { get; set; }
    public DbSet<Res_DeviceUseStatement_Index__security> Res_DeviceUseStatement_Index__security { get; set; }
    public DbSet<Res_DeviceUseStatement_Index__tag> Res_DeviceUseStatement_Index__tag { get; set; }
    public DbSet<Res_DiagnosticReport> Res_DiagnosticReport { get; set; }
    public DbSet<Res_DiagnosticReport_History> Res_DiagnosticReport_History { get; set; }
    public DbSet<Res_DiagnosticReport_Index_category> Res_DiagnosticReport_Index_category { get; set; }
    public DbSet<Res_DiagnosticReport_Index_code> Res_DiagnosticReport_Index_code { get; set; }
    public DbSet<Res_DiagnosticReport_Index_diagnosis> Res_DiagnosticReport_Index_diagnosis { get; set; }
    public DbSet<Res_DiagnosticReport_Index_identifier> Res_DiagnosticReport_Index_identifier { get; set; }
    public DbSet<Res_DiagnosticReport_Index_image> Res_DiagnosticReport_Index_image { get; set; }
    public DbSet<Res_DiagnosticReport_Index_performer> Res_DiagnosticReport_Index_performer { get; set; }
    public DbSet<Res_DiagnosticReport_Index_request> Res_DiagnosticReport_Index_request { get; set; }
    public DbSet<Res_DiagnosticReport_Index_result> Res_DiagnosticReport_Index_result { get; set; }
    public DbSet<Res_DiagnosticReport_Index_specimen> Res_DiagnosticReport_Index_specimen { get; set; }
    public DbSet<Res_DiagnosticReport_Index__profile> Res_DiagnosticReport_Index__profile { get; set; }
    public DbSet<Res_DiagnosticReport_Index__security> Res_DiagnosticReport_Index__security { get; set; }
    public DbSet<Res_DiagnosticReport_Index__tag> Res_DiagnosticReport_Index__tag { get; set; }
    public DbSet<Res_DiagnosticRequest> Res_DiagnosticRequest { get; set; }
    public DbSet<Res_DiagnosticRequest_History> Res_DiagnosticRequest_History { get; set; }
    public DbSet<Res_DiagnosticRequest_Index_based_on> Res_DiagnosticRequest_Index_based_on { get; set; }
    public DbSet<Res_DiagnosticRequest_Index_code> Res_DiagnosticRequest_Index_code { get; set; }
    public DbSet<Res_DiagnosticRequest_Index_definition> Res_DiagnosticRequest_Index_definition { get; set; }
    public DbSet<Res_DiagnosticRequest_Index_identifier> Res_DiagnosticRequest_Index_identifier { get; set; }
    public DbSet<Res_DiagnosticRequest_Index_replaces> Res_DiagnosticRequest_Index_replaces { get; set; }
    public DbSet<Res_DiagnosticRequest_Index_stage> Res_DiagnosticRequest_Index_stage { get; set; }
    public DbSet<Res_DiagnosticRequest_Index__profile> Res_DiagnosticRequest_Index__profile { get; set; }
    public DbSet<Res_DiagnosticRequest_Index__security> Res_DiagnosticRequest_Index__security { get; set; }
    public DbSet<Res_DiagnosticRequest_Index__tag> Res_DiagnosticRequest_Index__tag { get; set; }
    public DbSet<Res_DocumentManifest> Res_DocumentManifest { get; set; }
    public DbSet<Res_DocumentManifest_History> Res_DocumentManifest_History { get; set; }
    public DbSet<Res_DocumentManifest_Index_author> Res_DocumentManifest_Index_author { get; set; }
    public DbSet<Res_DocumentManifest_Index_content_ref> Res_DocumentManifest_Index_content_ref { get; set; }
    public DbSet<Res_DocumentManifest_Index_identifier> Res_DocumentManifest_Index_identifier { get; set; }
    public DbSet<Res_DocumentManifest_Index_recipient> Res_DocumentManifest_Index_recipient { get; set; }
    public DbSet<Res_DocumentManifest_Index_related_id> Res_DocumentManifest_Index_related_id { get; set; }
    public DbSet<Res_DocumentManifest_Index_related_ref> Res_DocumentManifest_Index_related_ref { get; set; }
    public DbSet<Res_DocumentManifest_Index_type> Res_DocumentManifest_Index_type { get; set; }
    public DbSet<Res_DocumentManifest_Index__profile> Res_DocumentManifest_Index__profile { get; set; }
    public DbSet<Res_DocumentManifest_Index__security> Res_DocumentManifest_Index__security { get; set; }
    public DbSet<Res_DocumentManifest_Index__tag> Res_DocumentManifest_Index__tag { get; set; }
    public DbSet<Res_DocumentReference> Res_DocumentReference { get; set; }
    public DbSet<Res_DocumentReference_History> Res_DocumentReference_History { get; set; }
    public DbSet<Res_DocumentReference_Index_author> Res_DocumentReference_Index_author { get; set; }
    public DbSet<Res_DocumentReference_Index_class> Res_DocumentReference_Index_class { get; set; }
    public DbSet<Res_DocumentReference_Index_event> Res_DocumentReference_Index_event { get; set; }
    public DbSet<Res_DocumentReference_Index_facility> Res_DocumentReference_Index_facility { get; set; }
    public DbSet<Res_DocumentReference_Index_format> Res_DocumentReference_Index_format { get; set; }
    public DbSet<Res_DocumentReference_Index_identifier> Res_DocumentReference_Index_identifier { get; set; }
    public DbSet<Res_DocumentReference_Index_language> Res_DocumentReference_Index_language { get; set; }
    public DbSet<Res_DocumentReference_Index_location> Res_DocumentReference_Index_location { get; set; }
    public DbSet<Res_DocumentReference_Index_related_id> Res_DocumentReference_Index_related_id { get; set; }
    public DbSet<Res_DocumentReference_Index_related_ref> Res_DocumentReference_Index_related_ref { get; set; }
    public DbSet<Res_DocumentReference_Index_relatesto> Res_DocumentReference_Index_relatesto { get; set; }
    public DbSet<Res_DocumentReference_Index_relation> Res_DocumentReference_Index_relation { get; set; }
    public DbSet<Res_DocumentReference_Index_securitylabel> Res_DocumentReference_Index_securitylabel { get; set; }
    public DbSet<Res_DocumentReference_Index_setting> Res_DocumentReference_Index_setting { get; set; }
    public DbSet<Res_DocumentReference_Index_type> Res_DocumentReference_Index_type { get; set; }
    public DbSet<Res_DocumentReference_Index__profile> Res_DocumentReference_Index__profile { get; set; }
    public DbSet<Res_DocumentReference_Index__security> Res_DocumentReference_Index__security { get; set; }
    public DbSet<Res_DocumentReference_Index__tag> Res_DocumentReference_Index__tag { get; set; }
    public DbSet<Res_EligibilityRequest> Res_EligibilityRequest { get; set; }
    public DbSet<Res_EligibilityRequest_History> Res_EligibilityRequest_History { get; set; }
    public DbSet<Res_EligibilityRequest_Index_identifier> Res_EligibilityRequest_Index_identifier { get; set; }
    public DbSet<Res_EligibilityRequest_Index__profile> Res_EligibilityRequest_Index__profile { get; set; }
    public DbSet<Res_EligibilityRequest_Index__security> Res_EligibilityRequest_Index__security { get; set; }
    public DbSet<Res_EligibilityRequest_Index__tag> Res_EligibilityRequest_Index__tag { get; set; }
    public DbSet<Res_EligibilityResponse> Res_EligibilityResponse { get; set; }
    public DbSet<Res_EligibilityResponse_History> Res_EligibilityResponse_History { get; set; }
    public DbSet<Res_EligibilityResponse_Index_identifier> Res_EligibilityResponse_Index_identifier { get; set; }
    public DbSet<Res_EligibilityResponse_Index__profile> Res_EligibilityResponse_Index__profile { get; set; }
    public DbSet<Res_EligibilityResponse_Index__security> Res_EligibilityResponse_Index__security { get; set; }
    public DbSet<Res_EligibilityResponse_Index__tag> Res_EligibilityResponse_Index__tag { get; set; }
    public DbSet<Res_Encounter> Res_Encounter { get; set; }
    public DbSet<Res_Encounter_History> Res_Encounter_History { get; set; }
    public DbSet<Res_Encounter_Index_condition> Res_Encounter_Index_condition { get; set; }
    public DbSet<Res_Encounter_Index_episodeofcare> Res_Encounter_Index_episodeofcare { get; set; }
    public DbSet<Res_Encounter_Index_identifier> Res_Encounter_Index_identifier { get; set; }
    public DbSet<Res_Encounter_Index_incomingreferral> Res_Encounter_Index_incomingreferral { get; set; }
    public DbSet<Res_Encounter_Index_indication> Res_Encounter_Index_indication { get; set; }
    public DbSet<Res_Encounter_Index_location> Res_Encounter_Index_location { get; set; }
    public DbSet<Res_Encounter_Index_location_period> Res_Encounter_Index_location_period { get; set; }
    public DbSet<Res_Encounter_Index_participant> Res_Encounter_Index_participant { get; set; }
    public DbSet<Res_Encounter_Index_participant_type> Res_Encounter_Index_participant_type { get; set; }
    public DbSet<Res_Encounter_Index_practitioner> Res_Encounter_Index_practitioner { get; set; }
    public DbSet<Res_Encounter_Index_procedure> Res_Encounter_Index_procedure { get; set; }
    public DbSet<Res_Encounter_Index_reason> Res_Encounter_Index_reason { get; set; }
    public DbSet<Res_Encounter_Index_special_arrangement> Res_Encounter_Index_special_arrangement { get; set; }
    public DbSet<Res_Encounter_Index_type> Res_Encounter_Index_type { get; set; }
    public DbSet<Res_Encounter_Index__profile> Res_Encounter_Index__profile { get; set; }
    public DbSet<Res_Encounter_Index__security> Res_Encounter_Index__security { get; set; }
    public DbSet<Res_Encounter_Index__tag> Res_Encounter_Index__tag { get; set; }
    public DbSet<Res_Endpoint> Res_Endpoint { get; set; }
    public DbSet<Res_Endpoint_History> Res_Endpoint_History { get; set; }
    public DbSet<Res_Endpoint_Index_identifier> Res_Endpoint_Index_identifier { get; set; }
    public DbSet<Res_Endpoint_Index_payload_type> Res_Endpoint_Index_payload_type { get; set; }
    public DbSet<Res_Endpoint_Index__profile> Res_Endpoint_Index__profile { get; set; }
    public DbSet<Res_Endpoint_Index__security> Res_Endpoint_Index__security { get; set; }
    public DbSet<Res_Endpoint_Index__tag> Res_Endpoint_Index__tag { get; set; }
    public DbSet<Res_EnrollmentRequest> Res_EnrollmentRequest { get; set; }
    public DbSet<Res_EnrollmentRequest_History> Res_EnrollmentRequest_History { get; set; }
    public DbSet<Res_EnrollmentRequest_Index_identifier> Res_EnrollmentRequest_Index_identifier { get; set; }
    public DbSet<Res_EnrollmentRequest_Index__profile> Res_EnrollmentRequest_Index__profile { get; set; }
    public DbSet<Res_EnrollmentRequest_Index__security> Res_EnrollmentRequest_Index__security { get; set; }
    public DbSet<Res_EnrollmentRequest_Index__tag> Res_EnrollmentRequest_Index__tag { get; set; }
    public DbSet<Res_EnrollmentResponse> Res_EnrollmentResponse { get; set; }
    public DbSet<Res_EnrollmentResponse_History> Res_EnrollmentResponse_History { get; set; }
    public DbSet<Res_EnrollmentResponse_Index_identifier> Res_EnrollmentResponse_Index_identifier { get; set; }
    public DbSet<Res_EnrollmentResponse_Index__profile> Res_EnrollmentResponse_Index__profile { get; set; }
    public DbSet<Res_EnrollmentResponse_Index__security> Res_EnrollmentResponse_Index__security { get; set; }
    public DbSet<Res_EnrollmentResponse_Index__tag> Res_EnrollmentResponse_Index__tag { get; set; }
    public DbSet<Res_EpisodeOfCare> Res_EpisodeOfCare { get; set; }
    public DbSet<Res_EpisodeOfCare_History> Res_EpisodeOfCare_History { get; set; }
    public DbSet<Res_EpisodeOfCare_Index_condition> Res_EpisodeOfCare_Index_condition { get; set; }
    public DbSet<Res_EpisodeOfCare_Index_identifier> Res_EpisodeOfCare_Index_identifier { get; set; }
    public DbSet<Res_EpisodeOfCare_Index_incomingreferral> Res_EpisodeOfCare_Index_incomingreferral { get; set; }
    public DbSet<Res_EpisodeOfCare_Index_type> Res_EpisodeOfCare_Index_type { get; set; }
    public DbSet<Res_EpisodeOfCare_Index__profile> Res_EpisodeOfCare_Index__profile { get; set; }
    public DbSet<Res_EpisodeOfCare_Index__security> Res_EpisodeOfCare_Index__security { get; set; }
    public DbSet<Res_EpisodeOfCare_Index__tag> Res_EpisodeOfCare_Index__tag { get; set; }
    public DbSet<Res_ExpansionProfile> Res_ExpansionProfile { get; set; }
    public DbSet<Res_ExpansionProfile_History> Res_ExpansionProfile_History { get; set; }
    public DbSet<Res_ExpansionProfile_Index__profile> Res_ExpansionProfile_Index__profile { get; set; }
    public DbSet<Res_ExpansionProfile_Index__security> Res_ExpansionProfile_Index__security { get; set; }
    public DbSet<Res_ExpansionProfile_Index__tag> Res_ExpansionProfile_Index__tag { get; set; }
    public DbSet<Res_ExplanationOfBenefit> Res_ExplanationOfBenefit { get; set; }
    public DbSet<Res_ExplanationOfBenefit_History> Res_ExplanationOfBenefit_History { get; set; }
    public DbSet<Res_ExplanationOfBenefit_Index_identifier> Res_ExplanationOfBenefit_Index_identifier { get; set; }
    public DbSet<Res_ExplanationOfBenefit_Index__profile> Res_ExplanationOfBenefit_Index__profile { get; set; }
    public DbSet<Res_ExplanationOfBenefit_Index__security> Res_ExplanationOfBenefit_Index__security { get; set; }
    public DbSet<Res_ExplanationOfBenefit_Index__tag> Res_ExplanationOfBenefit_Index__tag { get; set; }
    public DbSet<Res_FamilyMemberHistory> Res_FamilyMemberHistory { get; set; }
    public DbSet<Res_FamilyMemberHistory_History> Res_FamilyMemberHistory_History { get; set; }
    public DbSet<Res_FamilyMemberHistory_Index_code> Res_FamilyMemberHistory_Index_code { get; set; }
    public DbSet<Res_FamilyMemberHistory_Index_identifier> Res_FamilyMemberHistory_Index_identifier { get; set; }
    public DbSet<Res_FamilyMemberHistory_Index_relationship> Res_FamilyMemberHistory_Index_relationship { get; set; }
    public DbSet<Res_FamilyMemberHistory_Index__profile> Res_FamilyMemberHistory_Index__profile { get; set; }
    public DbSet<Res_FamilyMemberHistory_Index__security> Res_FamilyMemberHistory_Index__security { get; set; }
    public DbSet<Res_FamilyMemberHistory_Index__tag> Res_FamilyMemberHistory_Index__tag { get; set; }
    public DbSet<Res_Flag> Res_Flag { get; set; }
    public DbSet<Res_Flag_History> Res_Flag_History { get; set; }
    public DbSet<Res_Flag_Index__profile> Res_Flag_Index__profile { get; set; }
    public DbSet<Res_Flag_Index__security> Res_Flag_Index__security { get; set; }
    public DbSet<Res_Flag_Index__tag> Res_Flag_Index__tag { get; set; }
    public DbSet<Res_Goal> Res_Goal { get; set; }
    public DbSet<Res_Goal_History> Res_Goal_History { get; set; }
    public DbSet<Res_Goal_Index_category> Res_Goal_Index_category { get; set; }
    public DbSet<Res_Goal_Index_identifier> Res_Goal_Index_identifier { get; set; }
    public DbSet<Res_Goal_Index__profile> Res_Goal_Index__profile { get; set; }
    public DbSet<Res_Goal_Index__security> Res_Goal_Index__security { get; set; }
    public DbSet<Res_Goal_Index__tag> Res_Goal_Index__tag { get; set; }
    public DbSet<Res_Group> Res_Group { get; set; }
    public DbSet<Res_Group_History> Res_Group_History { get; set; }
    public DbSet<Res_Group_Index_characteristic> Res_Group_Index_characteristic { get; set; }
    public DbSet<Res_Group_Index_code> Res_Group_Index_code { get; set; }
    public DbSet<Res_Group_Index_exclude> Res_Group_Index_exclude { get; set; }
    public DbSet<Res_Group_Index_identifier> Res_Group_Index_identifier { get; set; }
    public DbSet<Res_Group_Index_member> Res_Group_Index_member { get; set; }
    public DbSet<Res_Group_Index_value> Res_Group_Index_value { get; set; }
    public DbSet<Res_Group_Index__profile> Res_Group_Index__profile { get; set; }
    public DbSet<Res_Group_Index__security> Res_Group_Index__security { get; set; }
    public DbSet<Res_Group_Index__tag> Res_Group_Index__tag { get; set; }
    public DbSet<Res_GuidanceResponse> Res_GuidanceResponse { get; set; }
    public DbSet<Res_GuidanceResponse_History> Res_GuidanceResponse_History { get; set; }
    public DbSet<Res_GuidanceResponse_Index__profile> Res_GuidanceResponse_Index__profile { get; set; }
    public DbSet<Res_GuidanceResponse_Index__security> Res_GuidanceResponse_Index__security { get; set; }
    public DbSet<Res_GuidanceResponse_Index__tag> Res_GuidanceResponse_Index__tag { get; set; }
    public DbSet<Res_HealthcareService> Res_HealthcareService { get; set; }
    public DbSet<Res_HealthcareService_History> Res_HealthcareService_History { get; set; }
    public DbSet<Res_HealthcareService_Index_characteristic> Res_HealthcareService_Index_characteristic { get; set; }
    public DbSet<Res_HealthcareService_Index_identifier> Res_HealthcareService_Index_identifier { get; set; }
    public DbSet<Res_HealthcareService_Index_location> Res_HealthcareService_Index_location { get; set; }
    public DbSet<Res_HealthcareService_Index_programname> Res_HealthcareService_Index_programname { get; set; }
    public DbSet<Res_HealthcareService_Index_servicecategory> Res_HealthcareService_Index_servicecategory { get; set; }
    public DbSet<Res_HealthcareService_Index_servicetype> Res_HealthcareService_Index_servicetype { get; set; }
    public DbSet<Res_HealthcareService_Index__profile> Res_HealthcareService_Index__profile { get; set; }
    public DbSet<Res_HealthcareService_Index__security> Res_HealthcareService_Index__security { get; set; }
    public DbSet<Res_HealthcareService_Index__tag> Res_HealthcareService_Index__tag { get; set; }
    public DbSet<Res_ImagingManifest> Res_ImagingManifest { get; set; }
    public DbSet<Res_ImagingManifest_History> Res_ImagingManifest_History { get; set; }
    public DbSet<Res_ImagingManifest_Index_selected_study> Res_ImagingManifest_Index_selected_study { get; set; }
    public DbSet<Res_ImagingManifest_Index_title> Res_ImagingManifest_Index_title { get; set; }
    public DbSet<Res_ImagingManifest_Index__profile> Res_ImagingManifest_Index__profile { get; set; }
    public DbSet<Res_ImagingManifest_Index__security> Res_ImagingManifest_Index__security { get; set; }
    public DbSet<Res_ImagingManifest_Index__tag> Res_ImagingManifest_Index__tag { get; set; }
    public DbSet<Res_ImagingStudy> Res_ImagingStudy { get; set; }
    public DbSet<Res_ImagingStudy_History> Res_ImagingStudy_History { get; set; }
    public DbSet<Res_ImagingStudy_Index_basedon> Res_ImagingStudy_Index_basedon { get; set; }
    public DbSet<Res_ImagingStudy_Index_bodysite> Res_ImagingStudy_Index_bodysite { get; set; }
    public DbSet<Res_ImagingStudy_Index_dicom_class> Res_ImagingStudy_Index_dicom_class { get; set; }
    public DbSet<Res_ImagingStudy_Index_identifier> Res_ImagingStudy_Index_identifier { get; set; }
    public DbSet<Res_ImagingStudy_Index_modality> Res_ImagingStudy_Index_modality { get; set; }
    public DbSet<Res_ImagingStudy_Index_reason> Res_ImagingStudy_Index_reason { get; set; }
    public DbSet<Res_ImagingStudy_Index_series> Res_ImagingStudy_Index_series { get; set; }
    public DbSet<Res_ImagingStudy_Index_uid> Res_ImagingStudy_Index_uid { get; set; }
    public DbSet<Res_ImagingStudy_Index__profile> Res_ImagingStudy_Index__profile { get; set; }
    public DbSet<Res_ImagingStudy_Index__security> Res_ImagingStudy_Index__security { get; set; }
    public DbSet<Res_ImagingStudy_Index__tag> Res_ImagingStudy_Index__tag { get; set; }
    public DbSet<Res_Immunization> Res_Immunization { get; set; }
    public DbSet<Res_Immunization_History> Res_Immunization_History { get; set; }
    public DbSet<Res_Immunization_Index_dose_sequence> Res_Immunization_Index_dose_sequence { get; set; }
    public DbSet<Res_Immunization_Index_identifier> Res_Immunization_Index_identifier { get; set; }
    public DbSet<Res_Immunization_Index_reaction> Res_Immunization_Index_reaction { get; set; }
    public DbSet<Res_Immunization_Index_reaction_date> Res_Immunization_Index_reaction_date { get; set; }
    public DbSet<Res_Immunization_Index_reason> Res_Immunization_Index_reason { get; set; }
    public DbSet<Res_Immunization_Index_reason_not_given> Res_Immunization_Index_reason_not_given { get; set; }
    public DbSet<Res_Immunization_Index_vaccine_code> Res_Immunization_Index_vaccine_code { get; set; }
    public DbSet<Res_Immunization_Index__profile> Res_Immunization_Index__profile { get; set; }
    public DbSet<Res_Immunization_Index__security> Res_Immunization_Index__security { get; set; }
    public DbSet<Res_Immunization_Index__tag> Res_Immunization_Index__tag { get; set; }
    public DbSet<Res_ImmunizationRecommendation> Res_ImmunizationRecommendation { get; set; }
    public DbSet<Res_ImmunizationRecommendation_History> Res_ImmunizationRecommendation_History { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index_date> Res_ImmunizationRecommendation_Index_date { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index_dose_number> Res_ImmunizationRecommendation_Index_dose_number { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index_dose_sequence> Res_ImmunizationRecommendation_Index_dose_sequence { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index_identifier> Res_ImmunizationRecommendation_Index_identifier { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index_information> Res_ImmunizationRecommendation_Index_information { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index_status> Res_ImmunizationRecommendation_Index_status { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index_support> Res_ImmunizationRecommendation_Index_support { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index_vaccine_type> Res_ImmunizationRecommendation_Index_vaccine_type { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index__profile> Res_ImmunizationRecommendation_Index__profile { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index__security> Res_ImmunizationRecommendation_Index__security { get; set; }
    public DbSet<Res_ImmunizationRecommendation_Index__tag> Res_ImmunizationRecommendation_Index__tag { get; set; }
    public DbSet<Res_ImplementationGuide> Res_ImplementationGuide { get; set; }
    public DbSet<Res_ImplementationGuide_History> Res_ImplementationGuide_History { get; set; }
    public DbSet<Res_ImplementationGuide_Index_context> Res_ImplementationGuide_Index_context { get; set; }
    public DbSet<Res_ImplementationGuide_Index_dependency> Res_ImplementationGuide_Index_dependency { get; set; }
    public DbSet<Res_ImplementationGuide_Index_resource> Res_ImplementationGuide_Index_resource { get; set; }
    public DbSet<Res_ImplementationGuide_Index__profile> Res_ImplementationGuide_Index__profile { get; set; }
    public DbSet<Res_ImplementationGuide_Index__security> Res_ImplementationGuide_Index__security { get; set; }
    public DbSet<Res_ImplementationGuide_Index__tag> Res_ImplementationGuide_Index__tag { get; set; }
    public DbSet<Res_Library> Res_Library { get; set; }
    public DbSet<Res_Library_History> Res_Library_History { get; set; }
    public DbSet<Res_Library_Index_identifier> Res_Library_Index_identifier { get; set; }
    public DbSet<Res_Library_Index_topic> Res_Library_Index_topic { get; set; }
    public DbSet<Res_Library_Index__profile> Res_Library_Index__profile { get; set; }
    public DbSet<Res_Library_Index__security> Res_Library_Index__security { get; set; }
    public DbSet<Res_Library_Index__tag> Res_Library_Index__tag { get; set; }
    public DbSet<Res_Linkage> Res_Linkage { get; set; }
    public DbSet<Res_Linkage_History> Res_Linkage_History { get; set; }
    public DbSet<Res_Linkage_Index_item> Res_Linkage_Index_item { get; set; }
    public DbSet<Res_Linkage_Index_source> Res_Linkage_Index_source { get; set; }
    public DbSet<Res_Linkage_Index__profile> Res_Linkage_Index__profile { get; set; }
    public DbSet<Res_Linkage_Index__security> Res_Linkage_Index__security { get; set; }
    public DbSet<Res_Linkage_Index__tag> Res_Linkage_Index__tag { get; set; }
    public DbSet<Res_List> Res_List { get; set; }
    public DbSet<Res_List_History> Res_List_History { get; set; }
    public DbSet<Res_List_Index_code> Res_List_Index_code { get; set; }
    public DbSet<Res_List_Index_empty_reason> Res_List_Index_empty_reason { get; set; }
    public DbSet<Res_List_Index_identifier> Res_List_Index_identifier { get; set; }
    public DbSet<Res_List_Index_item> Res_List_Index_item { get; set; }
    public DbSet<Res_List_Index_notes> Res_List_Index_notes { get; set; }
    public DbSet<Res_List_Index__profile> Res_List_Index__profile { get; set; }
    public DbSet<Res_List_Index__security> Res_List_Index__security { get; set; }
    public DbSet<Res_List_Index__tag> Res_List_Index__tag { get; set; }
    public DbSet<Res_Location> Res_Location { get; set; }
    public DbSet<Res_Location_History> Res_Location_History { get; set; }
    public DbSet<Res_Location_Index_address> Res_Location_Index_address { get; set; }
    public DbSet<Res_Location_Index_identifier> Res_Location_Index_identifier { get; set; }
    public DbSet<Res_Location_Index_name> Res_Location_Index_name { get; set; }
    public DbSet<Res_Location_Index_type> Res_Location_Index_type { get; set; }
    public DbSet<Res_Location_Index__profile> Res_Location_Index__profile { get; set; }
    public DbSet<Res_Location_Index__security> Res_Location_Index__security { get; set; }
    public DbSet<Res_Location_Index__tag> Res_Location_Index__tag { get; set; }
    public DbSet<Res_Measure> Res_Measure { get; set; }
    public DbSet<Res_Measure_History> Res_Measure_History { get; set; }
    public DbSet<Res_Measure_Index_identifier> Res_Measure_Index_identifier { get; set; }
    public DbSet<Res_Measure_Index_topic> Res_Measure_Index_topic { get; set; }
    public DbSet<Res_Measure_Index__profile> Res_Measure_Index__profile { get; set; }
    public DbSet<Res_Measure_Index__security> Res_Measure_Index__security { get; set; }
    public DbSet<Res_Measure_Index__tag> Res_Measure_Index__tag { get; set; }
    public DbSet<Res_MeasureReport> Res_MeasureReport { get; set; }
    public DbSet<Res_MeasureReport_History> Res_MeasureReport_History { get; set; }
    public DbSet<Res_MeasureReport_Index__profile> Res_MeasureReport_Index__profile { get; set; }
    public DbSet<Res_MeasureReport_Index__security> Res_MeasureReport_Index__security { get; set; }
    public DbSet<Res_MeasureReport_Index__tag> Res_MeasureReport_Index__tag { get; set; }
    public DbSet<Res_Media> Res_Media { get; set; }
    public DbSet<Res_Media_History> Res_Media_History { get; set; }
    public DbSet<Res_Media_Index_identifier> Res_Media_Index_identifier { get; set; }
    public DbSet<Res_Media_Index_subtype> Res_Media_Index_subtype { get; set; }
    public DbSet<Res_Media_Index_view> Res_Media_Index_view { get; set; }
    public DbSet<Res_Media_Index__profile> Res_Media_Index__profile { get; set; }
    public DbSet<Res_Media_Index__security> Res_Media_Index__security { get; set; }
    public DbSet<Res_Media_Index__tag> Res_Media_Index__tag { get; set; }
    public DbSet<Res_Medication> Res_Medication { get; set; }
    public DbSet<Res_Medication_History> Res_Medication_History { get; set; }
    public DbSet<Res_Medication_Index_code> Res_Medication_Index_code { get; set; }
    public DbSet<Res_Medication_Index_container> Res_Medication_Index_container { get; set; }
    public DbSet<Res_Medication_Index_form> Res_Medication_Index_form { get; set; }
    public DbSet<Res_Medication_Index_ingredient> Res_Medication_Index_ingredient { get; set; }
    public DbSet<Res_Medication_Index_ingredient_code> Res_Medication_Index_ingredient_code { get; set; }
    public DbSet<Res_Medication_Index_package_item> Res_Medication_Index_package_item { get; set; }
    public DbSet<Res_Medication_Index_package_item_code> Res_Medication_Index_package_item_code { get; set; }
    public DbSet<Res_Medication_Index__profile> Res_Medication_Index__profile { get; set; }
    public DbSet<Res_Medication_Index__security> Res_Medication_Index__security { get; set; }
    public DbSet<Res_Medication_Index__tag> Res_Medication_Index__tag { get; set; }
    public DbSet<Res_MedicationAdministration> Res_MedicationAdministration { get; set; }
    public DbSet<Res_MedicationAdministration_History> Res_MedicationAdministration_History { get; set; }
    public DbSet<Res_MedicationAdministration_Index_code> Res_MedicationAdministration_Index_code { get; set; }
    public DbSet<Res_MedicationAdministration_Index_device> Res_MedicationAdministration_Index_device { get; set; }
    public DbSet<Res_MedicationAdministration_Index_identifier> Res_MedicationAdministration_Index_identifier { get; set; }
    public DbSet<Res_MedicationAdministration_Index__profile> Res_MedicationAdministration_Index__profile { get; set; }
    public DbSet<Res_MedicationAdministration_Index__security> Res_MedicationAdministration_Index__security { get; set; }
    public DbSet<Res_MedicationAdministration_Index__tag> Res_MedicationAdministration_Index__tag { get; set; }
    public DbSet<Res_MedicationDispense> Res_MedicationDispense { get; set; }
    public DbSet<Res_MedicationDispense_History> Res_MedicationDispense_History { get; set; }
    public DbSet<Res_MedicationDispense_Index_code> Res_MedicationDispense_Index_code { get; set; }
    public DbSet<Res_MedicationDispense_Index_prescription> Res_MedicationDispense_Index_prescription { get; set; }
    public DbSet<Res_MedicationDispense_Index_receiver> Res_MedicationDispense_Index_receiver { get; set; }
    public DbSet<Res_MedicationDispense_Index_responsibleparty> Res_MedicationDispense_Index_responsibleparty { get; set; }
    public DbSet<Res_MedicationDispense_Index_type> Res_MedicationDispense_Index_type { get; set; }
    public DbSet<Res_MedicationDispense_Index__profile> Res_MedicationDispense_Index__profile { get; set; }
    public DbSet<Res_MedicationDispense_Index__security> Res_MedicationDispense_Index__security { get; set; }
    public DbSet<Res_MedicationDispense_Index__tag> Res_MedicationDispense_Index__tag { get; set; }
    public DbSet<Res_MedicationOrder> Res_MedicationOrder { get; set; }
    public DbSet<Res_MedicationOrder_History> Res_MedicationOrder_History { get; set; }
    public DbSet<Res_MedicationOrder_Index_code> Res_MedicationOrder_Index_code { get; set; }
    public DbSet<Res_MedicationOrder_Index_identifier> Res_MedicationOrder_Index_identifier { get; set; }
    public DbSet<Res_MedicationOrder_Index__profile> Res_MedicationOrder_Index__profile { get; set; }
    public DbSet<Res_MedicationOrder_Index__security> Res_MedicationOrder_Index__security { get; set; }
    public DbSet<Res_MedicationOrder_Index__tag> Res_MedicationOrder_Index__tag { get; set; }
    public DbSet<Res_MedicationStatement> Res_MedicationStatement { get; set; }
    public DbSet<Res_MedicationStatement_History> Res_MedicationStatement_History { get; set; }
    public DbSet<Res_MedicationStatement_Index_code> Res_MedicationStatement_Index_code { get; set; }
    public DbSet<Res_MedicationStatement_Index_identifier> Res_MedicationStatement_Index_identifier { get; set; }
    public DbSet<Res_MedicationStatement_Index__profile> Res_MedicationStatement_Index__profile { get; set; }
    public DbSet<Res_MedicationStatement_Index__security> Res_MedicationStatement_Index__security { get; set; }
    public DbSet<Res_MedicationStatement_Index__tag> Res_MedicationStatement_Index__tag { get; set; }
    public DbSet<Res_MessageHeader> Res_MessageHeader { get; set; }
    public DbSet<Res_MessageHeader_History> Res_MessageHeader_History { get; set; }
    public DbSet<Res_MessageHeader_Index_data> Res_MessageHeader_Index_data { get; set; }
    public DbSet<Res_MessageHeader_Index_destination> Res_MessageHeader_Index_destination { get; set; }
    public DbSet<Res_MessageHeader_Index_destination_uri> Res_MessageHeader_Index_destination_uri { get; set; }
    public DbSet<Res_MessageHeader_Index_target> Res_MessageHeader_Index_target { get; set; }
    public DbSet<Res_MessageHeader_Index__profile> Res_MessageHeader_Index__profile { get; set; }
    public DbSet<Res_MessageHeader_Index__security> Res_MessageHeader_Index__security { get; set; }
    public DbSet<Res_MessageHeader_Index__tag> Res_MessageHeader_Index__tag { get; set; }
    public DbSet<Res_NamingSystem> Res_NamingSystem { get; set; }
    public DbSet<Res_NamingSystem_History> Res_NamingSystem_History { get; set; }
    public DbSet<Res_NamingSystem_Index_contact> Res_NamingSystem_Index_contact { get; set; }
    public DbSet<Res_NamingSystem_Index_context> Res_NamingSystem_Index_context { get; set; }
    public DbSet<Res_NamingSystem_Index_id_type> Res_NamingSystem_Index_id_type { get; set; }
    public DbSet<Res_NamingSystem_Index_period> Res_NamingSystem_Index_period { get; set; }
    public DbSet<Res_NamingSystem_Index_telecom> Res_NamingSystem_Index_telecom { get; set; }
    public DbSet<Res_NamingSystem_Index_type> Res_NamingSystem_Index_type { get; set; }
    public DbSet<Res_NamingSystem_Index_value> Res_NamingSystem_Index_value { get; set; }
    public DbSet<Res_NamingSystem_Index__profile> Res_NamingSystem_Index__profile { get; set; }
    public DbSet<Res_NamingSystem_Index__security> Res_NamingSystem_Index__security { get; set; }
    public DbSet<Res_NamingSystem_Index__tag> Res_NamingSystem_Index__tag { get; set; }
    public DbSet<Res_NutritionRequest> Res_NutritionRequest { get; set; }
    public DbSet<Res_NutritionRequest_History> Res_NutritionRequest_History { get; set; }
    public DbSet<Res_NutritionRequest_Index_additive> Res_NutritionRequest_Index_additive { get; set; }
    public DbSet<Res_NutritionRequest_Index_formula> Res_NutritionRequest_Index_formula { get; set; }
    public DbSet<Res_NutritionRequest_Index_identifier> Res_NutritionRequest_Index_identifier { get; set; }
    public DbSet<Res_NutritionRequest_Index_oraldiet> Res_NutritionRequest_Index_oraldiet { get; set; }
    public DbSet<Res_NutritionRequest_Index_supplement> Res_NutritionRequest_Index_supplement { get; set; }
    public DbSet<Res_NutritionRequest_Index__profile> Res_NutritionRequest_Index__profile { get; set; }
    public DbSet<Res_NutritionRequest_Index__security> Res_NutritionRequest_Index__security { get; set; }
    public DbSet<Res_NutritionRequest_Index__tag> Res_NutritionRequest_Index__tag { get; set; }
    public DbSet<Res_Observation> Res_Observation { get; set; }
    public DbSet<Res_Observation_History> Res_Observation_History { get; set; }
    public DbSet<Res_Observation_Index_category> Res_Observation_Index_category { get; set; }
    public DbSet<Res_Observation_Index_code> Res_Observation_Index_code { get; set; }
    public DbSet<Res_Observation_Index_data_absent_reason> Res_Observation_Index_data_absent_reason { get; set; }
    public DbSet<Res_Observation_Index_identifier> Res_Observation_Index_identifier { get; set; }
    public DbSet<Res_Observation_Index_method> Res_Observation_Index_method { get; set; }
    public DbSet<Res_Observation_Index_performer> Res_Observation_Index_performer { get; set; }
    public DbSet<Res_Observation_Index_related_target> Res_Observation_Index_related_target { get; set; }
    public DbSet<Res_Observation_Index_related_type> Res_Observation_Index_related_type { get; set; }
    public DbSet<Res_Observation_Index_value_concept> Res_Observation_Index_value_concept { get; set; }
    public DbSet<Res_Observation_Index_value_quantity> Res_Observation_Index_value_quantity { get; set; }
    public DbSet<Res_Observation_Index_value_string> Res_Observation_Index_value_string { get; set; }
    public DbSet<Res_Observation_Index__profile> Res_Observation_Index__profile { get; set; }
    public DbSet<Res_Observation_Index__security> Res_Observation_Index__security { get; set; }
    public DbSet<Res_Observation_Index__tag> Res_Observation_Index__tag { get; set; }
    public DbSet<Res_OperationDefinition> Res_OperationDefinition { get; set; }
    public DbSet<Res_OperationDefinition_History> Res_OperationDefinition_History { get; set; }
    public DbSet<Res_OperationDefinition_Index_context> Res_OperationDefinition_Index_context { get; set; }
    public DbSet<Res_OperationDefinition_Index_paramprofile> Res_OperationDefinition_Index_paramprofile { get; set; }
    public DbSet<Res_OperationDefinition_Index_type> Res_OperationDefinition_Index_type { get; set; }
    public DbSet<Res_OperationDefinition_Index__profile> Res_OperationDefinition_Index__profile { get; set; }
    public DbSet<Res_OperationDefinition_Index__security> Res_OperationDefinition_Index__security { get; set; }
    public DbSet<Res_OperationDefinition_Index__tag> Res_OperationDefinition_Index__tag { get; set; }
    public DbSet<Res_OperationOutcome> Res_OperationOutcome { get; set; }
    public DbSet<Res_OperationOutcome_History> Res_OperationOutcome_History { get; set; }
    public DbSet<Res_OperationOutcome_Index__profile> Res_OperationOutcome_Index__profile { get; set; }
    public DbSet<Res_OperationOutcome_Index__security> Res_OperationOutcome_Index__security { get; set; }
    public DbSet<Res_OperationOutcome_Index__tag> Res_OperationOutcome_Index__tag { get; set; }
    public DbSet<Res_Organization> Res_Organization { get; set; }
    public DbSet<Res_Organization_History> Res_Organization_History { get; set; }
    public DbSet<Res_Organization_Index_address> Res_Organization_Index_address { get; set; }
    public DbSet<Res_Organization_Index_address_city> Res_Organization_Index_address_city { get; set; }
    public DbSet<Res_Organization_Index_address_country> Res_Organization_Index_address_country { get; set; }
    public DbSet<Res_Organization_Index_address_postalcode> Res_Organization_Index_address_postalcode { get; set; }
    public DbSet<Res_Organization_Index_address_state> Res_Organization_Index_address_state { get; set; }
    public DbSet<Res_Organization_Index_address_use> Res_Organization_Index_address_use { get; set; }
    public DbSet<Res_Organization_Index_identifier> Res_Organization_Index_identifier { get; set; }
    public DbSet<Res_Organization_Index_name> Res_Organization_Index_name { get; set; }
    public DbSet<Res_Organization_Index_type> Res_Organization_Index_type { get; set; }
    public DbSet<Res_Organization_Index__profile> Res_Organization_Index__profile { get; set; }
    public DbSet<Res_Organization_Index__security> Res_Organization_Index__security { get; set; }
    public DbSet<Res_Organization_Index__tag> Res_Organization_Index__tag { get; set; }
    public DbSet<Res_Parameters> Res_Parameters { get; set; }
    public DbSet<Res_Parameters_History> Res_Parameters_History { get; set; }
    public DbSet<Res_Parameters_Index__profile> Res_Parameters_Index__profile { get; set; }
    public DbSet<Res_Parameters_Index__security> Res_Parameters_Index__security { get; set; }
    public DbSet<Res_Parameters_Index__tag> Res_Parameters_Index__tag { get; set; }
    public DbSet<Res_Patient> Res_Patient { get; set; }
    public DbSet<Res_Patient_History> Res_Patient_History { get; set; }
    public DbSet<Res_Patient_Index_address> Res_Patient_Index_address { get; set; }
    public DbSet<Res_Patient_Index_address_city> Res_Patient_Index_address_city { get; set; }
    public DbSet<Res_Patient_Index_address_country> Res_Patient_Index_address_country { get; set; }
    public DbSet<Res_Patient_Index_address_postalcode> Res_Patient_Index_address_postalcode { get; set; }
    public DbSet<Res_Patient_Index_address_state> Res_Patient_Index_address_state { get; set; }
    public DbSet<Res_Patient_Index_address_use> Res_Patient_Index_address_use { get; set; }
    public DbSet<Res_Patient_Index_animal_breed> Res_Patient_Index_animal_breed { get; set; }
    public DbSet<Res_Patient_Index_animal_species> Res_Patient_Index_animal_species { get; set; }
    public DbSet<Res_Patient_Index_email> Res_Patient_Index_email { get; set; }
    public DbSet<Res_Patient_Index_family> Res_Patient_Index_family { get; set; }
    public DbSet<Res_Patient_Index_general_practitioner> Res_Patient_Index_general_practitioner { get; set; }
    public DbSet<Res_Patient_Index_given> Res_Patient_Index_given { get; set; }
    public DbSet<Res_Patient_Index_identifier> Res_Patient_Index_identifier { get; set; }
    public DbSet<Res_Patient_Index_language> Res_Patient_Index_language { get; set; }
    public DbSet<Res_Patient_Index_link> Res_Patient_Index_link { get; set; }
    public DbSet<Res_Patient_Index_name> Res_Patient_Index_name { get; set; }
    public DbSet<Res_Patient_Index_phone> Res_Patient_Index_phone { get; set; }
    public DbSet<Res_Patient_Index_phonetic> Res_Patient_Index_phonetic { get; set; }
    public DbSet<Res_Patient_Index_telecom> Res_Patient_Index_telecom { get; set; }
    public DbSet<Res_Patient_Index__profile> Res_Patient_Index__profile { get; set; }
    public DbSet<Res_Patient_Index__security> Res_Patient_Index__security { get; set; }
    public DbSet<Res_Patient_Index__tag> Res_Patient_Index__tag { get; set; }
    public DbSet<Res_PaymentNotice> Res_PaymentNotice { get; set; }
    public DbSet<Res_PaymentNotice_History> Res_PaymentNotice_History { get; set; }
    public DbSet<Res_PaymentNotice_Index_identifier> Res_PaymentNotice_Index_identifier { get; set; }
    public DbSet<Res_PaymentNotice_Index__profile> Res_PaymentNotice_Index__profile { get; set; }
    public DbSet<Res_PaymentNotice_Index__security> Res_PaymentNotice_Index__security { get; set; }
    public DbSet<Res_PaymentNotice_Index__tag> Res_PaymentNotice_Index__tag { get; set; }
    public DbSet<Res_PaymentReconciliation> Res_PaymentReconciliation { get; set; }
    public DbSet<Res_PaymentReconciliation_History> Res_PaymentReconciliation_History { get; set; }
    public DbSet<Res_PaymentReconciliation_Index_identifier> Res_PaymentReconciliation_Index_identifier { get; set; }
    public DbSet<Res_PaymentReconciliation_Index__profile> Res_PaymentReconciliation_Index__profile { get; set; }
    public DbSet<Res_PaymentReconciliation_Index__security> Res_PaymentReconciliation_Index__security { get; set; }
    public DbSet<Res_PaymentReconciliation_Index__tag> Res_PaymentReconciliation_Index__tag { get; set; }
    public DbSet<Res_Person> Res_Person { get; set; }
    public DbSet<Res_Person_History> Res_Person_History { get; set; }
    public DbSet<Res_Person_Index_address> Res_Person_Index_address { get; set; }
    public DbSet<Res_Person_Index_address_city> Res_Person_Index_address_city { get; set; }
    public DbSet<Res_Person_Index_address_country> Res_Person_Index_address_country { get; set; }
    public DbSet<Res_Person_Index_address_postalcode> Res_Person_Index_address_postalcode { get; set; }
    public DbSet<Res_Person_Index_address_state> Res_Person_Index_address_state { get; set; }
    public DbSet<Res_Person_Index_address_use> Res_Person_Index_address_use { get; set; }
    public DbSet<Res_Person_Index_email> Res_Person_Index_email { get; set; }
    public DbSet<Res_Person_Index_identifier> Res_Person_Index_identifier { get; set; }
    public DbSet<Res_Person_Index_link> Res_Person_Index_link { get; set; }
    public DbSet<Res_Person_Index_name> Res_Person_Index_name { get; set; }
    public DbSet<Res_Person_Index_patient> Res_Person_Index_patient { get; set; }
    public DbSet<Res_Person_Index_phone> Res_Person_Index_phone { get; set; }
    public DbSet<Res_Person_Index_phonetic> Res_Person_Index_phonetic { get; set; }
    public DbSet<Res_Person_Index_practitioner> Res_Person_Index_practitioner { get; set; }
    public DbSet<Res_Person_Index_relatedperson> Res_Person_Index_relatedperson { get; set; }
    public DbSet<Res_Person_Index_telecom> Res_Person_Index_telecom { get; set; }
    public DbSet<Res_Person_Index__profile> Res_Person_Index__profile { get; set; }
    public DbSet<Res_Person_Index__security> Res_Person_Index__security { get; set; }
    public DbSet<Res_Person_Index__tag> Res_Person_Index__tag { get; set; }
    public DbSet<Res_PlanDefinition> Res_PlanDefinition { get; set; }
    public DbSet<Res_PlanDefinition_History> Res_PlanDefinition_History { get; set; }
    public DbSet<Res_PlanDefinition_Index_identifier> Res_PlanDefinition_Index_identifier { get; set; }
    public DbSet<Res_PlanDefinition_Index_topic> Res_PlanDefinition_Index_topic { get; set; }
    public DbSet<Res_PlanDefinition_Index__profile> Res_PlanDefinition_Index__profile { get; set; }
    public DbSet<Res_PlanDefinition_Index__security> Res_PlanDefinition_Index__security { get; set; }
    public DbSet<Res_PlanDefinition_Index__tag> Res_PlanDefinition_Index__tag { get; set; }
    public DbSet<Res_Practitioner> Res_Practitioner { get; set; }
    public DbSet<Res_Practitioner_History> Res_Practitioner_History { get; set; }
    public DbSet<Res_Practitioner_Index_address> Res_Practitioner_Index_address { get; set; }
    public DbSet<Res_Practitioner_Index_address_city> Res_Practitioner_Index_address_city { get; set; }
    public DbSet<Res_Practitioner_Index_address_country> Res_Practitioner_Index_address_country { get; set; }
    public DbSet<Res_Practitioner_Index_address_postalcode> Res_Practitioner_Index_address_postalcode { get; set; }
    public DbSet<Res_Practitioner_Index_address_state> Res_Practitioner_Index_address_state { get; set; }
    public DbSet<Res_Practitioner_Index_address_use> Res_Practitioner_Index_address_use { get; set; }
    public DbSet<Res_Practitioner_Index_communication> Res_Practitioner_Index_communication { get; set; }
    public DbSet<Res_Practitioner_Index_email> Res_Practitioner_Index_email { get; set; }
    public DbSet<Res_Practitioner_Index_family> Res_Practitioner_Index_family { get; set; }
    public DbSet<Res_Practitioner_Index_given> Res_Practitioner_Index_given { get; set; }
    public DbSet<Res_Practitioner_Index_identifier> Res_Practitioner_Index_identifier { get; set; }
    public DbSet<Res_Practitioner_Index_location> Res_Practitioner_Index_location { get; set; }
    public DbSet<Res_Practitioner_Index_name> Res_Practitioner_Index_name { get; set; }
    public DbSet<Res_Practitioner_Index_organization> Res_Practitioner_Index_organization { get; set; }
    public DbSet<Res_Practitioner_Index_phone> Res_Practitioner_Index_phone { get; set; }
    public DbSet<Res_Practitioner_Index_phonetic> Res_Practitioner_Index_phonetic { get; set; }
    public DbSet<Res_Practitioner_Index_role> Res_Practitioner_Index_role { get; set; }
    public DbSet<Res_Practitioner_Index_specialty> Res_Practitioner_Index_specialty { get; set; }
    public DbSet<Res_Practitioner_Index_telecom> Res_Practitioner_Index_telecom { get; set; }
    public DbSet<Res_Practitioner_Index__profile> Res_Practitioner_Index__profile { get; set; }
    public DbSet<Res_Practitioner_Index__security> Res_Practitioner_Index__security { get; set; }
    public DbSet<Res_Practitioner_Index__tag> Res_Practitioner_Index__tag { get; set; }
    public DbSet<Res_PractitionerRole> Res_PractitionerRole { get; set; }
    public DbSet<Res_PractitionerRole_History> Res_PractitionerRole_History { get; set; }
    public DbSet<Res_PractitionerRole_Index_email> Res_PractitionerRole_Index_email { get; set; }
    public DbSet<Res_PractitionerRole_Index_identifier> Res_PractitionerRole_Index_identifier { get; set; }
    public DbSet<Res_PractitionerRole_Index_location> Res_PractitionerRole_Index_location { get; set; }
    public DbSet<Res_PractitionerRole_Index_phone> Res_PractitionerRole_Index_phone { get; set; }
    public DbSet<Res_PractitionerRole_Index_role> Res_PractitionerRole_Index_role { get; set; }
    public DbSet<Res_PractitionerRole_Index_specialty> Res_PractitionerRole_Index_specialty { get; set; }
    public DbSet<Res_PractitionerRole_Index_telecom> Res_PractitionerRole_Index_telecom { get; set; }
    public DbSet<Res_PractitionerRole_Index__profile> Res_PractitionerRole_Index__profile { get; set; }
    public DbSet<Res_PractitionerRole_Index__security> Res_PractitionerRole_Index__security { get; set; }
    public DbSet<Res_PractitionerRole_Index__tag> Res_PractitionerRole_Index__tag { get; set; }
    public DbSet<Res_Procedure> Res_Procedure { get; set; }
    public DbSet<Res_Procedure_History> Res_Procedure_History { get; set; }
    public DbSet<Res_Procedure_Index_category> Res_Procedure_Index_category { get; set; }
    public DbSet<Res_Procedure_Index_code> Res_Procedure_Index_code { get; set; }
    public DbSet<Res_Procedure_Index_identifier> Res_Procedure_Index_identifier { get; set; }
    public DbSet<Res_Procedure_Index_performer> Res_Procedure_Index_performer { get; set; }
    public DbSet<Res_Procedure_Index__profile> Res_Procedure_Index__profile { get; set; }
    public DbSet<Res_Procedure_Index__security> Res_Procedure_Index__security { get; set; }
    public DbSet<Res_Procedure_Index__tag> Res_Procedure_Index__tag { get; set; }
    public DbSet<Res_ProcedureRequest> Res_ProcedureRequest { get; set; }
    public DbSet<Res_ProcedureRequest_History> Res_ProcedureRequest_History { get; set; }
    public DbSet<Res_ProcedureRequest_Index_identifier> Res_ProcedureRequest_Index_identifier { get; set; }
    public DbSet<Res_ProcedureRequest_Index__profile> Res_ProcedureRequest_Index__profile { get; set; }
    public DbSet<Res_ProcedureRequest_Index__security> Res_ProcedureRequest_Index__security { get; set; }
    public DbSet<Res_ProcedureRequest_Index__tag> Res_ProcedureRequest_Index__tag { get; set; }
    public DbSet<Res_ProcessRequest> Res_ProcessRequest { get; set; }
    public DbSet<Res_ProcessRequest_History> Res_ProcessRequest_History { get; set; }
    public DbSet<Res_ProcessRequest_Index_identifier> Res_ProcessRequest_Index_identifier { get; set; }
    public DbSet<Res_ProcessRequest_Index__profile> Res_ProcessRequest_Index__profile { get; set; }
    public DbSet<Res_ProcessRequest_Index__security> Res_ProcessRequest_Index__security { get; set; }
    public DbSet<Res_ProcessRequest_Index__tag> Res_ProcessRequest_Index__tag { get; set; }
    public DbSet<Res_ProcessResponse> Res_ProcessResponse { get; set; }
    public DbSet<Res_ProcessResponse_History> Res_ProcessResponse_History { get; set; }
    public DbSet<Res_ProcessResponse_Index_identifier> Res_ProcessResponse_Index_identifier { get; set; }
    public DbSet<Res_ProcessResponse_Index__profile> Res_ProcessResponse_Index__profile { get; set; }
    public DbSet<Res_ProcessResponse_Index__security> Res_ProcessResponse_Index__security { get; set; }
    public DbSet<Res_ProcessResponse_Index__tag> Res_ProcessResponse_Index__tag { get; set; }
    public DbSet<Res_Provenance> Res_Provenance { get; set; }
    public DbSet<Res_Provenance_History> Res_Provenance_History { get; set; }
    public DbSet<Res_Provenance_Index_agent> Res_Provenance_Index_agent { get; set; }
    public DbSet<Res_Provenance_Index_entity> Res_Provenance_Index_entity { get; set; }
    public DbSet<Res_Provenance_Index_entity_type> Res_Provenance_Index_entity_type { get; set; }
    public DbSet<Res_Provenance_Index_patient> Res_Provenance_Index_patient { get; set; }
    public DbSet<Res_Provenance_Index_sig> Res_Provenance_Index_sig { get; set; }
    public DbSet<Res_Provenance_Index_target> Res_Provenance_Index_target { get; set; }
    public DbSet<Res_Provenance_Index_userid> Res_Provenance_Index_userid { get; set; }
    public DbSet<Res_Provenance_Index__profile> Res_Provenance_Index__profile { get; set; }
    public DbSet<Res_Provenance_Index__security> Res_Provenance_Index__security { get; set; }
    public DbSet<Res_Provenance_Index__tag> Res_Provenance_Index__tag { get; set; }
    public DbSet<Res_Questionnaire> Res_Questionnaire { get; set; }
    public DbSet<Res_Questionnaire_History> Res_Questionnaire_History { get; set; }
    public DbSet<Res_Questionnaire_Index_code> Res_Questionnaire_Index_code { get; set; }
    public DbSet<Res_Questionnaire_Index_context> Res_Questionnaire_Index_context { get; set; }
    public DbSet<Res_Questionnaire_Index_identifier> Res_Questionnaire_Index_identifier { get; set; }
    public DbSet<Res_Questionnaire_Index__profile> Res_Questionnaire_Index__profile { get; set; }
    public DbSet<Res_Questionnaire_Index__security> Res_Questionnaire_Index__security { get; set; }
    public DbSet<Res_Questionnaire_Index__tag> Res_Questionnaire_Index__tag { get; set; }
    public DbSet<Res_QuestionnaireResponse> Res_QuestionnaireResponse { get; set; }
    public DbSet<Res_QuestionnaireResponse_History> Res_QuestionnaireResponse_History { get; set; }
    public DbSet<Res_QuestionnaireResponse_Index_based_on> Res_QuestionnaireResponse_Index_based_on { get; set; }
    public DbSet<Res_QuestionnaireResponse_Index_parent> Res_QuestionnaireResponse_Index_parent { get; set; }
    public DbSet<Res_QuestionnaireResponse_Index__profile> Res_QuestionnaireResponse_Index__profile { get; set; }
    public DbSet<Res_QuestionnaireResponse_Index__security> Res_QuestionnaireResponse_Index__security { get; set; }
    public DbSet<Res_QuestionnaireResponse_Index__tag> Res_QuestionnaireResponse_Index__tag { get; set; }
    public DbSet<Res_ReferralRequest> Res_ReferralRequest { get; set; }
    public DbSet<Res_ReferralRequest_History> Res_ReferralRequest_History { get; set; }
    public DbSet<Res_ReferralRequest_Index_basedon> Res_ReferralRequest_Index_basedon { get; set; }
    public DbSet<Res_ReferralRequest_Index_priority> Res_ReferralRequest_Index_priority { get; set; }
    public DbSet<Res_ReferralRequest_Index_recipient> Res_ReferralRequest_Index_recipient { get; set; }
    public DbSet<Res_ReferralRequest_Index_specialty> Res_ReferralRequest_Index_specialty { get; set; }
    public DbSet<Res_ReferralRequest_Index_type> Res_ReferralRequest_Index_type { get; set; }
    public DbSet<Res_ReferralRequest_Index__profile> Res_ReferralRequest_Index__profile { get; set; }
    public DbSet<Res_ReferralRequest_Index__security> Res_ReferralRequest_Index__security { get; set; }
    public DbSet<Res_ReferralRequest_Index__tag> Res_ReferralRequest_Index__tag { get; set; }
    public DbSet<Res_RelatedPerson> Res_RelatedPerson { get; set; }
    public DbSet<Res_RelatedPerson_History> Res_RelatedPerson_History { get; set; }
    public DbSet<Res_RelatedPerson_Index_address> Res_RelatedPerson_Index_address { get; set; }
    public DbSet<Res_RelatedPerson_Index_address_city> Res_RelatedPerson_Index_address_city { get; set; }
    public DbSet<Res_RelatedPerson_Index_address_country> Res_RelatedPerson_Index_address_country { get; set; }
    public DbSet<Res_RelatedPerson_Index_address_postalcode> Res_RelatedPerson_Index_address_postalcode { get; set; }
    public DbSet<Res_RelatedPerson_Index_address_state> Res_RelatedPerson_Index_address_state { get; set; }
    public DbSet<Res_RelatedPerson_Index_address_use> Res_RelatedPerson_Index_address_use { get; set; }
    public DbSet<Res_RelatedPerson_Index_email> Res_RelatedPerson_Index_email { get; set; }
    public DbSet<Res_RelatedPerson_Index_identifier> Res_RelatedPerson_Index_identifier { get; set; }
    public DbSet<Res_RelatedPerson_Index_name> Res_RelatedPerson_Index_name { get; set; }
    public DbSet<Res_RelatedPerson_Index_phone> Res_RelatedPerson_Index_phone { get; set; }
    public DbSet<Res_RelatedPerson_Index_phonetic> Res_RelatedPerson_Index_phonetic { get; set; }
    public DbSet<Res_RelatedPerson_Index_telecom> Res_RelatedPerson_Index_telecom { get; set; }
    public DbSet<Res_RelatedPerson_Index__profile> Res_RelatedPerson_Index__profile { get; set; }
    public DbSet<Res_RelatedPerson_Index__security> Res_RelatedPerson_Index__security { get; set; }
    public DbSet<Res_RelatedPerson_Index__tag> Res_RelatedPerson_Index__tag { get; set; }
    public DbSet<Res_RiskAssessment> Res_RiskAssessment { get; set; }
    public DbSet<Res_RiskAssessment_History> Res_RiskAssessment_History { get; set; }
    public DbSet<Res_RiskAssessment_Index_method> Res_RiskAssessment_Index_method { get; set; }
    public DbSet<Res_RiskAssessment_Index__profile> Res_RiskAssessment_Index__profile { get; set; }
    public DbSet<Res_RiskAssessment_Index__security> Res_RiskAssessment_Index__security { get; set; }
    public DbSet<Res_RiskAssessment_Index__tag> Res_RiskAssessment_Index__tag { get; set; }
    public DbSet<Res_Schedule> Res_Schedule { get; set; }
    public DbSet<Res_Schedule_History> Res_Schedule_History { get; set; }
    public DbSet<Res_Schedule_Index_identifier> Res_Schedule_Index_identifier { get; set; }
    public DbSet<Res_Schedule_Index_type> Res_Schedule_Index_type { get; set; }
    public DbSet<Res_Schedule_Index__profile> Res_Schedule_Index__profile { get; set; }
    public DbSet<Res_Schedule_Index__security> Res_Schedule_Index__security { get; set; }
    public DbSet<Res_Schedule_Index__tag> Res_Schedule_Index__tag { get; set; }
    public DbSet<Res_SearchParameter> Res_SearchParameter { get; set; }
    public DbSet<Res_SearchParameter_History> Res_SearchParameter_History { get; set; }
    public DbSet<Res_SearchParameter_Index_component> Res_SearchParameter_Index_component { get; set; }
    public DbSet<Res_SearchParameter_Index_context> Res_SearchParameter_Index_context { get; set; }
    public DbSet<Res_SearchParameter_Index_target> Res_SearchParameter_Index_target { get; set; }
    public DbSet<Res_SearchParameter_Index__profile> Res_SearchParameter_Index__profile { get; set; }
    public DbSet<Res_SearchParameter_Index__security> Res_SearchParameter_Index__security { get; set; }
    public DbSet<Res_SearchParameter_Index__tag> Res_SearchParameter_Index__tag { get; set; }
    public DbSet<Res_Sequence> Res_Sequence { get; set; }
    public DbSet<Res_Sequence_History> Res_Sequence_History { get; set; }
    public DbSet<Res_Sequence_Index_chromosome> Res_Sequence_Index_chromosome { get; set; }
    public DbSet<Res_Sequence_Index_end> Res_Sequence_Index_end { get; set; }
    public DbSet<Res_Sequence_Index_start> Res_Sequence_Index_start { get; set; }
    public DbSet<Res_Sequence_Index__profile> Res_Sequence_Index__profile { get; set; }
    public DbSet<Res_Sequence_Index__security> Res_Sequence_Index__security { get; set; }
    public DbSet<Res_Sequence_Index__tag> Res_Sequence_Index__tag { get; set; }
    public DbSet<Res_Slot> Res_Slot { get; set; }
    public DbSet<Res_Slot_History> Res_Slot_History { get; set; }
    public DbSet<Res_Slot_Index_identifier> Res_Slot_Index_identifier { get; set; }
    public DbSet<Res_Slot_Index_slot_type> Res_Slot_Index_slot_type { get; set; }
    public DbSet<Res_Slot_Index__profile> Res_Slot_Index__profile { get; set; }
    public DbSet<Res_Slot_Index__security> Res_Slot_Index__security { get; set; }
    public DbSet<Res_Slot_Index__tag> Res_Slot_Index__tag { get; set; }
    public DbSet<Res_Specimen> Res_Specimen { get; set; }
    public DbSet<Res_Specimen_History> Res_Specimen_History { get; set; }
    public DbSet<Res_Specimen_Index_bodysite> Res_Specimen_Index_bodysite { get; set; }
    public DbSet<Res_Specimen_Index_container> Res_Specimen_Index_container { get; set; }
    public DbSet<Res_Specimen_Index_container_id> Res_Specimen_Index_container_id { get; set; }
    public DbSet<Res_Specimen_Index_identifier> Res_Specimen_Index_identifier { get; set; }
    public DbSet<Res_Specimen_Index_parent> Res_Specimen_Index_parent { get; set; }
    public DbSet<Res_Specimen_Index_type> Res_Specimen_Index_type { get; set; }
    public DbSet<Res_Specimen_Index__profile> Res_Specimen_Index__profile { get; set; }
    public DbSet<Res_Specimen_Index__security> Res_Specimen_Index__security { get; set; }
    public DbSet<Res_Specimen_Index__tag> Res_Specimen_Index__tag { get; set; }
    public DbSet<Res_StructureDefinition> Res_StructureDefinition { get; set; }
    public DbSet<Res_StructureDefinition_History> Res_StructureDefinition_History { get; set; }
    public DbSet<Res_StructureDefinition_Index_base_path> Res_StructureDefinition_Index_base_path { get; set; }
    public DbSet<Res_StructureDefinition_Index_code> Res_StructureDefinition_Index_code { get; set; }
    public DbSet<Res_StructureDefinition_Index_context> Res_StructureDefinition_Index_context { get; set; }
    public DbSet<Res_StructureDefinition_Index_ext_context> Res_StructureDefinition_Index_ext_context { get; set; }
    public DbSet<Res_StructureDefinition_Index_identifier> Res_StructureDefinition_Index_identifier { get; set; }
    public DbSet<Res_StructureDefinition_Index_path> Res_StructureDefinition_Index_path { get; set; }
    public DbSet<Res_StructureDefinition_Index_valueset> Res_StructureDefinition_Index_valueset { get; set; }
    public DbSet<Res_StructureDefinition_Index__profile> Res_StructureDefinition_Index__profile { get; set; }
    public DbSet<Res_StructureDefinition_Index__security> Res_StructureDefinition_Index__security { get; set; }
    public DbSet<Res_StructureDefinition_Index__tag> Res_StructureDefinition_Index__tag { get; set; }
    public DbSet<Res_StructureMap> Res_StructureMap { get; set; }
    public DbSet<Res_StructureMap_History> Res_StructureMap_History { get; set; }
    public DbSet<Res_StructureMap_Index_context> Res_StructureMap_Index_context { get; set; }
    public DbSet<Res_StructureMap_Index_identifier> Res_StructureMap_Index_identifier { get; set; }
    public DbSet<Res_StructureMap_Index__profile> Res_StructureMap_Index__profile { get; set; }
    public DbSet<Res_StructureMap_Index__security> Res_StructureMap_Index__security { get; set; }
    public DbSet<Res_StructureMap_Index__tag> Res_StructureMap_Index__tag { get; set; }
    public DbSet<Res_Subscription> Res_Subscription { get; set; }
    public DbSet<Res_Subscription_History> Res_Subscription_History { get; set; }
    public DbSet<Res_Subscription_Index_contact> Res_Subscription_Index_contact { get; set; }
    public DbSet<Res_Subscription_Index_tag> Res_Subscription_Index_tag { get; set; }
    public DbSet<Res_Subscription_Index__profile> Res_Subscription_Index__profile { get; set; }
    public DbSet<Res_Subscription_Index__security> Res_Subscription_Index__security { get; set; }
    public DbSet<Res_Subscription_Index__tag> Res_Subscription_Index__tag { get; set; }
    public DbSet<Res_Substance> Res_Substance { get; set; }
    public DbSet<Res_Substance_History> Res_Substance_History { get; set; }
    public DbSet<Res_Substance_Index_category> Res_Substance_Index_category { get; set; }
    public DbSet<Res_Substance_Index_code> Res_Substance_Index_code { get; set; }
    public DbSet<Res_Substance_Index_container_identifier> Res_Substance_Index_container_identifier { get; set; }
    public DbSet<Res_Substance_Index_expiry> Res_Substance_Index_expiry { get; set; }
    public DbSet<Res_Substance_Index_identifier> Res_Substance_Index_identifier { get; set; }
    public DbSet<Res_Substance_Index_quantity> Res_Substance_Index_quantity { get; set; }
    public DbSet<Res_Substance_Index_substance_reference> Res_Substance_Index_substance_reference { get; set; }
    public DbSet<Res_Substance_Index__profile> Res_Substance_Index__profile { get; set; }
    public DbSet<Res_Substance_Index__security> Res_Substance_Index__security { get; set; }
    public DbSet<Res_Substance_Index__tag> Res_Substance_Index__tag { get; set; }
    public DbSet<Res_SupplyDelivery> Res_SupplyDelivery { get; set; }
    public DbSet<Res_SupplyDelivery_History> Res_SupplyDelivery_History { get; set; }
    public DbSet<Res_SupplyDelivery_Index_receiver> Res_SupplyDelivery_Index_receiver { get; set; }
    public DbSet<Res_SupplyDelivery_Index__profile> Res_SupplyDelivery_Index__profile { get; set; }
    public DbSet<Res_SupplyDelivery_Index__security> Res_SupplyDelivery_Index__security { get; set; }
    public DbSet<Res_SupplyDelivery_Index__tag> Res_SupplyDelivery_Index__tag { get; set; }
    public DbSet<Res_SupplyRequest> Res_SupplyRequest { get; set; }
    public DbSet<Res_SupplyRequest_History> Res_SupplyRequest_History { get; set; }
    public DbSet<Res_SupplyRequest_Index_kind> Res_SupplyRequest_Index_kind { get; set; }
    public DbSet<Res_SupplyRequest_Index_supplier> Res_SupplyRequest_Index_supplier { get; set; }
    public DbSet<Res_SupplyRequest_Index__profile> Res_SupplyRequest_Index__profile { get; set; }
    public DbSet<Res_SupplyRequest_Index__security> Res_SupplyRequest_Index__security { get; set; }
    public DbSet<Res_SupplyRequest_Index__tag> Res_SupplyRequest_Index__tag { get; set; }
    public DbSet<Res_Task> Res_Task { get; set; }
    public DbSet<Res_Task_History> Res_Task_History { get; set; }
    public DbSet<Res_Task_Index_code> Res_Task_Index_code { get; set; }
    public DbSet<Res_Task_Index_parent> Res_Task_Index_parent { get; set; }
    public DbSet<Res_Task_Index_performer> Res_Task_Index_performer { get; set; }
    public DbSet<Res_Task_Index_stage> Res_Task_Index_stage { get; set; }
    public DbSet<Res_Task_Index_statusreason> Res_Task_Index_statusreason { get; set; }
    public DbSet<Res_Task_Index__profile> Res_Task_Index__profile { get; set; }
    public DbSet<Res_Task_Index__security> Res_Task_Index__security { get; set; }
    public DbSet<Res_Task_Index__tag> Res_Task_Index__tag { get; set; }
    public DbSet<Res_TestScript> Res_TestScript { get; set; }
    public DbSet<Res_TestScript_History> Res_TestScript_History { get; set; }
    public DbSet<Res_TestScript_Index_testscript_capability> Res_TestScript_Index_testscript_capability { get; set; }
    public DbSet<Res_TestScript_Index_use_context> Res_TestScript_Index_use_context { get; set; }
    public DbSet<Res_TestScript_Index__profile> Res_TestScript_Index__profile { get; set; }
    public DbSet<Res_TestScript_Index__security> Res_TestScript_Index__security { get; set; }
    public DbSet<Res_TestScript_Index__tag> Res_TestScript_Index__tag { get; set; }
    public DbSet<Res_ValueSet> Res_ValueSet { get; set; }
    public DbSet<Res_ValueSet_History> Res_ValueSet_History { get; set; }
    public DbSet<Res_ValueSet_Index_context> Res_ValueSet_Index_context { get; set; }
    public DbSet<Res_ValueSet_Index_identifier> Res_ValueSet_Index_identifier { get; set; }
    public DbSet<Res_ValueSet_Index_reference> Res_ValueSet_Index_reference { get; set; }
    public DbSet<Res_ValueSet_Index__profile> Res_ValueSet_Index__profile { get; set; }
    public DbSet<Res_ValueSet_Index__security> Res_ValueSet_Index__security { get; set; }
    public DbSet<Res_ValueSet_Index__tag> Res_ValueSet_Index__tag { get; set; }
    public DbSet<Res_VisionPrescription> Res_VisionPrescription { get; set; }
    public DbSet<Res_VisionPrescription_History> Res_VisionPrescription_History { get; set; }
    public DbSet<Res_VisionPrescription_Index_identifier> Res_VisionPrescription_Index_identifier { get; set; }
    public DbSet<Res_VisionPrescription_Index__profile> Res_VisionPrescription_Index__profile { get; set; }
    public DbSet<Res_VisionPrescription_Index__security> Res_VisionPrescription_Index__security { get; set; }
    public DbSet<Res_VisionPrescription_Index__tag> Res_VisionPrescription_Index__tag { get; set; }

    protected override void OnModelCreating(DbModelBuilder Mb)
    {
      base.OnModelCreating(Mb);
      Mb.Conventions.Remove<PluralizingTableNameConvention>();
      
      Mb.Configurations.Add(new ServiceRootURL_Store_Configuration());
      Mb.Configurations.Add(new Res_Account_Configuration());
      Mb.Configurations.Add(new Res_Account_History_Configuration());
      Mb.Configurations.Add(new Res_Account_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Account_Index_type_Configuration());
      Mb.Configurations.Add(new Res_Account_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Account_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Account_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ActivityDefinition_Configuration());
      Mb.Configurations.Add(new Res_ActivityDefinition_History_Configuration());
      Mb.Configurations.Add(new Res_ActivityDefinition_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_ActivityDefinition_Index_topic_Configuration());
      Mb.Configurations.Add(new Res_ActivityDefinition_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ActivityDefinition_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ActivityDefinition_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_History_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_Index_code_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_Index_manifestation_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_Index_onset_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_Index_route_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_Index_severity_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_Index__security_Configuration());
      Mb.Configurations.Add(new Res_AllergyIntolerance_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Configuration());
      Mb.Configurations.Add(new Res_Appointment_History_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index_actor_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index_appointment_type_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index_location_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index_part_status_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index_patient_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index_practitioner_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index_service_type_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Appointment_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_AppointmentResponse_Configuration());
      Mb.Configurations.Add(new Res_AppointmentResponse_History_Configuration());
      Mb.Configurations.Add(new Res_AppointmentResponse_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_AppointmentResponse_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_AppointmentResponse_Index__security_Configuration());
      Mb.Configurations.Add(new Res_AppointmentResponse_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_History_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_address_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_agent_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_agent_name_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_altid_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_entity_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_entity_id_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_entity_name_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_entity_type_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_patient_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_policy_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_role_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_subtype_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index_user_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index__security_Configuration());
      Mb.Configurations.Add(new Res_AuditEvent_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Basic_Configuration());
      Mb.Configurations.Add(new Res_Basic_History_Configuration());
      Mb.Configurations.Add(new Res_Basic_Index_code_Configuration());
      Mb.Configurations.Add(new Res_Basic_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Basic_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Basic_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Basic_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Binary_Configuration());
      Mb.Configurations.Add(new Res_Binary_History_Configuration());
      Mb.Configurations.Add(new Res_Binary_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Binary_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Binary_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_BodySite_Configuration());
      Mb.Configurations.Add(new Res_BodySite_History_Configuration());
      Mb.Configurations.Add(new Res_BodySite_Index_code_Configuration());
      Mb.Configurations.Add(new Res_BodySite_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_BodySite_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_BodySite_Index__security_Configuration());
      Mb.Configurations.Add(new Res_BodySite_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Bundle_Configuration());
      Mb.Configurations.Add(new Res_Bundle_History_Configuration());
      Mb.Configurations.Add(new Res_Bundle_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Bundle_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Bundle_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_History_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index_activitycode_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index_activitydate_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index_activityreference_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index_careteam_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index_category_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index_condition_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index_goal_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index_performer_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index_relatedcode_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index_relatedplan_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index__security_Configuration());
      Mb.Configurations.Add(new Res_CarePlan_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_CareTeam_Configuration());
      Mb.Configurations.Add(new Res_CareTeam_History_Configuration());
      Mb.Configurations.Add(new Res_CareTeam_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_CareTeam_Index_participant_Configuration());
      Mb.Configurations.Add(new Res_CareTeam_Index_status_Configuration());
      Mb.Configurations.Add(new Res_CareTeam_Index_type_Configuration());
      Mb.Configurations.Add(new Res_CareTeam_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_CareTeam_Index__security_Configuration());
      Mb.Configurations.Add(new Res_CareTeam_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Claim_Configuration());
      Mb.Configurations.Add(new Res_Claim_History_Configuration());
      Mb.Configurations.Add(new Res_Claim_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Claim_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Claim_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Claim_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ClaimResponse_Configuration());
      Mb.Configurations.Add(new Res_ClaimResponse_History_Configuration());
      Mb.Configurations.Add(new Res_ClaimResponse_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_ClaimResponse_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ClaimResponse_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ClaimResponse_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_History_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_Index_action_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_Index_finding_code_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_Index_finding_ref_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_Index_investigation_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_Index_plan_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_Index_problem_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ClinicalImpression_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_CodeSystem_Configuration());
      Mb.Configurations.Add(new Res_CodeSystem_History_Configuration());
      Mb.Configurations.Add(new Res_CodeSystem_Index_code_Configuration());
      Mb.Configurations.Add(new Res_CodeSystem_Index_context_Configuration());
      Mb.Configurations.Add(new Res_CodeSystem_Index_language_Configuration());
      Mb.Configurations.Add(new Res_CodeSystem_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_CodeSystem_Index__security_Configuration());
      Mb.Configurations.Add(new Res_CodeSystem_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Communication_Configuration());
      Mb.Configurations.Add(new Res_Communication_History_Configuration());
      Mb.Configurations.Add(new Res_Communication_Index_based_on_Configuration());
      Mb.Configurations.Add(new Res_Communication_Index_category_Configuration());
      Mb.Configurations.Add(new Res_Communication_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Communication_Index_medium_Configuration());
      Mb.Configurations.Add(new Res_Communication_Index_recipient_Configuration());
      Mb.Configurations.Add(new Res_Communication_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Communication_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Communication_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_CommunicationRequest_Configuration());
      Mb.Configurations.Add(new Res_CommunicationRequest_History_Configuration());
      Mb.Configurations.Add(new Res_CommunicationRequest_Index_category_Configuration());
      Mb.Configurations.Add(new Res_CommunicationRequest_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_CommunicationRequest_Index_medium_Configuration());
      Mb.Configurations.Add(new Res_CommunicationRequest_Index_priority_Configuration());
      Mb.Configurations.Add(new Res_CommunicationRequest_Index_recipient_Configuration());
      Mb.Configurations.Add(new Res_CommunicationRequest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_CommunicationRequest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_CommunicationRequest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_CompartmentDefinition_Configuration());
      Mb.Configurations.Add(new Res_CompartmentDefinition_History_Configuration());
      Mb.Configurations.Add(new Res_CompartmentDefinition_Index_resource_Configuration());
      Mb.Configurations.Add(new Res_CompartmentDefinition_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_CompartmentDefinition_Index__security_Configuration());
      Mb.Configurations.Add(new Res_CompartmentDefinition_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Composition_Configuration());
      Mb.Configurations.Add(new Res_Composition_History_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index_attester_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index_author_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index_class_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index_context_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index_entry_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index_period_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index_section_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index_type_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Composition_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_History_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Index_context_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Index_dependson_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Index_product_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Index_source_code_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Index_source_system_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Index_target_code_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Index_target_system_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ConceptMap_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Condition_Configuration());
      Mb.Configurations.Add(new Res_Condition_History_Configuration());
      Mb.Configurations.Add(new Res_Condition_Index_body_site_Configuration());
      Mb.Configurations.Add(new Res_Condition_Index_category_Configuration());
      Mb.Configurations.Add(new Res_Condition_Index_code_Configuration());
      Mb.Configurations.Add(new Res_Condition_Index_evidence_Configuration());
      Mb.Configurations.Add(new Res_Condition_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Condition_Index_severity_Configuration());
      Mb.Configurations.Add(new Res_Condition_Index_stage_Configuration());
      Mb.Configurations.Add(new Res_Condition_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Condition_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Condition_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Configuration());
      Mb.Configurations.Add(new Res_Conformance_History_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index_context_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index_event_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index_format_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index_mode_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index_resource_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index_resourceprofile_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index_securityservice_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index_supported_profile_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Conformance_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Consent_Configuration());
      Mb.Configurations.Add(new Res_Consent_History_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index_action_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index_actor_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index_category_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index_consentor_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index_data_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index_purpose_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index_recipient_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index_security_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Consent_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Contract_Configuration());
      Mb.Configurations.Add(new Res_Contract_History_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index_agent_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index_authority_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index_domain_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index_patient_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index_signer_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index_subject_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index_topic_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index_ttopic_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Contract_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Coverage_Configuration());
      Mb.Configurations.Add(new Res_Coverage_History_Configuration());
      Mb.Configurations.Add(new Res_Coverage_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Coverage_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Coverage_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Coverage_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DataElement_Configuration());
      Mb.Configurations.Add(new Res_DataElement_History_Configuration());
      Mb.Configurations.Add(new Res_DataElement_Index_code_Configuration());
      Mb.Configurations.Add(new Res_DataElement_Index_context_Configuration());
      Mb.Configurations.Add(new Res_DataElement_Index_description_Configuration());
      Mb.Configurations.Add(new Res_DataElement_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_DataElement_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DataElement_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DataElement_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DecisionSupportServiceModule_Configuration());
      Mb.Configurations.Add(new Res_DecisionSupportServiceModule_History_Configuration());
      Mb.Configurations.Add(new Res_DecisionSupportServiceModule_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_DecisionSupportServiceModule_Index_topic_Configuration());
      Mb.Configurations.Add(new Res_DecisionSupportServiceModule_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DecisionSupportServiceModule_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DecisionSupportServiceModule_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DetectedIssue_Configuration());
      Mb.Configurations.Add(new Res_DetectedIssue_History_Configuration());
      Mb.Configurations.Add(new Res_DetectedIssue_Index_category_Configuration());
      Mb.Configurations.Add(new Res_DetectedIssue_Index_implicated_Configuration());
      Mb.Configurations.Add(new Res_DetectedIssue_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DetectedIssue_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DetectedIssue_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Device_Configuration());
      Mb.Configurations.Add(new Res_Device_History_Configuration());
      Mb.Configurations.Add(new Res_Device_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Device_Index_type_Configuration());
      Mb.Configurations.Add(new Res_Device_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Device_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Device_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DeviceComponent_Configuration());
      Mb.Configurations.Add(new Res_DeviceComponent_History_Configuration());
      Mb.Configurations.Add(new Res_DeviceComponent_Index_type_Configuration());
      Mb.Configurations.Add(new Res_DeviceComponent_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DeviceComponent_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DeviceComponent_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DeviceMetric_Configuration());
      Mb.Configurations.Add(new Res_DeviceMetric_History_Configuration());
      Mb.Configurations.Add(new Res_DeviceMetric_Index_type_Configuration());
      Mb.Configurations.Add(new Res_DeviceMetric_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DeviceMetric_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DeviceMetric_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_History_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_Index_based_on_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_Index_code_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_Index_definition_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_Index_replaces_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_Index_stage_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseRequest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseStatement_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseStatement_History_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseStatement_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseStatement_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DeviceUseStatement_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_History_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index_category_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index_code_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index_diagnosis_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index_image_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index_performer_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index_request_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index_result_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index_specimen_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticReport_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_History_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_Index_based_on_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_Index_code_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_Index_definition_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_Index_replaces_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_Index_stage_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DiagnosticRequest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_History_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Index_author_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Index_content_ref_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Index_recipient_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Index_related_id_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Index_related_ref_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Index_type_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DocumentManifest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_History_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_author_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_class_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_event_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_facility_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_format_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_language_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_location_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_related_id_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_related_ref_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_relatesto_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_relation_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_securitylabel_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_setting_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index_type_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index__security_Configuration());
      Mb.Configurations.Add(new Res_DocumentReference_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_EligibilityRequest_Configuration());
      Mb.Configurations.Add(new Res_EligibilityRequest_History_Configuration());
      Mb.Configurations.Add(new Res_EligibilityRequest_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_EligibilityRequest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_EligibilityRequest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_EligibilityRequest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_EligibilityResponse_Configuration());
      Mb.Configurations.Add(new Res_EligibilityResponse_History_Configuration());
      Mb.Configurations.Add(new Res_EligibilityResponse_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_EligibilityResponse_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_EligibilityResponse_Index__security_Configuration());
      Mb.Configurations.Add(new Res_EligibilityResponse_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Configuration());
      Mb.Configurations.Add(new Res_Encounter_History_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_condition_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_episodeofcare_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_incomingreferral_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_indication_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_location_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_location_period_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_participant_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_participant_type_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_practitioner_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_procedure_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_reason_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_special_arrangement_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index_type_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Encounter_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Endpoint_Configuration());
      Mb.Configurations.Add(new Res_Endpoint_History_Configuration());
      Mb.Configurations.Add(new Res_Endpoint_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Endpoint_Index_payload_type_Configuration());
      Mb.Configurations.Add(new Res_Endpoint_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Endpoint_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Endpoint_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentRequest_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentRequest_History_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentRequest_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentRequest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentRequest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentRequest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentResponse_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentResponse_History_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentResponse_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentResponse_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentResponse_Index__security_Configuration());
      Mb.Configurations.Add(new Res_EnrollmentResponse_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_EpisodeOfCare_Configuration());
      Mb.Configurations.Add(new Res_EpisodeOfCare_History_Configuration());
      Mb.Configurations.Add(new Res_EpisodeOfCare_Index_condition_Configuration());
      Mb.Configurations.Add(new Res_EpisodeOfCare_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_EpisodeOfCare_Index_incomingreferral_Configuration());
      Mb.Configurations.Add(new Res_EpisodeOfCare_Index_type_Configuration());
      Mb.Configurations.Add(new Res_EpisodeOfCare_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_EpisodeOfCare_Index__security_Configuration());
      Mb.Configurations.Add(new Res_EpisodeOfCare_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ExpansionProfile_Configuration());
      Mb.Configurations.Add(new Res_ExpansionProfile_History_Configuration());
      Mb.Configurations.Add(new Res_ExpansionProfile_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ExpansionProfile_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ExpansionProfile_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ExplanationOfBenefit_Configuration());
      Mb.Configurations.Add(new Res_ExplanationOfBenefit_History_Configuration());
      Mb.Configurations.Add(new Res_ExplanationOfBenefit_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_ExplanationOfBenefit_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ExplanationOfBenefit_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ExplanationOfBenefit_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_FamilyMemberHistory_Configuration());
      Mb.Configurations.Add(new Res_FamilyMemberHistory_History_Configuration());
      Mb.Configurations.Add(new Res_FamilyMemberHistory_Index_code_Configuration());
      Mb.Configurations.Add(new Res_FamilyMemberHistory_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_FamilyMemberHistory_Index_relationship_Configuration());
      Mb.Configurations.Add(new Res_FamilyMemberHistory_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_FamilyMemberHistory_Index__security_Configuration());
      Mb.Configurations.Add(new Res_FamilyMemberHistory_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Flag_Configuration());
      Mb.Configurations.Add(new Res_Flag_History_Configuration());
      Mb.Configurations.Add(new Res_Flag_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Flag_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Flag_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Goal_Configuration());
      Mb.Configurations.Add(new Res_Goal_History_Configuration());
      Mb.Configurations.Add(new Res_Goal_Index_category_Configuration());
      Mb.Configurations.Add(new Res_Goal_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Goal_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Goal_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Goal_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Group_Configuration());
      Mb.Configurations.Add(new Res_Group_History_Configuration());
      Mb.Configurations.Add(new Res_Group_Index_characteristic_Configuration());
      Mb.Configurations.Add(new Res_Group_Index_code_Configuration());
      Mb.Configurations.Add(new Res_Group_Index_exclude_Configuration());
      Mb.Configurations.Add(new Res_Group_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Group_Index_member_Configuration());
      Mb.Configurations.Add(new Res_Group_Index_value_Configuration());
      Mb.Configurations.Add(new Res_Group_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Group_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Group_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_GuidanceResponse_Configuration());
      Mb.Configurations.Add(new Res_GuidanceResponse_History_Configuration());
      Mb.Configurations.Add(new Res_GuidanceResponse_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_GuidanceResponse_Index__security_Configuration());
      Mb.Configurations.Add(new Res_GuidanceResponse_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_History_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_Index_characteristic_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_Index_location_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_Index_programname_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_Index_servicecategory_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_Index_servicetype_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_Index__security_Configuration());
      Mb.Configurations.Add(new Res_HealthcareService_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ImagingManifest_Configuration());
      Mb.Configurations.Add(new Res_ImagingManifest_History_Configuration());
      Mb.Configurations.Add(new Res_ImagingManifest_Index_selected_study_Configuration());
      Mb.Configurations.Add(new Res_ImagingManifest_Index_title_Configuration());
      Mb.Configurations.Add(new Res_ImagingManifest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ImagingManifest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ImagingManifest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_History_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index_basedon_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index_bodysite_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index_dicom_class_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index_modality_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index_reason_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index_series_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index_uid_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ImagingStudy_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Configuration());
      Mb.Configurations.Add(new Res_Immunization_History_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Index_dose_sequence_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Index_reaction_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Index_reaction_date_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Index_reason_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Index_reason_not_given_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Index_vaccine_code_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Immunization_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_History_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index_date_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index_dose_number_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index_dose_sequence_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index_information_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index_status_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index_support_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index_vaccine_type_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ImmunizationRecommendation_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ImplementationGuide_Configuration());
      Mb.Configurations.Add(new Res_ImplementationGuide_History_Configuration());
      Mb.Configurations.Add(new Res_ImplementationGuide_Index_context_Configuration());
      Mb.Configurations.Add(new Res_ImplementationGuide_Index_dependency_Configuration());
      Mb.Configurations.Add(new Res_ImplementationGuide_Index_resource_Configuration());
      Mb.Configurations.Add(new Res_ImplementationGuide_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ImplementationGuide_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ImplementationGuide_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Library_Configuration());
      Mb.Configurations.Add(new Res_Library_History_Configuration());
      Mb.Configurations.Add(new Res_Library_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Library_Index_topic_Configuration());
      Mb.Configurations.Add(new Res_Library_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Library_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Library_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Linkage_Configuration());
      Mb.Configurations.Add(new Res_Linkage_History_Configuration());
      Mb.Configurations.Add(new Res_Linkage_Index_item_Configuration());
      Mb.Configurations.Add(new Res_Linkage_Index_source_Configuration());
      Mb.Configurations.Add(new Res_Linkage_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Linkage_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Linkage_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_List_Configuration());
      Mb.Configurations.Add(new Res_List_History_Configuration());
      Mb.Configurations.Add(new Res_List_Index_code_Configuration());
      Mb.Configurations.Add(new Res_List_Index_empty_reason_Configuration());
      Mb.Configurations.Add(new Res_List_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_List_Index_item_Configuration());
      Mb.Configurations.Add(new Res_List_Index_notes_Configuration());
      Mb.Configurations.Add(new Res_List_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_List_Index__security_Configuration());
      Mb.Configurations.Add(new Res_List_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Location_Configuration());
      Mb.Configurations.Add(new Res_Location_History_Configuration());
      Mb.Configurations.Add(new Res_Location_Index_address_Configuration());
      Mb.Configurations.Add(new Res_Location_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Location_Index_name_Configuration());
      Mb.Configurations.Add(new Res_Location_Index_type_Configuration());
      Mb.Configurations.Add(new Res_Location_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Location_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Location_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Measure_Configuration());
      Mb.Configurations.Add(new Res_Measure_History_Configuration());
      Mb.Configurations.Add(new Res_Measure_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Measure_Index_topic_Configuration());
      Mb.Configurations.Add(new Res_Measure_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Measure_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Measure_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_MeasureReport_Configuration());
      Mb.Configurations.Add(new Res_MeasureReport_History_Configuration());
      Mb.Configurations.Add(new Res_MeasureReport_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_MeasureReport_Index__security_Configuration());
      Mb.Configurations.Add(new Res_MeasureReport_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Media_Configuration());
      Mb.Configurations.Add(new Res_Media_History_Configuration());
      Mb.Configurations.Add(new Res_Media_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Media_Index_subtype_Configuration());
      Mb.Configurations.Add(new Res_Media_Index_view_Configuration());
      Mb.Configurations.Add(new Res_Media_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Media_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Media_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Medication_Configuration());
      Mb.Configurations.Add(new Res_Medication_History_Configuration());
      Mb.Configurations.Add(new Res_Medication_Index_code_Configuration());
      Mb.Configurations.Add(new Res_Medication_Index_container_Configuration());
      Mb.Configurations.Add(new Res_Medication_Index_form_Configuration());
      Mb.Configurations.Add(new Res_Medication_Index_ingredient_Configuration());
      Mb.Configurations.Add(new Res_Medication_Index_ingredient_code_Configuration());
      Mb.Configurations.Add(new Res_Medication_Index_package_item_Configuration());
      Mb.Configurations.Add(new Res_Medication_Index_package_item_code_Configuration());
      Mb.Configurations.Add(new Res_Medication_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Medication_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Medication_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_MedicationAdministration_Configuration());
      Mb.Configurations.Add(new Res_MedicationAdministration_History_Configuration());
      Mb.Configurations.Add(new Res_MedicationAdministration_Index_code_Configuration());
      Mb.Configurations.Add(new Res_MedicationAdministration_Index_device_Configuration());
      Mb.Configurations.Add(new Res_MedicationAdministration_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_MedicationAdministration_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_MedicationAdministration_Index__security_Configuration());
      Mb.Configurations.Add(new Res_MedicationAdministration_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_MedicationDispense_Configuration());
      Mb.Configurations.Add(new Res_MedicationDispense_History_Configuration());
      Mb.Configurations.Add(new Res_MedicationDispense_Index_code_Configuration());
      Mb.Configurations.Add(new Res_MedicationDispense_Index_prescription_Configuration());
      Mb.Configurations.Add(new Res_MedicationDispense_Index_receiver_Configuration());
      Mb.Configurations.Add(new Res_MedicationDispense_Index_responsibleparty_Configuration());
      Mb.Configurations.Add(new Res_MedicationDispense_Index_type_Configuration());
      Mb.Configurations.Add(new Res_MedicationDispense_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_MedicationDispense_Index__security_Configuration());
      Mb.Configurations.Add(new Res_MedicationDispense_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_MedicationOrder_Configuration());
      Mb.Configurations.Add(new Res_MedicationOrder_History_Configuration());
      Mb.Configurations.Add(new Res_MedicationOrder_Index_code_Configuration());
      Mb.Configurations.Add(new Res_MedicationOrder_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_MedicationOrder_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_MedicationOrder_Index__security_Configuration());
      Mb.Configurations.Add(new Res_MedicationOrder_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_MedicationStatement_Configuration());
      Mb.Configurations.Add(new Res_MedicationStatement_History_Configuration());
      Mb.Configurations.Add(new Res_MedicationStatement_Index_code_Configuration());
      Mb.Configurations.Add(new Res_MedicationStatement_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_MedicationStatement_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_MedicationStatement_Index__security_Configuration());
      Mb.Configurations.Add(new Res_MedicationStatement_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_MessageHeader_Configuration());
      Mb.Configurations.Add(new Res_MessageHeader_History_Configuration());
      Mb.Configurations.Add(new Res_MessageHeader_Index_data_Configuration());
      Mb.Configurations.Add(new Res_MessageHeader_Index_destination_Configuration());
      Mb.Configurations.Add(new Res_MessageHeader_Index_destination_uri_Configuration());
      Mb.Configurations.Add(new Res_MessageHeader_Index_target_Configuration());
      Mb.Configurations.Add(new Res_MessageHeader_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_MessageHeader_Index__security_Configuration());
      Mb.Configurations.Add(new Res_MessageHeader_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_History_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Index_contact_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Index_context_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Index_id_type_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Index_period_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Index_telecom_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Index_type_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Index_value_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Index__security_Configuration());
      Mb.Configurations.Add(new Res_NamingSystem_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_NutritionRequest_Configuration());
      Mb.Configurations.Add(new Res_NutritionRequest_History_Configuration());
      Mb.Configurations.Add(new Res_NutritionRequest_Index_additive_Configuration());
      Mb.Configurations.Add(new Res_NutritionRequest_Index_formula_Configuration());
      Mb.Configurations.Add(new Res_NutritionRequest_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_NutritionRequest_Index_oraldiet_Configuration());
      Mb.Configurations.Add(new Res_NutritionRequest_Index_supplement_Configuration());
      Mb.Configurations.Add(new Res_NutritionRequest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_NutritionRequest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_NutritionRequest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Observation_Configuration());
      Mb.Configurations.Add(new Res_Observation_History_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_category_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_code_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_data_absent_reason_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_method_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_performer_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_related_target_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_related_type_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_value_concept_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_value_quantity_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index_value_string_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Observation_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_OperationDefinition_Configuration());
      Mb.Configurations.Add(new Res_OperationDefinition_History_Configuration());
      Mb.Configurations.Add(new Res_OperationDefinition_Index_context_Configuration());
      Mb.Configurations.Add(new Res_OperationDefinition_Index_paramprofile_Configuration());
      Mb.Configurations.Add(new Res_OperationDefinition_Index_type_Configuration());
      Mb.Configurations.Add(new Res_OperationDefinition_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_OperationDefinition_Index__security_Configuration());
      Mb.Configurations.Add(new Res_OperationDefinition_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_OperationOutcome_Configuration());
      Mb.Configurations.Add(new Res_OperationOutcome_History_Configuration());
      Mb.Configurations.Add(new Res_OperationOutcome_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_OperationOutcome_Index__security_Configuration());
      Mb.Configurations.Add(new Res_OperationOutcome_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Organization_Configuration());
      Mb.Configurations.Add(new Res_Organization_History_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index_address_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index_address_city_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index_address_country_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index_address_postalcode_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index_address_state_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index_address_use_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index_name_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index_type_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Organization_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Parameters_Configuration());
      Mb.Configurations.Add(new Res_Parameters_History_Configuration());
      Mb.Configurations.Add(new Res_Parameters_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Parameters_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Parameters_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Patient_Configuration());
      Mb.Configurations.Add(new Res_Patient_History_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_address_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_address_city_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_address_country_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_address_postalcode_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_address_state_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_address_use_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_animal_breed_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_animal_species_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_email_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_family_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_general_practitioner_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_given_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_language_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_link_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_name_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_phone_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_phonetic_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index_telecom_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Patient_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_PaymentNotice_Configuration());
      Mb.Configurations.Add(new Res_PaymentNotice_History_Configuration());
      Mb.Configurations.Add(new Res_PaymentNotice_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_PaymentNotice_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_PaymentNotice_Index__security_Configuration());
      Mb.Configurations.Add(new Res_PaymentNotice_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_PaymentReconciliation_Configuration());
      Mb.Configurations.Add(new Res_PaymentReconciliation_History_Configuration());
      Mb.Configurations.Add(new Res_PaymentReconciliation_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_PaymentReconciliation_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_PaymentReconciliation_Index__security_Configuration());
      Mb.Configurations.Add(new Res_PaymentReconciliation_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Person_Configuration());
      Mb.Configurations.Add(new Res_Person_History_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_address_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_address_city_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_address_country_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_address_postalcode_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_address_state_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_address_use_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_email_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_link_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_name_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_patient_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_phone_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_phonetic_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_practitioner_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_relatedperson_Configuration());
      Mb.Configurations.Add(new Res_Person_Index_telecom_Configuration());
      Mb.Configurations.Add(new Res_Person_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Person_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Person_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_PlanDefinition_Configuration());
      Mb.Configurations.Add(new Res_PlanDefinition_History_Configuration());
      Mb.Configurations.Add(new Res_PlanDefinition_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_PlanDefinition_Index_topic_Configuration());
      Mb.Configurations.Add(new Res_PlanDefinition_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_PlanDefinition_Index__security_Configuration());
      Mb.Configurations.Add(new Res_PlanDefinition_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_History_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_address_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_address_city_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_address_country_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_address_postalcode_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_address_state_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_address_use_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_communication_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_email_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_family_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_given_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_location_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_name_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_organization_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_phone_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_phonetic_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_role_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_specialty_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index_telecom_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Practitioner_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_History_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Index_email_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Index_location_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Index_phone_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Index_role_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Index_specialty_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Index_telecom_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Index__security_Configuration());
      Mb.Configurations.Add(new Res_PractitionerRole_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Procedure_Configuration());
      Mb.Configurations.Add(new Res_Procedure_History_Configuration());
      Mb.Configurations.Add(new Res_Procedure_Index_category_Configuration());
      Mb.Configurations.Add(new Res_Procedure_Index_code_Configuration());
      Mb.Configurations.Add(new Res_Procedure_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Procedure_Index_performer_Configuration());
      Mb.Configurations.Add(new Res_Procedure_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Procedure_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Procedure_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ProcedureRequest_Configuration());
      Mb.Configurations.Add(new Res_ProcedureRequest_History_Configuration());
      Mb.Configurations.Add(new Res_ProcedureRequest_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_ProcedureRequest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ProcedureRequest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ProcedureRequest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ProcessRequest_Configuration());
      Mb.Configurations.Add(new Res_ProcessRequest_History_Configuration());
      Mb.Configurations.Add(new Res_ProcessRequest_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_ProcessRequest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ProcessRequest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ProcessRequest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ProcessResponse_Configuration());
      Mb.Configurations.Add(new Res_ProcessResponse_History_Configuration());
      Mb.Configurations.Add(new Res_ProcessResponse_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_ProcessResponse_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ProcessResponse_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ProcessResponse_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Configuration());
      Mb.Configurations.Add(new Res_Provenance_History_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Index_agent_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Index_entity_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Index_entity_type_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Index_patient_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Index_sig_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Index_target_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Index_userid_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Provenance_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Questionnaire_Configuration());
      Mb.Configurations.Add(new Res_Questionnaire_History_Configuration());
      Mb.Configurations.Add(new Res_Questionnaire_Index_code_Configuration());
      Mb.Configurations.Add(new Res_Questionnaire_Index_context_Configuration());
      Mb.Configurations.Add(new Res_Questionnaire_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Questionnaire_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Questionnaire_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Questionnaire_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_QuestionnaireResponse_Configuration());
      Mb.Configurations.Add(new Res_QuestionnaireResponse_History_Configuration());
      Mb.Configurations.Add(new Res_QuestionnaireResponse_Index_based_on_Configuration());
      Mb.Configurations.Add(new Res_QuestionnaireResponse_Index_parent_Configuration());
      Mb.Configurations.Add(new Res_QuestionnaireResponse_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_QuestionnaireResponse_Index__security_Configuration());
      Mb.Configurations.Add(new Res_QuestionnaireResponse_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ReferralRequest_Configuration());
      Mb.Configurations.Add(new Res_ReferralRequest_History_Configuration());
      Mb.Configurations.Add(new Res_ReferralRequest_Index_basedon_Configuration());
      Mb.Configurations.Add(new Res_ReferralRequest_Index_priority_Configuration());
      Mb.Configurations.Add(new Res_ReferralRequest_Index_recipient_Configuration());
      Mb.Configurations.Add(new Res_ReferralRequest_Index_specialty_Configuration());
      Mb.Configurations.Add(new Res_ReferralRequest_Index_type_Configuration());
      Mb.Configurations.Add(new Res_ReferralRequest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ReferralRequest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ReferralRequest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_History_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_address_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_address_city_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_address_country_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_address_postalcode_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_address_state_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_address_use_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_email_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_name_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_phone_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_phonetic_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index_telecom_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index__security_Configuration());
      Mb.Configurations.Add(new Res_RelatedPerson_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_RiskAssessment_Configuration());
      Mb.Configurations.Add(new Res_RiskAssessment_History_Configuration());
      Mb.Configurations.Add(new Res_RiskAssessment_Index_method_Configuration());
      Mb.Configurations.Add(new Res_RiskAssessment_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_RiskAssessment_Index__security_Configuration());
      Mb.Configurations.Add(new Res_RiskAssessment_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Schedule_Configuration());
      Mb.Configurations.Add(new Res_Schedule_History_Configuration());
      Mb.Configurations.Add(new Res_Schedule_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Schedule_Index_type_Configuration());
      Mb.Configurations.Add(new Res_Schedule_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Schedule_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Schedule_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_SearchParameter_Configuration());
      Mb.Configurations.Add(new Res_SearchParameter_History_Configuration());
      Mb.Configurations.Add(new Res_SearchParameter_Index_component_Configuration());
      Mb.Configurations.Add(new Res_SearchParameter_Index_context_Configuration());
      Mb.Configurations.Add(new Res_SearchParameter_Index_target_Configuration());
      Mb.Configurations.Add(new Res_SearchParameter_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_SearchParameter_Index__security_Configuration());
      Mb.Configurations.Add(new Res_SearchParameter_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Sequence_Configuration());
      Mb.Configurations.Add(new Res_Sequence_History_Configuration());
      Mb.Configurations.Add(new Res_Sequence_Index_chromosome_Configuration());
      Mb.Configurations.Add(new Res_Sequence_Index_end_Configuration());
      Mb.Configurations.Add(new Res_Sequence_Index_start_Configuration());
      Mb.Configurations.Add(new Res_Sequence_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Sequence_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Sequence_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Slot_Configuration());
      Mb.Configurations.Add(new Res_Slot_History_Configuration());
      Mb.Configurations.Add(new Res_Slot_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Slot_Index_slot_type_Configuration());
      Mb.Configurations.Add(new Res_Slot_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Slot_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Slot_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Specimen_Configuration());
      Mb.Configurations.Add(new Res_Specimen_History_Configuration());
      Mb.Configurations.Add(new Res_Specimen_Index_bodysite_Configuration());
      Mb.Configurations.Add(new Res_Specimen_Index_container_Configuration());
      Mb.Configurations.Add(new Res_Specimen_Index_container_id_Configuration());
      Mb.Configurations.Add(new Res_Specimen_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Specimen_Index_parent_Configuration());
      Mb.Configurations.Add(new Res_Specimen_Index_type_Configuration());
      Mb.Configurations.Add(new Res_Specimen_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Specimen_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Specimen_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_History_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Index_base_path_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Index_code_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Index_context_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Index_ext_context_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Index_path_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Index_valueset_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Index__security_Configuration());
      Mb.Configurations.Add(new Res_StructureDefinition_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_StructureMap_Configuration());
      Mb.Configurations.Add(new Res_StructureMap_History_Configuration());
      Mb.Configurations.Add(new Res_StructureMap_Index_context_Configuration());
      Mb.Configurations.Add(new Res_StructureMap_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_StructureMap_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_StructureMap_Index__security_Configuration());
      Mb.Configurations.Add(new Res_StructureMap_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Subscription_Configuration());
      Mb.Configurations.Add(new Res_Subscription_History_Configuration());
      Mb.Configurations.Add(new Res_Subscription_Index_contact_Configuration());
      Mb.Configurations.Add(new Res_Subscription_Index_tag_Configuration());
      Mb.Configurations.Add(new Res_Subscription_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Subscription_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Subscription_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Substance_Configuration());
      Mb.Configurations.Add(new Res_Substance_History_Configuration());
      Mb.Configurations.Add(new Res_Substance_Index_category_Configuration());
      Mb.Configurations.Add(new Res_Substance_Index_code_Configuration());
      Mb.Configurations.Add(new Res_Substance_Index_container_identifier_Configuration());
      Mb.Configurations.Add(new Res_Substance_Index_expiry_Configuration());
      Mb.Configurations.Add(new Res_Substance_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_Substance_Index_quantity_Configuration());
      Mb.Configurations.Add(new Res_Substance_Index_substance_reference_Configuration());
      Mb.Configurations.Add(new Res_Substance_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Substance_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Substance_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_SupplyDelivery_Configuration());
      Mb.Configurations.Add(new Res_SupplyDelivery_History_Configuration());
      Mb.Configurations.Add(new Res_SupplyDelivery_Index_receiver_Configuration());
      Mb.Configurations.Add(new Res_SupplyDelivery_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_SupplyDelivery_Index__security_Configuration());
      Mb.Configurations.Add(new Res_SupplyDelivery_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_SupplyRequest_Configuration());
      Mb.Configurations.Add(new Res_SupplyRequest_History_Configuration());
      Mb.Configurations.Add(new Res_SupplyRequest_Index_kind_Configuration());
      Mb.Configurations.Add(new Res_SupplyRequest_Index_supplier_Configuration());
      Mb.Configurations.Add(new Res_SupplyRequest_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_SupplyRequest_Index__security_Configuration());
      Mb.Configurations.Add(new Res_SupplyRequest_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_Task_Configuration());
      Mb.Configurations.Add(new Res_Task_History_Configuration());
      Mb.Configurations.Add(new Res_Task_Index_code_Configuration());
      Mb.Configurations.Add(new Res_Task_Index_parent_Configuration());
      Mb.Configurations.Add(new Res_Task_Index_performer_Configuration());
      Mb.Configurations.Add(new Res_Task_Index_stage_Configuration());
      Mb.Configurations.Add(new Res_Task_Index_statusreason_Configuration());
      Mb.Configurations.Add(new Res_Task_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_Task_Index__security_Configuration());
      Mb.Configurations.Add(new Res_Task_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_TestScript_Configuration());
      Mb.Configurations.Add(new Res_TestScript_History_Configuration());
      Mb.Configurations.Add(new Res_TestScript_Index_testscript_capability_Configuration());
      Mb.Configurations.Add(new Res_TestScript_Index_use_context_Configuration());
      Mb.Configurations.Add(new Res_TestScript_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_TestScript_Index__security_Configuration());
      Mb.Configurations.Add(new Res_TestScript_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_ValueSet_Configuration());
      Mb.Configurations.Add(new Res_ValueSet_History_Configuration());
      Mb.Configurations.Add(new Res_ValueSet_Index_context_Configuration());
      Mb.Configurations.Add(new Res_ValueSet_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_ValueSet_Index_reference_Configuration());
      Mb.Configurations.Add(new Res_ValueSet_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_ValueSet_Index__security_Configuration());
      Mb.Configurations.Add(new Res_ValueSet_Index__tag_Configuration());
      Mb.Configurations.Add(new Res_VisionPrescription_Configuration());
      Mb.Configurations.Add(new Res_VisionPrescription_History_Configuration());
      Mb.Configurations.Add(new Res_VisionPrescription_Index_identifier_Configuration());
      Mb.Configurations.Add(new Res_VisionPrescription_Index__profile_Configuration());
      Mb.Configurations.Add(new Res_VisionPrescription_Index__security_Configuration());
      Mb.Configurations.Add(new Res_VisionPrescription_Index__tag_Configuration());
    }
  }
}
