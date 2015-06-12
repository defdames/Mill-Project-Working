using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class channelpartner_shipto_crossrefMap : EntityTypeConfiguration<channelpartner_shipto_crossref>
    {
        public channelpartner_shipto_crossrefMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_ship_name, t.im_adres_city, t.im_adres_state, t.en_ship_key });

            // Properties
            this.Property(t => t.en_ship_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("channelpartner_shipto_crossref");
            this.Property(t => t.en_ship_name).HasColumnName("en_ship_name");
            this.Property(t => t.im_adres_city).HasColumnName("im_adres_city");
            this.Property(t => t.im_adres_state).HasColumnName("im_adres_state");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
        }
    }
}
