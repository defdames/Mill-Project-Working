using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_aragingMap : EntityTypeConfiguration<CHINA_araging>
    {
        public CHINA_aragingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sequence_number, t.BillName, t.Terms, t.HdrKey, t.Type, t.gl_cmp_key });

            // Properties
            this.Property(t => t.sequence_number)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.BillTo)
                .HasMaxLength(10);

            this.Property(t => t.CustPONo)
                .HasMaxLength(25);

            this.Property(t => t.BillName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Terms)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.HdrKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.im_adres_tel)
                .HasMaxLength(20);

            this.Property(t => t.im_adres_itnet)
                .HasMaxLength(300);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.SalesOrder)
                .HasMaxLength(10);

            this.Property(t => t.RedNumber)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CHINA_araging");
            this.Property(t => t.sequence_number).HasColumnName("sequence_number");
            this.Property(t => t.BillTo).HasColumnName("BillTo");
            this.Property(t => t.CustPONo).HasColumnName("CustPONo");
            this.Property(t => t.BillName).HasColumnName("BillName");
            this.Property(t => t.LstPayDate).HasColumnName("LstPayDate");
            this.Property(t => t.Terms).HasColumnName("Terms");
            this.Property(t => t.CreditLimit).HasColumnName("CreditLimit");
            this.Property(t => t.HdrKey).HasColumnName("HdrKey");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.im_adres_tel).HasColumnName("im_adres_tel");
            this.Property(t => t.im_adres_itnet).HasColumnName("im_adres_itnet");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.SalesOrder).HasColumnName("SalesOrder");
            this.Property(t => t.RedNumber).HasColumnName("RedNumber");
        }
    }
}
