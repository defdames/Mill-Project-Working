using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_statecd_tblMap : EntityTypeConfiguration<ap_statecd_tbl>
    {
        public ap_statecd_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ap_statecd_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_statecd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_statecd_desc)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("ap_statecd_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ap_statecd_key).HasColumnName("ap_statecd_key");
            this.Property(t => t.ap_statecd_desc).HasColumnName("ap_statecd_desc");
            this.Property(t => t.ap_statecd_crtdt).HasColumnName("ap_statecd_crtdt");
            this.Property(t => t.ap_statecd_chgdt).HasColumnName("ap_statecd_chgdt");
            this.Property(t => t.ap_statecd_dirpayf).HasColumnName("ap_statecd_dirpayf");
            this.Property(t => t.ap_statecd_upcnt).HasColumnName("ap_statecd_upcnt");
        }
    }
}
