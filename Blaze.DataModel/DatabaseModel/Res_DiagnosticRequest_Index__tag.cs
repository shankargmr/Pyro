﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blaze.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Blaze.DataModel.DatabaseModel
{

  public class Res_DiagnosticRequest_Index__tag : TokenIndex
  {
    public int Res_DiagnosticRequest_Index__tagID {get; set;}
    public virtual Res_DiagnosticRequest Res_DiagnosticRequest { get; set; }
   
    public Res_DiagnosticRequest_Index__tag()
    {
    }
  }
}

