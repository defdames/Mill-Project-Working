using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_item_tblMap : EntityTypeConfiguration<in_item_tbl>
    {
        public in_item_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_item_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_ssds)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_ssby)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_abcc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_revno)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_srce_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_class_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_comcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_drwsz)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_drwno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ec_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_srlf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_msds)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_type_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_catlg_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_item_wuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_szuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_itgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_mohcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_cyccd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.in_uomgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_item_vuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_frtitem_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_phfmt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_item_upcean)
                .HasMaxLength(13);

            this.Property(t => t.in_item_scccode)
                .HasMaxLength(14);

            this.Property(t => t.in_item_sccdesc)
                .HasMaxLength(60);

            this.Property(t => t.en_cntry_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_acct_stkvar)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_paccrual)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_item_prefpack)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_gtin_key)
                .HasMaxLength(14);

            this.Property(t => t.gl_invacctgrp_key)
                .HasMaxLength(10);

            this.Property(t => t.in_item_dlotfrmt)
                .HasMaxLength(250);

            this.Property(t => t.in_item_plotfrmt)
                .HasMaxLength(250);

            this.Property(t => t.in_item_mlotfrmt)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("in_item_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_ssds).HasColumnName("in_ssds");
            this.Property(t => t.in_ssds_date).HasColumnName("in_ssds_date");
            this.Property(t => t.in_ssby).HasColumnName("in_ssby");
            this.Property(t => t.in_ssby_date).HasColumnName("in_ssby_date");
            this.Property(t => t.in_desc).HasColumnName("in_desc");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.in_abcc).HasColumnName("in_abcc");
            this.Property(t => t.in_item_revno).HasColumnName("in_item_revno");
            this.Property(t => t.in_srce_key).HasColumnName("in_srce_key");
            this.Property(t => t.in_class_key).HasColumnName("in_class_key");
            this.Property(t => t.in_comcd_key).HasColumnName("in_comcd_key");
            this.Property(t => t.in_drwsz).HasColumnName("in_drwsz");
            this.Property(t => t.in_drwno).HasColumnName("in_drwno");
            this.Property(t => t.ec_hdr_key).HasColumnName("ec_hdr_key");
            this.Property(t => t.in_ndysp).HasColumnName("in_ndysp");
            this.Property(t => t.in_sstk).HasColumnName("in_sstk");
            this.Property(t => t.in_mhlc).HasColumnName("in_mhlc");
            this.Property(t => t.in_yldf).HasColumnName("in_yldf");
            this.Property(t => t.in_minoq).HasColumnName("in_minoq");
            this.Property(t => t.in_ropt).HasColumnName("in_ropt");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.in_lscdt).HasColumnName("in_lscdt");
            this.Property(t => t.in_pmcd).HasColumnName("in_pmcd");
            this.Property(t => t.in_srlf).HasColumnName("in_srlf");
            this.Property(t => t.in_msds).HasColumnName("in_msds");
            this.Property(t => t.in_type_key).HasColumnName("in_type_key");
            this.Property(t => t.in_catlg_key).HasColumnName("in_catlg_key");
            this.Property(t => t.in_item_wgt).HasColumnName("in_item_wgt");
            this.Property(t => t.in_item_wuom).HasColumnName("in_item_wuom");
            this.Property(t => t.in_item_wdth).HasColumnName("in_item_wdth");
            this.Property(t => t.in_item_hght).HasColumnName("in_item_hght");
            this.Property(t => t.in_item_dpth).HasColumnName("in_item_dpth");
            this.Property(t => t.in_item_szuom).HasColumnName("in_item_szuom");
            this.Property(t => t.in_itgrp_key).HasColumnName("in_itgrp_key");
            this.Property(t => t.in_item_cmth).HasColumnName("in_item_cmth");
            this.Property(t => t.in_item_shelf).HasColumnName("in_item_shelf");
            this.Property(t => t.in_item_sopolicy).HasColumnName("in_item_sopolicy");
            this.Property(t => t.in_item_wtpolicy).HasColumnName("in_item_wtpolicy");
            this.Property(t => t.in_item_wopolicy).HasColumnName("in_item_wopolicy");
            this.Property(t => t.in_item_lvlcd).HasColumnName("in_item_lvlcd");
            this.Property(t => t.in_cnfgf).HasColumnName("in_cnfgf");
            this.Property(t => t.in_item_stflg).HasColumnName("in_item_stflg");
            this.Property(t => t.in_mohcd_key).HasColumnName("in_mohcd_key");
            this.Property(t => t.in_cyccd_key).HasColumnName("in_cyccd_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_item_chgdt).HasColumnName("in_item_chgdt");
            this.Property(t => t.in_item_crtdt).HasColumnName("in_item_crtdt");
            this.Property(t => t.in_item_allocf).HasColumnName("in_item_allocf");
            this.Property(t => t.in_item_pickf).HasColumnName("in_item_pickf");
            this.Property(t => t.in_item_lotalcf).HasColumnName("in_item_lotalcf");
            this.Property(t => t.in_item_ffltm).HasColumnName("in_item_ffltm");
            this.Property(t => t.in_item_piktm).HasColumnName("in_item_piktm");
            this.Property(t => t.in_item_rsrvtm).HasColumnName("in_item_rsrvtm");
            this.Property(t => t.in_uomgrp_key).HasColumnName("in_uomgrp_key");
            this.Property(t => t.in_item_spgvt).HasColumnName("in_item_spgvt");
            this.Property(t => t.in_item_actconf).HasColumnName("in_item_actconf");
            this.Property(t => t.in_item_pltqt).HasColumnName("in_item_pltqt");
            this.Property(t => t.in_item_vol).HasColumnName("in_item_vol");
            this.Property(t => t.in_item_vuom).HasColumnName("in_item_vuom");
            this.Property(t => t.in_item_drctf).HasColumnName("in_item_drctf");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.en_phfmt_key).HasColumnName("en_phfmt_key");
            this.Property(t => t.in_item_taxf).HasColumnName("in_item_taxf");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.in_item_fillattr).HasColumnName("in_item_fillattr");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.in_item_upcean).HasColumnName("in_item_upcean");
            this.Property(t => t.in_item_scccode).HasColumnName("in_item_scccode");
            this.Property(t => t.in_item_sccdesc).HasColumnName("in_item_sccdesc");
            this.Property(t => t.in_item_mfridlen).HasColumnName("in_item_mfridlen");
            this.Property(t => t.in_item_upcnt).HasColumnName("in_item_upcnt");
            this.Property(t => t.in_item_qcsublotf).HasColumnName("in_item_qcsublotf");
            this.Property(t => t.in_item_actfillf).HasColumnName("in_item_actfillf");
            this.Property(t => t.in_item_sublotf).HasColumnName("in_item_sublotf");
            this.Property(t => t.in_item_hazf).HasColumnName("in_item_hazf");
            this.Property(t => t.in_item_bkflinf).HasColumnName("in_item_bkflinf");
            this.Property(t => t.in_item_bkflopf).HasColumnName("in_item_bkflopf");
            this.Property(t => t.en_cntry_key).HasColumnName("en_cntry_key");
            this.Property(t => t.in_item_cstpltp).HasColumnName("in_item_cstpltp");
            this.Property(t => t.in_item_ovtfct).HasColumnName("in_item_ovtfct");
            this.Property(t => t.gl_acct_stkvar).HasColumnName("gl_acct_stkvar");
            this.Property(t => t.gl_acct_paccrual).HasColumnName("gl_acct_paccrual");
            this.Property(t => t.in_item_qcspecf).HasColumnName("in_item_qcspecf");
            this.Property(t => t.in_source_blendf).HasColumnName("in_source_blendf");
            this.Property(t => t.in_target_blendf).HasColumnName("in_target_blendf");
            this.Property(t => t.in_item_prefpack).HasColumnName("in_item_prefpack");
            this.Property(t => t.en_gtin_key).HasColumnName("en_gtin_key");
            this.Property(t => t.in_item_apprf).HasColumnName("in_item_apprf");
            this.Property(t => t.in_item_autosourcef).HasColumnName("in_item_autosourcef");
            this.Property(t => t.in_item_bklvlpercent).HasColumnName("in_item_bklvlpercent");
            this.Property(t => t.gl_invacctgrp_key).HasColumnName("gl_invacctgrp_key");
            this.Property(t => t.in_item_invcntrlf).HasColumnName("in_item_invcntrlf");
            this.Property(t => t.in_item_dlotfrmt).HasColumnName("in_item_dlotfrmt");
            this.Property(t => t.in_item_plotfrmt).HasColumnName("in_item_plotfrmt");
            this.Property(t => t.in_item_mlotfrmt).HasColumnName("in_item_mlotfrmt");
        }
    }
}
