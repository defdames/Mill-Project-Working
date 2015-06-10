using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_unvouchered_receipts_pdbalMap : EntityTypeConfiguration<CHINA_unvouchered_receipts_pdbal>
    {
        public CHINA_unvouchered_receipts_pdbalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Acct, t.gl_cmp_key });

            // Properties
            this.Property(t => t.Acct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_unvouchered_receipts_pdbal");
            this.Property(t => t.Acct).HasColumnName("Acct");
            this.Property(t => t.PdBalAmt).HasColumnName("PdBalAmt");
            this.Property(t => t.PdStartDate).HasColumnName("PdStartDate");
            this.Property(t => t.PdEndDate).HasColumnName("PdEndDate");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
