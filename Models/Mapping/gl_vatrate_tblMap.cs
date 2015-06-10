using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_vatrate_tblMap : EntityTypeConfiguration<gl_vatrate_tbl>
    {
        public gl_vatrate_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_vatcd_id, t.gl_vatcd_key, t.gl_vatrate_actdt });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_vatcd_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gl_vatrate_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_vatcd_id).HasColumnName("gl_vatcd_id");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_actdt).HasColumnName("gl_vatrate_actdt");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.gl_vatrate_crtdt).HasColumnName("gl_vatrate_crtdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_vatrate_chgdt).HasColumnName("gl_vatrate_chgdt");
            this.Property(t => t.gl_vatrate_upcnt).HasColumnName("gl_vatrate_upcnt");
            this.Property(t => t.gl_vatrate_whldpct).HasColumnName("gl_vatrate_whldpct");
        }
    }
}
