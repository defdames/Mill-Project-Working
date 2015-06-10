using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_export_view_planned_vs_actualMap : EntityTypeConfiguration<advpl_export_view_planned_vs_actual>
    {
        public advpl_export_view_planned_vs_actualMap()
        {
            // Primary Key
            this.HasKey(t => t.PlannedProduction);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.Products_at_Warehouses_Commodity)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("advpl_export_view_planned_vs_actual");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pdmo).HasColumnName("pdmo");
            this.Property(t => t.pdyr).HasColumnName("pdyr");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.PlannedProduction).HasColumnName("PlannedProduction");
            this.Property(t => t.ActualProduction).HasColumnName("ActualProduction");
            this.Property(t => t.Variance).HasColumnName("Variance");
            this.Property(t => t.Products_at_Warehouses_Commodity).HasColumnName("Products at Warehouses Commodity");
        }
    }
}
