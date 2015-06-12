using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_payments_SLLMap : EntityTypeConfiguration<ap_payments_SLL>
    {
        public ap_payments_SLLMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ap_remt_key, t.amount, t.VATamt, t.gl_cmp_key });

            // Properties
            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_remt_name)
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ap_payments SLL");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.ap_remt_name).HasColumnName("ap_remt_name");
            this.Property(t => t.ap_vchr_pysldt).HasColumnName("ap_vchr_pysldt");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.VATamt).HasColumnName("VATamt");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
