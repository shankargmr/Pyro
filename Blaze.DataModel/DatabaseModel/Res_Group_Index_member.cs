﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blaze.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Blaze.DataModel.DatabaseModel
{

  public class Res_Group_Index_member : ReferenceIndex
  {
    public int Res_Group_Index_memberID {get; set;}
    public virtual Res_Group Res_Group { get; set; }
   
    public Res_Group_Index_member()
    {
    }
  }
}
