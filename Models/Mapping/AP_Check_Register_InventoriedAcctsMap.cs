using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class AP_Check_Register_InventoriedAcctsMap : EntityTypeConfiguration<AP_Check_Register_InventoriedAccts>
    {
        public AP_Check_Register_InventoriedAcctsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Ven_num, t.Ven_nam, t.gl_cmp_key });

            // Properties
            this.Property(t => t.Chk_num)
                .HasMaxLength(20);

            this.Property(t => t.Ven_num)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Invnum)
                .HasMaxLength(30);

            this.Property(t => t.Ven_nam)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CkStat)
                .HasMaxLength(1);

            this.Property(t => t.Clrd_outst)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("AP_Check_Register_InventoriedAccts");
            this.Property(t => t.Chk_num).HasColumnName("Chk_num");
            this.Property(t => t.Chk_dte).HasColumnName("Chk_dte");
            this.Property(t => t.Ven_num).HasColumnName("Ven_num");
            this.Property(t => t.Pay_Amt).HasColumnName("Pay_Amt");
            this.Property(t => t.Discamt).HasColumnName("Discamt");
            this.Property(t => t.Voucher_amt).HasColumnName("Voucher_amt");
            this.Property(t => t.Invnum).HasColumnName("Invnum");
            this.Property(t => t.InvDate).HasColumnName("InvDate");
            this.Property(t => t.Ven_nam).HasColumnName("Ven_nam");
            this.Property(t => t.CkStat).HasColumnName("CkStat");
            this.Property(t => t.Chk_amt).HasColumnName("Chk_amt");
            this.Property(t => t.Clrd_outst).HasColumnName("Clrd_outst");
            this.Property(t => t.Dat_Clrd).HasColumnName("Dat_Clrd");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
