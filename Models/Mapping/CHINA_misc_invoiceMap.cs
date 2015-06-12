using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_misc_invoiceMap : EntityTypeConfiguration<CHINA_misc_invoice>
    {
        public CHINA_misc_invoiceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_ivhdr_key, t.tran_date_key, t.ar_bill_key, t.ar_ship_key, t.so_hdr_cpono, t.so_hdr_key, t.en_cust_key, t.ar_ivhdr_ivblc, t.so_dtl_unitc, t.ar_ivdtl_extdc, t.ar_ivdtl_key, t.ar_ivdtl_invqtpuom, t.so_ship_key, t.en_whs_key, t.ar_tax_key, t.ar_tax_amtc, t.ar_ivhdr_type, t.OrderDate, t.UoM, t.ar_ivdtl_eadbasecf, t.UnitCost, t.ExtPrice, t.gl_cmp_key, t.VatCode, t.VatRate, t.VatAmt });

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

            this.Property(t => t.ar_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ivhdr_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.SoldName)
                .HasMaxLength(30);

            this.Property(t => t.SoldLine1)
                .HasMaxLength(67);

            this.Property(t => t.SoldLine2)
                .HasMaxLength(67);

            this.Property(t => t.SoldLine3)
                .HasMaxLength(67);

            this.Property(t => t.SoldCSZ)
                .HasMaxLength(67);

            this.Property(t => t.ShipName)
                .HasMaxLength(30);

            this.Property(t => t.ShipLine1)
                .HasMaxLength(67);

            this.Property(t => t.ShipLine2)
                .HasMaxLength(67);

            this.Property(t => t.ShipLine3)
                .HasMaxLength(67);

            this.Property(t => t.ShipCSZ)
                .HasMaxLength(67);

            this.Property(t => t.UoM)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.OrdrQty)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.ShipQty)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.TermDesc)
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.VatCode)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CHINA_misc_invoice");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.tran_date_key).HasColumnName("tran_date_key");
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
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.ar_tax_amtc).HasColumnName("ar_tax_amtc");
            this.Property(t => t.ar_ivhdr_type).HasColumnName("ar_ivhdr_type");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.SoldName).HasColumnName("SoldName");
            this.Property(t => t.SoldLine1).HasColumnName("SoldLine1");
            this.Property(t => t.SoldLine2).HasColumnName("SoldLine2");
            this.Property(t => t.SoldLine3).HasColumnName("SoldLine3");
            this.Property(t => t.SoldCSZ).HasColumnName("SoldCSZ");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.ShipLine1).HasColumnName("ShipLine1");
            this.Property(t => t.ShipLine2).HasColumnName("ShipLine2");
            this.Property(t => t.ShipLine3).HasColumnName("ShipLine3");
            this.Property(t => t.ShipCSZ).HasColumnName("ShipCSZ");
            this.Property(t => t.UoM).HasColumnName("UoM");
            this.Property(t => t.OrdrQty).HasColumnName("OrdrQty");
            this.Property(t => t.ShipQty).HasColumnName("ShipQty");
            this.Property(t => t.ar_ivdtl_eadbasecf).HasColumnName("ar_ivdtl_eadbasecf");
            this.Property(t => t.UnitCost).HasColumnName("UnitCost");
            this.Property(t => t.ExtPrice).HasColumnName("ExtPrice");
            this.Property(t => t.TermDesc).HasColumnName("TermDesc");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.VatCode).HasColumnName("VatCode");
            this.Property(t => t.VatRate).HasColumnName("VatRate");
            this.Property(t => t.VatAmt).HasColumnName("VatAmt");
        }
    }
}
