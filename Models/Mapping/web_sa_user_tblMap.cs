using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class web_sa_user_tblMap : EntityTypeConfiguration<web_sa_user_tbl>
    {
        public web_sa_user_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.sa_user_key);

            // Properties
            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sa_user_name)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("web_sa_user_tbl");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.sa_user_name).HasColumnName("sa_user_name");

            // Relationships
            this.HasMany(t => t.web_sa_report_tbl)
                .WithMany(t => t.web_sa_user_tbl)
                .Map(m =>
                    {
                        m.ToTable("web_sa_usrreport_tbl");
                        m.MapLeftKey("sa_user_key");
                        m.MapRightKey("sa_report_name", "sa_report_type");
                    });


        }
    }
}
