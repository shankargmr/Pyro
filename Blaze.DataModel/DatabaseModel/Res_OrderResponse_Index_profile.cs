﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blaze.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Blaze.DataModel.DatabaseModel
{

  public class Res_OrderResponse_Index_profile : UriIndex
  {
    public int Res_OrderResponse_Index_profileID {get; set;}
    public virtual Res_OrderResponse Res_OrderResponse { get; set; }
   
    public Res_OrderResponse_Index_profile()
    {
    }
  }
}
