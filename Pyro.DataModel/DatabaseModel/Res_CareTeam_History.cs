﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_CareTeam_History : ResourceIndexBase
  {
    public int Res_CareTeam_HistoryID {get; set;}
    public virtual Res_CareTeam Res_CareTeam { get; set; }
   
    public Res_CareTeam_History()
    {
    }
  }
}
