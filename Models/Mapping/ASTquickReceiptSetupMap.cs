using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ASTquickReceiptSetupMap : EntityTypeConfiguration<ASTquickReceiptSetup>
    {
        public ASTquickReceiptSetupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.receiptCompanyKey, t.receiptBranchKey, t.receiptVendorKey, t.shipCompanyKey, t.shipCustomerKey });

            // Properties
            this.Property(t => t.receiptCompanyKey)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.receiptBranchKey)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.receiptVendorKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.shipCompanyKey)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.shipCustomerKey)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ASTquickReceiptSetup");
            this.Property(t => t.receiptCompanyKey).HasColumnName("receiptCompanyKey");
            this.Property(t => t.receiptBranchKey).HasColumnName("receiptBranchKey");
            this.Property(t => t.receiptVendorKey).HasColumnName("receiptVendorKey");
            this.Property(t => t.shipCompanyKey).HasColumnName("shipCompanyKey");
            this.Property(t => t.shipCustomerKey).HasColumnName("shipCustomerKey");
        }
    }
}
