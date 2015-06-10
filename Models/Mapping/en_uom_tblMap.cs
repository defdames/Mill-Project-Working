using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_uom_tblMap : EntityTypeConfiguration<en_uom_tbl>
    {
        public en_uom_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_uom_key);

            // Properties
            this.Property(t => t.en_uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_uom_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_uom_fmt)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("en_uom_tbl");
            this.Property(t => t.en_uom_key).HasColumnName("en_uom_key");
            this.Property(t => t.en_uom_desc).HasColumnName("en_uom_desc");
            this.Property(t => t.en_uom_type).HasColumnName("en_uom_type");
            this.Property(t => t.en_uom_fmt).HasColumnName("en_uom_fmt");
            this.Property(t => t.en_uom_round).HasColumnName("en_uom_round");
            this.Property(t => t.en_uom_rsvfg).HasColumnName("en_uom_rsvfg");
            this.Property(t => t.en_uom_upcnt).HasColumnName("en_uom_upcnt");
        }
    }
}
