using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class web_sa_group_tblMap : EntityTypeConfiguration<web_sa_group_tbl>
    {
        public web_sa_group_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.sa_group_key);

            // Properties
            this.Property(t => t.sa_group_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sa_group_desc)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("web_sa_group_tbl");
            this.Property(t => t.sa_group_key).HasColumnName("sa_group_key");
            this.Property(t => t.sa_group_desc).HasColumnName("sa_group_desc");

            // Relationships
            this.HasMany(t => t.web_sa_report_tbl)
                .WithMany(t => t.web_sa_group_tbl)
                .Map(m =>
                    {
                        m.ToTable("web_sa_grpreport_tbl");
                        m.MapLeftKey("sa_group_key");
                        m.MapRightKey("sa_report_name", "sa_report_type");
                    });

            this.HasMany(t => t.web_sa_user_tbl)
                .WithMany(t => t.web_sa_group_tbl)
                .Map(m =>
                    {
                        m.ToTable("web_sa_user_group_tbl");
                        m.MapLeftKey("sa_group_key");
                        m.MapRightKey("sa_user_key");
                    });


        }
    }
}
