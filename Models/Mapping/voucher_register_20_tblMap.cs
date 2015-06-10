using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class voucher_register_20_tblMap : EntityTypeConfiguration<voucher_register_20_tbl>
    {
        public voucher_register_20_tblMap()
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

            // Table & Column Mappings
            this.ToTable("voucher_register_20_tbl");
            this.Property(t => t.VKey).HasColumnName("VKey");
            this.Property(t => t.VType).HasColumnName("VType");
            this.Property(t => t.AcctKey).HasColumnName("AcctKey");
            this.Property(t => t.DCType).HasColumnName("DCType");
            this.Property(t => t.glamt).HasColumnName("glamt");
            this.Property(t => t.seq).HasColumnName("seq");
        }
    }
}
