using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EHS_Incident_Classification_ListMap : EntityTypeConfiguration<EHS_Incident_Classification_List>
    {
        public EHS_Incident_Classification_ListMap()
        {
            // Primary Key
            this.HasKey(t => t.Description);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EHS Incident Classification List");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
