using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_vatreg_tblMap : EntityTypeConfiguration<gl_vatreg_tbl>
    {
        public gl_vatreg_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_vatreg_ent, t.gl_vatreg_key, t.en_cntry_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_vatreg_ent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_vatreg_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cntry_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_vatreg_num)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gl_vatreg_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_vatreg_ent).HasColumnName("gl_vatreg_ent");
            this.Property(t => t.gl_vatreg_key).HasColumnName("gl_vatreg_key");
            this.Property(t => t.en_cntry_key).HasColumnName("en_cntry_key");
            this.Property(t => t.gl_vatreg_num).HasColumnName("gl_vatreg_num");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatreg_crtdt).HasColumnName("gl_vatreg_crtdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_vatreg_chgdt).HasColumnName("gl_vatreg_chgdt");
            this.Property(t => t.gl_vatreg_upcnt).HasColumnName("gl_vatreg_upcnt");
        }
    }
}
