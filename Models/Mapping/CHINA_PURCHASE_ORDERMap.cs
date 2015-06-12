using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_PURCHASE_ORDERMap : EntityTypeConfiguration<CHINA_PURCHASE_ORDER>
    {
        public CHINA_PURCHASE_ORDERMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Ven_itemID, t.Ven_name, t.Ven_key, t.Po_num, t.im_pack_key, t.Remarks, t.ConfVia, t.ConfWith, t.vend_nm, t.ShiptoKey, t.Shipname, t.Line2, t.Line3, t.Line4, t.Line8, t.Date_ordrd, t.Date_reqrd, t.DtlType, t.Detlkey, t.comm_Req, t.UOM, t.Carrier, t.Proj_num, t.Qty_ordrd, t.Price_Qty, t.Price_Uom, t.Descr, t.Dtlcomments, t.Byr_Cde, t.Stats_Code, t.Whname, t.Wh_Addr1, t.Wh_Key, t.Wh_addr2, t.Wh_Postc, t.Wh_City, t.Wh_st, t.Wh_cntry, t.Frt_Terms, t.po_hdr_orddt, t.po_hdr_reqdt, t.gl_cmp_key, t.po_hdr_revno, t.unit_price_foreign, t.EN_SERVICE_KEY, t.po_dtl_stats, t.GL_VATRATE_PCT, t.PO_DTL_CMMTS, t.ap_remt_key, t.po_dtl_vatcf, t.LineOrder });

            // Properties
            this.Property(t => t.Ven_itemID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Ven_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Ven_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Po_num)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Remarks)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ConfVia)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ConfWith)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.vend_nm)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ShiptoKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Shipname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Line2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Line3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Line4)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Line5)
                .HasMaxLength(20);

            this.Property(t => t.Line6)
                .HasMaxLength(60);

            this.Property(t => t.Line7)
                .HasMaxLength(60);

            this.Property(t => t.Line8)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DtlType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Detlkey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemKey)
                .HasMaxLength(20);

            this.Property(t => t.FOb_dtl)
                .HasMaxLength(30);

            this.Property(t => t.EnItemKey)
                .HasMaxLength(20);

            this.Property(t => t.EnItemDesc)
                .HasMaxLength(60);

            this.Property(t => t.comm_Req)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.UOM)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Trms)
                .HasMaxLength(30);

            this.Property(t => t.FOB)
                .HasMaxLength(30);

            this.Property(t => t.Carrier)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Carrier_Desc)
                .HasMaxLength(30);

            this.Property(t => t.Proj_num)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Price_Uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Descr)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.Dtlcomments)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Byr_Cde)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.Stats_Code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Whname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Wh_Addr1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Wh_Key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Wh_addr2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Wh_Postc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Wh_City)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Wh_st)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Wh_cntry)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Buydesc)
                .HasMaxLength(30);

            this.Property(t => t.Itm_key_itdsc)
                .HasMaxLength(20);

            this.Property(t => t.Itm_desc)
                .HasMaxLength(255);

            this.Property(t => t.Frt_Terms)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.direct_ship_name)
                .HasMaxLength(30);

            this.Property(t => t.direct_ship_adr1)
                .HasMaxLength(30);

            this.Property(t => t.direct_ship_adr2)
                .HasMaxLength(30);

            this.Property(t => t.direct_ship_adr3)
                .HasMaxLength(30);

            this.Property(t => t.direct_ship_city)
                .HasMaxLength(20);

            this.Property(t => t.direct_ship_state)
                .HasMaxLength(10);

            this.Property(t => t.direct_ship_cntry)
                .HasMaxLength(20);

            this.Property(t => t.direct_ship_zip)
                .HasMaxLength(10);

            this.Property(t => t.direct_ship_no)
                .HasMaxLength(10);

            this.Property(t => t.po_hdr_revno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EN_SERVICE_KEY)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GL_CRNCY_KEY)
                .HasMaxLength(3);

            this.Property(t => t.countertype)
                .HasMaxLength(1);

            this.Property(t => t.po_dtl_stats)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VPRT)
                .HasMaxLength(30);

            this.Property(t => t.VDESC)
                .HasMaxLength(60);

            this.Property(t => t.PO_DTL_CMMTS)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.requisition_number)
                .HasMaxLength(10);

            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LineOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CHINA_PURCHASE_ORDER");
            this.Property(t => t.Ven_itemID).HasColumnName("Ven_itemID");
            this.Property(t => t.Ven_name).HasColumnName("Ven_name");
            this.Property(t => t.Ven_key).HasColumnName("Ven_key");
            this.Property(t => t.Po_num).HasColumnName("Po_num");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.ConfVia).HasColumnName("ConfVia");
            this.Property(t => t.ConfWith).HasColumnName("ConfWith");
            this.Property(t => t.ConfDt).HasColumnName("ConfDt");
            this.Property(t => t.vend_nm).HasColumnName("vend_nm");
            this.Property(t => t.ShiptoKey).HasColumnName("ShiptoKey");
            this.Property(t => t.Shipname).HasColumnName("Shipname");
            this.Property(t => t.Line2).HasColumnName("Line2");
            this.Property(t => t.Line3).HasColumnName("Line3");
            this.Property(t => t.Line4).HasColumnName("Line4");
            this.Property(t => t.Line5).HasColumnName("Line5");
            this.Property(t => t.Line6).HasColumnName("Line6");
            this.Property(t => t.Line7).HasColumnName("Line7");
            this.Property(t => t.Line8).HasColumnName("Line8");
            this.Property(t => t.Date_ordrd).HasColumnName("Date_ordrd");
            this.Property(t => t.Date_reqrd).HasColumnName("Date_reqrd");
            this.Property(t => t.DtlType).HasColumnName("DtlType");
            this.Property(t => t.Detlkey).HasColumnName("Detlkey");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.FOb_dtl).HasColumnName("FOb_dtl");
            this.Property(t => t.EnItemKey).HasColumnName("EnItemKey");
            this.Property(t => t.EnItemDesc).HasColumnName("EnItemDesc");
            this.Property(t => t.comm_Req).HasColumnName("comm_Req");
            this.Property(t => t.UOM).HasColumnName("UOM");
            this.Property(t => t.Trms).HasColumnName("Trms");
            this.Property(t => t.FOB).HasColumnName("FOB");
            this.Property(t => t.Carrier).HasColumnName("Carrier");
            this.Property(t => t.Carrier_Desc).HasColumnName("Carrier Desc");
            this.Property(t => t.Proj_num).HasColumnName("Proj_num");
            this.Property(t => t.Qty_ordrd).HasColumnName("Qty_ordrd");
            this.Property(t => t.Price_Qty).HasColumnName("Price Qty");
            this.Property(t => t.Price_Uom).HasColumnName("Price Uom");
            this.Property(t => t.Descr).HasColumnName("Descr");
            this.Property(t => t.Unit_prce).HasColumnName("Unit_prce");
            this.Property(t => t.Dtlcomments).HasColumnName("Dtlcomments");
            this.Property(t => t.Byr_Cde).HasColumnName("Byr_Cde");
            this.Property(t => t.Stats_Code).HasColumnName("Stats_Code");
            this.Property(t => t.Whname).HasColumnName("Whname");
            this.Property(t => t.Wh_Addr1).HasColumnName("Wh_Addr1");
            this.Property(t => t.Wh_Key).HasColumnName("Wh_Key");
            this.Property(t => t.Wh_addr2).HasColumnName("Wh_addr2");
            this.Property(t => t.Wh_Postc).HasColumnName("Wh_Postc");
            this.Property(t => t.Wh_City).HasColumnName("Wh_City");
            this.Property(t => t.Wh_st).HasColumnName("Wh_st");
            this.Property(t => t.Wh_cntry).HasColumnName("Wh_cntry");
            this.Property(t => t.Buydesc).HasColumnName("Buydesc");
            this.Property(t => t.Itm_key_itdsc).HasColumnName("Itm_key_itdsc");
            this.Property(t => t.Itm_desc).HasColumnName("Itm_desc");
            this.Property(t => t.Frt_Terms).HasColumnName("Frt_Terms");
            this.Property(t => t.po_hdr_orddt).HasColumnName("po_hdr_orddt");
            this.Property(t => t.po_hdr_reqdt).HasColumnName("po_hdr_reqdt");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.direct_ship_name).HasColumnName("direct_ship_name");
            this.Property(t => t.direct_ship_adr1).HasColumnName("direct_ship_adr1");
            this.Property(t => t.direct_ship_adr2).HasColumnName("direct_ship_adr2");
            this.Property(t => t.direct_ship_adr3).HasColumnName("direct_ship_adr3");
            this.Property(t => t.direct_ship_city).HasColumnName("direct_ship_city");
            this.Property(t => t.direct_ship_state).HasColumnName("direct_ship_state");
            this.Property(t => t.direct_ship_cntry).HasColumnName("direct_ship_cntry");
            this.Property(t => t.direct_ship_zip).HasColumnName("direct_ship_zip");
            this.Property(t => t.direct_ship_no).HasColumnName("direct_ship_no");
            this.Property(t => t.po_hdr_revno).HasColumnName("po_hdr_revno");
            this.Property(t => t.unit_price_foreign).HasColumnName("unit_price_foreign");
            this.Property(t => t.EN_SERVICE_KEY).HasColumnName("EN_SERVICE_KEY");
            this.Property(t => t.GL_CRNCY_KEY).HasColumnName("GL_CRNCY_KEY");
            this.Property(t => t.countertype).HasColumnName("countertype");
            this.Property(t => t.po_dtl_stats).HasColumnName("po_dtl_stats");
            this.Property(t => t.po_hdr_revdt).HasColumnName("po_hdr_revdt");
            this.Property(t => t.GL_VATRATE_PCT).HasColumnName("GL_VATRATE_PCT");
            this.Property(t => t.VPRT).HasColumnName("VPRT");
            this.Property(t => t.VDESC).HasColumnName("VDESC");
            this.Property(t => t.PO_DTL_CMMTS).HasColumnName("PO_DTL_CMMTS");
            this.Property(t => t.requisition_number).HasColumnName("requisition_number");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.fullprice).HasColumnName("fullprice");
            this.Property(t => t.po_dtl_vatcf).HasColumnName("po_dtl_vatcf");
            this.Property(t => t.LineOrder).HasColumnName("LineOrder");
        }
    }
}
