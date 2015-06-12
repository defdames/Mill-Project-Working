using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sap_marketMap : EntityTypeConfiguration<sap_market>
    {
        public sap_marketMap()
        {
            // Primary Key
            this.HasKey(t => t.sap_market1);

            // Properties
            this.Property(t => t.sap_market1)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("sap_market");
            this.Property(t => t.sap_market1).HasColumnName("sap_market");
        }
    }
}
