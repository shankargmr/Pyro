﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace Pyro.Common.Tools
{
  public static class FhirOperationOutcomeSupport
  {
    public static OperationOutcome Generate(List<OperationOutcome.IssueComponent> IssueList)
    {
      if (IssueList.Count == 0)
        return null;

      var NarativeTextList = new List<string>();
      var OpOutCome = new OperationOutcome();
      foreach (var Issue in IssueList)
      {
        NarativeTextList.Add(ObtainNarrativeText(Issue));
        OpOutCome.Issue.Add(Issue);
      }
      OpOutCome.Text.Div = GenerateNarrative(NarativeTextList);
      OpOutCome.Meta = new Meta();
      OpOutCome.Meta.LastUpdated = DateTimeOffset.Now;
      return OpOutCome;
    }

    private static string ObtainNarrativeText(OperationOutcome.IssueComponent Issue)
    {
      if (Issue.Details != null && !string.IsNullOrWhiteSpace(Issue.Details.Text))
      {
        return Issue.Details.Text;
      }
      else if (!string.IsNullOrWhiteSpace(Issue.Diagnostics))
      {
        return Issue.Diagnostics;
      }
      else if (Issue.Details != null && Issue.Details.Coding != null && Issue.Details.Coding.Count > 0)
      {
        var Text = new StringBuilder();
        foreach (var item in Issue.Details.Coding)
        {
          if (string.IsNullOrWhiteSpace(item.Display))
            Text.AppendLine(item.Display);
        }
        return Text.ToString();
      }
      else
      {
        throw new Exception("Server Error: No narrative text could be formed for an Operation Outcome.");
      }
    }

    private static string GenerateNarrative(List<string> NarrativeList)
    {
      StringBuilder NarrativeString = new StringBuilder();
      NarrativeString.AppendLine("<div xmlns=\"http://www.w3.org/1999/xhtml\">");
      foreach (var Text in NarrativeList)
      {
        NarrativeString.Append("<p>");
        NarrativeString.Append(System.Security.SecurityElement.Escape(Text.Replace(System.Environment.NewLine, "</br>")));
        NarrativeString.Append("</p>");
      }
      NarrativeString.Append("</div>");
      return NarrativeString.ToString();
    }

    public static void EscapeOperationOutComeContent(OperationOutcome OpOutCome)
    {
      foreach (OperationOutcome.IssueComponent Issue in OpOutCome.Issue)
      {
        Issue.Diagnostics = XhtmlSupport.EncodeToString(Issue.Diagnostics);

        if (Issue.Details != null)
        {
          Issue.Details.Text = XhtmlSupport.EncodeToString(Issue.Details.Text);
          foreach (Coding Code in Issue.Details.Coding)
          {
            Code.Display = XhtmlSupport.EncodeToString(Code.Display);
          }
        }
        var EscapedLocation = new List<string>();
        if (Issue.Location != null)
        {
          foreach (var Location in Issue.Location)
          {
            EscapedLocation.Add(XhtmlSupport.EncodeToString(Location));
          }
          Issue.Location = EscapedLocation;
        }
      }
    }


  }
}
