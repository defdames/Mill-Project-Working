using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class cash_receipts_journal3Map : EntityTypeConfiguration<cash_receipts_journal3>
    {
        public cash_receipts_journal3Map()
        {
            // Primary Key
            this.HasKey(t => t.gl_cmp_key);

            // Properties
            this.Property(t => t.gl_interface_docno)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("cash_receipts_journal3");
            this.Property(t => t.Amt).HasColumnName("Amt");
            this.Property(t => t.gl_interface_docno).HasColumnName("gl_interface_docno");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
