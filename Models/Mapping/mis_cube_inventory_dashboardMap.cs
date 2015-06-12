using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_inventory_dashboardMap : EntityTypeConfiguration<mis_cube_inventory_dashboard>
    {
        public mis_cube_inventory_dashboardMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.type, t.gl_perod_year, t.gl_perod_id });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("mis_cube_inventory_dashboard");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
            this.Property(t => t.in_stkmv_eoh).HasColumnName("in_stkmv_eoh");
            this.Property(t => t.in_stkmv_eoh_cost).HasColumnName("in_stkmv_eoh_cost");
        }
    }
}
