using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class voucher_register_30_tblMap : EntityTypeConfiguration<voucher_register_30_tbl>
    {
        public voucher_register_30_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.po_hdr_key, t.po_tran_docno, t.po_tran_dbcrf, t.gl_acct_key, t.amt });

            // Properties
            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_tran_docno)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_tran_dbcrf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("voucher_register_30_tbl");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_tran_docno).HasColumnName("po_tran_docno");
            this.Property(t => t.po_tran_dbcrf).HasColumnName("po_tran_dbcrf");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.amt).HasColumnName("amt");
        }
    }
}
