using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_check_sum_v1_sapMap : EntityTypeConfiguration<ap_check_sum_v1_sap>
    {
        public ap_check_sum_v1_sapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Currency, t.gl_cmp_key, t.RemitTo });

            // Properties
            this.Property(t => t.CheckNo)
                .HasMaxLength(20);

            this.Property(t => t.Currency)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.RemitTo)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ap_check_sum_v1_sap");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.CheckAmt).HasColumnName("CheckAmt");
            this.Property(t => t.CheckAmtSGD).HasColumnName("CheckAmtSGD");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.RemitTo).HasColumnName("RemitTo");
        }
    }
}
