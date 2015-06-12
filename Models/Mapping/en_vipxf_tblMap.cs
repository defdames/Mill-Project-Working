using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_vipxf_tblMap : EntityTypeConfiguration<en_vipxf_tbl>
    {
        public en_vipxf_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_vend_key, t.en_item_key, t.im_pack_key });

            // Properties
            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_vipxf_vprt)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_vipxf_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_vipxf_puom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_buyc_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_vipxf_cmnts)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_vipxf_tluom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_vcpcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_1099_key)
                .HasMaxLength(10);

            this.Property(t => t.en_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("en_vipxf_tbl");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_vipxf_upcnt).HasColumnName("en_vipxf_upcnt");
            this.Property(t => t.en_vipxf_vprt).HasColumnName("en_vipxf_vprt");
            this.Property(t => t.en_vipxf_desc).HasColumnName("en_vipxf_desc");
            this.Property(t => t.en_vipxf_aprvf).HasColumnName("en_vipxf_aprvf");
            this.Property(t => t.en_vipxf_puom).HasColumnName("en_vipxf_puom");
            this.Property(t => t.en_vipxf_margn).HasColumnName("en_vipxf_margn");
            this.Property(t => t.en_vipxf_mnoqt).HasColumnName("en_vipxf_mnoqt");
            this.Property(t => t.en_vipxf_mxoqt).HasColumnName("en_vipxf_mxoqt");
            this.Property(t => t.en_vipxf_inoqt).HasColumnName("en_vipxf_inoqt");
            this.Property(t => t.en_vipxf_auddt).HasColumnName("en_vipxf_auddt");
            this.Property(t => t.en_vipxf_crtdt).HasColumnName("en_vipxf_crtdt");
            this.Property(t => t.en_vipxf_chgdt).HasColumnName("en_vipxf_chgdt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_buyc_key).HasColumnName("en_buyc_key");
            this.Property(t => t.en_vipxf_cmnts).HasColumnName("en_vipxf_cmnts");
            this.Property(t => t.en_vipxf_tlfcf).HasColumnName("en_vipxf_tlfcf");
            this.Property(t => t.en_vipxf_tlpcf).HasColumnName("en_vipxf_tlpcf");
            this.Property(t => t.en_vipxf_pshp).HasColumnName("en_vipxf_pshp");
            this.Property(t => t.en_vipxf_cshp).HasColumnName("en_vipxf_cshp");
            this.Property(t => t.en_vipxf_tlovr).HasColumnName("en_vipxf_tlovr");
            this.Property(t => t.en_vipxf_tludr).HasColumnName("en_vipxf_tludr");
            this.Property(t => t.en_vipxf_tluom).HasColumnName("en_vipxf_tluom");
            this.Property(t => t.en_vcpcd_key).HasColumnName("en_vcpcd_key");
            this.Property(t => t.en_vipxf_popkf).HasColumnName("en_vipxf_popkf");
            this.Property(t => t.en_vend_1099f).HasColumnName("en_vend_1099f");
            this.Property(t => t.en_1099_key).HasColumnName("en_1099_key");
            this.Property(t => t.en_crncy_key).HasColumnName("en_crncy_key");
            this.Property(t => t.en_vipxf_ovtfct).HasColumnName("en_vipxf_ovtfct");
        }
    }
}
