﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blaze.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Blaze.DataModel.DatabaseModel
{

  public class Res_DecisionSupportRule_Index_security : TokenIndex
  {
    public int Res_DecisionSupportRule_Index_securityID {get; set;}
    public virtual Res_DecisionSupportRule Res_DecisionSupportRule { get; set; }
   
    public Res_DecisionSupportRule_Index_security()
    {
    }
  }
}
