using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_bill_tblMap : EntityTypeConfiguration<en_bill_tbl>
    {
        public en_bill_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_bill_key);

            // Properties
            this.Property(t => t.en_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_bill_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_bank_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_bank_acctno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_bill_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_bill_rslen)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_bill_catgy)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_comp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_bill_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_bill_bkact)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_bill_dbrtg)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.en_bill_dbno)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.en_bill_tacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.en_bill_dacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.en_frgt_key)
                .HasMaxLength(10);

            this.Property(t => t.en_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_doccd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_bill_intvndno)
                .HasMaxLength(10);

            this.Property(t => t.en_bill_crdtrep)
                .HasMaxLength(20);

            this.Property(t => t.en_riskcode_key)
                .HasMaxLength(20);

            this.Property(t => t.en_bill_holdresn)
                .HasMaxLength(30);

            this.Property(t => t.en_bill_crdtcrncy)
                .HasMaxLength(3);

            this.Property(t => t.en_bill_ccaudit)
                .HasMaxLength(76);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .HasMaxLength(4);

            this.Property(t => t.en_paygrp_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_bill_tbl");
            this.Property(t => t.en_bill_key).HasColumnName("en_bill_key");
            this.Property(t => t.en_bill_upcnt).HasColumnName("en_bill_upcnt");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.en_bill_name).HasColumnName("en_bill_name");
            this.Property(t => t.en_bill_dunte).HasColumnName("en_bill_dunte");
            this.Property(t => t.en_bill_chgdt).HasColumnName("en_bill_chgdt");
            this.Property(t => t.en_bill_fchgc).HasColumnName("en_bill_fchgc");
            this.Property(t => t.en_bill_clmtc).HasColumnName("en_bill_clmtc");
            this.Property(t => t.en_bank_key).HasColumnName("en_bank_key");
            this.Property(t => t.en_bank_acctno).HasColumnName("en_bank_acctno");
            this.Property(t => t.en_bill_remk).HasColumnName("en_bill_remk");
            this.Property(t => t.en_tax_key).HasColumnName("en_tax_key");
            this.Property(t => t.en_bill_rslen).HasColumnName("en_bill_rslen");
            this.Property(t => t.en_terms_key).HasColumnName("en_terms_key");
            this.Property(t => t.en_bill_catgy).HasColumnName("en_bill_catgy");
            this.Property(t => t.en_bill_taxf).HasColumnName("en_bill_taxf");
            this.Property(t => t.en_bill_holdf).HasColumnName("en_bill_holdf");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_bill_fstat).HasColumnName("en_bill_fstat");
            this.Property(t => t.en_bill_bilcy).HasColumnName("en_bill_bilcy");
            this.Property(t => t.en_bill_stmtp).HasColumnName("en_bill_stmtp");
            this.Property(t => t.en_bill_crtdt).HasColumnName("en_bill_crtdt");
            this.Property(t => t.en_crncy_key).HasColumnName("en_crncy_key");
            this.Property(t => t.en_comp_key).HasColumnName("en_comp_key");
            this.Property(t => t.en_bill_cmnts).HasColumnName("en_bill_cmnts");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_bill_bkact).HasColumnName("en_bill_bkact");
            this.Property(t => t.en_bill_dbrtg).HasColumnName("en_bill_dbrtg");
            this.Property(t => t.en_bill_dbno).HasColumnName("en_bill_dbno");
            this.Property(t => t.en_bill_avgdp).HasColumnName("en_bill_avgdp");
            this.Property(t => t.en_bill_intf).HasColumnName("en_bill_intf");
            this.Property(t => t.en_bill_tlamt).HasColumnName("en_bill_tlamt");
            this.Property(t => t.en_bill_toltp).HasColumnName("en_bill_toltp");
            this.Property(t => t.en_bill_unpdc).HasColumnName("en_bill_unpdc");
            this.Property(t => t.en_bill_avilc).HasColumnName("en_bill_avilc");
            this.Property(t => t.en_bill_depc).HasColumnName("en_bill_depc");
            this.Property(t => t.en_bill_ordrc).HasColumnName("en_bill_ordrc");
            this.Property(t => t.en_bill_lstpc).HasColumnName("en_bill_lstpc");
            this.Property(t => t.en_bill_stdsc).HasColumnName("en_bill_stdsc");
            this.Property(t => t.en_bill_tacct).HasColumnName("en_bill_tacct");
            this.Property(t => t.en_bill_dacct).HasColumnName("en_bill_dacct");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.en_lang_key).HasColumnName("en_lang_key");
            this.Property(t => t.en_bill_curf).HasColumnName("en_bill_curf");
            this.Property(t => t.en_paycd_key).HasColumnName("en_paycd_key");
            this.Property(t => t.en_doccd_key).HasColumnName("en_doccd_key");
            this.Property(t => t.en_bill_intvndno).HasColumnName("en_bill_intvndno");
            this.Property(t => t.en_bill_crdtlmtwng).HasColumnName("en_bill_crdtlmtwng");
            this.Property(t => t.en_bill_crdtrep).HasColumnName("en_bill_crdtrep");
            this.Property(t => t.en_riskcode_key).HasColumnName("en_riskcode_key");
            this.Property(t => t.en_bill_pstdueamtf).HasColumnName("en_bill_pstdueamtf");
            this.Property(t => t.en_bill_pstdueamt).HasColumnName("en_bill_pstdueamt");
            this.Property(t => t.en_bill_pstduedays).HasColumnName("en_bill_pstduedays");
            this.Property(t => t.en_bill_pstdueprdf).HasColumnName("en_bill_pstdueprdf");
            this.Property(t => t.en_bill_maxordramt).HasColumnName("en_bill_maxordramt");
            this.Property(t => t.en_bill_holdresn).HasColumnName("en_bill_holdresn");
            this.Property(t => t.en_bill_holdefctdt).HasColumnName("en_bill_holdefctdt");
            this.Property(t => t.en_bill_lcrdtrevdt).HasColumnName("en_bill_lcrdtrevdt");
            this.Property(t => t.en_bill_ncrdtrevdt).HasColumnName("en_bill_ncrdtrevdt");
            this.Property(t => t.en_bill_incrdtmgtf).HasColumnName("en_bill_incrdtmgtf");
            this.Property(t => t.en_bill_crdtcrncy).HasColumnName("en_bill_crdtcrncy");
            this.Property(t => t.en_bill_incdisitmf).HasColumnName("en_bill_incdisitmf");
            this.Property(t => t.en_bill_crdtexp).HasColumnName("en_bill_crdtexp");
            this.Property(t => t.en_bill_crdtexpdt).HasColumnName("en_bill_crdtexpdt");
            this.Property(t => t.en_bill_ccaudit).HasColumnName("en_bill_ccaudit");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.en_paygrp_key).HasColumnName("en_paygrp_key");
        }
    }
}
