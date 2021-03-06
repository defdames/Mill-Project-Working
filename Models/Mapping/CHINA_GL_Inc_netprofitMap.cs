using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_GL_Inc_netprofitMap : EntityTypeConfiguration<CHINA_GL_Inc_netprofit>
    {
        public CHINA_GL_Inc_netprofitMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Type, t.Class, t.Acct, t.AcctDesc, t.Deb_Cred, t.gl_cmp_key });

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Class)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Acct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.AcctDesc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Deb_Cred)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ClassDesc)
                .HasMaxLength(30);

            this.Property(t => t.TypeDesc)
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_GL_Inc_netprofit");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Class).HasColumnName("Class");
            this.Property(t => t.Acct).HasColumnName("Acct");
            this.Property(t => t.AcctDesc).HasColumnName("AcctDesc");
            this.Property(t => t.Deb_Cred).HasColumnName("Deb_Cred");
            this.Property(t => t.PeriodYR).HasColumnName("PeriodYR");
            this.Property(t => t.PeriodID).HasColumnName("PeriodID");
            this.Property(t => t.PdBalAmt).HasColumnName("PdBalAmt");
            this.Property(t => t.PdBalOpen).HasColumnName("PdBalOpen");
            this.Property(t => t.ClassDesc).HasColumnName("ClassDesc");
            this.Property(t => t.TypeDesc).HasColumnName("TypeDesc");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
