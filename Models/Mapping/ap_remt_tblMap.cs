using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_remt_tblMap : EntityTypeConfiguration<ap_remt_tbl>
    {
        public ap_remt_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ap_remt_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_remt_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ap_bank_acctno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ap_bank_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ap_remt_pacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ap_remt_tacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ar_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_remt_regid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_pay)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_acct_disc)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.en_1099_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ap_remt_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.ap_remt_name).HasColumnName("ap_remt_name");
            this.Property(t => t.ap_bank_acctno).HasColumnName("ap_bank_acctno");
            this.Property(t => t.ap_bank_key).HasColumnName("ap_bank_key");
            this.Property(t => t.ap_remt_crbal).HasColumnName("ap_remt_crbal");
            this.Property(t => t.ap_remt_holdf).HasColumnName("ap_remt_holdf");
            this.Property(t => t.ap_remt_invdt).HasColumnName("ap_remt_invdt");
            this.Property(t => t.ap_remt_lstpd).HasColumnName("ap_remt_lstpd");
            this.Property(t => t.ap_remt_pacct).HasColumnName("ap_remt_pacct");
            this.Property(t => t.ap_remt_paddt).HasColumnName("ap_remt_paddt");
            this.Property(t => t.ap_remt_pri).HasColumnName("ap_remt_pri");
            this.Property(t => t.ap_remt_tacct).HasColumnName("ap_remt_tacct");
            this.Property(t => t.ap_remt_unapd).HasColumnName("ap_remt_unapd");
            this.Property(t => t.ap_remt_upcnt).HasColumnName("ap_remt_upcnt");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.ar_terms_key).HasColumnName("ar_terms_key");
            this.Property(t => t.ap_remt_unapc).HasColumnName("ap_remt_unapc");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.ap_remt_1099f).HasColumnName("ap_remt_1099f");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.ap_remt_regid).HasColumnName("ap_remt_regid");
            this.Property(t => t.ap_remt_type).HasColumnName("ap_remt_type");
            this.Property(t => t.gl_vatcd_qlf).HasColumnName("gl_vatcd_qlf");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.ap_remt_declp).HasColumnName("ap_remt_declp");
            this.Property(t => t.ap_remt_recalc).HasColumnName("ap_remt_recalc");
            this.Property(t => t.ap_remt_incld).HasColumnName("ap_remt_incld");
            this.Property(t => t.ap_remt_curf).HasColumnName("ap_remt_curf");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.ap_remt_autovchf).HasColumnName("ap_remt_autovchf");
            this.Property(t => t.gl_cmp_pay).HasColumnName("gl_cmp_pay");
            this.Property(t => t.gl_acct_disc).HasColumnName("gl_acct_disc");
            this.Property(t => t.ap_remt_dfltbk).HasColumnName("ap_remt_dfltbk");
            this.Property(t => t.ap_remt_whldtaxf).HasColumnName("ap_remt_whldtaxf");
            this.Property(t => t.en_1099_key).HasColumnName("en_1099_key");
        }
    }
}
