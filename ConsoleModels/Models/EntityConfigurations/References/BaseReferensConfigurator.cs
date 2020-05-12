using ConsoleModels.Models.References;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ConsoleModels.Models.EntityConfigurations
{
    class BaseReferensConfigurator
    {

        //public static void ConfigureBaseProperties<T, U>( EntityTypeBuilder<T> builder) where U : class where T : IReferenceBase<U>
        public static void ConfigureBaseProperties<T>(ref EntityTypeBuilder<T> builder) where T: class , IReferenceBase<T>
        {
            BaseConfigurator.ConfigureBaseProperties<T>(ref builder);

            builder.HasKey(s => s.Id);

            ////// Why?????
            //////Microsoft.Data.SqlClient.SqlException(0x80131904): Не удалось создать внешний ключ "FK_Contragents_Contragents_ParentID" со ссылочным действием SET NULL, поскольку один или несколько ссылающихся столбцов не допускают значения NULL.
            builder.HasOne(s => s.Parent).WithMany(p => p.Children).HasForeignKey(s => s.ParentID).OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(s => s.Code);
            builder.HasIndex(s => s.IsDeleted);
            builder.HasIndex(s => s.IsFolder);
            builder.HasIndex(s => s.IsPredefined);
            builder.HasIndex(s => s.Name);
            builder.HasIndex(s => s.ParentID);

            builder.Property("Code").IsRequired();
            builder.Property("IsDeleted").IsRequired().HasDefaultValue(false);
            builder.Property("IsFolder").IsRequired();
            builder.Property("IsPredefined").IsRequired().HasDefaultValue(false);
            builder.Property("Name").IsRequired();
            
        }

    }
}
