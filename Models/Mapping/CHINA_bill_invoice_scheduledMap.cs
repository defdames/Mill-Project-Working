using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_bill_invoice_scheduledMap : EntityTypeConfiguration<CHINA_bill_invoice_scheduled>
    {
        public CHINA_bill_invoice_scheduledMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_ivhdr_key, t.ar_ivhdr_duedt, t.ar_bill_key, t.ar_ship_key, t.so_hdr_cpono, t.so_hdr_key, t.en_cust_key, t.ar_ivhdr_ivblc, t.so_dtl_unitc, t.ar_ivdtl_extdc, t.ar_ivdtl_key, t.ar_ivdtl_invqtpuom, t.so_ship_key, t.en_whs_key, t.ar_ivhdr_type, t.gl_cmp_key, t.VATAMT, t.DVATAMT, t.gl_crncy_key, t.gl_vatrate_pct, t.ar_ivhdr_crtdt });

            // Properties
            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_cpono)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ProdKey)
                .HasMaxLength(20);

            this.Property(t => t.ProdDesc)
                .HasMaxLength(60);

            this.Property(t => t.ar_ivdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.so_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_ivhdr_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.FOB)
                .HasMaxLength(30);

            this.Property(t => t.so_dtl_cprtn)
                .HasMaxLength(30);

            this.Property(t => t.so_dtl_cpono)
                .HasMaxLength(25);

            this.Property(t => t.en_frgt_key)
                .HasMaxLength(10);

            this.Property(t => t.ShipVia)
                .HasMaxLength(10);

            this.Property(t => t.ShipName)
                .HasMaxLength(80);

            this.Property(t => t.ShipLine1)
                .HasMaxLength(67);

            this.Property(t => t.ShipLine2)
                .HasMaxLength(67);

            this.Property(t => t.ShipLine3)
                .HasMaxLength(67);

            this.Property(t => t.ShipCSZ)
                .HasMaxLength(67);

            this.Property(t => t.SoldName)
                .HasMaxLength(80);

            this.Property(t => t.SoldLine1)
                .HasMaxLength(67);

            this.Property(t => t.SoldLine2)
                .HasMaxLength(67);

            this.Property(t => t.SoldLine3)
                .HasMaxLength(67);

            this.Property(t => t.SoldCSZ)
                .HasMaxLength(67);

            this.Property(t => t.UoM)
                .HasMaxLength(2);

            this.Property(t => t.DtlInst)
                .HasMaxLength(180);

            this.Property(t => t.TermDesc)
                .HasMaxLength(30);

            this.Property(t => t.IntNbr)
                .HasMaxLength(10);

            this.Property(t => t.e)
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_tax_key)
                .HasMaxLength(10);

            this.Property(t => t.ex_ship_mark1)
                .HasMaxLength(60);

            this.Property(t => t.ex_ship_mark2)
                .HasMaxLength(40);

            this.Property(t => t.ex_ship_mark3)
                .HasMaxLength(40);

            this.Property(t => t.ex_ship_mark4)
                .HasMaxLength(40);

            this.Property(t => t.ex_ship_mark5)
                .HasMaxLength(40);

            this.Property(t => t.ex_ship_mark6)
                .HasMaxLength(40);

            this.Property(t => t.vessel)
                .HasMaxLength(60);

            this.Property(t => t.markings)
                .HasMaxLength(30);

            this.Property(t => t.shipping_dates)
                .HasMaxLength(30);

            this.Property(t => t.airway_bill_voy)
                .HasMaxLength(30);

            this.Property(t => t.destination_cntry)
                .HasMaxLength(60);

            this.Property(t => t.ports_from_to)
                .HasMaxLength(60);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.agent)
                .HasMaxLength(30);

            this.Property(t => t.so_dtl_shtvatregno)
                .HasMaxLength(20);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.Porp)
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("CHINA_bill_invoice_scheduled");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.tran_date_key).HasColumnName("tran_date_key");
            this.Property(t => t.ar_ivhdr_duedt).HasColumnName("ar_ivhdr_duedt");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.so_hdr_cpono).HasColumnName("so_hdr_cpono");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.ar_ivhdr_ivblc).HasColumnName("ar_ivhdr_ivblc");
            this.Property(t => t.ProdKey).HasColumnName("ProdKey");
            this.Property(t => t.ProdDesc).HasColumnName("ProdDesc");
            this.Property(t => t.so_dtl_unitc).HasColumnName("so_dtl_unitc");
            this.Property(t => t.ar_ivdtl_extdc).HasColumnName("ar_ivdtl_extdc");
            this.Property(t => t.ar_ivdtl_key).HasColumnName("ar_ivdtl_key");
            this.Property(t => t.dtlkey).HasColumnName("dtlkey");
            this.Property(t => t.ar_ivdtl_invqtpuom).HasColumnName("ar_ivdtl_invqtpuom");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.en_whs_key).HasColumnName("en_whs_key");
            this.Property(t => t.ar_ivhdr_type).HasColumnName("ar_ivhdr_type");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.FOB).HasColumnName("FOB");
            this.Property(t => t.so_dtl_ordqt).HasColumnName("so_dtl_ordqt");
            this.Property(t => t.so_dtl_cprtn).HasColumnName("so_dtl_cprtn");
            this.Property(t => t.so_dtl_cpono).HasColumnName("so_dtl_cpono");
            this.Property(t => t.so_dtl_shpqt).HasColumnName("so_dtl_shpqt");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.ShipVia).HasColumnName("ShipVia");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.ShipLine1).HasColumnName("ShipLine1");
            this.Property(t => t.ShipLine2).HasColumnName("ShipLine2");
            this.Property(t => t.ShipLine3).HasColumnName("ShipLine3");
            this.Property(t => t.ShipCSZ).HasColumnName("ShipCSZ");
            this.Property(t => t.SoldName).HasColumnName("SoldName");
            this.Property(t => t.SoldLine1).HasColumnName("SoldLine1");
            this.Property(t => t.SoldLine2).HasColumnName("SoldLine2");
            this.Property(t => t.SoldLine3).HasColumnName("SoldLine3");
            this.Property(t => t.SoldCSZ).HasColumnName("SoldCSZ");
            this.Property(t => t.UoM).HasColumnName("UoM");
            this.Property(t => t.OrdrQty).HasColumnName("OrdrQty");
            this.Property(t => t.ShipQty).HasColumnName("ShipQty");
            this.Property(t => t.UnitCost).HasColumnName("UnitCost");
            this.Property(t => t.ExtPrice).HasColumnName("ExtPrice");
            this.Property(t => t.DtlInst).HasColumnName("DtlInst");
            this.Property(t => t.TermDesc).HasColumnName("TermDesc");
            this.Property(t => t.IntNbr).HasColumnName("IntNbr");
            this.Property(t => t.e).HasColumnName("e");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.ar_tax_amtcf).HasColumnName("ar_tax_amtcf");
            this.Property(t => t.ex_ship_mark1).HasColumnName("ex_ship_mark1");
            this.Property(t => t.ex_ship_mark2).HasColumnName("ex_ship_mark2");
            this.Property(t => t.ex_ship_mark3).HasColumnName("ex_ship_mark3");
            this.Property(t => t.ex_ship_mark4).HasColumnName("ex_ship_mark4");
            this.Property(t => t.ex_ship_mark5).HasColumnName("ex_ship_mark5");
            this.Property(t => t.ex_ship_mark6).HasColumnName("ex_ship_mark6");
            this.Property(t => t.vessel).HasColumnName("vessel");
            this.Property(t => t.markings).HasColumnName("markings");
            this.Property(t => t.shipping_dates).HasColumnName("shipping_dates");
            this.Property(t => t.airway_bill_voy).HasColumnName("airway_bill_voy");
            this.Property(t => t.destination_cntry).HasColumnName("destination_cntry");
            this.Property(t => t.ports_from_to).HasColumnName("ports_from_to");
            this.Property(t => t.so_prod_shipf).HasColumnName("so_prod_shipf");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.erate).HasColumnName("erate");
            this.Property(t => t.agent).HasColumnName("agent");
            this.Property(t => t.VATAMT).HasColumnName("VATAMT");
            this.Property(t => t.DVATAMT).HasColumnName("DVATAMT");
            this.Property(t => t.so_dtl_shtvatregno).HasColumnName("so_dtl_shtvatregno");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.Porp).HasColumnName("Porp");
            this.Property(t => t.ar_ivhdr_crtdt).HasColumnName("ar_ivhdr_crtdt");
        }
    }
}
