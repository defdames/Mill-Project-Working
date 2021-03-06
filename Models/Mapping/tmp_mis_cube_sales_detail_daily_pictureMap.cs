using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_mis_cube_sales_detail_daily_pictureMap : EntityTypeConfiguration<tmp_mis_cube_sales_detail_daily_picture>
    {
        public tmp_mis_cube_sales_detail_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.product, t.en_item_key, t.en_ship_name, t.hdrkey, t.dtlkey, t.soldto, t.gl_cmp_key, t.ar_bill_key, t.CD, t.Invoice_Num, t.SO_Num, t.Ship_Whse });

            // Properties
            this.Property(t => t.mktseg)
                .HasMaxLength(1);

            this.Property(t => t.agent)
                .HasMaxLength(45);

            this.Property(t => t.product)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_prod_desc)
                .HasMaxLength(60);

            this.Property(t => t.itmclass)
                .HasMaxLength(4);

            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_catlg_key)
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .HasMaxLength(6);

            this.Property(t => t.shipkey)
                .HasMaxLength(10);

            this.Property(t => t.en_ship_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.hdrkey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.dtlkey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.salestype)
                .HasMaxLength(10);

            this.Property(t => t.soldto)
                .IsRequired()
                .HasMaxLength(41);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_name)
                .HasMaxLength(30);

            this.Property(t => t.ManufacturingLoc)
                .HasMaxLength(8);

            this.Property(t => t.LotNo)
                .HasMaxLength(25);

            this.Property(t => t.CD)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Country)
                .HasMaxLength(20);

            this.Property(t => t.whseacct)
                .HasMaxLength(10);

            this.Property(t => t.Invoice_Num)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.SO_Num)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Ship_Whse)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.Sales_Type)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("tmp_mis_cube_sales_detail_daily_picture");
            this.Property(t => t.tran_date_key).HasColumnName("tran_date_key");
            this.Property(t => t.mktseg).HasColumnName("mktseg");
            this.Property(t => t.agent).HasColumnName("agent");
            this.Property(t => t.product).HasColumnName("product");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
            this.Property(t => t.itmclass).HasColumnName("itmclass");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.en_catlg_key).HasColumnName("en_catlg_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.shipkey).HasColumnName("shipkey");
            this.Property(t => t.en_ship_name).HasColumnName("en_ship_name");
            this.Property(t => t.hdrkey).HasColumnName("hdrkey");
            this.Property(t => t.dtlkey).HasColumnName("dtlkey");
            this.Property(t => t.salestype).HasColumnName("salestype");
            this.Property(t => t.soldto).HasColumnName("soldto");
            this.Property(t => t.dollars).HasColumnName("dollars");
            this.Property(t => t.pounds).HasColumnName("pounds");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_bill_name).HasColumnName("ar_bill_name");
            this.Property(t => t.cost_value).HasColumnName("cost_value");
            this.Property(t => t.kgs).HasColumnName("kgs");
            this.Property(t => t.ManufacturingLoc).HasColumnName("ManufacturingLoc");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.CD).HasColumnName("CD");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.whseacct).HasColumnName("whseacct");
            this.Property(t => t.Invoice_Num).HasColumnName("Invoice_Num");
            this.Property(t => t.SO_Num).HasColumnName("SO_Num");
            this.Property(t => t.Ship_Whse).HasColumnName("Ship_Whse");
            this.Property(t => t.Sales_Type).HasColumnName("Sales_Type");
            this.Property(t => t.euros).HasColumnName("euros");
        }
    }
}
