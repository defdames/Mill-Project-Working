using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class rebates_for_channelpartners3_tblMap : EntityTypeConfiguration<rebates_for_channelpartners3_tbl>
    {
        public rebates_for_channelpartners3_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tran_date_key, t.HdrKey, t.DtlKey, t.ShipName, t.ShipTo, t.ProdDesc, t.Product, t.dollars, t.en_cust_key, t.en_whs_key, t.gl_cmp_key, t.pda_newrequestedprice, t.soldto_channel_partner_units, t.soldto_channel_partner_dollars, t.soldto_channel_partner_uom, t.inv_item, t.en_cust_name, t.channel_partner_invoice, t.channel_partner_invoice_date, t.channel_discount, t.Silberline_Net_Price_Per_Unit, t.repack });

            // Properties
            this.Property(t => t.HdrKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DtlKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShipName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ShipTo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ProdDesc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.Product)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Class)
                .HasMaxLength(30);

            this.Property(t => t.lot)
                .HasMaxLength(25);

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_key)
                .HasMaxLength(10);

            this.Property(t => t.en_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pda_newrequestedprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soldto_channel_partner_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.inv_item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pda_item)
                .HasMaxLength(50);

            this.Property(t => t.channel_partner_code)
                .HasMaxLength(10);

            this.Property(t => t.en_cust_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.channel_partner_invoice)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.channel_partner_soldto_customer)
                .HasMaxLength(150);

            this.Property(t => t.channel_partner_detail_sales_lot)
                .HasMaxLength(50);

            this.Property(t => t.repack)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("rebates_for_channelpartners3_tbl");
            this.Property(t => t.tran_date_key).HasColumnName("tran_date_key");
            this.Property(t => t.HdrKey).HasColumnName("HdrKey");
            this.Property(t => t.DtlKey).HasColumnName("DtlKey");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.ShipTo).HasColumnName("ShipTo");
            this.Property(t => t.ProdDesc).HasColumnName("ProdDesc");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.Class).HasColumnName("Class");
            this.Property(t => t.dollars).HasColumnName("dollars");
            this.Property(t => t.pounds).HasColumnName("pounds");
            this.Property(t => t.lot).HasColumnName("lot");
            this.Property(t => t.lotpounds).HasColumnName("lotpounds");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.en_whs_key).HasColumnName("en_whs_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pda_newrequestedprice).HasColumnName("pda_newrequestedprice");
            this.Property(t => t.pda_effective).HasColumnName("pda_effective");
            this.Property(t => t.pda_expiration).HasColumnName("pda_expiration");
            this.Property(t => t.soldto_channel_partner_units).HasColumnName("soldto_channel_partner_units");
            this.Property(t => t.soldto_channel_partner_dollars).HasColumnName("soldto_channel_partner_dollars");
            this.Property(t => t.soldto_channel_partner_uom).HasColumnName("soldto_channel_partner_uom");
            this.Property(t => t.inv_item).HasColumnName("inv_item");
            this.Property(t => t.pda_item).HasColumnName("pda_item");
            this.Property(t => t.channel_partner_code).HasColumnName("channel_partner_code");
            this.Property(t => t.en_cust_name).HasColumnName("en_cust_name");
            this.Property(t => t.channel_partner_invoice).HasColumnName("channel_partner_invoice");
            this.Property(t => t.channel_partner_invoice_date).HasColumnName("channel_partner_invoice_date");
            this.Property(t => t.channel_partner_soldto_customer).HasColumnName("channel_partner_soldto_customer");
            this.Property(t => t.channel_partner_detail_sales_lot).HasColumnName("channel_partner_detail_sales_lot");
            this.Property(t => t.channel_discount).HasColumnName("channel_discount");
            this.Property(t => t.Silberline_Net_Price_Per_Unit).HasColumnName("Silberline_Net_Price_Per_Unit");
            this.Property(t => t.smc_base).HasColumnName("smc_base");
            this.Property(t => t.repack).HasColumnName("repack");
        }
    }
}
