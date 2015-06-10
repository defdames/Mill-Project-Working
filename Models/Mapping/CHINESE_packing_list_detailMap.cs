using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINESE_packing_list_detailMap : EntityTypeConfiguration<CHINESE_packing_list_detail>
    {
        public CHINESE_packing_list_detailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_hdr_key, t.so_brnch_key, t.gl_cmp_key, t.ar_ship_key, t.ar_bill_key, t.en_cust_key, t.so_hdr_crtdt, t.so_hdr_ref, t.so_dtl_stats, t.so_dtl_key, t.so_dtl_shsdt, t.so_dtl_ordqt, t.so_dtl_cprtn, t.so_dtl_cpono, t.in_prod_key, t.in_prod_desc, t.so_dtl_shpqt, t.so_dtl_shpws, t.en_frgt_key, t.so_dtl_prmdt, t.en_frtitem_key });

            // Properties
            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

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
                .HasMaxLength(180);

            this.Property(t => t.LotKey)
                .HasMaxLength(25);

            this.Property(t => t.InsNo)
                .HasMaxLength(12);

            this.Property(t => t.Remarks)
                .HasMaxLength(255);

            this.Property(t => t.ShipName)
                .HasMaxLength(200);

            this.Property(t => t.ShipLine1)
                .HasMaxLength(807);

            this.Property(t => t.ShipLine2)
                .HasMaxLength(807);

            this.Property(t => t.ShipLine3)
                .HasMaxLength(807);

            this.Property(t => t.ShipCSZ)
                .HasMaxLength(807);

            this.Property(t => t.ShipTel)
                .HasMaxLength(20);

            this.Property(t => t.SoldName)
                .HasMaxLength(200);

            this.Property(t => t.SoldLine1)
                .HasMaxLength(807);

            this.Property(t => t.SoldLine2)
                .HasMaxLength(807);

            this.Property(t => t.SoldLine3)
                .HasMaxLength(807);

            this.Property(t => t.SoldCSZ)
                .HasMaxLength(807);

            this.Property(t => t.UoM)
                .HasMaxLength(2);

            this.Property(t => t.LineNbr)
                .HasMaxLength(13);

            this.Property(t => t.TermDesc)
                .HasMaxLength(30);

            this.Property(t => t.CarrDesc)
                .HasMaxLength(200);

            this.Property(t => t.so_hdr_booknum)
                .HasMaxLength(60);

            this.Property(t => t.ex_ship_container)
                .HasMaxLength(30);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.en_frtitem_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cntry_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CHINESE_packing_list_detail");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
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
            this.Property(t => t.so_dtl_prmdt).HasColumnName("so_dtl_prmdt");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.DtlInst).HasColumnName("DtlInst");
            this.Property(t => t.LotKey).HasColumnName("LotKey");
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
            this.Property(t => t.NoPkgSAP).HasColumnName("NoPkgSAP");
            this.Property(t => t.OrdrQty).HasColumnName("OrdrQty");
            this.Property(t => t.ShipQty).HasColumnName("ShipQty");
            this.Property(t => t.LineNbr).HasColumnName("LineNbr");
            this.Property(t => t.TermDesc).HasColumnName("TermDesc");
            this.Property(t => t.CarrDesc).HasColumnName("CarrDesc");
            this.Property(t => t.so_hdr_booknum).HasColumnName("so_hdr_booknum");
            this.Property(t => t.ex_ship_container).HasColumnName("ex_ship_container");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.GrossWt).HasColumnName("GrossWt");
            this.Property(t => t.en_cntry_key).HasColumnName("en_cntry_key");
            this.Property(t => t.en_hazard_flg).HasColumnName("en_hazard_flg");
        }
    }
}
