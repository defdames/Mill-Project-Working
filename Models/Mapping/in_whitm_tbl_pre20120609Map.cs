using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_whitm_tbl_pre20120609Map : EntityTypeConfiguration<in_whitm_tbl_pre20120609>
    {
        public in_whitm_tbl_pre20120609Map()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_item_key, t.in_whitm_reclc, t.in_whitm_pcklc, t.in_whitm_pmcd, t.in_whitm_ordpl, t.in_whitm_sourc, t.in_whitm_leadt, t.in_whitm_ndysp, t.in_whitm_sstk, t.in_whitm_minoq, t.in_whitm_maxoq, t.in_whitm_incroq, t.in_whitm_ropt, t.in_whitm_nqoh, t.in_whitm_nnqoh, t.in_whitm_alcqt, t.uom_key, t.in_whitm_sngrclc, t.in_whitm_sngpklc, t.in_whitm_shelf, t.in_whitm_cmth, t.in_whitm_acstext, t.in_whitm_lcst, t.in_whitm_pcst, t.in_whitm_scst, t.in_whitm_tfrtp, t.gl_acct_key, t.in_mohcd_key, t.in_cyccd_key, t.in_whitm_stflg, t.in_cycno_key, t.in_whitm_vract, t.sa_user_key, t.in_whitm_chgdt, t.in_whitm_crtdt, t.en_vend_key, t.ap_remt_key, t.ap_delfm_key, t.in_whitm_srcwhs, t.in_whitm_taxf, t.in_whitm_cstflg, t.in_whitm_bkflinf, t.in_whitm_bkflopf, t.in_whitm_pdstdcstf, t.in_whitm_mrkpricef, t.in_whitm_advplnf, t.in_whitm_upcnt, t.in_whitm_cstpltp, t.in_whitm_actcstf, t.gl_acct_stkvar, t.gl_acct_paccrual, t.in_whitm_bmscst, t.in_whitm_pmscst, t.in_whitm_bmoscst, t.in_whitm_pmoscst, t.in_whitm_brscst, t.in_whitm_prscst, t.in_whitm_broscst, t.in_whitm_proscst, t.in_whitm_cdscst, t.in_whitm_frtscst, t.in_whitm_mktscst, t.in_whitm_othscst, t.in_whitm_bmpcst, t.in_whitm_pmpcst, t.in_whitm_bmopcst, t.in_whitm_pmopcst, t.in_whitm_brpcst, t.in_whitm_prpcst, t.in_whitm_bropcst, t.in_whitm_propcst, t.in_whitm_cdpcst, t.in_whitm_frtpcst, t.in_whitm_mktpcst, t.in_whitm_othpcst, t.in_whitm_prefpack, t.in_whitm_tolunder, t.in_whitm_tolover, t.in_whitm_tolbasis, t.in_whitm_toltype, t.in_whitm_pkdptlocf, t.in_whitm_incusgf, t.in_whitm_abcc, t.in_whitm_rcdptlocf, t.in_type_key, t.in_class_key, t.in_comcd_key, t.in_itgrp_key });

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

            this.Property(t => t.in_whitm_reclc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whitm_pcklc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whitm_pmcd)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_ordpl)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_sourc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whitm_leadt)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_ndysp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_ropt)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whitm_sngrclc)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_whitm_sngpklc)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_whitm_shelf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_cmth)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_tfrtp)
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

            this.Property(t => t.in_whitm_stflg)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_cycno_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_vract)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whitm_srcwhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_whitm_taxf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ap_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.in_whitm_cstflg)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_bkflinf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_bkflopf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_pdstdcstf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_mrkpricef)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_advplnf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_uom_time)
                .HasMaxLength(2);

            this.Property(t => t.in_whitm_upcnt)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_cstpltp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_actcstf)
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

            this.Property(t => t.in_whitm_prefpack)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_whitm_tolbasis)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_toltype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_uom_tolerance)
                .HasMaxLength(2);

            this.Property(t => t.in_whitm_pkdptlocf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_incusgf)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whitm_pprplnt)
                .HasMaxLength(4);

            this.Property(t => t.in_whitm_abcc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whitm_rcdptlocf)
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
            this.ToTable("in_whitm_tbl_pre20120609");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_whitm_reclc).HasColumnName("in_whitm_reclc");
            this.Property(t => t.in_whitm_pcklc).HasColumnName("in_whitm_pcklc");
            this.Property(t => t.in_whitm_pmcd).HasColumnName("in_whitm_pmcd");
            this.Property(t => t.in_whitm_ordpl).HasColumnName("in_whitm_ordpl");
            this.Property(t => t.in_whitm_sourc).HasColumnName("in_whitm_sourc");
            this.Property(t => t.in_whitm_leadt).HasColumnName("in_whitm_leadt");
            this.Property(t => t.in_whitm_ndysp).HasColumnName("in_whitm_ndysp");
            this.Property(t => t.in_whitm_sstk).HasColumnName("in_whitm_sstk");
            this.Property(t => t.in_whitm_minoq).HasColumnName("in_whitm_minoq");
            this.Property(t => t.in_whitm_maxoq).HasColumnName("in_whitm_maxoq");
            this.Property(t => t.in_whitm_incroq).HasColumnName("in_whitm_incroq");
            this.Property(t => t.in_whitm_ropt).HasColumnName("in_whitm_ropt");
            this.Property(t => t.in_whitm_nqoh).HasColumnName("in_whitm_nqoh");
            this.Property(t => t.in_whitm_nnqoh).HasColumnName("in_whitm_nnqoh");
            this.Property(t => t.in_whitm_alcqt).HasColumnName("in_whitm_alcqt");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.in_whitm_sngrclc).HasColumnName("in_whitm_sngrclc");
            this.Property(t => t.in_whitm_sngpklc).HasColumnName("in_whitm_sngpklc");
            this.Property(t => t.in_whitm_shelf).HasColumnName("in_whitm_shelf");
            this.Property(t => t.in_whitm_cmth).HasColumnName("in_whitm_cmth");
            this.Property(t => t.in_whitm_acstext).HasColumnName("in_whitm_acstext");
            this.Property(t => t.in_whitm_lcst).HasColumnName("in_whitm_lcst");
            this.Property(t => t.in_whitm_pcst).HasColumnName("in_whitm_pcst");
            this.Property(t => t.in_whitm_scst).HasColumnName("in_whitm_scst");
            this.Property(t => t.in_whitm_tfrtp).HasColumnName("in_whitm_tfrtp");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.in_mohcd_key).HasColumnName("in_mohcd_key");
            this.Property(t => t.in_cyccd_key).HasColumnName("in_cyccd_key");
            this.Property(t => t.in_whitm_nctdt).HasColumnName("in_whitm_nctdt");
            this.Property(t => t.in_whitm_stflg).HasColumnName("in_whitm_stflg");
            this.Property(t => t.in_cycno_key).HasColumnName("in_cycno_key");
            this.Property(t => t.in_whitm_vract).HasColumnName("in_whitm_vract");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_whitm_chgdt).HasColumnName("in_whitm_chgdt");
            this.Property(t => t.in_whitm_crtdt).HasColumnName("in_whitm_crtdt");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.in_cyccd_lstdt).HasColumnName("in_cyccd_lstdt");
            this.Property(t => t.in_cyccd_freq).HasColumnName("in_cyccd_freq");
            this.Property(t => t.in_cyccd_nxtdt).HasColumnName("in_cyccd_nxtdt");
            this.Property(t => t.in_cycnt_key).HasColumnName("in_cycnt_key");
            this.Property(t => t.in_cycnt_seqno).HasColumnName("in_cycnt_seqno");
            this.Property(t => t.in_whitm_srcwhs).HasColumnName("in_whitm_srcwhs");
            this.Property(t => t.in_whitm_ffltm).HasColumnName("in_whitm_ffltm");
            this.Property(t => t.in_whitm_piktm).HasColumnName("in_whitm_piktm");
            this.Property(t => t.in_whitm_rsrvtm).HasColumnName("in_whitm_rsrvtm");
            this.Property(t => t.in_whitm_taxf).HasColumnName("in_whitm_taxf");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.in_whitm_cstflg).HasColumnName("in_whitm_cstflg");
            this.Property(t => t.in_whitm_bkflinf).HasColumnName("in_whitm_bkflinf");
            this.Property(t => t.in_whitm_bkflopf).HasColumnName("in_whitm_bkflopf");
            this.Property(t => t.in_whitm_pdstdcstf).HasColumnName("in_whitm_pdstdcstf");
            this.Property(t => t.in_whitm_mrkpricef).HasColumnName("in_whitm_mrkpricef");
            this.Property(t => t.in_whitm_advplnf).HasColumnName("in_whitm_advplnf");
            this.Property(t => t.in_whitm_holdcst).HasColumnName("in_whitm_holdcst");
            this.Property(t => t.en_uom_time).HasColumnName("en_uom_time");
            this.Property(t => t.in_whitm_upcnt).HasColumnName("in_whitm_upcnt");
            this.Property(t => t.in_whitm_cstpltp).HasColumnName("in_whitm_cstpltp");
            this.Property(t => t.in_whitm_actcstf).HasColumnName("in_whitm_actcstf");
            this.Property(t => t.gl_acct_avgcadj).HasColumnName("gl_acct_avgcadj");
            this.Property(t => t.gl_acct_icreturn).HasColumnName("gl_acct_icreturn");
            this.Property(t => t.gl_acct_icppvar).HasColumnName("gl_acct_icppvar");
            this.Property(t => t.in_whitm_ovtfct).HasColumnName("in_whitm_ovtfct");
            this.Property(t => t.gl_acct_stkvar).HasColumnName("gl_acct_stkvar");
            this.Property(t => t.gl_acct_paccrual).HasColumnName("gl_acct_paccrual");
            this.Property(t => t.in_whitm_bmscst).HasColumnName("in_whitm_bmscst");
            this.Property(t => t.in_whitm_pmscst).HasColumnName("in_whitm_pmscst");
            this.Property(t => t.in_whitm_bmoscst).HasColumnName("in_whitm_bmoscst");
            this.Property(t => t.in_whitm_pmoscst).HasColumnName("in_whitm_pmoscst");
            this.Property(t => t.in_whitm_brscst).HasColumnName("in_whitm_brscst");
            this.Property(t => t.in_whitm_prscst).HasColumnName("in_whitm_prscst");
            this.Property(t => t.in_whitm_broscst).HasColumnName("in_whitm_broscst");
            this.Property(t => t.in_whitm_proscst).HasColumnName("in_whitm_proscst");
            this.Property(t => t.in_whitm_cdscst).HasColumnName("in_whitm_cdscst");
            this.Property(t => t.in_whitm_frtscst).HasColumnName("in_whitm_frtscst");
            this.Property(t => t.in_whitm_mktscst).HasColumnName("in_whitm_mktscst");
            this.Property(t => t.in_whitm_othscst).HasColumnName("in_whitm_othscst");
            this.Property(t => t.in_whitm_bmpcst).HasColumnName("in_whitm_bmpcst");
            this.Property(t => t.in_whitm_pmpcst).HasColumnName("in_whitm_pmpcst");
            this.Property(t => t.in_whitm_bmopcst).HasColumnName("in_whitm_bmopcst");
            this.Property(t => t.in_whitm_pmopcst).HasColumnName("in_whitm_pmopcst");
            this.Property(t => t.in_whitm_brpcst).HasColumnName("in_whitm_brpcst");
            this.Property(t => t.in_whitm_prpcst).HasColumnName("in_whitm_prpcst");
            this.Property(t => t.in_whitm_bropcst).HasColumnName("in_whitm_bropcst");
            this.Property(t => t.in_whitm_propcst).HasColumnName("in_whitm_propcst");
            this.Property(t => t.in_whitm_cdpcst).HasColumnName("in_whitm_cdpcst");
            this.Property(t => t.in_whitm_frtpcst).HasColumnName("in_whitm_frtpcst");
            this.Property(t => t.in_whitm_mktpcst).HasColumnName("in_whitm_mktpcst");
            this.Property(t => t.in_whitm_othpcst).HasColumnName("in_whitm_othpcst");
            this.Property(t => t.in_whitm_prefpack).HasColumnName("in_whitm_prefpack");
            this.Property(t => t.in_whitm_tolunder).HasColumnName("in_whitm_tolunder");
            this.Property(t => t.in_whitm_tolover).HasColumnName("in_whitm_tolover");
            this.Property(t => t.in_whitm_tolbasis).HasColumnName("in_whitm_tolbasis");
            this.Property(t => t.in_whitm_toltype).HasColumnName("in_whitm_toltype");
            this.Property(t => t.en_uom_tolerance).HasColumnName("en_uom_tolerance");
            this.Property(t => t.in_whitm_pkdptlocf).HasColumnName("in_whitm_pkdptlocf");
            this.Property(t => t.in_whitm_incusgf).HasColumnName("in_whitm_incusgf");
            this.Property(t => t.in_whitm_pprplnt).HasColumnName("in_whitm_pprplnt");
            this.Property(t => t.in_whitm_abcc).HasColumnName("in_whitm_abcc");
            this.Property(t => t.in_whitm_stdrevaldt).HasColumnName("in_whitm_stdrevaldt");
            this.Property(t => t.in_whitm_rcdptlocf).HasColumnName("in_whitm_rcdptlocf");
            this.Property(t => t.in_whitm_stdcstexpdt).HasColumnName("in_whitm_stdcstexpdt");
            this.Property(t => t.in_type_key).HasColumnName("in_type_key");
            this.Property(t => t.in_class_key).HasColumnName("in_class_key");
            this.Property(t => t.in_comcd_key).HasColumnName("in_comcd_key");
            this.Property(t => t.in_itgrp_key).HasColumnName("in_itgrp_key");
            this.Property(t => t.gl_acct_neginv).HasColumnName("gl_acct_neginv");
        }
    }
}
