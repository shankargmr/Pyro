﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Sequence_Index_end : NumberIndex
  {
    public int Res_Sequence_Index_endID {get; set;}
    public virtual Res_Sequence Res_Sequence { get; set; }
   
    public Res_Sequence_Index_end()
    {
    }
  }
}
