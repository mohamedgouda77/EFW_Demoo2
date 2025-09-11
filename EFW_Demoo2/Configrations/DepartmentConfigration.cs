﻿using EFW_Demoo2.Contexts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFW_Demoo2.Configrations
{
    public class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.DeptId);            
            builder.Property(x => x.DeptId)
                   .UseIdentityColumn(10, 10);

            //modelBuilder.Entity<Department>()
            //            .Property(x => x.DeptId)
            //            .ValueGeneratedNever();   // Disable identity column

            //modelBuilder.Entity<Department>()
            //            .Property(x => x.DeptId)
            //            .HasDefaultValueSql("newGuid()")
            //            .HasMaxLength(50);  

           
                        builder.Property(x => x.Name)
                        .HasColumnType("varchar")
                        .HasMaxLength(50)
                        .HasColumnName("DepartmentName")
                        .IsRequired(false)
                        .HasDefaultValue("HR");

           
                        builder.Property(x => x.DateofCreation)
                        .HasAnnotation("DataType", "Date");

            
                        builder.Ignore(x => x.serial); // Not mapped to any column in the table

        }
    }
}
