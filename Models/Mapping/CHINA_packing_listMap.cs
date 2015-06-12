using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_packing_listMap : EntityTypeConfiguration<CHINA_packing_list>
    {
        public CHINA_packing_listMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_hdr_key, t.ar_ship_key, t.ar_bill_key, t.en_cust_key, t.so_hdr_crtdt, t.so_hdr_ref, t.so_dtl_stats, t.so_dtl_key, t.so_dtl_shsdt, t.so_dtl_ordqt, t.so_dtl_cprtn, t.so_dtl_cpono, t.in_prod_key, t.in_prod_desc, t.so_dtl_shpqt, t.so_dtl_shpws, t.en_frgt_key, t.so_dtl_prmdt, t.DtlInst, t.gl_cmp_key, t.porp });

            // Properties
            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_cpono)
                .HasMaxLength(25);

            this.Property(t => t.so_hdr_ref)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_stats)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.so_dtl_fobds)
                .HasMaxLength(30);

            this.Property(t => t.so_dtl_cprtn)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_dtl_cpono)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.so_dtl_shpws)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_frgt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_carr_key)
                .HasMaxLength(10);

            this.Property(t => t.im_pack_key)
                .HasMaxLength(6);

            this.Property(t => t.DtlInst)
                .IsRequired()
                .HasMaxLength(180);

            this.Property(t => t.in_lot_key)
                .HasMaxLength(25);

            this.Property(t => t.InsNo)
                .HasMaxLength(12);

            this.Property(t => t.Remarks)
                .HasMaxLength(255);

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

            this.Property(t => t.ShipTel)
                .HasMaxLength(20);

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

            this.Property(t => t.LineNbr)
                .HasMaxLength(13);

            this.Property(t => t.TermDesc)
                .HasMaxLength(30);

            this.Property(t => t.CarrDesc)
                .HasMaxLength(30);

            this.Property(t => t.so_hdr_booknum)
                .HasMaxLength(60);

            this.Property(t => t.ex_ship_container)
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.inv_whs)
                .HasMaxLength(4);

            this.Property(t => t.in_whs_name)
                .HasMaxLength(30);

            this.Property(t => t.in_whs_adr1)
                .HasMaxLength(30);

            this.Property(t => t.in_whs_adr2)
                .HasMaxLength(30);

            this.Property(t => t.whsline3)
                .HasMaxLength(31);

            this.Property(t => t.whsline4)
                .HasMaxLength(31);

            this.Property(t => t.EN_MODE_KEY)
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

            this.Property(t => t.so_hdr_instrux)
                .HasMaxLength(255);

            this.Property(t => t.so_hdr_spec_instrux)
                .HasMaxLength(255);

            this.Property(t => t.xwport_of_loading)
                .HasMaxLength(255);

            this.Property(t => t.so_hdr_port_discharge)
                .HasMaxLength(60);

            this.Property(t => t.porp)
                .IsRequired()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("CHINA_packing_list");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.so_hdr_crtdt).HasColumnName("so_hdr_crtdt");
            this.Property(t => t.so_hdr_cpono).HasColumnName("so_hdr_cpono");
            this.Property(t => t.so_hdr_ref).HasColumnName("so_hdr_ref");
            this.Property(t => t.so_dtl_stats).HasColumnName("so_dtl_stats");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.so_dtl_shsdt).HasColumnName("so_dtl_shsdt");
            this.Property(t => t.so_dtl_fobds).HasColumnName("so_dtl_fobds");
            this.Property(t => t.so_dtl_ordqt).HasColumnName("so_dtl_ordqt");
            this.Property(t => t.so_dtl_cprtn).HasColumnName("so_dtl_cprtn");
            this.Property(t => t.so_dtl_cpono).HasColumnName("so_dtl_cpono");
            this.Property(t => t.in_prod_key).HasColumnName("in_prod_key");
            this.Property(t => t.in_prod_desc).HasColumnName("in_prod_desc");
            this.Property(t => t.so_dtl_shpqt).HasColumnName("so_dtl_shpqt");
            this.Property(t => t.so_dtl_shpws).HasColumnName("so_dtl_shpws");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.so_dtl_prmdt).HasColumnName("so_dtl_prmdt");
            this.Property(t => t.DtlInst).HasColumnName("DtlInst");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.InsNo).HasColumnName("InsNo");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.ShipLine1).HasColumnName("ShipLine1");
            this.Property(t => t.ShipLine2).HasColumnName("ShipLine2");
            this.Property(t => t.ShipLine3).HasColumnName("ShipLine3");
            this.Property(t => t.ShipCSZ).HasColumnName("ShipCSZ");
            this.Property(t => t.ShipTel).HasColumnName("ShipTel");
            this.Property(t => t.SoldName).HasColumnName("SoldName");
            this.Property(t => t.SoldLine1).HasColumnName("SoldLine1");
            this.Property(t => t.SoldLine2).HasColumnName("SoldLine2");
            this.Property(t => t.SoldLine3).HasColumnName("SoldLine3");
            this.Property(t => t.SoldCSZ).HasColumnName("SoldCSZ");
            this.Property(t => t.UoM).HasColumnName("UoM");
            this.Property(t => t.NoPkg).HasColumnName("NoPkg");
            this.Property(t => t.OrdrQty).HasColumnName("OrdrQty");
            this.Property(t => t.ShipQty).HasColumnName("ShipQty");
            this.Property(t => t.LineNbr).HasColumnName("LineNbr");
            this.Property(t => t.TermDesc).HasColumnName("TermDesc");
            this.Property(t => t.CarrDesc).HasColumnName("CarrDesc");
            this.Property(t => t.ShipDate).HasColumnName("ShipDate");
            this.Property(t => t.so_hdr_booknum).HasColumnName("so_hdr_booknum");
            this.Property(t => t.ex_ship_container).HasColumnName("ex_ship_container");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.inv_whs).HasColumnName("inv_whs");
            this.Property(t => t.in_whs_name).HasColumnName("in_whs_name");
            this.Property(t => t.in_whs_adr1).HasColumnName("in_whs_adr1");
            this.Property(t => t.in_whs_adr2).HasColumnName("in_whs_adr2");
            this.Property(t => t.whsline3).HasColumnName("whsline3");
            this.Property(t => t.whsline4).HasColumnName("whsline4");
            this.Property(t => t.EN_MODE_KEY).HasColumnName("EN_MODE_KEY");
            this.Property(t => t.ex_ship_mark1).HasColumnName("ex_ship_mark1");
            this.Property(t => t.ex_ship_mark2).HasColumnName("ex_ship_mark2");
            this.Property(t => t.ex_ship_mark3).HasColumnName("ex_ship_mark3");
            this.Property(t => t.ex_ship_mark4).HasColumnName("ex_ship_mark4");
            this.Property(t => t.ex_ship_mark5).HasColumnName("ex_ship_mark5");
            this.Property(t => t.ex_ship_mark6).HasColumnName("ex_ship_mark6");
            this.Property(t => t.so_hdr_instrux).HasColumnName("so_hdr_instrux");
            this.Property(t => t.so_hdr_pallets).HasColumnName("so_hdr_pallets");
            this.Property(t => t.so_hdr_spec_instrux).HasColumnName("so_hdr_spec_instrux");
            this.Property(t => t.im_pack_qty).HasColumnName("im_pack_qty");
            this.Property(t => t.so_hdr_reqdt).HasColumnName("so_hdr_reqdt");
            this.Property(t => t.xwport_of_loading).HasColumnName("xwport_of_loading");
            this.Property(t => t.so_hdr_port_discharge).HasColumnName("so_hdr_port_discharge");
            this.Property(t => t.GrossWt).HasColumnName("GrossWt");
            this.Property(t => t.porp).HasColumnName("porp");
        }
    }
}
