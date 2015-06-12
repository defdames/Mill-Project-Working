using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_vndjn_tblMap : EntityTypeConfiguration<en_vndjn_tbl>
    {
        public en_vndjn_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_vend_key, t.en_remt_key, t.en_delfm_key });

            // Properties
            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_vndjn_tbl");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.en_remt_key).HasColumnName("en_remt_key");
            this.Property(t => t.en_delfm_key).HasColumnName("en_delfm_key");
            this.Property(t => t.en_vndjn_upcnt).HasColumnName("en_vndjn_upcnt");
            this.Property(t => t.en_vndjn_crtdt).HasColumnName("en_vndjn_crtdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_vndjn_chgdt).HasColumnName("en_vndjn_chgdt");
        }
    }
}
