using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class china_applicationMap : EntityTypeConfiguration<china_application>
    {
        public china_applicationMap()
        {
            // Primary Key
            this.HasKey(t => t.china_application1);

            // Properties
            this.Property(t => t.china_application1)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("china_application");
            this.Property(t => t.china_application1).HasColumnName("china_application");
        }
    }
}
