using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_sales_sj_costs_sjMap : EntityTypeConfiguration<mis_cube_sales_sj_costs_sj>
    {
        public mis_cube_sales_sj_costs_sjMap()
        {
            // Primary Key
            this.HasKey(t => t.en_item_key);

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("mis_cube_sales_sj_costs_sj");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.globalcostlb).HasColumnName("globalcostlb");
            this.Property(t => t.ictpcostlb).HasColumnName("ictpcostlb");
        }
    }
}
