using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class web_sa_report_software_tblMap : EntityTypeConfiguration<web_sa_report_software_tbl>
    {
        public web_sa_report_software_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.sa_report_software);

            // Properties
            this.Property(t => t.sa_report_software)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("web_sa_report_software_tbl");
            this.Property(t => t.sa_report_software).HasColumnName("sa_report_software");
        }
    }
}
