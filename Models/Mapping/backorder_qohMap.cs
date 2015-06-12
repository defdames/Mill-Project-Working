using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class backorder_qohMap : EntityTypeConfiguration<backorder_qoh>
    {
        public backorder_qohMap()
        {
            // Primary Key
            this.HasKey(t => new { t.type, t.gl_cmp_key, t.in_whs_key, t.in_item_key });

            // Properties
            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("backorder_qoh");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.QOH).HasColumnName("QOH");
        }
    }
}
