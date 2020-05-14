using ConsoleModels.Models.References;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleModels.Models.EntityConfigurations
{
    class RecordOfGoodConsistsConfiguration : IEntityTypeConfiguration<RcordOfGoodConsist>
    {
        public void Configure(EntityTypeBuilder<RcordOfGoodConsist> builder)
        {
            builder.HasKey(r => new {r.Id, r.GoodID });
            builder.HasIndex(r => r.GoodID);
            builder.HasOne(r => r.Good).WithMany(g => g.Consist).HasForeignKey(r => r.GoodID);
            
            builder.Property(s=>s.Brutto).IsRequired().HasDefaultValue(0);
            builder.Property(s => s.Netto).HasDefaultValue(0);
            builder.Property(s => s.Unit).IsRequired().HasDefaultValue(Units.piece); // piece 
        }
    }
}
