using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_2012_SL_customerMap : EntityTypeConfiguration<mis_cube_salesfcst_2012_SL_customer>
    {
        public mis_cube_salesfcst_2012_SL_customerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.datesold, t.domformsam, t.company });

            // Properties
            this.Property(t => t.datesold)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.shipkey)
                .HasMaxLength(255);

            this.Property(t => t.domformsam)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.new_market)
                .HasMaxLength(255);

            this.Property(t => t.product)
                .HasMaxLength(50);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.item)
                .HasMaxLength(255);

            this.Property(t => t.itemclass)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_2012_SL_customer");
            this.Property(t => t.datesold).HasColumnName("datesold");
            this.Property(t => t.shipkey).HasColumnName("shipkey");
            this.Property(t => t.domformsam).HasColumnName("domformsam");
            this.Property(t => t.new_market).HasColumnName("new market");
            this.Property(t => t.dollarssoldlc).HasColumnName("dollarssoldlc");
            this.Property(t => t.kgs).HasColumnName("kgs");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.itemclass).HasColumnName("itemclass");
        }
    }
}
