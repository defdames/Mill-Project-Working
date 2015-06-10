using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_2011_forecast_SPMap : EntityTypeConfiguration<mis_cube_salesfcst_2011_forecast_SP>
    {
        public mis_cube_salesfcst_2011_forecast_SPMap()
        {
            // Primary Key
            this.HasKey(t => t.act_fcst);

            // Properties
            this.Property(t => t.datesold)
                .HasMaxLength(10);

            this.Property(t => t.PRODUCT)
                .HasMaxLength(255);

            this.Property(t => t.company)
                .HasMaxLength(255);

            this.Property(t => t.item)
                .HasMaxLength(20);

            this.Property(t => t.ITeMCLASS)
                .HasMaxLength(5);

            this.Property(t => t.domforsam)
                .HasMaxLength(266);

            this.Property(t => t.act_fcst)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_2011_forecast_SP");
            this.Property(t => t.datesold).HasColumnName("datesold");
            this.Property(t => t.PRODUCT).HasColumnName("PRODUCT");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.dollarssoldlc).HasColumnName("dollarssoldlc");
            this.Property(t => t.poundssoldlc).HasColumnName("poundssoldlc");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.ITeMCLASS).HasColumnName("ITeMCLASS");
            this.Property(t => t.costvalue).HasColumnName("costvalue");
            this.Property(t => t.kgs).HasColumnName("kgs");
            this.Property(t => t.globalcost).HasColumnName("globalcost");
            this.Property(t => t.domforsam).HasColumnName("domforsam");
            this.Property(t => t.act_fcst).HasColumnName("act_fcst");
            this.Property(t => t.matlvalue).HasColumnName("matlvalue");
            this.Property(t => t.rsrcvalue).HasColumnName("rsrcvalue");
            this.Property(t => t.euros).HasColumnName("euros");
        }
    }
}
