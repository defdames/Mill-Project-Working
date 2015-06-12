using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_mode_tblMap : EntityTypeConfiguration<en_mode_tbl>
    {
        public en_mode_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_mode_key);

            // Properties
            this.Property(t => t.en_mode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mode_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_trnsport_key)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("en_mode_tbl");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_mode_desc).HasColumnName("en_mode_desc");
            this.Property(t => t.en_trnsport_key).HasColumnName("en_trnsport_key");
            this.Property(t => t.en_mode_upcnt).HasColumnName("en_mode_upcnt");
        }
    }
}
