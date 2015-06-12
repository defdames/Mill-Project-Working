using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_whitmpk_tbl_20120201Map : EntityTypeConfiguration<in_whitmpk_tbl_20120201>
    {
        public in_whitmpk_tbl_20120201Map()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_item_key, t.im_pack_key, t.in_whitmpk_acstext, t.in_whitmpk_lcst, t.in_whitmpk_pcst, t.in_whitmpk_scst, t.in_whitmpk_nqoh, t.in_whitmpk_nnqoh, t.in_whitmpk_alcqt, t.in_whitmpk_reclc, t.in_whitmpk_pcklc, t.in_whitmpk_ndysp, t.in_whitmpk_shelf, t.in_whitmpk_sourc, t.in_whitmpk_pmcd, t.in_whitmpk_minoq, t.in_whitmpk_maxoq, t.in_whitmpk_incoq, t.uom_key, t.in_whitmpk_sngpklc, t.in_whitmpk_sngrclc, t.in_whitmpk_ordpl, t.in_whitmpk_leadt, t.in_whitmpk_cmth, t.in_whitmpk_tftyp, t.in_whitmpk_tfcst, t.gl_acct_key, t.in_mohcd_key, t.in_whitmpk_crtdt, t.in_whitmpk_chgdt, t.in_cyccd_key, t.in_stat_key, t.in_whitmpk_slmvf, t.sa_user_key, t.in_whitmpk_ropt, t.in_whitmpk_cmnts, t.in_whitmpk_upcnt, t.en_vend_key, t.ap_remt_key, t.ap_delfm_key, t.in_whitmpk_sstk, t.in_whitmpk_tfrtp, t.in_whitmpk_vract, t.in_cycno_key, t.in_whitmpk_srcwhs, t.in_whitmpk_taxf, t.in_whitmpk_cstflg, t.in_whitmpk_bkflinf, t.in_whitmpk_bkflopf, t.in_whitmpk_advplnf, t.in_whitmpk_asinfct, t.in_whitmpk_cstpltp, t.in_whitmpk_actcstf, t.gl_acct_stkvar, t.gl_acct_paccrual, t.in_whitmpk_bmscst, t.in_whitmpk_pmscst, t.in_whitmpk_bmoscst, t.in_whitmpk_pmoscst, t.in_whitmpk_brscst, t.in_whitmpk_prscst, t.in_whitmpk_broscst, t.in_whitmpk_proscst, t.in_whitmpk_cdscst, t.in_whitmpk_frtscst, t.in_whitmpk_mktscst, t.in_whitmpk_othscst, t.in_whitmpk_bmpcst, t.in_whitmpk_pmpcst, t.in_whitmpk_bmopcst, t.in_whitmpk_pmopcst, t.in_whitmpk_brpcst, t.in_whitmpk_prpcst, t.in_whitmpk_bropcst, t.in_whitmpk_propcst, t.in_whitmpk_cdpcst, t.in_whitmpk_frtpcst, t.in_whitmpk_mktpcst, t.in_whitmpk_othpcst, t.in_whitmpk_incusgf, t.in_whitmpk_tolunder, t.in_whitmpk_tolover, t.in_whitmpk_tolbasis, t.in_whitmpk_toltype, t.in_whitmpk_pkdptlocf, t.in_whitmpk_abcc, t.in_whitmpk_rcdptlocf, t.in_type_key, t.in_class_key, t.in_comcd_key, t.in_itgrp_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_whitmpk_reclc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whitmpk_pcklc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whitmpk_sourc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whitmpk_pmcd)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whitmpk_sngpklc)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_whitmpk_sngrclc)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_whitmpk_ordpl)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_cmth)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_tftyp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_mohcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_cyccd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_stat_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whitmpk_slmvf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.in_whitmpk_ropt)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_cmnts)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.in_whitmpk_upcnt)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whitmpk_tfrtp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_vract)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_cycno_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_srcwhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_whitmpk_taxf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ap_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.in_whitmpk_cstflg)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_bkflinf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_bkflopf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_advplnf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_uom_time)
                .HasMaxLength(2);

            this.Property(t => t.in_whitmpk_cstpltp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_actcstf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_acct_avgcadj)
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_icreturn)
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_icppvar)
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_stkvar)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_paccrual)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.in_whitmpk_incusgf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_pprplnt)
                .HasMaxLength(4);

            this.Property(t => t.in_whitmpk_tolbasis)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_toltype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_uom_tolerance)
                .HasMaxLength(2);

            this.Property(t => t.in_whitmpk_pkdptlocf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitmpk_abcc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whitmpk_rcdptlocf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_type_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_class_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_comcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_itgrp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_acct_neginv)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("in_whitmpk_tbl_20120201");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_whitmpk_acstext).HasColumnName("in_whitmpk_acstext");
            this.Property(t => t.in_whitmpk_lcst).HasColumnName("in_whitmpk_lcst");
            this.Property(t => t.in_whitmpk_pcst).HasColumnName("in_whitmpk_pcst");
            this.Property(t => t.in_whitmpk_scst).HasColumnName("in_whitmpk_scst");
            this.Property(t => t.in_whitmpk_nqoh).HasColumnName("in_whitmpk_nqoh");
            this.Property(t => t.in_whitmpk_nnqoh).HasColumnName("in_whitmpk_nnqoh");
            this.Property(t => t.in_whitmpk_alcqt).HasColumnName("in_whitmpk_alcqt");
            this.Property(t => t.in_whitmpk_reclc).HasColumnName("in_whitmpk_reclc");
            this.Property(t => t.in_whitmpk_pcklc).HasColumnName("in_whitmpk_pcklc");
            this.Property(t => t.in_whitmpk_ndysp).HasColumnName("in_whitmpk_ndysp");
            this.Property(t => t.in_whitmpk_shelf).HasColumnName("in_whitmpk_shelf");
            this.Property(t => t.in_whitmpk_sourc).HasColumnName("in_whitmpk_sourc");
            this.Property(t => t.in_whitmpk_pmcd).HasColumnName("in_whitmpk_pmcd");
            this.Property(t => t.in_whitmpk_minoq).HasColumnName("in_whitmpk_minoq");
            this.Property(t => t.in_whitmpk_maxoq).HasColumnName("in_whitmpk_maxoq");
            this.Property(t => t.in_whitmpk_incoq).HasColumnName("in_whitmpk_incoq");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.in_whitmpk_sngpklc).HasColumnName("in_whitmpk_sngpklc");
            this.Property(t => t.in_whitmpk_sngrclc).HasColumnName("in_whitmpk_sngrclc");
            this.Property(t => t.in_whitmpk_ordpl).HasColumnName("in_whitmpk_ordpl");
            this.Property(t => t.in_whitmpk_leadt).HasColumnName("in_whitmpk_leadt");
            this.Property(t => t.in_whitmpk_cmth).HasColumnName("in_whitmpk_cmth");
            this.Property(t => t.in_whitmpk_tftyp).HasColumnName("in_whitmpk_tftyp");
            this.Property(t => t.in_whitmpk_tfcst).HasColumnName("in_whitmpk_tfcst");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.in_mohcd_key).HasColumnName("in_mohcd_key");
            this.Property(t => t.in_whitmpk_crtdt).HasColumnName("in_whitmpk_crtdt");
            this.Property(t => t.in_whitmpk_chgdt).HasColumnName("in_whitmpk_chgdt");
            this.Property(t => t.in_cyccd_key).HasColumnName("in_cyccd_key");
            this.Property(t => t.in_stat_key).HasColumnName("in_stat_key");
            this.Property(t => t.in_whitmpk_lscdt).HasColumnName("in_whitmpk_lscdt");
            this.Property(t => t.in_whitmpk_slmvf).HasColumnName("in_whitmpk_slmvf");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_whitmpk_ropt).HasColumnName("in_whitmpk_ropt");
            this.Property(t => t.in_whitmpk_cmnts).HasColumnName("in_whitmpk_cmnts");
            this.Property(t => t.in_whitmpk_upcnt).HasColumnName("in_whitmpk_upcnt");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.in_whitmpk_sstk).HasColumnName("in_whitmpk_sstk");
            this.Property(t => t.in_whitmpk_tfrtp).HasColumnName("in_whitmpk_tfrtp");
            this.Property(t => t.in_whitmpk_nctdt).HasColumnName("in_whitmpk_nctdt");
            this.Property(t => t.in_whitmpk_vract).HasColumnName("in_whitmpk_vract");
            this.Property(t => t.in_cycno_key).HasColumnName("in_cycno_key");
            this.Property(t => t.in_cyccd_lstdt).HasColumnName("in_cyccd_lstdt");
            this.Property(t => t.in_cyccd_freq).HasColumnName("in_cyccd_freq");
            this.Property(t => t.in_cyccd_nxtdt).HasColumnName("in_cyccd_nxtdt");
            this.Property(t => t.in_cycnt_key).HasColumnName("in_cycnt_key");
            this.Property(t => t.in_cycnt_seqno).HasColumnName("in_cycnt_seqno");
            this.Property(t => t.in_whitmpk_srcwhs).HasColumnName("in_whitmpk_srcwhs");
            this.Property(t => t.in_whitmpk_ffltm).HasColumnName("in_whitmpk_ffltm");
            this.Property(t => t.in_whitmpk_piktm).HasColumnName("in_whitmpk_piktm");
            this.Property(t => t.in_whitmpk_rsrvtm).HasColumnName("in_whitmpk_rsrvtm");
            this.Property(t => t.in_whitmpk_taxf).HasColumnName("in_whitmpk_taxf");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.in_whitmpk_cstflg).HasColumnName("in_whitmpk_cstflg");
            this.Property(t => t.in_whitmpk_bkflinf).HasColumnName("in_whitmpk_bkflinf");
            this.Property(t => t.in_whitmpk_bkflopf).HasColumnName("in_whitmpk_bkflopf");
            this.Property(t => t.in_whitmpk_advplnf).HasColumnName("in_whitmpk_advplnf");
            this.Property(t => t.in_whitmpk_holdcst).HasColumnName("in_whitmpk_holdcst");
            this.Property(t => t.en_uom_time).HasColumnName("en_uom_time");
            this.Property(t => t.in_whitmpk_asinfct).HasColumnName("in_whitmpk_asinfct");
            this.Property(t => t.in_whitmpk_cstpltp).HasColumnName("in_whitmpk_cstpltp");
            this.Property(t => t.in_whitmpk_actcstf).HasColumnName("in_whitmpk_actcstf");
            this.Property(t => t.gl_acct_avgcadj).HasColumnName("gl_acct_avgcadj");
            this.Property(t => t.gl_acct_icreturn).HasColumnName("gl_acct_icreturn");
            this.Property(t => t.gl_acct_icppvar).HasColumnName("gl_acct_icppvar");
            this.Property(t => t.in_whitmpk_ovtfct).HasColumnName("in_whitmpk_ovtfct");
            this.Property(t => t.gl_acct_stkvar).HasColumnName("gl_acct_stkvar");
            this.Property(t => t.gl_acct_paccrual).HasColumnName("gl_acct_paccrual");
            this.Property(t => t.in_whitmpk_bmscst).HasColumnName("in_whitmpk_bmscst");
            this.Property(t => t.in_whitmpk_pmscst).HasColumnName("in_whitmpk_pmscst");
            this.Property(t => t.in_whitmpk_bmoscst).HasColumnName("in_whitmpk_bmoscst");
            this.Property(t => t.in_whitmpk_pmoscst).HasColumnName("in_whitmpk_pmoscst");
            this.Property(t => t.in_whitmpk_brscst).HasColumnName("in_whitmpk_brscst");
            this.Property(t => t.in_whitmpk_prscst).HasColumnName("in_whitmpk_prscst");
            this.Property(t => t.in_whitmpk_broscst).HasColumnName("in_whitmpk_broscst");
            this.Property(t => t.in_whitmpk_proscst).HasColumnName("in_whitmpk_proscst");
            this.Property(t => t.in_whitmpk_cdscst).HasColumnName("in_whitmpk_cdscst");
            this.Property(t => t.in_whitmpk_frtscst).HasColumnName("in_whitmpk_frtscst");
            this.Property(t => t.in_whitmpk_mktscst).HasColumnName("in_whitmpk_mktscst");
            this.Property(t => t.in_whitmpk_othscst).HasColumnName("in_whitmpk_othscst");
            this.Property(t => t.in_whitmpk_bmpcst).HasColumnName("in_whitmpk_bmpcst");
            this.Property(t => t.in_whitmpk_pmpcst).HasColumnName("in_whitmpk_pmpcst");
            this.Property(t => t.in_whitmpk_bmopcst).HasColumnName("in_whitmpk_bmopcst");
            this.Property(t => t.in_whitmpk_pmopcst).HasColumnName("in_whitmpk_pmopcst");
            this.Property(t => t.in_whitmpk_brpcst).HasColumnName("in_whitmpk_brpcst");
            this.Property(t => t.in_whitmpk_prpcst).HasColumnName("in_whitmpk_prpcst");
            this.Property(t => t.in_whitmpk_bropcst).HasColumnName("in_whitmpk_bropcst");
            this.Property(t => t.in_whitmpk_propcst).HasColumnName("in_whitmpk_propcst");
            this.Property(t => t.in_whitmpk_cdpcst).HasColumnName("in_whitmpk_cdpcst");
            this.Property(t => t.in_whitmpk_frtpcst).HasColumnName("in_whitmpk_frtpcst");
            this.Property(t => t.in_whitmpk_mktpcst).HasColumnName("in_whitmpk_mktpcst");
            this.Property(t => t.in_whitmpk_othpcst).HasColumnName("in_whitmpk_othpcst");
            this.Property(t => t.in_whitmpk_incusgf).HasColumnName("in_whitmpk_incusgf");
            this.Property(t => t.in_whitmpk_pprplnt).HasColumnName("in_whitmpk_pprplnt");
            this.Property(t => t.in_whitmpk_tolunder).HasColumnName("in_whitmpk_tolunder");
            this.Property(t => t.in_whitmpk_tolover).HasColumnName("in_whitmpk_tolover");
            this.Property(t => t.in_whitmpk_tolbasis).HasColumnName("in_whitmpk_tolbasis");
            this.Property(t => t.in_whitmpk_toltype).HasColumnName("in_whitmpk_toltype");
            this.Property(t => t.en_uom_tolerance).HasColumnName("en_uom_tolerance");
            this.Property(t => t.in_whitmpk_pkdptlocf).HasColumnName("in_whitmpk_pkdptlocf");
            this.Property(t => t.in_whitmpk_abcc).HasColumnName("in_whitmpk_abcc");
            this.Property(t => t.in_whitmpk_rcdptlocf).HasColumnName("in_whitmpk_rcdptlocf");
            this.Property(t => t.in_whitmpk_stdrevaldt).HasColumnName("in_whitmpk_stdrevaldt");
            this.Property(t => t.in_whitmpk_stdcstexpdt).HasColumnName("in_whitmpk_stdcstexpdt");
            this.Property(t => t.in_type_key).HasColumnName("in_type_key");
            this.Property(t => t.in_class_key).HasColumnName("in_class_key");
            this.Property(t => t.in_comcd_key).HasColumnName("in_comcd_key");
            this.Property(t => t.in_itgrp_key).HasColumnName("in_itgrp_key");
            this.Property(t => t.gl_acct_neginv).HasColumnName("gl_acct_neginv");
        }
    }
}
