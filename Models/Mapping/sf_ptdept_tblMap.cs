using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_ptdept_tblMap : EntityTypeConfiguration<sf_ptdept_tbl>
    {
        public sf_ptdept_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_ptdept_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_ptdept_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_ptdept_sdesc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_ptdept_name)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("sf_ptdept_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_ptdept_key).HasColumnName("sf_ptdept_key");
            this.Property(t => t.sf_ptdept_sdesc).HasColumnName("sf_ptdept_sdesc");
            this.Property(t => t.sf_ptdept_name).HasColumnName("sf_ptdept_name");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.sf_ptdept_crtdt).HasColumnName("sf_ptdept_crtdt");
            this.Property(t => t.sf_ptdept_chgdt).HasColumnName("sf_ptdept_chgdt");
            this.Property(t => t.sf_ptdept_upcnt).HasColumnName("sf_ptdept_upcnt");
            this.Property(t => t.sf_ptdept_dfltf).HasColumnName("sf_ptdept_dfltf");
        }
    }
}
