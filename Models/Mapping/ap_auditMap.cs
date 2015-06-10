using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_auditMap : EntityTypeConfiguration<ap_audit>
    {
        public ap_auditMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VoucherNo, t.PONo, t.VoucherDate, t.VoucherAmt });

            // Properties
            this.Property(t => t.VoucherNo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.VendorName)
                .HasMaxLength(30);

            this.Property(t => t.PONo)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ap_audit");
            this.Property(t => t.VoucherNo).HasColumnName("VoucherNo");
            this.Property(t => t.VendorName).HasColumnName("VendorName");
            this.Property(t => t.PONo).HasColumnName("PONo");
            this.Property(t => t.VoucherDate).HasColumnName("VoucherDate");
            this.Property(t => t.VoucherAmt).HasColumnName("VoucherAmt");
            this.Property(t => t.VoucherMo).HasColumnName("VoucherMo");
            this.Property(t => t.VoucherYr).HasColumnName("VoucherYr");
        }
    }
}
