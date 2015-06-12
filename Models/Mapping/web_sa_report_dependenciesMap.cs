using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class web_sa_report_dependenciesMap : EntityTypeConfiguration<web_sa_report_dependencies>
    {
        public web_sa_report_dependenciesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.report_name, t.dependency, t.type });

            // Properties
            this.Property(t => t.report_name)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.dependency)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("web_sa_report_dependencies");
            this.Property(t => t.report_name).HasColumnName("report_name");
            this.Property(t => t.dependency).HasColumnName("dependency");
            this.Property(t => t.type).HasColumnName("type");
        }
    }
}
