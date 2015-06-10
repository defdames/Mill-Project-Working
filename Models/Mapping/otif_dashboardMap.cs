using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class otif_dashboardMap : EntityTypeConfiguration<otif_dashboard>
    {
        public otif_dashboardMap()
        {
            // Primary Key
            this.HasKey(t => t.gl_cmp_key);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.monthtime)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("otif_dashboard");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.monthtime).HasColumnName("monthtime");
            this.Property(t => t.otiffail).HasColumnName("otiffail");
            this.Property(t => t.otiffull).HasColumnName("otiffull");
            this.Property(t => t.otif).HasColumnName("otif");
        }
    }
}
