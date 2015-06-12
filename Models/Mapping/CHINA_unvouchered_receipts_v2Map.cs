using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_unvouchered_receipts_v2Map : EntityTypeConfiguration<CHINA_unvouchered_receipts_v2>
    {
        public CHINA_unvouchered_receipts_v2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Seq, t.Acct, t.DocType, t.DocDate, t.gl_cmp_key });

            // Properties
            this.Property(t => t.Seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Acct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.DocNo)
                .HasMaxLength(10);

            this.Property(t => t.DocType)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.POKey)
                .HasMaxLength(10);

            this.Property(t => t.VendKey)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_unvouchered_receipts_v2");
            this.Property(t => t.Seq).HasColumnName("Seq");
            this.Property(t => t.Acct).HasColumnName("Acct");
            this.Property(t => t.DocNo).HasColumnName("DocNo");
            this.Property(t => t.DocType).HasColumnName("DocType");
            this.Property(t => t.DocDate).HasColumnName("DocDate");
            this.Property(t => t.POKey).HasColumnName("POKey");
            this.Property(t => t.Amt).HasColumnName("Amt");
            this.Property(t => t.GlDate).HasColumnName("GlDate");
            this.Property(t => t.PODate).HasColumnName("PODate");
            this.Property(t => t.POStatus).HasColumnName("POStatus");
            this.Property(t => t.VendKey).HasColumnName("VendKey");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
