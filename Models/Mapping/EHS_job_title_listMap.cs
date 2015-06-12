using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EHS_job_title_listMap : EntityTypeConfiguration<EHS_job_title_list>
    {
        public EHS_job_title_listMap()
        {
            // Primary Key
            this.HasKey(t => new { t.location, t.job_title });

            // Properties
            this.Property(t => t.location)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.job_title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EHS job title list");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.job_title).HasColumnName("job_title");
        }
    }
}
