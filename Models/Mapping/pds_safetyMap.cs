using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pds_safetyMap : EntityTypeConfiguration<pds_safety>
    {
        public pds_safetyMap()
        {
            // Primary Key
            this.HasKey(t => t.safetyID);

            // Properties
            this.Property(t => t.safetyID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.safety_content)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("pds_safety");
            this.Property(t => t.safetyID).HasColumnName("safetyID");
            this.Property(t => t.safety_content).HasColumnName("safety_content");
        }
    }
}
