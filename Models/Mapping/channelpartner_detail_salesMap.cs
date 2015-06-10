using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class channelpartner_detail_salesMap : EntityTypeConfiguration<channelpartner_detail_sales>
    {
        public channelpartner_detail_salesMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.channel_partner_code)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.customer_code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.invoice_number)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.product_code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.lot_number)
                .HasMaxLength(50);

            this.Property(t => t.uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.rebate)
                .HasMaxLength(1);

            this.Property(t => t.approved)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.uploaded)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("channelpartner_detail_sales");
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
            this.Property(t => t.id).HasColumnName("id");
        }
    }
}
