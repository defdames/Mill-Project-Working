using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_bill_tblMap : EntityTypeConfiguration<ar_bill_tbl>
    {
        public ar_bill_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ar_bill_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_bank_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ap_bank_acctno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ar_bill_tacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ar_bill_dacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ar_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ar_bill_crdno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ar_bill_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ar_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_bill_catgy)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_exemno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_frgt_key)
                .HasMaxLength(10);

            this.Property(t => t.ar_duncyc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_doccd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_bill_regid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_exsus)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ar_bill_intvndno)
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_crdtrep)
                .HasMaxLength(20);

            this.Property(t => t.en_riskcode_key)
                .HasMaxLength(20);

            this.Property(t => t.ar_bill_holdresn)
                .HasMaxLength(30);

            this.Property(t => t.ar_bill_crdtcrncy)
                .HasMaxLength(3);

            this.Property(t => t.ar_bill_ccaudit)
                .HasMaxLength(76);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_paygrp_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_recv)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_bill_cmtacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ar_ivdelcd_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ar_bill_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_bill_depc).HasColumnName("ar_bill_depc");
            this.Property(t => t.ar_bill_clmtc).HasColumnName("ar_bill_clmtc");
            this.Property(t => t.ar_bill_lstpc).HasColumnName("ar_bill_lstpc");
            this.Property(t => t.ap_bank_key).HasColumnName("ap_bank_key");
            this.Property(t => t.ap_bank_acctno).HasColumnName("ap_bank_acctno");
            this.Property(t => t.ar_bill_tacct).HasColumnName("ar_bill_tacct");
            this.Property(t => t.ar_bill_dacct).HasColumnName("ar_bill_dacct");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.ar_bill_fstat).HasColumnName("ar_bill_fstat");
            this.Property(t => t.ar_bill_bilcy).HasColumnName("ar_bill_bilcy");
            this.Property(t => t.ar_bill_stmtp).HasColumnName("ar_bill_stmtp");
            this.Property(t => t.ar_bill_dunte).HasColumnName("ar_bill_dunte");
            this.Property(t => t.ar_bill_stmdt).HasColumnName("ar_bill_stmdt");
            this.Property(t => t.ar_bill_lpddt).HasColumnName("ar_bill_lpddt");
            this.Property(t => t.ar_bill_unpdc).HasColumnName("ar_bill_unpdc");
            this.Property(t => t.ar_bill_fchgc).HasColumnName("ar_bill_fchgc");
            this.Property(t => t.ar_bill_remk).HasColumnName("ar_bill_remk");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.ar_bill_crdno).HasColumnName("ar_bill_crdno");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.ar_bill_chgdt).HasColumnName("ar_bill_chgdt");
            this.Property(t => t.ar_bill_crtdt).HasColumnName("ar_bill_crtdt");
            this.Property(t => t.ar_bill_name).HasColumnName("ar_bill_name");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
            this.Property(t => t.ar_bill_catgy).HasColumnName("ar_bill_catgy");
            this.Property(t => t.ar_bill_holdf).HasColumnName("ar_bill_holdf");
            this.Property(t => t.ar_bill_avgdp).HasColumnName("ar_bill_avgdp");
            this.Property(t => t.ar_bill_autoinv).HasColumnName("ar_bill_autoinv");
            this.Property(t => t.ar_bill_stdte).HasColumnName("ar_bill_stdte");
            this.Property(t => t.ar_bill_stmtf).HasColumnName("ar_bill_stmtf");
            this.Property(t => t.ar_bill_taxf).HasColumnName("ar_bill_taxf");
            this.Property(t => t.ar_bill_exemno).HasColumnName("ar_bill_exemno");
            this.Property(t => t.ar_bill_exemdt).HasColumnName("ar_bill_exemdt");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.ar_bill_upcnt).HasColumnName("ar_bill_upcnt");
            this.Property(t => t.ar_bill_dunflag).HasColumnName("ar_bill_dunflag");
            this.Property(t => t.en_lang_key).HasColumnName("en_lang_key");
            this.Property(t => t.ar_duncyc_key).HasColumnName("ar_duncyc_key");
            this.Property(t => t.ar_bill_lastdundt).HasColumnName("ar_bill_lastdundt");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.gl_doccd_key).HasColumnName("gl_doccd_key");
            this.Property(t => t.ar_bill_curf).HasColumnName("ar_bill_curf");
            this.Property(t => t.ar_bill_regid).HasColumnName("ar_bill_regid");
            this.Property(t => t.ar_bill_type).HasColumnName("ar_bill_type");
            this.Property(t => t.gl_vatcd_qlf).HasColumnName("gl_vatcd_qlf");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.ar_bill_declp).HasColumnName("ar_bill_declp");
            this.Property(t => t.ar_bill_exsus).HasColumnName("ar_bill_exsus");
            this.Property(t => t.ar_bill_lmtamtc).HasColumnName("ar_bill_lmtamtc");
            this.Property(t => t.ar_bill_lmtdt).HasColumnName("ar_bill_lmtdt");
            this.Property(t => t.ar_bill_ytdlmtc).HasColumnName("ar_bill_ytdlmtc");
            this.Property(t => t.ar_bill_nodrftc).HasColumnName("ar_bill_nodrftc");
            this.Property(t => t.ar_bill_nodrftcf).HasColumnName("ar_bill_nodrftcf");
            this.Property(t => t.ar_bill_padraft).HasColumnName("ar_bill_padraft");
            this.Property(t => t.ar_bill_intvndno).HasColumnName("ar_bill_intvndno");
            this.Property(t => t.ar_bill_crdttolf).HasColumnName("ar_bill_crdttolf");
            this.Property(t => t.ar_bill_crdtlmtwng).HasColumnName("ar_bill_crdtlmtwng");
            this.Property(t => t.ar_bill_crdtrep).HasColumnName("ar_bill_crdtrep");
            this.Property(t => t.en_riskcode_key).HasColumnName("en_riskcode_key");
            this.Property(t => t.ar_bill_pstdueamtf).HasColumnName("ar_bill_pstdueamtf");
            this.Property(t => t.ar_bill_pstdueamt).HasColumnName("ar_bill_pstdueamt");
            this.Property(t => t.ar_bill_pstduedays).HasColumnName("ar_bill_pstduedays");
            this.Property(t => t.ar_bill_pstdueprdf).HasColumnName("ar_bill_pstdueprdf");
            this.Property(t => t.ar_bill_maxordramt).HasColumnName("ar_bill_maxordramt");
            this.Property(t => t.ar_bill_holdresn).HasColumnName("ar_bill_holdresn");
            this.Property(t => t.ar_bill_holdefctdt).HasColumnName("ar_bill_holdefctdt");
            this.Property(t => t.ar_bill_lcrdtrevdt).HasColumnName("ar_bill_lcrdtrevdt");
            this.Property(t => t.ar_bill_ncrdtrevdt).HasColumnName("ar_bill_ncrdtrevdt");
            this.Property(t => t.ar_bill_incdisitmf).HasColumnName("ar_bill_incdisitmf");
            this.Property(t => t.ar_bill_incrdtmgtf).HasColumnName("ar_bill_incrdtmgtf");
            this.Property(t => t.ar_bill_crdtcrncy).HasColumnName("ar_bill_crdtcrncy");
            this.Property(t => t.ar_bill_crdtexp).HasColumnName("ar_bill_crdtexp");
            this.Property(t => t.ar_bill_crdtexpdt).HasColumnName("ar_bill_crdtexpdt");
            this.Property(t => t.ar_bill_crdttol).HasColumnName("ar_bill_crdttol");
            this.Property(t => t.ar_bill_manualf).HasColumnName("ar_bill_manualf");
            this.Property(t => t.ar_bill_ccaudit).HasColumnName("ar_bill_ccaudit");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.ar_paygrp_key).HasColumnName("ar_paygrp_key");
            this.Property(t => t.ar_bill_dfltbk).HasColumnName("ar_bill_dfltbk");
            this.Property(t => t.gl_cmp_recv).HasColumnName("gl_cmp_recv");
            this.Property(t => t.ar_bill_cmtacct).HasColumnName("ar_bill_cmtacct");
            this.Property(t => t.en_vatmthd_key).HasColumnName("en_vatmthd_key");
            this.Property(t => t.ar_ivdelcd_key).HasColumnName("ar_ivdelcd_key");
        }
    }
}
