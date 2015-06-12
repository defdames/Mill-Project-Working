using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_itdsc_tblMap : EntityTypeConfiguration<in_itdsc_tbl>
    {
        public in_itdsc_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_item_key, t.in_itdsc_type });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_itdsc_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_itdsc_desc)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("in_itdsc_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_itdsc_type).HasColumnName("in_itdsc_type");
            this.Property(t => t.in_itdsc_desc).HasColumnName("in_itdsc_desc");
            this.Property(t => t.in_itdsc_upcnt).HasColumnName("in_itdsc_upcnt");
        }
    }
}
