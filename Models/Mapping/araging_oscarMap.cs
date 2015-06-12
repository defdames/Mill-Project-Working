using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class araging_oscarMap : EntityTypeConfiguration<araging_oscar>
    {
        public araging_oscarMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillName, t.Terms, t.HdrKey, t.Type });

            // Properties
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

            // Table & Column Mappings
            this.ToTable("araging_oscar");
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
        }
    }
}
