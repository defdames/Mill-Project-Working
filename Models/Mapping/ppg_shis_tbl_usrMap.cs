using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ppg_shis_tbl_usrMap : EntityTypeConfiguration<ppg_shis_tbl_usr>
    {
        public ppg_shis_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ppg_partno_key, t.en_prod_desc, t.ppg_health_key, t.ppg_flam_key, t.ppg_reactive_key, t.ppg_perprot_key, t.ppg_haztxt1, t.ppg_haztxt2 });

            // Properties
            this.Property(t => t.ppg_partno_key)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ppg_health_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ppg_flam_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ppg_reactive_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ppg_perprot_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ppg_haztxt1)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ppg_haztxt2)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ppg_haztxt3)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("ppg_shis_tbl_usr");
            this.Property(t => t.ppg_partno_key).HasColumnName("ppg_partno_key");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
            this.Property(t => t.ppg_health_key).HasColumnName("ppg_health_key");
            this.Property(t => t.ppg_flam_key).HasColumnName("ppg_flam_key");
            this.Property(t => t.ppg_reactive_key).HasColumnName("ppg_reactive_key");
            this.Property(t => t.ppg_perprot_key).HasColumnName("ppg_perprot_key");
            this.Property(t => t.ppg_haztxt1).HasColumnName("ppg_haztxt1");
            this.Property(t => t.ppg_haztxt2).HasColumnName("ppg_haztxt2");
            this.Property(t => t.ppg_haztxt3).HasColumnName("ppg_haztxt3");
        }
    }
}
