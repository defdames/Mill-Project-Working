using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_paymentsMap : EntityTypeConfiguration<ap_payments>
    {
        public ap_paymentsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ap_payhdr_entid, t.ap_payhdr_entnm, t.ap_payhdr_stats, t.gl_cmp_key });

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

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ap_payments");
            this.Property(t => t.ap_payhdr_entid).HasColumnName("ap_payhdr_entid");
            this.Property(t => t.ap_payhdr_entnm).HasColumnName("ap_payhdr_entnm");
            this.Property(t => t.ap_payhdr_stats).HasColumnName("ap_payhdr_stats");
            this.Property(t => t.ap_payhdr_paydt).HasColumnName("ap_payhdr_paydt");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
