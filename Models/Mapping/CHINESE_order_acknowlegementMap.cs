using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINESE_order_acknowlegementMap : EntityTypeConfiguration<CHINESE_order_acknowlegement>
    {
        public CHINESE_order_acknowlegementMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_bill_key, t.ar_ship_key, t.so_hdr_key, t.en_cust_key, t.OrderDate, t.so_hdr_ref, t.so_hdr_cont, t.gl_cmp_key, t.so_hdr_typec, t.hdrcustpo, t.gl_crncy_key });

            // Properties
            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.ProdKey)
                .HasMaxLength(20);

            this.Property(t => t.ProdDesc)
                .HasMaxLength(60);

            this.Property(t => t.so_dtl_shpws)
                .HasMaxLength(4);

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
                .HasMaxLength(200);

            this.Property(t => t.ShipLine1)
                .HasMaxLength(807);

            this.Property(t => t.ShipLine2)
                .HasMaxLength(807);

            this.Property(t => t.ShipLine3)
                .HasMaxLength(807);

            this.Property(t => t.ShipCSZ)
                .HasMaxLength(807);

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

            this.Property(t => t.DtlInst)
                .HasMaxLength(180);

            this.Property(t => t.TermDesc)
                .HasMaxLength(30);

            this.Property(t => t.so_hdr_ref)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_cont)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_hdr_typec)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.xwport_of_loading)
                .HasMaxLength(255);

            this.Property(t => t.so_hdr_port_discharge)
                .HasMaxLength(60);

            this.Property(t => t.zord_ack)
                .HasMaxLength(255);

            this.Property(t => t.so_dtl_instrux)
                .HasMaxLength(999);

            this.Property(t => t.hdrcustpo)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("CHINESE_order_acknowlegement");
            this.Property(t => t.so_prod_shipf).HasColumnName("so_prod_shipf");
            this.Property(t => t.so_dtl_shpqt).HasColumnName("so_dtl_shpqt");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.ProdKey).HasColumnName("ProdKey");
            this.Property(t => t.ProdDesc).HasColumnName("ProdDesc");
            this.Property(t => t.so_dtl_ordqt).HasColumnName("so_dtl_ordqt");
            this.Property(t => t.UNITPRICE).HasColumnName("UNITPRICE");
            this.Property(t => t.so_dtl_shpws).HasColumnName("so_dtl_shpws");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.RequiredDate).HasColumnName("RequiredDate");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.FOB).HasColumnName("FOB");
            this.Property(t => t.so_dtl_cprtn).HasColumnName("so_dtl_cprtn");
            this.Property(t => t.so_dtl_cpono).HasColumnName("so_dtl_cpono");
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
            this.Property(t => t.DtlInst).HasColumnName("DtlInst");
            this.Property(t => t.TermDesc).HasColumnName("TermDesc");
            this.Property(t => t.so_hdr_ref).HasColumnName("so_hdr_ref");
            this.Property(t => t.so_dtl_prmdt).HasColumnName("so_dtl_prmdt");
            this.Property(t => t.so_dtl_shsdt).HasColumnName("so_dtl_shsdt");
            this.Property(t => t.so_hdr_cont).HasColumnName("so_hdr_cont");
            this.Property(t => t.orderqty).HasColumnName("orderqty");
            this.Property(t => t.in_whitm_scst).HasColumnName("in_whitm_scst");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_hdr_typec).HasColumnName("so_hdr_typec");
            this.Property(t => t.xwport_of_loading).HasColumnName("xwport_of_loading");
            this.Property(t => t.so_hdr_port_discharge).HasColumnName("so_hdr_port_discharge");
            this.Property(t => t.zord_ack).HasColumnName("zord_ack");
            this.Property(t => t.so_dtl_instrux).HasColumnName("so_dtl_instrux");
            this.Property(t => t.hdrcustpo).HasColumnName("hdrcustpo");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.so_dtlpr_vatcf).HasColumnName("so_dtlpr_vatcf");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
        }
    }
}
