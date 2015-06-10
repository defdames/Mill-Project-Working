using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_GL_Inc_NewCostsalesMap : EntityTypeConfiguration<CHINA_GL_Inc_NewCostsales>
    {
        public CHINA_GL_Inc_NewCostsalesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Type, t.Class, t.AcctDesc, t.Deb_Cred, t.htype, t.htype1, t.htype2, t.htype3, t.gl_cmp_key });

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Class)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.shortacct)
                .HasMaxLength(37);

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

            this.Property(t => t.htype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.htype1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.htype2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.htype3)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Acct)
                .HasMaxLength(40);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_GL_Inc_NewCostsales");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Class).HasColumnName("Class");
            this.Property(t => t.shortacct).HasColumnName("shortacct");
            this.Property(t => t.AcctDesc).HasColumnName("AcctDesc");
            this.Property(t => t.Deb_Cred).HasColumnName("Deb_Cred");
            this.Property(t => t.PeriodYR).HasColumnName("PeriodYR");
            this.Property(t => t.PeriodID).HasColumnName("PeriodID");
            this.Property(t => t.PdBalAmt).HasColumnName("PdBalAmt");
            this.Property(t => t.PdBalOpen).HasColumnName("PdBalOpen");
            this.Property(t => t.ClassDesc).HasColumnName("ClassDesc");
            this.Property(t => t.TypeDesc).HasColumnName("TypeDesc");
            this.Property(t => t.htype).HasColumnName("htype");
            this.Property(t => t.htype1).HasColumnName("htype1");
            this.Property(t => t.htype2).HasColumnName("htype2");
            this.Property(t => t.htype3).HasColumnName("htype3");
            this.Property(t => t.Acct).HasColumnName("Acct");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
