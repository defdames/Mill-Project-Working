using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class aged_material_statusMap : EntityTypeConfiguration<aged_material_status>
    {
        public aged_material_statusMap()
        {
            // Primary Key
            this.HasKey(t => t.itemkey);

            // Properties
            this.Property(t => t.itemkey)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_stats_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("aged_material_status");
            this.Property(t => t.itemkey).HasColumnName("itemkey");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
        }
    }
}
