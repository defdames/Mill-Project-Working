using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_misc_tblMap : EntityTypeConfiguration<gl_misc_tbl>
    {
        public gl_misc_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_misc_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_misc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_misc_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_misc_acpay)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_misc_acrec)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.en_1099_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_misc_arvat)
                .HasMaxLength(10);

            this.Property(t => t.gl_misc_apvat)
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_acct_paych)
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_rebaccr)
                .HasMaxLength(40);

            this.Property(t => t.en_vend_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_acct_accrexp)
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_accrlia)
                .HasMaxLength(40);

            this.Property(t => t.gl_withholdcd_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("gl_misc_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_misc_key).HasColumnName("gl_misc_key");
            this.Property(t => t.gl_misc_desc).HasColumnName("gl_misc_desc");
            this.Property(t => t.gl_misc_acpay).HasColumnName("gl_misc_acpay");
            this.Property(t => t.gl_misc_acrec).HasColumnName("gl_misc_acrec");
            this.Property(t => t.gl_misc_upcnt).HasColumnName("gl_misc_upcnt");
            this.Property(t => t.gl_misc_posof).HasColumnName("gl_misc_posof");
            this.Property(t => t.gl_misc_pagronlf).HasColumnName("gl_misc_pagronlf");
            this.Property(t => t.gl_misc_freightf).HasColumnName("gl_misc_freightf");
            this.Property(t => t.gl_misc_taxf).HasColumnName("gl_misc_taxf");
            this.Property(t => t.en_1099_key).HasColumnName("en_1099_key");
            this.Property(t => t.gl_misc_rollupf).HasColumnName("gl_misc_rollupf");
            this.Property(t => t.gl_misc_arvat).HasColumnName("gl_misc_arvat");
            this.Property(t => t.gl_misc_apvat).HasColumnName("gl_misc_apvat");
            this.Property(t => t.gl_misc_aptaxf).HasColumnName("gl_misc_aptaxf");
            this.Property(t => t.gl_misc_execpropcf).HasColumnName("gl_misc_execpropcf");
            this.Property(t => t.gl_misc_execprosof).HasColumnName("gl_misc_execprosof");
            this.Property(t => t.gl_misc_execproshf).HasColumnName("gl_misc_execproshf");
            this.Property(t => t.gl_misc_adjvaluet).HasColumnName("gl_misc_adjvaluet");
            this.Property(t => t.gl_misc_commf).HasColumnName("gl_misc_commf");
            this.Property(t => t.gl_misc_marginf).HasColumnName("gl_misc_marginf");
            this.Property(t => t.gl_misc_posbasrevf).HasColumnName("gl_misc_posbasrevf");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_misc_crtdt).HasColumnName("gl_misc_crtdt");
            this.Property(t => t.gl_misc_chgdt).HasColumnName("gl_misc_chgdt");
            this.Property(t => t.gl_misc_rebatef).HasColumnName("gl_misc_rebatef");
            this.Property(t => t.gl_acct_paych).HasColumnName("gl_acct_paych");
            this.Property(t => t.gl_acct_rebaccr).HasColumnName("gl_acct_rebaccr");
            this.Property(t => t.gl_misc_arpaychf).HasColumnName("gl_misc_arpaychf");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.gl_acct_accrexp).HasColumnName("gl_acct_accrexp");
            this.Property(t => t.gl_acct_accrlia).HasColumnName("gl_acct_accrlia");
            this.Property(t => t.gl_misc_apprf).HasColumnName("gl_misc_apprf");
            this.Property(t => t.gl_misc_whldtaxf).HasColumnName("gl_misc_whldtaxf");
            this.Property(t => t.gl_withholdcd_key).HasColumnName("gl_withholdcd_key");
        }
    }
}
