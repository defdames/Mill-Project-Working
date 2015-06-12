using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class global_costsMap : EntityTypeConfiguration<global_costs>
    {
        public global_costsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IN_WHS_KEY, t.company });

            // Properties
            this.Property(t => t.IN_WHS_KEY)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_prod_key)
                .HasMaxLength(255);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("global_costs");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.IN_WHS_KEY).HasColumnName("IN_WHS_KEY");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.LBCost).HasColumnName("LBCost");
            this.Property(t => t.KGcost).HasColumnName("KGcost");
            this.Property(t => t.GlobalMatlCostLB).HasColumnName("GlobalMatlCostLB");
            this.Property(t => t.GlobalDirectLaborlb).HasColumnName("GlobalDirectLaborlb");
            this.Property(t => t.GlobalVariableCostlb).HasColumnName("GlobalVariableCostlb");
            this.Property(t => t.company).HasColumnName("company");
        }
    }
}
