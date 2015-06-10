using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sap_enduserMap : EntityTypeConfiguration<sap_enduser>
    {
        public sap_enduserMap()
        {
            // Primary Key
            this.HasKey(t => t.sap_enduser1);

            // Properties
            this.Property(t => t.sap_enduser1)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("sap_enduser");
            this.Property(t => t.sap_enduser1).HasColumnName("sap_enduser");
        }
    }
}
