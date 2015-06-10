using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class BGL_Department_MultiCompanyMap : EntityTypeConfiguration<BGL_Department_MultiCompany>
    {
        public BGL_Department_MultiCompanyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Type, t.Class, t.Acct, t.AcctDesc, t.Deb_Cred, t.PeriodID, t.RTYPE, t.gl_class_key2, t.hdept, t.gl_class_key5, t.gl_cmp_key });

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

            this.Property(t => t.PeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClassDesc)
                .HasMaxLength(37);

            this.Property(t => t.TypeDesc)
                .HasMaxLength(30);

            this.Property(t => t.RTYPE)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.gl_class_key2)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.hdept)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bname)
                .HasMaxLength(5);

            this.Property(t => t.gl_class_key5)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("BGL_Department_MultiCompany");
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
            this.Property(t => t.RTYPE).HasColumnName("RTYPE");
            this.Property(t => t.gl_class_key2).HasColumnName("gl_class_key2");
            this.Property(t => t.hdept).HasColumnName("hdept");
            this.Property(t => t.bname).HasColumnName("bname");
            this.Property(t => t.gl_class_key5).HasColumnName("gl_class_key5");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
