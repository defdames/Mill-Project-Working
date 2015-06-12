using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EHS_Incident_Causes_ListMap : EntityTypeConfiguration<EHS_Incident_Causes_List>
    {
        public EHS_Incident_Causes_ListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sort_id, t.description });

            // Properties
            this.Property(t => t.sort_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("EHS Incident Causes List");
            this.Property(t => t.sort_id).HasColumnName("sort_id");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
