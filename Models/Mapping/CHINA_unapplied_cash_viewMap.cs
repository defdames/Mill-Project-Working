using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_unapplied_cash_viewMap : EntityTypeConfiguration<CHINA_unapplied_cash_view>
    {
        public CHINA_unapplied_cash_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ar_chek_key, t.ar_bill_name, t.ar_chek_refno, t.ar_chek_amt });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_chek_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ar_chek_refno)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.gl_paycd_key)
                .HasMaxLength(2);

            this.Property(t => t.en_cust_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CHINA_unapplied_cash_view");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_chek_key).HasColumnName("ar_chek_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_bill_name).HasColumnName("ar_bill_name");
            this.Property(t => t.tran_date_key).HasColumnName("tran_date_key");
            this.Property(t => t.ar_chek_refno).HasColumnName("ar_chek_refno");
            this.Property(t => t.ar_chek_amt).HasColumnName("ar_chek_amt");
            this.Property(t => t.unapplied_amount).HasColumnName("unapplied_amount");
            this.Property(t => t.gl_paycd_key).HasColumnName("gl_paycd_key");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.ar_chek_onacctf).HasColumnName("ar_chek_onacctf");
        }
    }
}
