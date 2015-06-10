using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_Gl_Comparitive_Trial_BalanceMap : EntityTypeConfiguration<CHINA_Gl_Comparitive_Trial_Balance>
    {
        public CHINA_Gl_Comparitive_Trial_BalanceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CMP_Key, t.Acct_Key, t.AcctDesc, t.Class_key, t.Type, t.Yr, t.Period, t.PdOpen, t.DAmt, t.CAmt, t.DbCr, t.gl_cmp_key });

            // Properties
            this.Property(t => t.CMP_Key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Acct_Key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.AcctDesc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Class_key)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Yr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Period)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DbCr)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_Gl_Comparitive_Trial_Balance");
            this.Property(t => t.CMP_Key).HasColumnName("CMP_Key");
            this.Property(t => t.Acct_Key).HasColumnName("Acct_Key");
            this.Property(t => t.AcctDesc).HasColumnName("AcctDesc");
            this.Property(t => t.Class_key).HasColumnName("Class_key");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Yr).HasColumnName("Yr");
            this.Property(t => t.Period).HasColumnName("Period");
            this.Property(t => t.PdOpen).HasColumnName("PdOpen");
            this.Property(t => t.Amt).HasColumnName("Amt");
            this.Property(t => t.DAmt).HasColumnName("DAmt");
            this.Property(t => t.CAmt).HasColumnName("CAmt");
            this.Property(t => t.DbCr).HasColumnName("DbCr");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
