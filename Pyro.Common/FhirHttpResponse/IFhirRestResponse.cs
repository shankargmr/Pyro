﻿using System.Net.Http;
using Hl7.Fhir.Rest;
using Pyro.Common.Interfaces.Service;
using Pyro.Common.Service.ResourceService;

namespace Pyro.Common.FhirHttpResponse
{
  public interface IFhirRestResponse
  {
    HttpResponseMessage GetHttpResponseMessage(IResourceServiceOutcome ResourceServiceOutcome, HttpRequestMessage Request, SummaryType? SummaryType);
  }
}