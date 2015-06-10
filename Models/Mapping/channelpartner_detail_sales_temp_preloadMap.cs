using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class channelpartner_detail_sales_temp_preloadMap : EntityTypeConfiguration<channelpartner_detail_sales_temp_preload>
    {
        public channelpartner_detail_sales_temp_preloadMap()
        {
            // Primary Key
            this.HasKey(t => new { t.approved, t.uploaded });

            // Properties
            this.Property(t => t.channel_partner_code)
                .HasMaxLength(2);

            this.Property(t => t.customer_code)
                .HasMaxLength(50);

            this.Property(t => t.invoice_number)
                .HasMaxLength(50);

            this.Property(t => t.product_code)
                .HasMaxLength(50);

            this.Property(t => t.lot_number)
                .HasMaxLength(50);

            this.Property(t => t.uom)
                .HasMaxLength(2);

            this.Property(t => t.rebate)
                .HasMaxLength(1);

            this.Property(t => t.approved)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.uploaded)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.currency)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("channelpartner_detail_sales_temp_preload");
            this.Property(t => t.channel_partner_code).HasColumnName("channel_partner_code");
            this.Property(t => t.customer_code).HasColumnName("customer_code");
            this.Property(t => t.invoice_number).HasColumnName("invoice_number");
            this.Property(t => t.invoice_date).HasColumnName("invoice_date");
            this.Property(t => t.product_code).HasColumnName("product_code");
            this.Property(t => t.lot_number).HasColumnName("lot_number");
            this.Property(t => t.units_sold).HasColumnName("units_sold");
            this.Property(t => t.uom).HasColumnName("uom");
            this.Property(t => t.dollars).HasColumnName("dollars");
            this.Property(t => t.rebate).HasColumnName("rebate");
            this.Property(t => t.approved).HasColumnName("approved");
            this.Property(t => t.uploaded).HasColumnName("uploaded");
            this.Property(t => t.currency).HasColumnName("currency");
        }
    }
}
