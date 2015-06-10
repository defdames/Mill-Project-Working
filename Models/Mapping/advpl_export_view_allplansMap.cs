using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_export_view_allplansMap : EntityTypeConfiguration<advpl_export_view_allplans>
    {
        public advpl_export_view_allplansMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Products_At_Warehouses_Planning_Family, t.published });

            // Properties
            this.Property(t => t.Products_At_Warehouses_Name)
                .HasMaxLength(50);

            this.Property(t => t.plant)
                .HasMaxLength(10);

            this.Property(t => t.Bucket)
                .HasMaxLength(50);

            this.Property(t => t.Products_At_Warehouses_Is_Purchased____)
                .HasMaxLength(50);

            this.Property(t => t.Products_At_Warehouses_Unit)
                .HasMaxLength(50);

            this.Property(t => t.Products_At_Warehouses_Planning_Family)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.Products_At_Warehouses_Description)
                .HasMaxLength(100);

            this.Property(t => t.Products_At_Warehouses_Commodity)
                .HasMaxLength(50);

            this.Property(t => t.company)
                .HasMaxLength(2);

            this.Property(t => t.planid)
                .HasMaxLength(30);

            this.Property(t => t.published)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("advpl_export_view_allplans");
            this.Property(t => t.Products_At_Warehouses_Name).HasColumnName("Products At Warehouses Name");
            this.Property(t => t.plant).HasColumnName("plant");
            this.Property(t => t.stdcost).HasColumnName("stdcost");
            this.Property(t => t.Products_At_Warehouses_unsatisfied_demand).HasColumnName("Products At Warehouses unsatisfied demand");
            this.Property(t => t.Products_At_Warehouses_transfer_out).HasColumnName("Products At Warehouses transfer out");
            this.Property(t => t.Products_At_Warehouses_transfer_in).HasColumnName("Products At Warehouses transfer in");
            this.Property(t => t.Products_At_Warehouses_stock_cover).HasColumnName("Products At Warehouses stock cover");
            this.Property(t => t.Products_At_Warehouses_satisfied_demand).HasColumnName("Products At Warehouses satisfied demand");
            this.Property(t => t.Products_At_Warehouses_safety_stock).HasColumnName("Products At Warehouses safety stock");
            this.Property(t => t.Products_At_Warehouses_purchase).HasColumnName("Products At Warehouses purchase");
            this.Property(t => t.Products_At_Warehouses_production).HasColumnName("Products At Warehouses production");
            this.Property(t => t.Products_At_Warehouses_planned_delivery).HasColumnName("Products At Warehouses planned delivery");
            this.Property(t => t.Products_At_Warehouses_orders).HasColumnName("Products At Warehouses orders");
            this.Property(t => t.Products_At_Warehouses_on_hand).HasColumnName("Products At Warehouses on hand");
            this.Property(t => t.Products_At_Warehouses_max_purchase).HasColumnName("Products At Warehouses max purchase");
            this.Property(t => t.Products_At_Warehouses_lead_time).HasColumnName("Products At Warehouses lead time");
            this.Property(t => t.Products_At_Warehouses_is_purchased).HasColumnName("Products At Warehouses is purchased");
            this.Property(t => t.Products_At_Warehouses_forecast).HasColumnName("Products At Warehouses forecast");
            this.Property(t => t.Products_At_Warehouses_firm_delivery).HasColumnName("Products At Warehouses firm delivery");
            this.Property(t => t.Products_At_Warehouses_end_inv).HasColumnName("Products At Warehouses end inv");
            this.Property(t => t.Products_At_Warehouses_downstream_demand).HasColumnName("Products At Warehouses downstream demand");
            this.Property(t => t.Products_At_Warehouses_demand).HasColumnName("Products At Warehouses demand");
            this.Property(t => t.Products_At_Warehouses_cumulative_unsatisfied_demand).HasColumnName("Products At Warehouses cumulative unsatisfied demand");
            this.Property(t => t.Products_At_Warehouses_below_safety_stock).HasColumnName("Products At Warehouses below safety stock");
            this.Property(t => t.Products_At_Warehouses_begin_inv).HasColumnName("Products At Warehouses begin inv");
            this.Property(t => t.Products_At_Warehouses_adjusted_safety_stock).HasColumnName("Products At Warehouses adjusted safety stock");
            this.Property(t => t.Bucket).HasColumnName("Bucket");
            this.Property(t => t.Products_At_Warehouses_Stock_Cover____).HasColumnName("Products At Warehouses Stock Cover (*)");
            this.Property(t => t.Products_At_Warehouses_Lead_Time____).HasColumnName("Products At Warehouses Lead Time (*)");
            this.Property(t => t.Products_At_Warehouses_Is_Purchased____).HasColumnName("Products At Warehouses Is Purchased (*)");
            this.Property(t => t.Products_At_Warehouses_Unit).HasColumnName("Products At Warehouses Unit");
            this.Property(t => t.Products_At_Warehouses_Planning_Family).HasColumnName("Products At Warehouses Planning Family");
            this.Property(t => t.Products_At_Warehouses_Description).HasColumnName("Products At Warehouses Description");
            this.Property(t => t.Products_At_Warehouses_Commodity).HasColumnName("Products At Warehouses Commodity");
            this.Property(t => t.products_at_warehouses_mixer_hours).HasColumnName("products at warehouses mixer hours");
            this.Property(t => t.products_at_warehouses_mill_hours).HasColumnName("products at warehouses mill hours");
            this.Property(t => t.products_at_warehouses_days_of_supply).HasColumnName("products at warehouses days of supply");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.planid).HasColumnName("planid");
            this.Property(t => t.published).HasColumnName("published");
        }
    }
}
