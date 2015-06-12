using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class open_order_daily_pictureMap : EntityTypeConfiguration<open_order_daily_picture>
    {
        public open_order_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderNo, t.COUNTRY, t.OrderQty, t.ShipQty, t.Price, t.AllocQty, t.Status, t.Product, t.PONumber, t.ScheduledShipDate, t.PromiseDate, t.RequiredDate, t.Warehouse, t.Ship_Key, t.GL_CMP_KEY, t.en_ship_name, t.OrderDate, t.so_dtl_key, t.LineCreateDate });

            // Properties
            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.COUNTRY)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Product)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PONumber)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Uom)
                .HasMaxLength(2);

            this.Property(t => t.Warehouse)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Ship_Key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GL_CMP_KEY)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_ship_name)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_mktseg_key)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Market)
                .HasMaxLength(30);

            this.Property(t => t.Source)
                .HasMaxLength(10);

            this.Property(t => t.SalesType)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("open_order_daily_picture");
            this.Property(t => t.yearcapture).HasColumnName("yearcapture");
            this.Property(t => t.weekcapture).HasColumnName("weekcapture");
            this.Property(t => t.monthcapture).HasColumnName("monthcapture");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.COUNTRY).HasColumnName("COUNTRY");
            this.Property(t => t.OrderQty).HasColumnName("OrderQty");
            this.Property(t => t.ShipQty).HasColumnName("ShipQty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.AllocQty).HasColumnName("AllocQty");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.PONumber).HasColumnName("PONumber");
            this.Property(t => t.ScheduledShipDate).HasColumnName("ScheduledShipDate");
            this.Property(t => t.PromiseDate).HasColumnName("PromiseDate");
            this.Property(t => t.RequiredDate).HasColumnName("RequiredDate");
            this.Property(t => t.Uom).HasColumnName("Uom");
            this.Property(t => t.Packsize).HasColumnName("Packsize");
            this.Property(t => t.Warehouse).HasColumnName("Warehouse");
            this.Property(t => t.Ship_Key).HasColumnName("Ship Key");
            this.Property(t => t.GL_CMP_KEY).HasColumnName("GL_CMP_KEY");
            this.Property(t => t.en_ship_name).HasColumnName("en_ship_name");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.en_mktseg_key).HasColumnName("en_mktseg_key");
            this.Property(t => t.Market).HasColumnName("Market");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.SalesType).HasColumnName("SalesType");
            this.Property(t => t.LineCreateDate).HasColumnName("LineCreateDate");
        }
    }
}
