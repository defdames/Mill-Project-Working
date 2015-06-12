using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_total_open_order_valueMap : EntityTypeConfiguration<CHINA_total_open_order_value>
    {
        public CHINA_total_open_order_valueMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_hdr_key, t.hold_msg, t.ar_ship_key, t.ar_bill_key, t.en_prod_shipf, t.sa_created_by, t.gl_cmp_key, t.so_hdr_crtdt, t.so_dtl_shsdt });

            // Properties
            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hold_msg)
                .IsRequired()
                .HasMaxLength(19);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_prod_shipf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sa_created_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_total_open_order_value");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.hold_msg).HasColumnName("hold_msg");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.en_prod_shipf).HasColumnName("en_prod_shipf");
            this.Property(t => t.open_order_value).HasColumnName("open_order_value");
            this.Property(t => t.open_order_qty).HasColumnName("open_order_qty");
            this.Property(t => t.open_order_cost).HasColumnName("open_order_cost");
            this.Property(t => t.sa_created_by).HasColumnName("sa_created_by");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_hdr_crtdt).HasColumnName("so_hdr_crtdt");
            this.Property(t => t.so_dtl_shsdt).HasColumnName("so_dtl_shsdt");
        }
    }
}
