using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_itmpk_tblMap : EntityTypeConfiguration<in_itmpk_tbl>
    {
        public in_itmpk_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_item_key, t.im_pack_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.im_itmpk_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.im_itmpk_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.bm_asy_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_itmpk_cntnr)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_itmpk_wuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_itmpk_vuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_frtitem_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_afill)
                .HasMaxLength(2);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_itmpk_upcean)
                .HasMaxLength(13);

            this.Property(t => t.in_itmpk_scccode)
                .HasMaxLength(14);

            this.Property(t => t.in_itmpk_sccdesc)
                .HasMaxLength(60);

            this.Property(t => t.in_spritm_key)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_gtin_key)
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("in_itmpk_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.im_itmpk_desc).HasColumnName("im_itmpk_desc");
            this.Property(t => t.im_itmpk_qty).HasColumnName("im_itmpk_qty");
            this.Property(t => t.im_itmpk_uom).HasColumnName("im_itmpk_uom");
            this.Property(t => t.bm_asy_key).HasColumnName("bm_asy_key");
            this.Property(t => t.im_itmpk_cntnr).HasColumnName("im_itmpk_cntnr");
            this.Property(t => t.im_itmpk_wgt).HasColumnName("im_itmpk_wgt");
            this.Property(t => t.im_itmpk_wuom).HasColumnName("im_itmpk_wuom");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_itmpk_chgdt).HasColumnName("in_itmpk_chgdt");
            this.Property(t => t.in_itmpk_crtdt).HasColumnName("in_itmpk_crtdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.in_itmpk_yld).HasColumnName("in_itmpk_yld");
            this.Property(t => t.in_itmpk_ffltm).HasColumnName("in_itmpk_ffltm");
            this.Property(t => t.in_itmpk_piktm).HasColumnName("in_itmpk_piktm");
            this.Property(t => t.in_itmpk_rsrvtm).HasColumnName("in_itmpk_rsrvtm");
            this.Property(t => t.in_itmpk_pltqt).HasColumnName("in_itmpk_pltqt");
            this.Property(t => t.in_itmpk_vol).HasColumnName("in_itmpk_vol");
            this.Property(t => t.in_itmpk_vuom).HasColumnName("in_itmpk_vuom");
            this.Property(t => t.in_itmpk_drctf).HasColumnName("in_itmpk_drctf");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.en_uom_key).HasColumnName("en_uom_key");
            this.Property(t => t.in_itmpk_taxf).HasColumnName("in_itmpk_taxf");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.in_itmpk_fillattr).HasColumnName("in_itmpk_fillattr");
            this.Property(t => t.in_itmpk_tolbasis).HasColumnName("in_itmpk_tolbasis");
            this.Property(t => t.in_itmpk_tolover).HasColumnName("in_itmpk_tolover");
            this.Property(t => t.in_itmpk_tolunder).HasColumnName("in_itmpk_tolunder");
            this.Property(t => t.en_uom_afill).HasColumnName("en_uom_afill");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.in_itmpk_upcean).HasColumnName("in_itmpk_upcean");
            this.Property(t => t.in_itmpk_scccode).HasColumnName("in_itmpk_scccode");
            this.Property(t => t.in_itmpk_sccdesc).HasColumnName("in_itmpk_sccdesc");
            this.Property(t => t.in_itmpk_mfridlen).HasColumnName("in_itmpk_mfridlen");
            this.Property(t => t.in_itmpk_upcnt).HasColumnName("in_itmpk_upcnt");
            this.Property(t => t.in_itmpk_qcsublotf).HasColumnName("in_itmpk_qcsublotf");
            this.Property(t => t.in_itmpk_actfillf).HasColumnName("in_itmpk_actfillf");
            this.Property(t => t.in_itmpk_sublotf).HasColumnName("in_itmpk_sublotf");
            this.Property(t => t.in_itmpk_bkflinf).HasColumnName("in_itmpk_bkflinf");
            this.Property(t => t.in_itmpk_bkflopf).HasColumnName("in_itmpk_bkflopf");
            this.Property(t => t.in_spritm_key).HasColumnName("in_spritm_key");
            this.Property(t => t.in_itmpk_ovtfct).HasColumnName("in_itmpk_ovtfct");
            this.Property(t => t.in_itmpk_qcspecf).HasColumnName("in_itmpk_qcspecf");
            this.Property(t => t.in_itmpk_cmth).HasColumnName("in_itmpk_cmth");
            this.Property(t => t.in_itmpk_cstplp).HasColumnName("in_itmpk_cstplp");
            this.Property(t => t.en_gtin_key).HasColumnName("en_gtin_key");
            this.Property(t => t.in_itmpk_invcntrlf).HasColumnName("in_itmpk_invcntrlf");
        }
    }
}
