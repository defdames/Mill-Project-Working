using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_kerry_new_sales_newMap : EntityTypeConfiguration<tmp_kerry_new_sales_new>
    {
        public tmp_kerry_new_sales_newMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DateSold, t.Company, t.Item, t.ItemClass, t.CostValue, t.KGS, t.GlobalCost, t.ACT_FCST, t.MatlValue, t.RsrcValue, t.EUROS });

            // Properties
            this.Property(t => t.DateSold)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Product)
                .HasMaxLength(255);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Item)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemClass)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.domforsam)
                .HasMaxLength(255);

            this.Property(t => t.ACT_FCST)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Region)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tmp_kerry_new_sales_new");
            this.Property(t => t.DateSold).HasColumnName("DateSold");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.DollarsSoldLC).HasColumnName("DollarsSoldLC");
            this.Property(t => t.PoundsSoldLC).HasColumnName("PoundsSoldLC");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.ItemClass).HasColumnName("ItemClass");
            this.Property(t => t.CostValue).HasColumnName("CostValue");
            this.Property(t => t.KGS).HasColumnName("KGS");
            this.Property(t => t.GlobalCost).HasColumnName("GlobalCost");
            this.Property(t => t.domforsam).HasColumnName("domforsam");
            this.Property(t => t.ACT_FCST).HasColumnName("ACT_FCST");
            this.Property(t => t.MatlValue).HasColumnName("MatlValue");
            this.Property(t => t.RsrcValue).HasColumnName("RsrcValue");
            this.Property(t => t.EUROS).HasColumnName("EUROS");
            this.Property(t => t.Region).HasColumnName("Region");
        }
    }
}
