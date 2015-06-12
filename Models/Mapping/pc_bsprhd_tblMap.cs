using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pc_bsprhd_tblMap : EntityTypeConfiguration<pc_bsprhd_tbl>
    {
        public pc_bsprhd_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pc_bsprhd_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_bsprhd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_bsprhd_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.pc_bsprhd_exdesc)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("pc_bsprhd_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pc_bsprhd_key).HasColumnName("pc_bsprhd_key");
            this.Property(t => t.pc_bsprhd_desc).HasColumnName("pc_bsprhd_desc");
            this.Property(t => t.pc_bsprhd_exdesc).HasColumnName("pc_bsprhd_exdesc");
            this.Property(t => t.pc_bsprhd_inact).HasColumnName("pc_bsprhd_inact");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.pc_bsprhd_type).HasColumnName("pc_bsprhd_type");
            this.Property(t => t.pc_bsprhd_upcnt).HasColumnName("pc_bsprhd_upcnt");
            this.Property(t => t.pc_bsprhd_crtdt).HasColumnName("pc_bsprhd_crtdt");
            this.Property(t => t.pc_bsprhd_chgdt).HasColumnName("pc_bsprhd_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.pc_bsprhd_reprchgf).HasColumnName("pc_bsprhd_reprchgf");
        }
    }
}
