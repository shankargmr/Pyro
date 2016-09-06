﻿using System.Collections.Generic;

//This file has been code generated by Blaze.CodeGenerationSupport.SearchParameterInfoCodeGeneration.SearchParameterEnumGeneration.tt

namespace Blaze.Common.Enum
{
  public static partial class FhirSearchEnum
  {
    public enum SearchParameterNameType
    {
      identifier,
      type,
      profile,
      security,
      tag,
      balance,
      name,
      owner,
      patient,
      period,
      status,
      subject,
      _id,
      page,
      _sort,
      manifestation,
      onset,
      route,
      severity,
      substance,
      category,
      criticality,
      date,
      last_date,
      recorder,
      reporter,
      actor,
      appointment_type,
      location,
      part_status,
      practitioner,
      service_type,
      appointment,
      address,
      agent,
      agent_name,
      altid,
      entity,
      entity_id,
      entity_name,
      entity_type,
      policy,
      subtype,
      user,
      action,
      site,
      source,
      code,
      author,
      created,
      contenttype,
      composition,
      message,
      activitycode,
      activitydate,
      activityreference,
      condition,
      goal,
      participant,
      performer,
      relatedcode,
      relatedplan,
      facilityidentifier,
      facilityreference,
      organizationidentifier,
      organizationreference,
      patientidentifier,
      patientreference,
      priority,
      provideridentifier,
      providerreference,
      targetidentifier,
      targetreference,
      use,
      disposition,
      outcome,
      paymentdate,
      requestidentifier,
      requestreference,
      finding,
      investigation,
      plan,
      problem,
      resolved,
      ruledout,
      trigger_code,
      assessor,
      previous,
      trigger,
      context,
      language,
      description,
      publisher,
      system,
      url,
      version,
      medium,
      recipient,
      encounter,
      received,
      request,
      sender,
      sent,
      requested,
      requester,
      time,
      resource,
      attester,
      _class,
      entry,
      section,
      confidentiality,
      title,
      dependson,
      product,
      source_code,
      source_system,
      target_code,
      target_system,
      source_uri,
      target,
      body_site,
      evidence,
      stage,
      asserter,
      clinicalstatus,
      date_recorded,
      _event,
      format,
      mode,
      resourceprofile,
      securityservice,
      supported_profile,
      fhirversion,
      software,
      authority,
      domain,
      signer,
      topic,
      ttopic,
      issued,
      beneficiaryidentifier,
      beneficiaryreference,
      dependent,
      group,
      issueridentifier,
      issuerreference,
      planholderidentifier,
      planholderreference,
      sequence,
      subplan,
      stringency,
      implicated,
      manufacturer,
      model,
      organization,
      udicarrier,
      parent,
      device,
      bodysite,
      event_date,
      event_status,
      item_date,
      item_past_status,
      item_status,
      specimen,
      orderer,
      diagnosis,
      image,
      result,
      content_ref,
      related_id,
      related_ref,
      facility,
      relatesto,
      relation,
      securitylabel,
      setting,
      authenticator,
      custodian,
      indexed,
      requestorganizationidentifier,
      requestorganizationreference,
      requestprovideridentifier,
      requestproviderreference,
      episodeofcare,
      incomingreferral,
      indication,
      location_period,
      participant_type,
      procedure,
      reason,
      special_arrangement,
      length,
      part_of,
      care_manager,
      claimindentifier,
      claimreference,
      relationship,
      gender,
      targetdate,
      characteristic,
      exclude,
      member,
      value,
      actual,
      programname,
      servicecategory,
      servicetype,
      selected_study,
      authoring_time,
      dicom_class,
      modality,
      order,
      series,
      uid,
      accession,
      started,
      study,
      dose_sequence,
      reaction,
      reaction_date,
      reason_not_given,
      vaccine_code,
      lot_number,
      notgiven,
      dose_number,
      information,
      support,
      vaccine_type,
      dependency,
      experimental,
      item,
      empty_reason,
      notes,
      address_city,
      address_country,
      address_postalcode,
      address_state,
      address_use,
      near,
      near_distance,
      partof,
      view,
      _operator,
      container,
      form,
      ingredient,
      ingredient_code,
      package_item,
      package_item_code,
      effectivetime,
      medication,
      prescription,
      wasnotgiven,
      receiver,
      responsibleparty,
      destination,
      dispenser,
      whenhandedover,
      whenprepared,
      datewritten,
      prescriber,
      effective,
      data,
      destination_uri,
      enterer,
      response_id,
      responsible,
      timestamp,
      contact,
      id_type,
      telecom,
      kind,
      replaced_by,
      additive,
      formula,
      oraldiet,
      supplement,
      datetime,
      provider,
      component_code,
      component_data_absent_reason,
      component_value_concept,
      component_value_quantity,
      component_value_string,
      data_absent_reason,
      related_target,
      related_type,
      value_concept,
      value_date,
      value_quantity,
      value_string,
      paramprofile,
      _base,
      instance,
      detail,
      when,
      when_code,
      fulfillment,
      who,
      active,
      phonetic,
      animal_breed,
      animal_species,
      careprovider,
      email,
      family,
      given,
      link,
      phone,
      birthdate,
      death_date,
      deceased,
      paymentstatus,
      responseidentifier,
      responsereference,
      statusdate,
      relatedperson,
      communication,
      role,
      specialty,
      sig,
      userid,
      end,
      start,
      authored,
      questionnaire,
      basedon,
      method,
      chromosome,
      species,
      slot_type,
      schedule,
      container_id,
      collected,
      collector,
      base_path,
      ext_context,
      path,
      valueset,
      _abstract,
      context_type,
      derivation,
      display,
      criteria,
      payload,
      container_identifier,
      expiry,
      quantity,
      supplier,
      failure,
      creator,
      definition,
      modified,
      testscript_capability,
      testscript_setup_capability,
      testscript_test_capability,
      reference,
      expansion,
  
    }

