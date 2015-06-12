using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pcash_receipts_journal_2_New_daily_pictureMap : EntityTypeConfiguration<pcash_receipts_journal_2_New_daily_picture>
    {
        public pcash_receipts_journal_2_New_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CheckNo, t.GlAcct, t.GlAcctName, t.CheckRefNo, t.ar_chek_key, t.gl_acct_key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.BillTo)
                .HasMaxLength(10);

            this.Property(t => t.CheckNo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GlAcct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.GlAcctName)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.CheckRefNo)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.ar_chek_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_interface_ref1)
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("pcash_receipts_journal_2_New_daily_picture");
            this.Property(t => t.BillTo).HasColumnName("BillTo");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.CrdAmt).HasColumnName("CrdAmt");
            this.Property(t => t.DbtAmt).HasColumnName("DbtAmt");
            this.Property(t => t.GlAcct).HasColumnName("GlAcct");
            this.Property(t => t.GlAcctName).HasColumnName("GlAcctName");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
            this.Property(t => t.CheckRefNo).HasColumnName("CheckRefNo");
            this.Property(t => t.ar_chek_key).HasColumnName("ar_chek_key");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.gl_interface_ref1).HasColumnName("gl_interface_ref1");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
