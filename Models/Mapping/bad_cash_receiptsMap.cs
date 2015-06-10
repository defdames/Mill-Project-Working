using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class bad_cash_receiptsMap : EntityTypeConfiguration<bad_cash_receipts>
    {
        public bad_cash_receiptsMap()
        {
            // Primary Key
            this.HasKey(t => t.gl_cmp_key);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_interface_docno)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("bad_cash_receipts");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_interface_docno).HasColumnName("gl_interface_docno");
            this.Property(t => t.unapplied).HasColumnName("unapplied");
            this.Property(t => t.tran_date_key).HasColumnName("tran_date_key");
        }
    }
}
