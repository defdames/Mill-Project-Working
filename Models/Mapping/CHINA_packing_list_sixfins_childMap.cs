using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_packing_list_sixfins_childMap : EntityTypeConfiguration<CHINA_packing_list_sixfins_child>
    {
        public CHINA_packing_list_sixfins_childMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_hdr_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.im_incls_key)
                .HasMaxLength(10);

            this.Property(t => t.sixfins_text_value)
                .HasMaxLength(1786);

            this.Property(t => t.en_item_key)
                .HasMaxLength(20);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_packing_list_sixfins_child");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.im_incls_key).HasColumnName("im_incls_key");
            this.Property(t => t.sixfins_text_value).HasColumnName("sixfins_text_value");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
