using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class channelpartner_customer_masterMap : EntityTypeConfiguration<channelpartner_customer_master>
    {
        public channelpartner_customer_masterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.channel_partner_code, t.customer_code });

            // Properties
            this.Property(t => t.channel_partner_code)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.customer_code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.customer_name)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.city)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.state)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.country)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.smc_en_ship_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("channelpartner_customer_master");
            this.Property(t => t.channel_partner_code).HasColumnName("channel_partner_code");
            this.Property(t => t.customer_code).HasColumnName("customer_code");
            this.Property(t => t.customer_name).HasColumnName("customer_name");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.smc_en_ship_key).HasColumnName("smc_en_ship_key");
            this.Property(t => t.NonAdage_Ship_key).HasColumnName("NonAdage_Ship_key");
        }
    }
}
