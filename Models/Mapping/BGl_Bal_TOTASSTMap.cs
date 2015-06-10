using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class BGl_Bal_TOTASSTMap : EntityTypeConfiguration<BGl_Bal_TOTASST>
    {
        public BGl_Bal_TOTASSTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Acct, t.Type, t.Class, t.AcctDesc, t.gl_acct_dbcrf, t.TypeDesc, t.RTYPE });

            // Properties
            this.Property(t => t.Acct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Class)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.AcctDesc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_acct_dbcrf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TypeDesc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ClassDes)
                .HasMaxLength(30);

            this.Property(t => t.AcctSort)
                .HasMaxLength(5);

            this.Property(t => t.RTYPE)
                .IsRequired()
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("BGl_Bal_TOTASST");
            this.Property(t => t.Acct).HasColumnName("Acct");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Class).HasColumnName("Class");
            this.Property(t => t.AcctDesc).HasColumnName("AcctDesc");
            this.Property(t => t.gl_acct_dbcrf).HasColumnName("gl_acct_dbcrf");
            this.Property(t => t.PeriodYR).HasColumnName("PeriodYR");
            this.Property(t => t.PeriodID).HasColumnName("PeriodID");
            this.Property(t => t.PdBalAmt).HasColumnName("PdBalAmt");
            this.Property(t => t.PdBalOpen).HasColumnName("PdBalOpen");
            this.Property(t => t.TypeDesc).HasColumnName("TypeDesc");
            this.Property(t => t.ClassDes).HasColumnName("ClassDes");
            this.Property(t => t.AcctSort).HasColumnName("AcctSort");
            this.Property(t => t.RTYPE).HasColumnName("RTYPE");
        }
    }
}
