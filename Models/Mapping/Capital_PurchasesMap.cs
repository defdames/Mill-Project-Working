using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Capital_PurchasesMap : EntityTypeConfiguration<Capital_Purchases>
    {
        public Capital_PurchasesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Ven_name, t.Ven_key, t.Po_num, t.im_pack_key, t.Remarks, t.ConfVia, t.vend_nm, t.ShiptoKey, t.Shipname, t.Addr1, t.Addr2, t.CityStateZip, t.Date_ordrd, t.Date_reqrd, t.DtlType, t.Detlkey, t.ItemKey, t.comm_Req, t.UOM, t.Carrier, t.Proj_num, t.Qty_ordrd, t.Price_Qty, t.Price_Uom, t.Descr, t.Unit_prce, t.Dtlcomments, t.Byr_Cde, t.Stats_Code, t.Whname, t.Wh_Addr1, t.Wh_Key, t.Wh_addr2, t.Wh_Postc, t.Wh_City, t.Wh_st, t.Wh_cntry, t.Frt_Terms });

            // Properties
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

            this.Property(t => t.vend_nm)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ShiptoKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Shipname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Addr1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Addr2)
                .IsRequired()
                .HasMaxLength(44);

            this.Property(t => t.CityStateZip)
                .IsRequired()
                .HasMaxLength(44);

            this.Property(t => t.Country)
                .HasMaxLength(44);

            this.Property(t => t.DtlType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Detlkey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemKey)
                .IsRequired()
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

            // Table & Column Mappings
            this.ToTable("Capital_Purchases");
            this.Property(t => t.Ven_name).HasColumnName("Ven_name");
            this.Property(t => t.Ven_key).HasColumnName("Ven_key");
            this.Property(t => t.Po_num).HasColumnName("Po_num");
            this.Property(t => t.WhsCnt).HasColumnName("WhsCnt");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.ConfVia).HasColumnName("ConfVia");
            this.Property(t => t.vend_nm).HasColumnName("vend_nm");
            this.Property(t => t.ShiptoKey).HasColumnName("ShiptoKey");
            this.Property(t => t.Shipname).HasColumnName("Shipname");
            this.Property(t => t.Addr1).HasColumnName("Addr1");
            this.Property(t => t.Addr2).HasColumnName("Addr2");
            this.Property(t => t.CityStateZip).HasColumnName("CityStateZip");
            this.Property(t => t.Country).HasColumnName("Country");
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
            this.Property(t => t.pototal).HasColumnName("pototal");
        }
    }
}
