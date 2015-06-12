using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class web_sa_report_tblMap : EntityTypeConfiguration<web_sa_report_tbl>
    {
        public web_sa_report_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sa_report_name, t.sa_report_type });

            // Properties
            this.Property(t => t.sa_report_name)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.sa_report_type)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sa_report_description)
                .HasMaxLength(200);

            this.Property(t => t.sa_view_name)
                .HasMaxLength(40);

            this.Property(t => t.sa_notes)
                .HasMaxLength(200);

            this.Property(t => t.sa_paper_type)
                .HasMaxLength(50);

            this.Property(t => t.sa_report_software)
                .HasMaxLength(50);

            this.Property(t => t.sa_importance)
                .HasMaxLength(10);

            this.Property(t => t.sa_active)
                .HasMaxLength(5);

            this.Property(t => t.sa_conversion_status)
                .HasMaxLength(15);

            this.Property(t => t.sa_report_owner)
                .HasMaxLength(20);

            this.Property(t => t.sa_report_results)
                .HasMaxLength(20);

            this.Property(t => t.sa_report_version)
                .HasMaxLength(20);

            this.Property(t => t.sapliveaccess)
                .HasMaxLength(50);

            this.Property(t => t.upgrade)
                .HasMaxLength(50);

            this.Property(t => t.sa_multi_company)
                .HasMaxLength(50);

            this.Property(t => t.sa_report_format)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("web_sa_report_tbl");
            this.Property(t => t.sa_report_name).HasColumnName("sa_report_name");
            this.Property(t => t.sa_report_type).HasColumnName("sa_report_type");
            this.Property(t => t.sa_report_description).HasColumnName("sa_report_description");
            this.Property(t => t.sa_view_name).HasColumnName("sa_view_name");
            this.Property(t => t.sa_notes).HasColumnName("sa_notes");
            this.Property(t => t.sa_paper_type).HasColumnName("sa_paper_type");
            this.Property(t => t.sa_report_software).HasColumnName("sa_report_software");
            this.Property(t => t.sa_importance).HasColumnName("sa_importance");
            this.Property(t => t.sa_active).HasColumnName("sa_active");
            this.Property(t => t.sa_conversion_status).HasColumnName("sa_conversion_status");
            this.Property(t => t.sa_report_owner).HasColumnName("sa_report_owner");
            this.Property(t => t.sa_report_date_tested).HasColumnName("sa_report_date_tested");
            this.Property(t => t.sa_report_results).HasColumnName("sa_report_results");
            this.Property(t => t.sa_report_version).HasColumnName("sa_report_version");
            this.Property(t => t.sapliveaccess).HasColumnName("sapliveaccess");
            this.Property(t => t.upgrade).HasColumnName("upgrade");
            this.Property(t => t.sa_multi_company).HasColumnName("sa_multi_company");
            this.Property(t => t.sa_report_format).HasColumnName("sa_report_format");
            this.Property(t => t.usage_count).HasColumnName("usage_count");

            // Relationships
            this.HasOptional(t => t.web_sa_output_type_tbl)
                .WithMany(t => t.web_sa_report_tbl)
                .HasForeignKey(d => d.sa_paper_type);
            this.HasOptional(t => t.web_sa_report_software_tbl)
                .WithMany(t => t.web_sa_report_tbl)
                .HasForeignKey(d => d.sa_report_software);
            this.HasRequired(t => t.web_sa_report_type_tbl)
                .WithMany(t => t.web_sa_report_tbl)
                .HasForeignKey(d => d.sa_report_type);
            this.HasOptional(t => t.web_sa_report_version_tbl)
                .WithMany(t => t.web_sa_report_tbl)
                .HasForeignKey(d => d.sa_report_version);

        }
    }
}
