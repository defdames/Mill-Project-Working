using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class otif_dashboard_weekMap : EntityTypeConfiguration<otif_dashboard_week>
    {
        public otif_dashboard_weekMap()
        {
            // Primary Key
            this.HasKey(t => t.gl_cmp_key);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.weektime)
                .HasMaxLength(34);

            // Table & Column Mappings
            this.ToTable("otif_dashboard_week");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.weektime).HasColumnName("weektime");
            this.Property(t => t.otiffail).HasColumnName("otiffail");
            this.Property(t => t.otiffull).HasColumnName("otiffull");
            this.Property(t => t.otif).HasColumnName("otif");
        }
    }
}
