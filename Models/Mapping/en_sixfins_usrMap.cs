using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_sixfins_usrMap : EntityTypeConfiguration<en_sixfins_usr>
    {
        public en_sixfins_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_ship_key, t.en_item_key, t.im_insmst_key });

            // Properties
            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_insmst_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sa_user_key)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_sixfins_usr");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.en_crt_dt).HasColumnName("en_crt_dt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
