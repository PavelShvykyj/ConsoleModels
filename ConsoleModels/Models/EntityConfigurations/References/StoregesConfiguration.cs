using ConsoleModels.Models.References;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleModels.Models.EntityConfigurations
{
    class StoregesConfiguration : IEntityTypeConfiguration<Storeges>
    {
        public void Configure(EntityTypeBuilder<Storeges> builder)
        {
            //Builder.HasBaseType<ReferenceBase<Storeges>>();
            BaseReferensConfigurator.ConfigureBaseProperties<Storeges>(ref builder);
            builder.Property(s => s.Name).HasMaxLength(50);
            builder.Property(s => s.Code).HasMaxLength(15);
        }
    }
}


