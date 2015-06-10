using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class cpm_adage_view_drillthruMap : EntityTypeConfiguration<cpm_adage_view_drillthru>
    {
        public cpm_adage_view_drillthruMap()
        {
            // Primary Key
            this.HasKey(t => new { t.company, t.year, t.version, t.gaap_adj, t.department, t.gl_acct_key });

            // Properties
            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.account)
                .HasMaxLength(255);

            this.Property(t => t.year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.period)
                .HasMaxLength(10);

            this.Property(t => t.version)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gaap_adj)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.department)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("cpm_adage_view_drillthru");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.account).HasColumnName("account");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.period).HasColumnName("period");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.gaap_adj).HasColumnName("gaap adj");
            this.Property(t => t.department).HasColumnName("department");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
        }
    }
}
