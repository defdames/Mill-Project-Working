using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mis_cube_salesfcst_2014_sa_20140203_torirevise_finalMap : EntityTypeConfiguration<mis_cube_salesfcst_2014_sa_20140203_torirevise_final>
    {
        public mis_cube_salesfcst_2014_sa_20140203_torirevise_finalMap()
        {
            // Primary Key
            this.HasKey(t => t.gl_crcnv_rate);

            // Properties
            this.Property(t => t.datesold)
                .HasMaxLength(255);

            this.Property(t => t.shipkey)
                .HasMaxLength(500);

            this.Property(t => t.product)
                .HasMaxLength(255);

            this.Property(t => t.company)
                .HasMaxLength(500);

            this.Property(t => t.item)
                .HasMaxLength(255);

            this.Property(t => t.itemclass)
                .HasMaxLength(255);

            this.Property(t => t.domforsam)
                .HasMaxLength(255);

            this.Property(t => t.act_fcst)
                .HasMaxLength(255);

            this.Property(t => t.region)
                .HasMaxLength(255);

            this.Property(t => t.market)
                .HasMaxLength(255);

            this.Property(t => t.gl_crcnv_rate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("mis_cube_salesfcst_2014_sa_20140203_torirevise_final");
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
            this.Property(t => t.priorcostvalue).HasColumnName("priorcostvalue");
            this.Property(t => t.priormatlvalue).HasColumnName("priormatlvalue");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.market).HasColumnName("market");
            this.Property(t => t.gl_crcnv_rate).HasColumnName("gl_crcnv_rate");
        }
    }
}
