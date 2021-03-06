using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class voucher_register_20_tbl_boMap : EntityTypeConfiguration<voucher_register_20_tbl_bo>
    {
        public voucher_register_20_tbl_boMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VKey, t.VType, t.AcctKey, t.DCType, t.glamt });

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

            this.Property(t => t.DCType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.company)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("voucher_register_20_tbl_bo");
            this.Property(t => t.VKey).HasColumnName("VKey");
            this.Property(t => t.VType).HasColumnName("VType");
            this.Property(t => t.AcctKey).HasColumnName("AcctKey");
            this.Property(t => t.DCType).HasColumnName("DCType");
            this.Property(t => t.glamt).HasColumnName("glamt");
            this.Property(t => t.seq).HasColumnName("seq");
            this.Property(t => t.company).HasColumnName("company");
        }
    }
}
