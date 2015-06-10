using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_stats_tblMap : EntityTypeConfiguration<en_stats_tbl>
    {
        public en_stats_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_stats_key);

            // Properties
            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_stats_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_stats_type)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("en_stats_tbl");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_stats_desc).HasColumnName("en_stats_desc");
            this.Property(t => t.en_stats_type).HasColumnName("en_stats_type");
            this.Property(t => t.en_stats_upcnt).HasColumnName("en_stats_upcnt");
        }
    }
}
