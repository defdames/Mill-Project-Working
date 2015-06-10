using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_sales_product_categorization_sllMap : EntityTypeConfiguration<mis_cube_sales_product_categorization_sll>
    {
        public mis_cube_sales_product_categorization_sllMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_prod_key, t.so_prod_desc, t.en_mktseg_desc, t.en_stats_key, t.New_Changed });

            // Properties
            this.Property(t => t.so_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_mktseg_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.New_Changed)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("mis_cube_sales_product_categorization_sll");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.so_prod_desc).HasColumnName("so_prod_desc");
            this.Property(t => t.en_mktseg_desc).HasColumnName("en_mktseg_desc");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.New_Changed).HasColumnName("New-Changed");
            this.Property(t => t.dolq1).HasColumnName("dolq1");
            this.Property(t => t.dolq2).HasColumnName("dolq2");
            this.Property(t => t.dolq3).HasColumnName("dolq3");
            this.Property(t => t.dolq4).HasColumnName("dolq4");
            this.Property(t => t.volq1).HasColumnName("volq1");
            this.Property(t => t.volq2).HasColumnName("volq2");
            this.Property(t => t.volq3).HasColumnName("volq3");
            this.Property(t => t.volq4).HasColumnName("volq4");
            this.Property(t => t.pc_bsprdt_price).HasColumnName("pc_bsprdt_price");
            this.Property(t => t.avgq1).HasColumnName("avgq1");
            this.Property(t => t.avgq2).HasColumnName("avgq2");
            this.Property(t => t.avgq3).HasColumnName("avgq3");
            this.Property(t => t.avgq4).HasColumnName("avgq4");
            this.Property(t => t.gmq1).HasColumnName("gmq1");
            this.Property(t => t.gmq2).HasColumnName("gmq2");
            this.Property(t => t.gmq3).HasColumnName("gmq3");
            this.Property(t => t.gmq4).HasColumnName("gmq4");
            this.Property(t => t.invq1).HasColumnName("invq1");
            this.Property(t => t.invq2).HasColumnName("invq2");
            this.Property(t => t.invq3).HasColumnName("invq3");
            this.Property(t => t.invq4).HasColumnName("invq4");
            this.Property(t => t.lateq1).HasColumnName("lateq1");
            this.Property(t => t.lateq2).HasColumnName("lateq2");
            this.Property(t => t.lateq3).HasColumnName("lateq3");
            this.Property(t => t.lateq4).HasColumnName("lateq4");
            this.Property(t => t.boq1).HasColumnName("boq1");
            this.Property(t => t.boq2).HasColumnName("boq2");
            this.Property(t => t.boq3).HasColumnName("boq3");
            this.Property(t => t.boq4).HasColumnName("boq4");
            this.Property(t => t.otifq1).HasColumnName("otifq1");
            this.Property(t => t.otifq2).HasColumnName("otifq2");
            this.Property(t => t.otifq3).HasColumnName("otifq3");
            this.Property(t => t.otifq4).HasColumnName("otifq4");
            this.Property(t => t.prodq1).HasColumnName("prodq1");
            this.Property(t => t.prodq2).HasColumnName("prodq2");
            this.Property(t => t.prodq3).HasColumnName("prodq3");
            this.Property(t => t.prodq4).HasColumnName("prodq4");
        }
    }
}
