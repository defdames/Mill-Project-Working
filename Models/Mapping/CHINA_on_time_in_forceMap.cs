using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_on_time_in_forceMap : EntityTypeConfiguration<CHINA_on_time_in_force>
    {
        public CHINA_on_time_in_forceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_hdr_key, t.so_hdr_crtdt, t.ar_ship_key, t.gl_cmp_key, t.so_dtl_shsdt, t.in_prod_key, t.in_prod_desc, t.so_dtl_entdt, t.so_dtl_prmdt, t.so_dtl_ordqt, t.so_dtl_shpqt, t.so_dtl_aordq, t.so_dtl_cpono });

            // Properties
            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.so_dtl_cpono)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.en_stats_key)
                .HasMaxLength(10);

            this.Property(t => t.en_ship_name)
                .HasMaxLength(30);

            this.Property(t => t.im_adres_city)
                .HasMaxLength(20);

            this.Property(t => t.im_adres_cntry)
                .HasMaxLength(20);

            this.Property(t => t.ar_ivhdr_key)
                .HasMaxLength(10);

            this.Property(t => t.so_ship_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CHINA_on_time_in_force");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_hdr_crtdt).HasColumnName("so_hdr_crtdt");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_dtl_shsdt).HasColumnName("so_dtl_shsdt");
            this.Property(t => t.so_dtl_shpdt).HasColumnName("so_dtl_shpdt");
            this.Property(t => t.in_prod_key).HasColumnName("in_prod_key");
            this.Property(t => t.in_prod_desc).HasColumnName("in_prod_desc");
            this.Property(t => t.so_dtl_entdt).HasColumnName("so_dtl_entdt");
            this.Property(t => t.so_dtl_prmdt).HasColumnName("so_dtl_prmdt");
            this.Property(t => t.so_dtl_ordqt).HasColumnName("so_dtl_ordqt");
            this.Property(t => t.so_dtl_shpqt).HasColumnName("so_dtl_shpqt");
            this.Property(t => t.so_dtl_aordq).HasColumnName("so_dtl_aordq");
            this.Property(t => t.so_dtl_cpono).HasColumnName("so_dtl_cpono");
            this.Property(t => t.im_pack_qty).HasColumnName("im_pack_qty");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_ship_name).HasColumnName("en_ship_name");
            this.Property(t => t.im_adres_city).HasColumnName("im_adres_city");
            this.Property(t => t.im_adres_cntry).HasColumnName("im_adres_cntry");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.ar_ivhdr_crtdt).HasColumnName("ar_ivhdr_crtdt");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.so_shpqt_qty).HasColumnName("so_shpqt_qty");
        }
    }
}
