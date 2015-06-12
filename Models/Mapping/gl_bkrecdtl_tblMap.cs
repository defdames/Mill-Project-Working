using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_bkrecdtl_tblMap : EntityTypeConfiguration<gl_bkrecdtl_tbl>
    {
        public gl_bkrecdtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ap_bank_key, t.ap_bank_acctno, t.gl_bkrec_stmtdt, t.gl_bkrecdtl_chkno, t.gl_bkrecdtl_pyrcft, t.gl_paycd_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_bank_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ap_bank_acctno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_bkrecdtl_chkno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_remtbill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_bkrecdtl_pyrcft)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_bkrecdtl_stat)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_bkrecdtl_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.gl_bkrecdtl_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("gl_bkrecdtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ap_bank_key).HasColumnName("ap_bank_key");
            this.Property(t => t.ap_bank_acctno).HasColumnName("ap_bank_acctno");
            this.Property(t => t.gl_bkrec_stmtdt).HasColumnName("gl_bkrec_stmtdt");
            this.Property(t => t.gl_bkrecdtl_chkno).HasColumnName("gl_bkrecdtl_chkno");
            this.Property(t => t.gl_remtbill_key).HasColumnName("gl_remtbill_key");
            this.Property(t => t.gl_bkrecdtl_pyrcft).HasColumnName("gl_bkrecdtl_pyrcft");
            this.Property(t => t.gl_bkrecdtl_chkamt).HasColumnName("gl_bkrecdtl_chkamt");
            this.Property(t => t.gl_bkrecdtl_stat).HasColumnName("gl_bkrecdtl_stat");
            this.Property(t => t.gl_bkrecdtl_upcnt).HasColumnName("gl_bkrecdtl_upcnt");
            this.Property(t => t.gl_bkrecdtl_date).HasColumnName("gl_bkrecdtl_date");
            this.Property(t => t.gl_bkrecdtl_desc).HasColumnName("gl_bkrecdtl_desc");
            this.Property(t => t.gl_bkrecdtl_type).HasColumnName("gl_bkrecdtl_type");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.gl_bkrecdtl_ckamtf).HasColumnName("gl_bkrecdtl_ckamtf");
            this.Property(t => t.gl_bkrecdtl_rate).HasColumnName("gl_bkrecdtl_rate");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.gl_bkrecdt_origto3).HasColumnName("gl_bkrecdt_origto3");
            this.Property(t => t.gl_bkrecdtl_tobase).HasColumnName("gl_bkrecdtl_tobase");
            this.Property(t => t.gl_bkrecdtl_asofdt).HasColumnName("gl_bkrecdtl_asofdt");
        }
    }
}
