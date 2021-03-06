using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_vndcn_tblMap : EntityTypeConfiguration<en_vndcn_tbl>
    {
        public en_vndcn_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_vend_key, t.im_contp_key, t.im_cntct_key });

            // Properties
            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_contp_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_cntct_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_vndcn_tbl");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.im_contp_key).HasColumnName("im_contp_key");
            this.Property(t => t.im_cntct_key).HasColumnName("im_cntct_key");
            this.Property(t => t.en_vndcn_upcnt).HasColumnName("en_vndcn_upcnt");
            this.Property(t => t.en_vndcn_crtdt).HasColumnName("en_vndcn_crtdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_vndcn_chgdt).HasColumnName("en_vndcn_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
