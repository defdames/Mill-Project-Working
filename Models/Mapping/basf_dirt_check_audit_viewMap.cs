using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class basf_dirt_check_audit_viewMap : EntityTypeConfiguration<basf_dirt_check_audit_view>
    {
        public basf_dirt_check_audit_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_hdr_Key, t.so_dtl_key, t.in_prod_key, t.in_prod_desc, t.so_dtl_shsdt, t.in_lot_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_hdr_Key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("basf_dirt_check_audit_view");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_hdr_Key).HasColumnName("so_hdr_Key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.in_prod_key).HasColumnName("in_prod_key");
            this.Property(t => t.in_prod_desc).HasColumnName("in_prod_desc");
            this.Property(t => t.so_dtl_shsdt).HasColumnName("so_dtl_shsdt");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
        }
    }
}
