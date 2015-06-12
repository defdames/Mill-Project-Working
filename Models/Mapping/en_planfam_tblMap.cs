using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_planfam_tblMap : EntityTypeConfiguration<en_planfam_tbl>
    {
        public en_planfam_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_planfam_key);

            // Properties
            this.Property(t => t.en_planfam_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_planfam_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_planfam_tbl");
            this.Property(t => t.en_planfam_key).HasColumnName("en_planfam_key");
            this.Property(t => t.en_planfam_desc).HasColumnName("en_planfam_desc");
            this.Property(t => t.en_planfam_crtdt).HasColumnName("en_planfam_crtdt");
            this.Property(t => t.en_planfam_chgdt).HasColumnName("en_planfam_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_planfam_upcnt).HasColumnName("en_planfam_upcnt");
        }
    }
}
