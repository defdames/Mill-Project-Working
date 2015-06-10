using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sap_applicationMap : EntityTypeConfiguration<sap_application>
    {
        public sap_applicationMap()
        {
            // Primary Key
            this.HasKey(t => t.sap_application1);

            // Properties
            this.Property(t => t.sap_application1)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("sap_application");
            this.Property(t => t.sap_application1).HasColumnName("sap_application");
        }
    }
}
