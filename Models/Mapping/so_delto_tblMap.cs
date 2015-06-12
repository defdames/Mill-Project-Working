using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_delto_tblMap : EntityTypeConfiguration<so_delto_tbl>
    {
        public so_delto_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_hdr_key, t.so_dtl_key, t.im_adrtp_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_adrtp_key)
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

            this.Property(t => t.im_adres_itnet)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.im_adres_cmnts)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.sa_modified_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sa_created_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_geocode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frtzone_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cntry_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("so_delto_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.im_adrtp_key).HasColumnName("im_adrtp_key");
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
            this.Property(t => t.im_adres_itnet).HasColumnName("im_adres_itnet");
            this.Property(t => t.im_adres_cmnts).HasColumnName("im_adres_cmnts");
            this.Property(t => t.sa_modified_by).HasColumnName("sa_modified_by");
            this.Property(t => t.sa_created_by).HasColumnName("sa_created_by");
            this.Property(t => t.sa_change_date).HasColumnName("sa_change_date");
            this.Property(t => t.sa_create_date).HasColumnName("sa_create_date");
            this.Property(t => t.en_geocode_key).HasColumnName("en_geocode_key");
            this.Property(t => t.en_frtzone_key).HasColumnName("en_frtzone_key");
            this.Property(t => t.so_delto_upcnt).HasColumnName("so_delto_upcnt");
            this.Property(t => t.en_cntry_key).HasColumnName("en_cntry_key");
        }
    }
}
