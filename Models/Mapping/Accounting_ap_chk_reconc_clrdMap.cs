using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Accounting_ap_chk_reconc_clrdMap : EntityTypeConfiguration<Accounting_ap_chk_reconc_clrd>
    {
        public Accounting_ap_chk_reconc_clrdMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Ven_num, t.Chk_amt, t.ap_payhdr_stats, t.gl_cmp_key });

            // Properties
            this.Property(t => t.Chk_num)
                .HasMaxLength(20);

            this.Property(t => t.Ven_num)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Ven_nam)
                .HasMaxLength(30);

            this.Property(t => t.Clrd_outst)
                .HasMaxLength(10);

            this.Property(t => t.ap_payhdr_stats)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Bank)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Accounting_ap_chk_reconc_clrd");
            this.Property(t => t.Chk_num).HasColumnName("Chk_num");
            this.Property(t => t.Chk_dte).HasColumnName("Chk_dte");
            this.Property(t => t.Ven_num).HasColumnName("Ven_num");
            this.Property(t => t.Ven_nam).HasColumnName("Ven_nam");
            this.Property(t => t.Chk_amt).HasColumnName("Chk_amt");
            this.Property(t => t.Clrd_outst).HasColumnName("Clrd_outst");
            this.Property(t => t.Dat_Clrd).HasColumnName("Dat_Clrd");
            this.Property(t => t.ap_payhdr_stats).HasColumnName("ap_payhdr_stats");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.Bank).HasColumnName("Bank");
        }
    }
}
