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
  public class Res_Group_Index_value_Configuration : EntityTypeConfiguration<Res_Group_Index_value>
  {

    public Res_Group_Index_value_Configuration()
    {
      HasKey(x => x.Res_Group_Index_valueID).Property(x => x.Res_Group_Index_valueID).IsRequired();
      Property(x => x.Code).IsRequired();
      Property(x => x.System).IsOptional();
      HasRequired(x => x.Res_Group).WithMany(x => x.value_List).WillCascadeOnDelete(true);
    }
  }
}