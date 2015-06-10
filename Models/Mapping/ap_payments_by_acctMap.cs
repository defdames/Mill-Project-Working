using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_payments_by_acctMap : EntityTypeConfiguration<ap_payments_by_acct>
    {
        public ap_payments_by_acctMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ap_payhdr_entid, t.ap_payhdr_entnm, t.ap_payhdr_stats, t.gl_acct_key, t.gl_intface_dbamtcf, t.gl_intface_cramtcf, t.gl_cmp_key });

            // Properties
            this.Property(t => t.ap_payhdr_entid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_payhdr_entnm)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ap_payhdr_stats)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.po_hdr_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ap_payments_by_acct");
            this.Property(t => t.ap_payhdr_entid).HasColumnName("ap_payhdr_entid");
            this.Property(t => t.ap_payhdr_entnm).HasColumnName("ap_payhdr_entnm");
            this.Property(t => t.ap_payhdr_stats).HasColumnName("ap_payhdr_stats");
            this.Property(t => t.ap_payhdr_paydt).HasColumnName("ap_payhdr_paydt");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.gl_intface_dbamtcf).HasColumnName("gl_intface_dbamtcf");
            this.Property(t => t.gl_intface_cramtcf).HasColumnName("gl_intface_cramtcf");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
        }
    }
}
