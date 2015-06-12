using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class voucher_register_10_tblMap : EntityTypeConfiguration<voucher_register_10_tbl>
    {
        public voucher_register_10_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VKey, t.VType, t.AcctKey, t.AcctDesc, t.amt });

            // Properties
            this.Property(t => t.VKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.VType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.AcctKey)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.AcctDesc)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("voucher_register_10_tbl");
            this.Property(t => t.VKey).HasColumnName("VKey");
            this.Property(t => t.VType).HasColumnName("VType");
            this.Property(t => t.AcctKey).HasColumnName("AcctKey");
            this.Property(t => t.AcctDesc).HasColumnName("AcctDesc");
            this.Property(t => t.amt).HasColumnName("amt");
            this.Property(t => t.seq).HasColumnName("seq");
        }
    }
}
