using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class channelpartner_product_masterMap : EntityTypeConfiguration<channelpartner_product_master>
    {
        public channelpartner_product_masterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.channel_partner_code, t.product_code });

            // Properties
            this.Property(t => t.channel_partner_code)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.product_code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.product_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.smc_en_prod_key)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("channelpartner_product_master");
            this.Property(t => t.channel_partner_code).HasColumnName("channel_partner_code");
            this.Property(t => t.product_code).HasColumnName("product_code");
            this.Property(t => t.product_name).HasColumnName("product_name");
            this.Property(t => t.smc_en_prod_key).HasColumnName("smc_en_prod_key");
        }
    }
}
