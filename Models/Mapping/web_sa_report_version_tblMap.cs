using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class web_sa_report_version_tblMap : EntityTypeConfiguration<web_sa_report_version_tbl>
    {
        public web_sa_report_version_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.sa_report_version);

            // Properties
            this.Property(t => t.sa_report_version)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sa_report_version_desc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("web_sa_report_version_tbl");
            this.Property(t => t.sa_report_version).HasColumnName("sa_report_version");
            this.Property(t => t.sa_report_version_desc).HasColumnName("sa_report_version_desc");
        }
    }
}
