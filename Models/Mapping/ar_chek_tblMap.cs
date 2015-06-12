using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_chek_tblMap : EntityTypeConfiguration<ar_chek_tbl>
    {
        public ar_chek_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ar_chek_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_chek_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .HasMaxLength(10);

            this.Property(t => t.ar_chek_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_chek_refno)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.ap_bank_key)
                .HasMaxLength(20);

            this.Property(t => t.ap_bank_acctno)
                .HasMaxLength(20);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ar_chek_stat)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_chek_dbank)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ar_chek_dbrch)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_chek_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ar_drafts_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_paycd_key)
                .HasMaxLength(2);

            this.Property(t => t.ar_batch_key)
                .HasMaxLength(10);

            this.Property(t => t.en_cust_key)
                .HasMaxLength(10);

            this.Property(t => t.ar_chek_lboxno)
                .HasMaxLength(10);

            this.Property(t => t.ar_chek_onacctbill)
                .HasMaxLength(10);

            this.Property(t => t.gl_bkcd_key)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ar_chek_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ar_chek_key).HasColumnName("ar_chek_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.tran_date_key).HasColumnName("tran_date_key");
            this.Property(t => t.comp_date_key).HasColumnName("comp_date_key");
            this.Property(t => t.ar_chek_type).HasColumnName("ar_chek_type");
            this.Property(t => t.ar_chek_refno).HasColumnName("ar_chek_refno");
            this.Property(t => t.ap_bank_key).HasColumnName("ap_bank_key");
            this.Property(t => t.ap_bank_acctno).HasColumnName("ap_bank_acctno");
            this.Property(t => t.ar_chek_amt).HasColumnName("ar_chek_amt");
            this.Property(t => t.ar_chek_amtf).HasColumnName("ar_chek_amtf");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.ar_chek_rate).HasColumnName("ar_chek_rate");
            this.Property(t => t.ar_chek_stat).HasColumnName("ar_chek_stat");
            this.Property(t => t.ar_chek_dbank).HasColumnName("ar_chek_dbank");
            this.Property(t => t.ar_chek_dbrch).HasColumnName("ar_chek_dbrch");
            this.Property(t => t.ar_chek_expdt).HasColumnName("ar_chek_expdt");
            this.Property(t => t.ar_chek_remk).HasColumnName("ar_chek_remk");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.ar_chek_chgdt).HasColumnName("ar_chek_chgdt");
            this.Property(t => t.ar_chek_crtdt).HasColumnName("ar_chek_crtdt");
            this.Property(t => t.ar_chek_duedt).HasColumnName("ar_chek_duedt");
            this.Property(t => t.ar_chek_upcnt).HasColumnName("ar_chek_upcnt");
            this.Property(t => t.ar_chek_stdte).HasColumnName("ar_chek_stdte");
            this.Property(t => t.ar_chek_presdt).HasColumnName("ar_chek_presdt");
            this.Property(t => t.ar_drafts_key).HasColumnName("ar_drafts_key");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.ar_chek_payst).HasColumnName("ar_chek_payst");
            this.Property(t => t.ar_chek_origto3).HasColumnName("ar_chek_origto3");
            this.Property(t => t.ar_chek_tobase).HasColumnName("ar_chek_tobase");
            this.Property(t => t.ar_chek_asofdt).HasColumnName("ar_chek_asofdt");
            this.Property(t => t.ar_batch_key).HasColumnName("ar_batch_key");
            this.Property(t => t.ar_chek_manf).HasColumnName("ar_chek_manf");
            this.Property(t => t.ar_chek_onacctf).HasColumnName("ar_chek_onacctf");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.ar_chek_lboxno).HasColumnName("ar_chek_lboxno");
            this.Property(t => t.ar_chek_ratetobtch).HasColumnName("ar_chek_ratetobtch");
            this.Property(t => t.ar_chek_onacctbill).HasColumnName("ar_chek_onacctbill");
            this.Property(t => t.ar_chek_onacctcf).HasColumnName("ar_chek_onacctcf");
            this.Property(t => t.ar_chek_bnkclr).HasColumnName("ar_chek_bnkclr");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.ar_chek_amtfb).HasColumnName("ar_chek_amtfb");
            this.Property(t => t.ar_chek_deductcf).HasColumnName("ar_chek_deductcf");
            this.Property(t => t.gl_bank_key).HasColumnName("gl_bank_key");
            this.Property(t => t.ar_chek_stmtdt).HasColumnName("ar_chek_stmtdt");
            this.Property(t => t.ar_chek_appamt).HasColumnName("ar_chek_appamt");
            this.Property(t => t.ar_chek_appamtf).HasColumnName("ar_chek_appamtf");
            this.Property(t => t.ar_chek_cramt).HasColumnName("ar_chek_cramt");
            this.Property(t => t.ar_chek_cramtf).HasColumnName("ar_chek_cramtf");
            this.Property(t => t.ar_chek_deduct).HasColumnName("ar_chek_deduct");
            this.Property(t => t.ar_chek_date).HasColumnName("ar_chek_date");
        }
    }
}
