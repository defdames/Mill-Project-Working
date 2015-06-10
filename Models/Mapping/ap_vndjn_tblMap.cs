using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_vndjn_tblMap : EntityTypeConfiguration<ap_vndjn_tbl>
    {
        public ap_vndjn_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.en_vend_key, t.ap_remt_key, t.ap_delfm_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("ap_vndjn_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.ap_remt_key).HasColumnName("ap_remt_key");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.ap_stats_key).HasColumnName("ap_stats_key");
            this.Property(t => t.ap_vndjn_chgdt).HasColumnName("ap_vndjn_chgdt");
            this.Property(t => t.ap_vndjn_upcnt).HasColumnName("ap_vndjn_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.ap_vndjn_crtdt).HasColumnName("ap_vndjn_crtdt");
        }
    }
}
