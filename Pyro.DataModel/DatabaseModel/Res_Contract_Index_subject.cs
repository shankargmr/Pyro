﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Contract_Index_subject : ReferenceIndex
  {
    public int Res_Contract_Index_subjectID {get; set;}
    public virtual Res_Contract Res_Contract { get; set; }
   
    public Res_Contract_Index_subject()
    {
    }
  }
}
