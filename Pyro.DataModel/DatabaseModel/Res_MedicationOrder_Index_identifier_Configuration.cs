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
  public class Res_MedicationOrder_Index_identifier_Configuration : EntityTypeConfiguration<Res_MedicationOrder_Index_identifier>
  {

    public Res_MedicationOrder_Index_identifier_Configuration()
    {
      HasKey(x => x.Res_MedicationOrder_Index_identifierID).Property(x => x.Res_MedicationOrder_Index_identifierID).IsRequired();
      Property(x => x.Code).IsRequired();
      Property(x => x.System).IsOptional();
      HasRequired(x => x.Res_MedicationOrder).WithMany(x => x.identifier_List).WillCascadeOnDelete(true);
    }
  }
}