using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class bill_of_lading_sapMap : EntityTypeConfiguration<bill_of_lading_sap>
    {
        public bill_of_lading_sapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_load_key, t.so_hdr_key, t.so_dtl_key, t.ar_ship_key, t.so_hdr_cpono, t.ar_bill_key, t.FrgtKey, t.WhsName, t.WhsLine1, t.HM, t.in_whs_key, t.gl_cmp_key, t.so_dtl_stats });

            // Properties
            this.Property(t => t.so_load_key)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_cpono)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Remark)
                .HasMaxLength(255);

            this.Property(t => t.FrgtKey)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.WhsName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.WhsLine1)
                .IsRequired()
                .HasMaxLength(44);

            this.Property(t => t.WhsLine2)
                .HasMaxLength(44);

            this.Property(t => t.WhsCSZ)
                .HasMaxLength(44);

            this.Property(t => t.ShipName)
                .HasMaxLength(80);

            this.Property(t => t.ShipLine1)
                .HasMaxLength(65);

            this.Property(t => t.ShipLine2)
                .HasMaxLength(65);

            this.Property(t => t.ShipLine3)
                .HasMaxLength(65);

            this.Property(t => t.ShipCSZ)
                .HasMaxLength(65);

            this.Property(t => t.Phone)
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

            this.Property(t => t.en_carr_scac)
                .HasMaxLength(10);

            this.Property(t => t.GLAcct)
                .HasMaxLength(5);

            this.Property(t => t.bol_desc1)
                .HasMaxLength(60);

            this.Property(t => t.bol_desc2)
                .HasMaxLength(60);

            this.Property(t => t.bol_desc3)
                .HasMaxLength(60);

            this.Property(t => t.bol_desc4)
                .HasMaxLength(60);

            this.Property(t => t.bol_desc5)
                .HasMaxLength(60);

            this.Property(t => t.en_frtitem_key)
                .HasMaxLength(10);

            this.Property(t => t.HM)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CarrDesc)
                .HasMaxLength(30);

            this.Property(t => t.im_adres_cntry)
                .HasMaxLength(20);

            this.Property(t => t.en_sltyp_key)
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_hdr_booknum)
                .HasMaxLength(60);

            this.Property(t => t.ex_ship_container)
                .HasMaxLength(30);

            this.Property(t => t.xvessel_name)
                .HasMaxLength(255);

            this.Property(t => t.xvoyage_number)
                .HasMaxLength(255);

            this.Property(t => t.xwport_of_loading)
                .HasMaxLength(255);

            this.Property(t => t.so_hdr_port_discharge)
                .HasMaxLength(60);

            this.Property(t => t.packdesc)
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_stats)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("bill_of_lading_sap");
            this.Property(t => t.so_load_key).HasColumnName("so_load_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.so_ship_date).HasColumnName("so_ship_date");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.so_hdr_cpono).HasColumnName("so_hdr_cpono");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.FrgtKey).HasColumnName("FrgtKey");
            this.Property(t => t.WhsName).HasColumnName("WhsName");
            this.Property(t => t.WhsLine1).HasColumnName("WhsLine1");
            this.Property(t => t.WhsLine2).HasColumnName("WhsLine2");
            this.Property(t => t.WhsCSZ).HasColumnName("WhsCSZ");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.ShipLine1).HasColumnName("ShipLine1");
            this.Property(t => t.ShipLine2).HasColumnName("ShipLine2");
            this.Property(t => t.ShipLine3).HasColumnName("ShipLine3");
            this.Property(t => t.ShipCSZ).HasColumnName("ShipCSZ");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.SoldName).HasColumnName("SoldName");
            this.Property(t => t.SoldLine1).HasColumnName("SoldLine1");
            this.Property(t => t.SoldLine2).HasColumnName("SoldLine2");
            this.Property(t => t.SoldLine3).HasColumnName("SoldLine3");
            this.Property(t => t.SoldCSZ).HasColumnName("SoldCSZ");
            this.Property(t => t.en_carr_scac).HasColumnName("en_carr_scac");
            this.Property(t => t.GLAcct).HasColumnName("GLAcct");
            this.Property(t => t.ShipWt).HasColumnName("ShipWt");
            this.Property(t => t.NoPkg).HasColumnName("NoPkg");
            this.Property(t => t.bol_desc1).HasColumnName("bol_desc1");
            this.Property(t => t.bol_desc2).HasColumnName("bol_desc2");
            this.Property(t => t.bol_desc3).HasColumnName("bol_desc3");
            this.Property(t => t.bol_desc4).HasColumnName("bol_desc4");
            this.Property(t => t.bol_desc5).HasColumnName("bol_desc5");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.HM).HasColumnName("HM");
            this.Property(t => t.CarrDesc).HasColumnName("CarrDesc");
            this.Property(t => t.im_adres_cntry).HasColumnName("im_adres_cntry");
            this.Property(t => t.en_sltyp_key).HasColumnName("en_sltyp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.so_hdr_booknum).HasColumnName("so_hdr_booknum");
            this.Property(t => t.ex_ship_container).HasColumnName("ex_ship_container");
            this.Property(t => t.xvessel_name).HasColumnName("xvessel_name");
            this.Property(t => t.xvoyage_number).HasColumnName("xvoyage_number");
            this.Property(t => t.xwport_of_loading).HasColumnName("xwport_of_loading");
            this.Property(t => t.so_hdr_port_discharge).HasColumnName("so_hdr_port_discharge");
            this.Property(t => t.packdesc).HasColumnName("packdesc");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.so_hdr_pallets).HasColumnName("so_hdr_pallets");
            this.Property(t => t.so_dtl_stats).HasColumnName("so_dtl_stats");
        }
    }
}
