using ConsoleModels.Models.References;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleModels.Models.EntityConfigurations
{
    class GoodsConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Good>
    {
        public void Configure(EntityTypeBuilder<Good> builder)
        {
            //builder.HasBaseType<ReferenceBase<Goods>>();
            builder.HasMany(g => g.Consist).WithOne(r => r.Good).OnDelete(DeleteBehavior.Cascade).HasForeignKey(r=>r.GoodID);

            BaseReferensConfigurator.ConfigureBaseProperties<Good>(ref builder);
            builder.Property(g => g.Code).HasMaxLength(15);
            builder.Property(g => g.GoodsType).IsRequired().HasDefaultValue(GoodsType.Good);
            builder.Property(g => g.Name).HasMaxLength(150);
            builder.Property(g => g.QuantityOnConsist).HasDefaultValue(1);
            builder.Property(g => g.UnitOfConsist).IsRequired().HasDefaultValue(Units.piece);
            builder.Property(g => g.UnitOfSale).IsRequired().HasDefaultValue(Units.piece);
            builder.Property(g => g.UnitOfStore).IsRequired().HasDefaultValue(Units.piece);
        }
    }
}
