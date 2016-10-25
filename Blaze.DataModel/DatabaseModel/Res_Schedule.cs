﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blaze.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Blaze.DataModel.DatabaseModel
{

  public class Res_Schedule : ResourceIndexBase
  {
    public int Res_ScheduleID {get; set;}
    public string active_Code {get; set;}
    public string active_System {get; set;}
    public string actor_VersionId {get; set;}
    public string actor_FhirId {get; set;}
    public string actor_Type {get; set;}
    public virtual ServiceRootURL_Store actor_Url { get; set; }
    public int? actor_ServiceRootURL_StoreID { get; set; }
    public DateTimeOffset? date_DateTimeOffsetLow {get; set;}
    public DateTimeOffset? date_DateTimeOffsetHigh {get; set;}
    public ICollection<Res_Schedule_History> Res_Schedule_History_List { get; set; }
    public ICollection<Res_Schedule_Index_identifier> identifier_List { get; set; }
    public ICollection<Res_Schedule_Index_type> type_List { get; set; }
    public ICollection<Res_Schedule_Index__profile> _profile_List { get; set; }
    public ICollection<Res_Schedule_Index__security> _security_List { get; set; }
    public ICollection<Res_Schedule_Index__tag> _tag_List { get; set; }
   
    public Res_Schedule()
    {
      this.identifier_List = new HashSet<Res_Schedule_Index_identifier>();
      this.type_List = new HashSet<Res_Schedule_Index_type>();
      this._profile_List = new HashSet<Res_Schedule_Index__profile>();
      this._security_List = new HashSet<Res_Schedule_Index__security>();
      this._tag_List = new HashSet<Res_Schedule_Index__tag>();
      this.Res_Schedule_History_List = new HashSet<Res_Schedule_History>();
    }
  }
}

