using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class cpm_adage_interco_viewMap : EntityTypeConfiguration<cpm_adage_interco_view>
    {
        public cpm_adage_interco_viewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.company, t.year, t.version, t.gaap_adj, t.department });

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

            this.Property(t => t.AffiliatedCompany)
                .HasMaxLength(200);

            this.Property(t => t.Currency)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("cpm_adage_interco_view");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.account).HasColumnName("account");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.period).HasColumnName("period");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.gaap_adj).HasColumnName("gaap adj");
            this.Property(t => t.department).HasColumnName("department");
            this.Property(t => t.AffiliatedCompany).HasColumnName("AffiliatedCompany");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.amount).HasColumnName("amount");
        }
    }
}