    public static Dictionary<string, SearchParameterNameType> GetSearchParameterNameType()
    {
      return new Dictionary<string, SearchParameterNameType>()
      {
        {"identifier", SearchParameterNameType.identifier},       
        {"type", SearchParameterNameType.type},       
        {"profile", SearchParameterNameType.profile},       
        {"security", SearchParameterNameType.security},       
        {"tag", SearchParameterNameType.tag},       
        {"balance", SearchParameterNameType.balance},       
        {"name", SearchParameterNameType.name},       
        {"owner", SearchParameterNameType.owner},       
        {"patient", SearchParameterNameType.patient},       
        {"period", SearchParameterNameType.period},       
        {"status", SearchParameterNameType.status},       
        {"subject", SearchParameterNameType.subject},       
        {"_id", SearchParameterNameType._id},       
        {"page", SearchParameterNameType.page},       
        {"_sort", SearchParameterNameType._sort},       
        {"manifestation", SearchParameterNameType.manifestation},       
        {"onset", SearchParameterNameType.onset},       
        {"route", SearchParameterNameType.route},       
        {"severity", SearchParameterNameType.severity},       
        {"substance", SearchParameterNameType.substance},       
        {"category", SearchParameterNameType.category},       
        {"criticality", SearchParameterNameType.criticality},       
        {"date", SearchParameterNameType.date},       
        {"last-date", SearchParameterNameType.last_date},       
        {"recorder", SearchParameterNameType.recorder},       
        {"reporter", SearchParameterNameType.reporter},       
        {"actor", SearchParameterNameType.actor},       
        {"appointment-type", SearchParameterNameType.appointment_type},       
        {"location", SearchParameterNameType.location},       
        {"part-status", SearchParameterNameType.part_status},       
        {"practitioner", SearchParameterNameType.practitioner},       
        {"service-type", SearchParameterNameType.service_type},       
        {"appointment", SearchParameterNameType.appointment},       
        {"address", SearchParameterNameType.address},       
        {"agent", SearchParameterNameType.agent},       
        {"agent-name", SearchParameterNameType.agent_name},       
        {"altid", SearchParameterNameType.altid},       
        {"entity", SearchParameterNameType.entity},       
        {"entity-id", SearchParameterNameType.entity_id},       
        {"entity-name", SearchParameterNameType.entity_name},       
        {"entity-type", SearchParameterNameType.entity_type},       
        {"policy", SearchParameterNameType.policy},       
        {"subtype", SearchParameterNameType.subtype},       
        {"user", SearchParameterNameType.user},       
        {"action", SearchParameterNameType.action},       
        {"site", SearchParameterNameType.site},       
        {"source", SearchParameterNameType.source},       
        {"code", SearchParameterNameType.code},       
        {"author", SearchParameterNameType.author},       
        {"created", SearchParameterNameType.created},       
        {"contenttype", SearchParameterNameType.contenttype},       
        {"composition", SearchParameterNameType.composition},       
        {"message", SearchParameterNameType.message},       
        {"activitycode", SearchParameterNameType.activitycode},       
        {"activitydate", SearchParameterNameType.activitydate},       
        {"activityreference", SearchParameterNameType.activityreference},       
        {"condition", SearchParameterNameType.condition},       
        {"goal", SearchParameterNameType.goal},       
        {"participant", SearchParameterNameType.participant},       
        {"performer", SearchParameterNameType.performer},       
        {"relatedcode", SearchParameterNameType.relatedcode},       
        {"relatedplan", SearchParameterNameType.relatedplan},       
        {"facilityidentifier", SearchParameterNameType.facilityidentifier},       
        {"facilityreference", SearchParameterNameType.facilityreference},       
        {"organizationidentifier", SearchParameterNameType.organizationidentifier},       
        {"organizationreference", SearchParameterNameType.organizationreference},       
        {"patientidentifier", SearchParameterNameType.patientidentifier},       
        {"patientreference", SearchParameterNameType.patientreference},       
        {"priority", SearchParameterNameType.priority},       
        {"provideridentifier", SearchParameterNameType.provideridentifier},       
        {"providerreference", SearchParameterNameType.providerreference},       
        {"targetidentifier", SearchParameterNameType.targetidentifier},       
        {"targetreference", SearchParameterNameType.targetreference},       
        {"use", SearchParameterNameType.use},       
        {"disposition", SearchParameterNameType.disposition},       
        {"outcome", SearchParameterNameType.outcome},       
        {"paymentdate", SearchParameterNameType.paymentdate},       
        {"requestidentifier", SearchParameterNameType.requestidentifier},       
        {"requestreference", SearchParameterNameType.requestreference},       
        {"finding", SearchParameterNameType.finding},       
        {"investigation", SearchParameterNameType.investigation},       
        {"plan", SearchParameterNameType.plan},       
        {"problem", SearchParameterNameType.problem},       
        {"resolved", SearchParameterNameType.resolved},       
        {"ruledout", SearchParameterNameType.ruledout},       
        {"trigger-code", SearchParameterNameType.trigger_code},       
        {"assessor", SearchParameterNameType.assessor},       
        {"previous", SearchParameterNameType.previous},       
        {"trigger", SearchParameterNameType.trigger},       
        {"context", SearchParameterNameType.context},       
        {"language", SearchParameterNameType.language},       
        {"description", SearchParameterNameType.description},       
        {"publisher", SearchParameterNameType.publisher},       
        {"system", SearchParameterNameType.system},       
        {"url", SearchParameterNameType.url},       
        {"version", SearchParameterNameType.version},       
        {"medium", SearchParameterNameType.medium},       
        {"recipient", SearchParameterNameType.recipient},       
        {"encounter", SearchParameterNameType.encounter},       
        {"received", SearchParameterNameType.received},       
        {"request", SearchParameterNameType.request},       
        {"sender", SearchParameterNameType.sender},       
        {"sent", SearchParameterNameType.sent},       
        {"requested", SearchParameterNameType.requested},       
        {"requester", SearchParameterNameType.requester},       
        {"time", SearchParameterNameType.time},       
        {"resource", SearchParameterNameType.resource},       
        {"attester", SearchParameterNameType.attester},       
        {"class", SearchParameterNameType._class},       
        {"entry", SearchParameterNameType.entry},       
        {"section", SearchParameterNameType.section},       
        {"confidentiality", SearchParameterNameType.confidentiality},       
        {"title", SearchParameterNameType.title},       
        {"dependson", SearchParameterNameType.dependson},       
        {"product", SearchParameterNameType.product},       
        {"source-code", SearchParameterNameType.source_code},       
        {"source-system", SearchParameterNameType.source_system},       
        {"target-code", SearchParameterNameType.target_code},       
        {"target-system", SearchParameterNameType.target_system},       
        {"source-uri", SearchParameterNameType.source_uri},       
        {"target", SearchParameterNameType.target},       
        {"body-site", SearchParameterNameType.body_site},       
        {"evidence", SearchParameterNameType.evidence},       
        {"stage", SearchParameterNameType.stage},       
        {"asserter", SearchParameterNameType.asserter},       
        {"clinicalstatus", SearchParameterNameType.clinicalstatus},       
        {"date-recorded", SearchParameterNameType.date_recorded},       
        {"event", SearchParameterNameType._event},       
        {"format", SearchParameterNameType.format},       
        {"mode", SearchParameterNameType.mode},       
        {"resourceprofile", SearchParameterNameType.resourceprofile},       
        {"securityservice", SearchParameterNameType.securityservice},       
        {"supported-profile", SearchParameterNameType.supported_profile},       
        {"fhirversion", SearchParameterNameType.fhirversion},       
        {"software", SearchParameterNameType.software},       
        {"authority", SearchParameterNameType.authority},       
        {"domain", SearchParameterNameType.domain},       
        {"signer", SearchParameterNameType.signer},       
        {"topic", SearchParameterNameType.topic},       
        {"ttopic", SearchParameterNameType.ttopic},       
        {"issued", SearchParameterNameType.issued},       
        {"beneficiaryidentifier", SearchParameterNameType.beneficiaryidentifier},       
        {"beneficiaryreference", SearchParameterNameType.beneficiaryreference},       
        {"dependent", SearchParameterNameType.dependent},       
        {"group", SearchParameterNameType.group},       
        {"issueridentifier", SearchParameterNameType.issueridentifier},       
        {"issuerreference", SearchParameterNameType.issuerreference},       
        {"planholderidentifier", SearchParameterNameType.planholderidentifier},       
        {"planholderreference", SearchParameterNameType.planholderreference},       
        {"sequence", SearchParameterNameType.sequence},       
        {"subplan", SearchParameterNameType.subplan},       
        {"stringency", SearchParameterNameType.stringency},       
        {"implicated", SearchParameterNameType.implicated},       
        {"manufacturer", SearchParameterNameType.manufacturer},       
        {"model", SearchParameterNameType.model},       
        {"organization", SearchParameterNameType.organization},       
        {"udicarrier", SearchParameterNameType.udicarrier},       
        {"parent", SearchParameterNameType.parent},       
        {"device", SearchParameterNameType.device},       
        {"bodysite", SearchParameterNameType.bodysite},       
        {"event-date", SearchParameterNameType.event_date},       
        {"event-status", SearchParameterNameType.event_status},       
        {"item-date", SearchParameterNameType.item_date},       
        {"item-past-status", SearchParameterNameType.item_past_status},       
        {"item-status", SearchParameterNameType.item_status},       
        {"specimen", SearchParameterNameType.specimen},       
        {"orderer", SearchParameterNameType.orderer},       
        {"diagnosis", SearchParameterNameType.diagnosis},       
        {"image", SearchParameterNameType.image},       
        {"result", SearchParameterNameType.result},       
        {"content-ref", SearchParameterNameType.content_ref},       
        {"related-id", SearchParameterNameType.related_id},       
        {"related-ref", SearchParameterNameType.related_ref},       
        {"facility", SearchParameterNameType.facility},       
        {"relatesto", SearchParameterNameType.relatesto},       
        {"relation", SearchParameterNameType.relation},       
        {"securitylabel", SearchParameterNameType.securitylabel},       
        {"setting", SearchParameterNameType.setting},       
        {"authenticator", SearchParameterNameType.authenticator},       
        {"custodian", SearchParameterNameType.custodian},       
        {"indexed", SearchParameterNameType.indexed},       
        {"requestorganizationidentifier", SearchParameterNameType.requestorganizationidentifier},       
        {"requestorganizationreference", SearchParameterNameType.requestorganizationreference},       
        {"requestprovideridentifier", SearchParameterNameType.requestprovideridentifier},       
        {"requestproviderreference", SearchParameterNameType.requestproviderreference},       
        {"episodeofcare", SearchParameterNameType.episodeofcare},       
        {"incomingreferral", SearchParameterNameType.incomingreferral},       
        {"indication", SearchParameterNameType.indication},       
        {"location-period", SearchParameterNameType.location_period},       
        {"participant-type", SearchParameterNameType.participant_type},       
        {"procedure", SearchParameterNameType.procedure},       
        {"reason", SearchParameterNameType.reason},       
        {"special-arrangement", SearchParameterNameType.special_arrangement},       
        {"length", SearchParameterNameType.length},       
        {"part-of", SearchParameterNameType.part_of},       
        {"care-manager", SearchParameterNameType.care_manager},       
        {"claimindentifier", SearchParameterNameType.claimindentifier},       
        {"claimreference", SearchParameterNameType.claimreference},       
        {"relationship", SearchParameterNameType.relationship},       
        {"gender", SearchParameterNameType.gender},       
        {"targetdate", SearchParameterNameType.targetdate},       
        {"characteristic", SearchParameterNameType.characteristic},       
        {"exclude", SearchParameterNameType.exclude},       
        {"member", SearchParameterNameType.member},       
        {"value", SearchParameterNameType.value},       
        {"actual", SearchParameterNameType.actual},       
        {"programname", SearchParameterNameType.programname},       
        {"servicecategory", SearchParameterNameType.servicecategory},       
        {"servicetype", SearchParameterNameType.servicetype},       
        {"selected-study", SearchParameterNameType.selected_study},       
        {"authoring-time", SearchParameterNameType.authoring_time},       
        {"dicom-class", SearchParameterNameType.dicom_class},       
        {"modality", SearchParameterNameType.modality},       
        {"order", SearchParameterNameType.order},       
        {"series", SearchParameterNameType.series},       
        {"uid", SearchParameterNameType.uid},       
        {"accession", SearchParameterNameType.accession},       
        {"started", SearchParameterNameType.started},       
        {"study", SearchParameterNameType.study},       
        {"dose-sequence", SearchParameterNameType.dose_sequence},       
        {"reaction", SearchParameterNameType.reaction},       
        {"reaction-date", SearchParameterNameType.reaction_date},       
        {"reason-not-given", SearchParameterNameType.reason_not_given},       
        {"vaccine-code", SearchParameterNameType.vaccine_code},       
        {"lot-number", SearchParameterNameType.lot_number},       
        {"notgiven", SearchParameterNameType.notgiven},       
        {"dose-number", SearchParameterNameType.dose_number},       
        {"information", SearchParameterNameType.information},       
        {"support", SearchParameterNameType.support},       
        {"vaccine-type", SearchParameterNameType.vaccine_type},       
        {"dependency", SearchParameterNameType.dependency},       
        {"experimental", SearchParameterNameType.experimental},       
        {"item", SearchParameterNameType.item},       
        {"empty-reason", SearchParameterNameType.empty_reason},       
        {"notes", SearchParameterNameType.notes},       
        {"address-city", SearchParameterNameType.address_city},       
        {"address-country", SearchParameterNameType.address_country},       
        {"address-postalcode", SearchParameterNameType.address_postalcode},       
        {"address-state", SearchParameterNameType.address_state},       
        {"address-use", SearchParameterNameType.address_use},       
        {"near", SearchParameterNameType.near},       
        {"near-distance", SearchParameterNameType.near_distance},       
        {"partof", SearchParameterNameType.partof},       
        {"view", SearchParameterNameType.view},       
        {"operator", SearchParameterNameType._operator},       
        {"container", SearchParameterNameType.container},       
        {"form", SearchParameterNameType.form},       
        {"ingredient", SearchParameterNameType.ingredient},       
        {"ingredient-code", SearchParameterNameType.ingredient_code},       
        {"package-item", SearchParameterNameType.package_item},       
        {"package-item-code", SearchParameterNameType.package_item_code},       
        {"effectivetime", SearchParameterNameType.effectivetime},       
        {"medication", SearchParameterNameType.medication},       
        {"prescription", SearchParameterNameType.prescription},       
        {"wasnotgiven", SearchParameterNameType.wasnotgiven},       
        {"receiver", SearchParameterNameType.receiver},       
        {"responsibleparty", SearchParameterNameType.responsibleparty},       
        {"destination", SearchParameterNameType.destination},       
        {"dispenser", SearchParameterNameType.dispenser},       
        {"whenhandedover", SearchParameterNameType.whenhandedover},       
        {"whenprepared", SearchParameterNameType.whenprepared},       
        {"datewritten", SearchParameterNameType.datewritten},       
        {"prescriber", SearchParameterNameType.prescriber},       
        {"effective", SearchParameterNameType.effective},       
        {"data", SearchParameterNameType.data},       
        {"destination-uri", SearchParameterNameType.destination_uri},       
        {"enterer", SearchParameterNameType.enterer},       
        {"response-id", SearchParameterNameType.response_id},       
        {"responsible", SearchParameterNameType.responsible},       
        {"timestamp", SearchParameterNameType.timestamp},       
        {"contact", SearchParameterNameType.contact},       
        {"id-type", SearchParameterNameType.id_type},       
        {"telecom", SearchParameterNameType.telecom},       
        {"kind", SearchParameterNameType.kind},       
        {"replaced-by", SearchParameterNameType.replaced_by},       
        {"additive", SearchParameterNameType.additive},       
        {"formula", SearchParameterNameType.formula},       
        {"oraldiet", SearchParameterNameType.oraldiet},       
        {"supplement", SearchParameterNameType.supplement},       
        {"datetime", SearchParameterNameType.datetime},       
        {"provider", SearchParameterNameType.provider},       
        {"component-code", SearchParameterNameType.component_code},       
        {"component-data-absent-reason", SearchParameterNameType.component_data_absent_reason},       
        {"component-value-concept", SearchParameterNameType.component_value_concept},       
        {"component-value-quantity", SearchParameterNameType.component_value_quantity},       
        {"component-value-string", SearchParameterNameType.component_value_string},       
        {"data-absent-reason", SearchParameterNameType.data_absent_reason},       
        {"related-target", SearchParameterNameType.related_target},       
        {"related-type", SearchParameterNameType.related_type},       
        {"value-concept", SearchParameterNameType.value_concept},       
        {"value-date", SearchParameterNameType.value_date},       
        {"value-quantity", SearchParameterNameType.value_quantity},       
        {"value-string", SearchParameterNameType.value_string},       
        {"paramprofile", SearchParameterNameType.paramprofile},       
        {"base", SearchParameterNameType._base},       
        {"instance", SearchParameterNameType.instance},       
        {"detail", SearchParameterNameType.detail},       
        {"when", SearchParameterNameType.when},       
        {"when_code", SearchParameterNameType.when_code},       
        {"fulfillment", SearchParameterNameType.fulfillment},       
        {"who", SearchParameterNameType.who},       
        {"active", SearchParameterNameType.active},       
        {"phonetic", SearchParameterNameType.phonetic},       
        {"animal-breed", SearchParameterNameType.animal_breed},       
        {"animal-species", SearchParameterNameType.animal_species},       
        {"careprovider", SearchParameterNameType.careprovider},       
        {"email", SearchParameterNameType.email},       
        {"family", SearchParameterNameType.family},       
        {"given", SearchParameterNameType.given},       
        {"link", SearchParameterNameType.link},       
        {"phone", SearchParameterNameType.phone},       
        {"birthdate", SearchParameterNameType.birthdate},       
        {"death-date", SearchParameterNameType.death_date},       
        {"deceased", SearchParameterNameType.deceased},       
        {"paymentstatus", SearchParameterNameType.paymentstatus},       
        {"responseidentifier", SearchParameterNameType.responseidentifier},       
        {"responsereference", SearchParameterNameType.responsereference},       
        {"statusdate", SearchParameterNameType.statusdate},       
        {"relatedperson", SearchParameterNameType.relatedperson},       
        {"communication", SearchParameterNameType.communication},       
        {"role", SearchParameterNameType.role},       
        {"specialty", SearchParameterNameType.specialty},       
        {"sig", SearchParameterNameType.sig},       
        {"userid", SearchParameterNameType.userid},       
        {"end", SearchParameterNameType.end},       
        {"start", SearchParameterNameType.start},       
        {"authored", SearchParameterNameType.authored},       
        {"questionnaire", SearchParameterNameType.questionnaire},       
        {"basedon", SearchParameterNameType.basedon},       
        {"method", SearchParameterNameType.method},       
        {"chromosome", SearchParameterNameType.chromosome},       
        {"species", SearchParameterNameType.species},       
        {"slot-type", SearchParameterNameType.slot_type},       
        {"schedule", SearchParameterNameType.schedule},       
        {"container-id", SearchParameterNameType.container_id},       
        {"collected", SearchParameterNameType.collected},       
        {"collector", SearchParameterNameType.collector},       
        {"base-path", SearchParameterNameType.base_path},       
        {"ext-context", SearchParameterNameType.ext_context},       
        {"path", SearchParameterNameType.path},       
        {"valueset", SearchParameterNameType.valueset},       
        {"abstract", SearchParameterNameType._abstract},       
        {"context-type", SearchParameterNameType.context_type},       
        {"derivation", SearchParameterNameType.derivation},       
        {"display", SearchParameterNameType.display},       
        {"criteria", SearchParameterNameType.criteria},       
        {"payload", SearchParameterNameType.payload},       
        {"container-identifier", SearchParameterNameType.container_identifier},       
        {"expiry", SearchParameterNameType.expiry},       
        {"quantity", SearchParameterNameType.quantity},       
        {"supplier", SearchParameterNameType.supplier},       
        {"failure", SearchParameterNameType.failure},       
        {"creator", SearchParameterNameType.creator},       
        {"definition", SearchParameterNameType.definition},       
        {"modified", SearchParameterNameType.modified},       
        {"testscript-capability", SearchParameterNameType.testscript_capability},       
        {"testscript-setup-capability", SearchParameterNameType.testscript_setup_capability},       
        {"testscript-test-capability", SearchParameterNameType.testscript_test_capability},       
        {"reference", SearchParameterNameType.reference},       
        {"expansion", SearchParameterNameType.expansion},       
  
      };
    }

  }
}

