using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lang_im_adres_tblMap : EntityTypeConfiguration<lang_im_adres_tbl>
    {
        public lang_im_adres_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.im_adres_key, t.language });

            // Properties
            this.Property(t => t.im_adres_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.im_adres_line1)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.im_adres_line2)
                .HasMaxLength(200);

            this.Property(t => t.im_adres_line3)
                .HasMaxLength(200);

            this.Property(t => t.im_adres_city)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.im_adres_state)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.im_adres_cntry)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.im_adres_pczip)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("lang_im_adres_tbl");
            this.Property(t => t.im_adres_key).HasColumnName("im_adres_key");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.im_adres_name).HasColumnName("im_adres_name");
            this.Property(t => t.im_adres_line1).HasColumnName("im_adres_line1");
            this.Property(t => t.im_adres_line2).HasColumnName("im_adres_line2");
            this.Property(t => t.im_adres_line3).HasColumnName("im_adres_line3");
            this.Property(t => t.im_adres_city).HasColumnName("im_adres_city");
            this.Property(t => t.im_adres_state).HasColumnName("im_adres_state");
            this.Property(t => t.im_adres_cntry).HasColumnName("im_adres_cntry");
            this.Property(t => t.im_adres_pczip).HasColumnName("im_adres_pczip");
        }
    }
}
