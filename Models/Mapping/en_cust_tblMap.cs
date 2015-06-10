using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_cust_tblMap : EntityTypeConfiguration<en_cust_tbl>
    {
        public en_cust_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_cust_key);

            // Properties
            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_cust_catgy)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_rslen)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_dbrtg)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.en_cust_dbno)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.en_cust_certf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_cust_taxf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_city)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_nactf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_cust_sdesc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_cust_remk)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.en_comp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_cust_acn)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_1cmp)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_cust_cpcde)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_sltyp_key)
                .HasMaxLength(10);

            this.Property(t => t.en_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_cust_plabelfmt)
                .HasMaxLength(20);

            this.Property(t => t.en_cust_chlabelfmt)
                .HasMaxLength(20);

            this.Property(t => t.en_cust_crdtrep)
                .HasMaxLength(20);

            this.Property(t => t.en_riskcode_key)
                .HasMaxLength(20);

            this.Property(t => t.en_cust_holdresn)
                .HasMaxLength(30);

            this.Property(t => t.en_cust_crdtcrncy)
                .HasMaxLength(3);

            this.Property(t => t.en_cust_ccaudit)
                .HasMaxLength(76);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_profit)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_profit)
                .HasMaxLength(4);

            this.Property(t => t.en_cust_gln)
                .HasMaxLength(13);

            this.Property(t => t.en_enduse_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_cust_tbl");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.en_crncy_key).HasColumnName("en_crncy_key");
            this.Property(t => t.en_terms_key).HasColumnName("en_terms_key");
            this.Property(t => t.en_cust_catgy).HasColumnName("en_cust_catgy");
            this.Property(t => t.en_cust_rslen).HasColumnName("en_cust_rslen");
            this.Property(t => t.en_cust_holdf).HasColumnName("en_cust_holdf");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_cust_fstat).HasColumnName("en_cust_fstat");
            this.Property(t => t.en_cust_dbrtg).HasColumnName("en_cust_dbrtg");
            this.Property(t => t.en_cust_dbno).HasColumnName("en_cust_dbno");
            this.Property(t => t.en_cust_cefdt).HasColumnName("en_cust_cefdt");
            this.Property(t => t.en_cust_ciadt).HasColumnName("en_cust_ciadt");
            this.Property(t => t.en_cust_dyely).HasColumnName("en_cust_dyely");
            this.Property(t => t.en_cust_auddt).HasColumnName("en_cust_auddt");
            this.Property(t => t.en_cust_audno).HasColumnName("en_cust_audno");
            this.Property(t => t.en_cust_certf).HasColumnName("en_cust_certf");
            this.Property(t => t.en_cust_taxf).HasColumnName("en_cust_taxf");
            this.Property(t => t.en_tax_key).HasColumnName("en_tax_key");
            this.Property(t => t.en_cust_city).HasColumnName("en_cust_city");
            this.Property(t => t.en_cust_state).HasColumnName("en_cust_state");
            this.Property(t => t.en_cust_nactf).HasColumnName("en_cust_nactf");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_cust_sdesc).HasColumnName("en_cust_sdesc");
            this.Property(t => t.en_cust_intf).HasColumnName("en_cust_intf");
            this.Property(t => t.en_cust_ciaf).HasColumnName("en_cust_ciaf");
            this.Property(t => t.en_cust_ptpkf).HasColumnName("en_cust_ptpkf");
            this.Property(t => t.en_cust_pshpf).HasColumnName("en_cust_pshpf");
            this.Property(t => t.en_cust_upcnt).HasColumnName("en_cust_upcnt");
            this.Property(t => t.en_cust_name).HasColumnName("en_cust_name");
            this.Property(t => t.en_cust_crtdt).HasColumnName("en_cust_crtdt");
            this.Property(t => t.en_cust_chgdt).HasColumnName("en_cust_chgdt");
            this.Property(t => t.en_cust_remk).HasColumnName("en_cust_remk");
            this.Property(t => t.en_comp_key).HasColumnName("en_comp_key");
            this.Property(t => t.ar_cust_acn).HasColumnName("ar_cust_acn");
            this.Property(t => t.en_cust_1cmp).HasColumnName("en_cust_1cmp");
            this.Property(t => t.en_cust_cpcde).HasColumnName("en_cust_cpcde");
            this.Property(t => t.en_cust_stdte).HasColumnName("en_cust_stdte");
            this.Property(t => t.en_cust_stmtf).HasColumnName("en_cust_stmtf");
            this.Property(t => t.en_cust_ntolpct).HasColumnName("en_cust_ntolpct");
            this.Property(t => t.en_cust_ptolpct).HasColumnName("en_cust_ptolpct");
            this.Property(t => t.en_cust_repricef).HasColumnName("en_cust_repricef");
            this.Property(t => t.en_cust_ntlprcpct).HasColumnName("en_cust_ntlprcpct");
            this.Property(t => t.en_cust_ptlprcpct).HasColumnName("en_cust_ptlprcpct");
            this.Property(t => t.en_sltyp_key).HasColumnName("en_sltyp_key");
            this.Property(t => t.en_cust_curf).HasColumnName("en_cust_curf");
            this.Property(t => t.en_paycd_key).HasColumnName("en_paycd_key");
            this.Property(t => t.en_cust_bcconfigf).HasColumnName("en_cust_bcconfigf");
            this.Property(t => t.en_cust_ovrridsof).HasColumnName("en_cust_ovrridsof");
            this.Property(t => t.en_cust_multipof).HasColumnName("en_cust_multipof");
            this.Property(t => t.en_cust_noprntlbs).HasColumnName("en_cust_noprntlbs");
            this.Property(t => t.en_cust_nochldlbs).HasColumnName("en_cust_nochldlbs");
            this.Property(t => t.en_cust_sndcasef).HasColumnName("en_cust_sndcasef");
            this.Property(t => t.en_cust_sndpltf).HasColumnName("en_cust_sndpltf");
            this.Property(t => t.en_cust_sndshpcntf).HasColumnName("en_cust_sndshpcntf");
            this.Property(t => t.en_cust_plabelfmt).HasColumnName("en_cust_plabelfmt");
            this.Property(t => t.en_cust_chlabelfmt).HasColumnName("en_cust_chlabelfmt");
            this.Property(t => t.en_cust_crdtlimit).HasColumnName("en_cust_crdtlimit");
            this.Property(t => t.en_cust_receivablf).HasColumnName("en_cust_receivablf");
            this.Property(t => t.en_cust_remittedf).HasColumnName("en_cust_remittedf");
            this.Property(t => t.en_cust_onorderf).HasColumnName("en_cust_onorderf");
            this.Property(t => t.en_cust_shipdordf).HasColumnName("en_cust_shipdordf");
            this.Property(t => t.en_cust_crdtlmtwng).HasColumnName("en_cust_crdtlmtwng");
            this.Property(t => t.en_cust_crdtrep).HasColumnName("en_cust_crdtrep");
            this.Property(t => t.en_riskcode_key).HasColumnName("en_riskcode_key");
            this.Property(t => t.en_cust_pstdueamtf).HasColumnName("en_cust_pstdueamtf");
            this.Property(t => t.en_cust_pstdueamt).HasColumnName("en_cust_pstdueamt");
            this.Property(t => t.en_cust_pstduedays).HasColumnName("en_cust_pstduedays");
            this.Property(t => t.en_cust_pstdueprdf).HasColumnName("en_cust_pstdueprdf");
            this.Property(t => t.en_cust_maxordramt).HasColumnName("en_cust_maxordramt");
            this.Property(t => t.en_cust_sordrhrznf).HasColumnName("en_cust_sordrhrznf");
            this.Property(t => t.en_cust_sordrhrzn).HasColumnName("en_cust_sordrhrzn");
            this.Property(t => t.en_cust_holdresn).HasColumnName("en_cust_holdresn");
            this.Property(t => t.en_cust_holdefctdt).HasColumnName("en_cust_holdefctdt");
            this.Property(t => t.en_cust_lcrdtrevdt).HasColumnName("en_cust_lcrdtrevdt");
            this.Property(t => t.en_cust_ncrdtrevdt).HasColumnName("en_cust_ncrdtrevdt");
            this.Property(t => t.en_cust_incrdtmgtf).HasColumnName("en_cust_incrdtmgtf");
            this.Property(t => t.en_cust_crdtcrncy).HasColumnName("en_cust_crdtcrncy");
            this.Property(t => t.en_cust_crdtexp).HasColumnName("en_cust_crdtexp");
            this.Property(t => t.en_cust_crdtexpdt).HasColumnName("en_cust_crdtexpdt");
            this.Property(t => t.en_cust_incdisitmf).HasColumnName("en_cust_incdisitmf");
            this.Property(t => t.en_cust_crdtrerunf).HasColumnName("en_cust_crdtrerunf");
            this.Property(t => t.en_cust_ccaudit).HasColumnName("en_cust_ccaudit");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_cmp_profit).HasColumnName("gl_cmp_profit");
            this.Property(t => t.so_brnch_profit).HasColumnName("so_brnch_profit");
            this.Property(t => t.en_cust_gln).HasColumnName("en_cust_gln");
            this.Property(t => t.en_enduse_key).HasColumnName("en_enduse_key");
        }
    }
}
