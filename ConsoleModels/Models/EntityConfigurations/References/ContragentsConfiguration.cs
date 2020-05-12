using ConsoleModels.Models.References;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleModels.Models.EntityConfigurations
{
    class ContragentsConfiguration : IEntityTypeConfiguration<Contragents>
    {
        public void Configure(EntityTypeBuilder<Contragents> builder)
        {
            //builder.HasBaseType<ReferenceBase<Contragents>>();
            BaseReferensConfigurator.ConfigureBaseProperties<Contragents>(ref builder);
            builder.Property(s => s.Name).HasMaxLength(50);
            builder.Property(s => s.Code).HasMaxLength(15);
            builder.Property(s => s.Phone).HasMaxLength(20);


        }
    }
}
