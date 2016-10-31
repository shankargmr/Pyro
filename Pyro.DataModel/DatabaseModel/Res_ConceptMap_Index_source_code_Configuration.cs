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
  public class Res_ConceptMap_Index_source_code_Configuration : EntityTypeConfiguration<Res_ConceptMap_Index_source_code>
  {

    public Res_ConceptMap_Index_source_code_Configuration()
    {
      HasKey(x => x.Res_ConceptMap_Index_source_codeID).Property(x => x.Res_ConceptMap_Index_source_codeID).IsRequired();
      Property(x => x.Code).IsRequired();
      Property(x => x.System).IsOptional();
      HasRequired(x => x.Res_ConceptMap).WithMany(x => x.source_code_List).WillCascadeOnDelete(true);
    }
  }
}