using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_sales_sll_historyMap : EntityTypeConfiguration<mis_cube_sales_sll_history>
    {
        public mis_cube_sales_sll_historyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.company, t.packkey, t.manufacturingloc, t.ship_whse, t.act_fcst });

            // Properties
            this.Property(t => t.datesold)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.product)
                .HasMaxLength(20);

            this.Property(t => t.shipkey)
                .HasMaxLength(62);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.packkey)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.agent)
                .HasMaxLength(41);

            this.Property(t => t.item)
                .HasMaxLength(20);

            this.Property(t => t.itmclass)
                .HasMaxLength(4);

            this.Property(t => t.manufacturingloc)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Country)
                .HasMaxLength(20);

            this.Property(t => t.soldto)
                .HasMaxLength(41);

            this.Property(t => t.whseacct)
                .HasMaxLength(50);

            this.Property(t => t.citystate)
                .HasMaxLength(31);

            this.Property(t => t.shipname)
                .HasMaxLength(51);

            this.Property(t => t.domforsam)
                .HasMaxLength(14);

            this.Property(t => t.ship_whse)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.act_fcst)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("mis_cube_sales_sll_history");
            this.Property(t => t.datesold).HasColumnName("datesold");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.shipkey).HasColumnName("shipkey");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.packkey).HasColumnName("packkey");
            this.Property(t => t.dollarssoldlc).HasColumnName("dollarssoldlc");
            this.Property(t => t.poundssoldlc).HasColumnName("poundssoldlc");
            this.Property(t => t.agent).HasColumnName("agent");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.itmclass).HasColumnName("itmclass");
            this.Property(t => t.costvalue).HasColumnName("costvalue");
            this.Property(t => t.kgs).HasColumnName("kgs");
            this.Property(t => t.globalcost).HasColumnName("globalcost");
            this.Property(t => t.globalmatlvalue).HasColumnName("globalmatlvalue");
            this.Property(t => t.globaldirectlabor).HasColumnName("globaldirectlabor");
            this.Property(t => t.globalvariablecost).HasColumnName("globalvariablecost");
            this.Property(t => t.manufacturingloc).HasColumnName("manufacturingloc");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.soldto).HasColumnName("soldto");
            this.Property(t => t.whseacct).HasColumnName("whseacct");
            this.Property(t => t.citystate).HasColumnName("citystate");
            this.Property(t => t.shipname).HasColumnName("shipname");
            this.Property(t => t.domforsam).HasColumnName("domforsam");
            this.Property(t => t.ship_whse).HasColumnName("ship_whse");
            this.Property(t => t.act_fcst).HasColumnName("act_fcst");
            this.Property(t => t.matlvalue).HasColumnName("matlvalue");
            this.Property(t => t.rsrcvalue).HasColumnName("rsrcvalue");
        }
    }
}
