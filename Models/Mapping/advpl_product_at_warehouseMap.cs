using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_product_at_warehouseMap : EntityTypeConfiguration<advpl_product_at_warehouse>
    {
        public advpl_product_at_warehouseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Code, t.Stock_Cover, t.Description, t.Commodity, t.Planning_Family, t.IsPurchased, t.company, t.priorityfactor });

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(34);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.Commodity)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Planning_Family)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.IsPurchased)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.priorityfactor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("advpl_product_at_warehouse");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Stock_Cover).HasColumnName("Stock Cover");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Commodity).HasColumnName("Commodity");
            this.Property(t => t.Planning_Family).HasColumnName("Planning Family");
            this.Property(t => t.IsPurchased).HasColumnName("IsPurchased");
            this.Property(t => t.stdcost).HasColumnName("stdcost");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.priorityfactor).HasColumnName("priorityfactor");
        }
    }
}
