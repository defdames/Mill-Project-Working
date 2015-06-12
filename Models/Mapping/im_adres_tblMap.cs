using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_adres_tblMap : EntityTypeConfiguration<im_adres_tbl>
    {
        public im_adres_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.im_adres_key);

            // Properties
            this.Property(t => t.im_adres_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_adres_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_line1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_line2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_line3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_adres_cntry)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_pczip)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_adres_tel)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_fax)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_telex)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_modem)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.im_adres_cmnts)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.im_adres_itnet)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.en_frtzone_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_geocode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cntry_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("im_adres_tbl");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.im_adres_name).HasColumnName("im_adres_name");
            this.Property(t => t.im_adres_line1).HasColumnName("im_adres_line1");
            this.Property(t => t.im_adres_line2).HasColumnName("im_adres_line2");
            this.Property(t => t.im_adres_line3).HasColumnName("im_adres_line3");
            this.Property(t => t.im_adres_city).HasColumnName("im_adres_city");
            this.Property(t => t.im_adres_state).HasColumnName("im_adres_state");
            this.Property(t => t.im_adres_cntry).HasColumnName("im_adres_cntry");
            this.Property(t => t.im_adres_pczip).HasColumnName("im_adres_pczip");
            this.Property(t => t.im_adres_tel).HasColumnName("im_adres_tel");
            this.Property(t => t.im_adres_fax).HasColumnName("im_adres_fax");
            this.Property(t => t.im_adres_telex).HasColumnName("im_adres_telex");
            this.Property(t => t.im_adres_modem).HasColumnName("im_adres_modem");
            this.Property(t => t.im_adres_crtdt).HasColumnName("im_adres_crtdt");
            this.Property(t => t.im_adres_chgdt).HasColumnName("im_adres_chgdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.im_adres_cmnts).HasColumnName("im_adres_cmnts");
            this.Property(t => t.im_adres_itnet).HasColumnName("im_adres_itnet");
            this.Property(t => t.en_frtzone_key).HasColumnName("en_frtzone_key");
            this.Property(t => t.en_geocode_key).HasColumnName("en_geocode_key");
            this.Property(t => t.im_adres_upcnt).HasColumnName("im_adres_upcnt");
            this.Property(t => t.en_cntry_key).HasColumnName("en_cntry_key");
        }
    }
}
