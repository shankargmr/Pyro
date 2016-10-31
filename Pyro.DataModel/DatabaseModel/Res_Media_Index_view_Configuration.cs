﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure.Annotations;

//This is an Auto generated file do not change it's contents!!.

namespace Pyro.DataModel.DatabaseModel
{
  public class Res_Media_Index_view_Configuration : EntityTypeConfiguration<Res_Media_Index_view>
  {

    public Res_Media_Index_view_Configuration()
    {
      HasKey(x => x.Res_Media_Index_viewID).Property(x => x.Res_Media_Index_viewID).IsRequired();
      Property(x => x.Code).IsRequired();
      Property(x => x.System).IsOptional();
      HasRequired(x => x.Res_Media).WithMany(x => x.view_List).WillCascadeOnDelete(true);
    }
  }
}