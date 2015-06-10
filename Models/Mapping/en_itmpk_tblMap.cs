using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_itmpk_tblMap : EntityTypeConfiguration<en_itmpk_tbl>
    {
        public en_itmpk_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_item_key, t.im_pack_key });

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_itmpk_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_itmpk_fluom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_itpkd_wuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_class_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_comcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_itgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_type_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_itmpk_orgin)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_itmpk_trdnm)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.en_itmpk_hzmtl)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_itmpk_hzmcl)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_itmpk_hzscl)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_itmpk_hzsub)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_itmpk_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.en_itmpk_abcc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_catlg_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_itpkd_szuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_itpkp_lot)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_itpkd_srlf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_itmpk_ssby)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_itmpk_ssds)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_itmpk_vuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_itmpk_contr)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.bm_asy_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_itpkp_cert)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_hmsqt_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_hssqt_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_frtitem_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_afill)
                .HasMaxLength(2);

            this.Property(t => t.en_itmpk_upcean)
                .HasMaxLength(13);

            this.Property(t => t.en_itmpk_scccode)
                .HasMaxLength(14);

            this.Property(t => t.en_itmpk_sccdesc)
                .HasMaxLength(60);

            this.Property(t => t.en_spritm_key)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_gtin_key)
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("en_itmpk_tbl");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_itmpk_desc).HasColumnName("en_itmpk_desc");
            this.Property(t => t.en_itmpk_filqt).HasColumnName("en_itmpk_filqt");
            this.Property(t => t.en_itmpk_fluom).HasColumnName("en_itmpk_fluom");
            this.Property(t => t.en_itpkd_wgt).HasColumnName("en_itpkd_wgt");
            this.Property(t => t.en_itpkd_wuom).HasColumnName("en_itpkd_wuom");
            this.Property(t => t.en_class_key).HasColumnName("en_class_key");
            this.Property(t => t.en_comcd_key).HasColumnName("en_comcd_key");
            this.Property(t => t.en_itmpk_cmth).HasColumnName("en_itmpk_cmth");
            this.Property(t => t.en_itgrp_key).HasColumnName("en_itgrp_key");
            this.Property(t => t.in_type_key).HasColumnName("in_type_key");
            this.Property(t => t.en_itmpk_orgin).HasColumnName("en_itmpk_orgin");
            this.Property(t => t.en_itmpk_trdnm).HasColumnName("en_itmpk_trdnm");
            this.Property(t => t.en_itmpk_pmcd).HasColumnName("en_itmpk_pmcd");
            this.Property(t => t.en_itmpk_hzmtl).HasColumnName("en_itmpk_hzmtl");
            this.Property(t => t.en_itmpk_hzmcl).HasColumnName("en_itmpk_hzmcl");
            this.Property(t => t.en_itmpk_hzscl).HasColumnName("en_itmpk_hzscl");
            this.Property(t => t.en_itmpk_hzsub).HasColumnName("en_itmpk_hzsub");
            this.Property(t => t.en_itmpk_hmsqt).HasColumnName("en_itmpk_hmsqt");
            this.Property(t => t.en_itmpk_hssqt).HasColumnName("en_itmpk_hssqt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_itmpk_crtdt).HasColumnName("en_itmpk_crtdt");
            this.Property(t => t.en_itmpk_chgdt).HasColumnName("en_itmpk_chgdt");
            this.Property(t => t.im_note_key).HasColumnName("im_note_key");
            this.Property(t => t.en_itmpk_cmnts).HasColumnName("en_itmpk_cmnts");
            this.Property(t => t.en_itmpk_abcc).HasColumnName("en_itmpk_abcc");
            this.Property(t => t.en_catlg_key).HasColumnName("en_catlg_key");
            this.Property(t => t.en_itmpk_lscdt).HasColumnName("en_itmpk_lscdt");
            this.Property(t => t.en_itpkd_dpth).HasColumnName("en_itpkd_dpth");
            this.Property(t => t.en_itpkd_szuom).HasColumnName("en_itpkd_szuom");
            this.Property(t => t.en_itpkp_shelf).HasColumnName("en_itpkp_shelf");
            this.Property(t => t.en_itpkd_hght).HasColumnName("en_itpkd_hght");
            this.Property(t => t.en_itmpk_lead).HasColumnName("en_itmpk_lead");
            this.Property(t => t.en_itpkp_lot).HasColumnName("en_itpkp_lot");
            this.Property(t => t.en_itpkd_srlf).HasColumnName("en_itpkd_srlf");
            this.Property(t => t.en_itmpk_ssby).HasColumnName("en_itmpk_ssby");
            this.Property(t => t.en_itmpk_sbydt).HasColumnName("en_itmpk_sbydt");
            this.Property(t => t.en_itmpk_sdsdt).HasColumnName("en_itmpk_sdsdt");
            this.Property(t => t.en_itmpk_ssds).HasColumnName("en_itmpk_ssds");
            this.Property(t => t.en_itmpk_vol).HasColumnName("en_itmpk_vol");
            this.Property(t => t.en_itmpk_vuom).HasColumnName("en_itmpk_vuom");
            this.Property(t => t.en_itpkd_wdth).HasColumnName("en_itpkd_wdth");
            this.Property(t => t.en_itmpk_contr).HasColumnName("en_itmpk_contr");
            this.Property(t => t.bm_asy_key).HasColumnName("bm_asy_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_itpkp_cert).HasColumnName("en_itpkp_cert");
            this.Property(t => t.en_hmsqt_uom).HasColumnName("en_hmsqt_uom");
            this.Property(t => t.en_hssqt_uom).HasColumnName("en_hssqt_uom");
            this.Property(t => t.en_itmpk_yld).HasColumnName("en_itmpk_yld");
            this.Property(t => t.en_itmpk_ffltm).HasColumnName("en_itmpk_ffltm");
            this.Property(t => t.en_itmpk_piktm).HasColumnName("en_itmpk_piktm");
            this.Property(t => t.en_itmpk_rsrvtm).HasColumnName("en_itmpk_rsrvtm");
            this.Property(t => t.en_itmpk_pltqt).HasColumnName("en_itmpk_pltqt");
            this.Property(t => t.en_itmpk_drctf).HasColumnName("en_itmpk_drctf");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.en_uom_key).HasColumnName("en_uom_key");
            this.Property(t => t.en_itmpk_taxf).HasColumnName("en_itmpk_taxf");
            this.Property(t => t.en_resn_key).HasColumnName("en_resn_key");
            this.Property(t => t.en_itmpk_fillattr).HasColumnName("en_itmpk_fillattr");
            this.Property(t => t.en_itmpk_tolbasis).HasColumnName("en_itmpk_tolbasis");
            this.Property(t => t.en_itmpk_tolover).HasColumnName("en_itmpk_tolover");
            this.Property(t => t.en_itmpk_tolunder).HasColumnName("en_itmpk_tolunder");
            this.Property(t => t.en_uom_afill).HasColumnName("en_uom_afill");
            this.Property(t => t.en_itmpk_upcean).HasColumnName("en_itmpk_upcean");
            this.Property(t => t.en_itmpk_scccode).HasColumnName("en_itmpk_scccode");
            this.Property(t => t.en_itmpk_sccdesc).HasColumnName("en_itmpk_sccdesc");
            this.Property(t => t.en_itmpk_mfridlen).HasColumnName("en_itmpk_mfridlen");
            this.Property(t => t.en_itmpk_actfillf).HasColumnName("en_itmpk_actfillf");
            this.Property(t => t.en_itmpk_sublotf).HasColumnName("en_itmpk_sublotf");
            this.Property(t => t.en_itmpk_qcsublotf).HasColumnName("en_itmpk_qcsublotf");
            this.Property(t => t.en_itmpk_upcnt).HasColumnName("en_itmpk_upcnt");
            this.Property(t => t.en_itmpk_bkflinf).HasColumnName("en_itmpk_bkflinf");
            this.Property(t => t.en_itmpk_bkflopf).HasColumnName("en_itmpk_bkflopf");
            this.Property(t => t.en_spritm_key).HasColumnName("en_spritm_key");
            this.Property(t => t.en_itmpk_ovtfct).HasColumnName("en_itmpk_ovtfct");
            this.Property(t => t.en_itmpk_qcspecf).HasColumnName("en_itmpk_qcspecf");
            this.Property(t => t.en_itmpk_cstpltp).HasColumnName("en_itmpk_cstpltp");
            this.Property(t => t.en_gtin_key).HasColumnName("en_gtin_key");
            this.Property(t => t.en_itmpk_invcntrlf).HasColumnName("en_itmpk_invcntrlf");
            this.Property(t => t.en_itmpk_hazmgr).HasColumnName("en_itmpk_hazmgr");
        }
    }
}
