using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_2012_forecast_customerMap : EntityTypeConfiguration<mis_cube_salesfcst_2012_forecast_customer>
    {
        public mis_cube_salesfcst_2012_forecast_customerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.datesold, t.company, t.domforsam, t.act_fcst, t.region });

            // Properties
            this.Property(t => t.datesold)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.shipkey)
                .HasMaxLength(500);

            this.Property(t => t.product)
                .HasMaxLength(20);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.item)
                .HasMaxLength(20);

            this.Property(t => t.itemclass)
                .HasMaxLength(4);

            this.Property(t => t.domforsam)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.act_fcst)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.market)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_2012_forecast_customer");
            this.Property(t => t.datesold).HasColumnName("datesold");
            this.Property(t => t.shipkey).HasColumnName("shipkey");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.dollarssoldlc).HasColumnName("dollarssoldlc");
            this.Property(t => t.poundssoldlc).HasColumnName("poundssoldlc");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.itemclass).HasColumnName("itemclass");
            this.Property(t => t.costvalue).HasColumnName("costvalue");
            this.Property(t => t.kgs).HasColumnName("kgs");
            this.Property(t => t.globalcost).HasColumnName("globalcost");
            this.Property(t => t.domforsam).HasColumnName("domforsam");
            this.Property(t => t.act_fcst).HasColumnName("act_fcst");
            this.Property(t => t.matlvalue).HasColumnName("matlvalue");
            this.Property(t => t.rsrcvalue).HasColumnName("rsrcvalue");
            this.Property(t => t.euros).HasColumnName("euros");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.market).HasColumnName("market");
        }
    }
}
