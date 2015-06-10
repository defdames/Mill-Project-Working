using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_adres_extMap : EntityTypeConfiguration<im_adres_ext>
    {
        public im_adres_extMap()
        {
            // Primary Key
            this.HasKey(t => t.im_adres_key);

            // Properties
            this.Property(t => t.im_adres_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_adres_adrtype)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("im_adres_ext");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.im_adres_adrtype).HasColumnName("im_adres_adrtype");
            this.Property(t => t.im_adres_upcnt).HasColumnName("im_adres_upcnt");
        }
    }
}
