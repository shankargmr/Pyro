﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blaze.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Blaze.DataModel.DatabaseModel
{

  public class Res_NutritionRequest_Index__tag : TokenIndex
  {
    public int Res_NutritionRequest_Index__tagID {get; set;}
    public virtual Res_NutritionRequest Res_NutritionRequest { get; set; }
   
    public Res_NutritionRequest_Index__tag()
    {
    }
  }
}

