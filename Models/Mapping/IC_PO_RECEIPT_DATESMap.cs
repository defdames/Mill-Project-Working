using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class IC_PO_RECEIPT_DATESMap : EntityTypeConfiguration<IC_PO_RECEIPT_DATES>
    {
        public IC_PO_RECEIPT_DATESMap()
        {
            // Primary Key
            this.HasKey(t => t.po_number);

            // Properties
            this.Property(t => t.po_number)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IC_PO_RECEIPT_DATES");
            this.Property(t => t.po_number).HasColumnName("po_number");
            this.Property(t => t.receipt_date).HasColumnName("receipt_date");
        }
    }
}
