using ConsoleModels.Models.References;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleModels.Models
{
    class BaseConfigurator
    {
        public static void ConfigureBaseProperties<T>(ref EntityTypeBuilder<T> builder) where T : class, IBase 
        {
            builder.HasIndex(s => s.LicenseID);
            builder.Property(s => s.LicenseID).IsRequired();
            /// для вызова ошибки при паралельном редактировании елемента https://metanit.com/sharp/entityframeworkcore/2.11.php
            builder.Property(s => s.Timestamp).IsRowVersion();
        }



    }
}
