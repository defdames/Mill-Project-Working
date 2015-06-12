using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_vipxf_tblMap : EntityTypeConfiguration<in_vipxf_tbl>
    {
        public in_vipxf_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_item_key, t.im_pack_key, t.en_vend_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.sa_user_key)
                .HasMaxLength(8);

            this.Property(t => t.in_vipxf_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.in_vipxf_cmnts)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.in_vipxf_puom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_buyc_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_carr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_service_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_vipxf_vprt)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ar_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_vipxf_tluom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_vcpcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_1099_key)
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_acct_contra)
                .HasMaxLength(40);

            this.Property(t => t.gl_acct_interpo)
                .HasMaxLength(40);

            this.Property(t => t.en_cstcnt_rop)
                .HasMaxLength(10);

            this.Property(t => t.en_cstcnt_plan)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("in_vipxf_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_vipxf_pshpf).HasColumnName("in_vipxf_pshpf");
            this.Property(t => t.in_vipxf_desc).HasColumnName("in_vipxf_desc");
            this.Property(t => t.in_vipxf_cmnts).HasColumnName("in_vipxf_cmnts");
            this.Property(t => t.in_vipxf_puom).HasColumnName("in_vipxf_puom");
            this.Property(t => t.in_buyc_key).HasColumnName("in_buyc_key");
            this.Property(t => t.in_vipxf_aprvf).HasColumnName("in_vipxf_aprvf");
            this.Property(t => t.in_vipxf_maxld).HasColumnName("in_vipxf_maxld");
            this.Property(t => t.in_vipxf_stdld).HasColumnName("in_vipxf_stdld");
            this.Property(t => t.in_vipxf_avgld).HasColumnName("in_vipxf_avgld");
            this.Property(t => t.in_vipxf_lstld).HasColumnName("in_vipxf_lstld");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.in_vipxf_pshp).HasColumnName("in_vipxf_pshp");
            this.Property(t => t.in_vipxf_cshp).HasColumnName("in_vipxf_cshp");
            this.Property(t => t.in_vipxf_vprt).HasColumnName("in_vipxf_vprt");
            this.Property(t => t.in_vipxf_margn).HasColumnName("in_vipxf_margn");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.in_vipxf_mnoqt).HasColumnName("in_vipxf_mnoqt");
            this.Property(t => t.in_vipxf_inoqt).HasColumnName("in_vipxf_inoqt");
            this.Property(t => t.in_vipxf_mxoqt).HasColumnName("in_vipxf_mxoqt");
            this.Property(t => t.in_vipxf_tlfcf).HasColumnName("in_vipxf_tlfcf");
            this.Property(t => t.in_vipxf_tlpcf).HasColumnName("in_vipxf_tlpcf");
            this.Property(t => t.in_vipxf_tlovr).HasColumnName("in_vipxf_tlovr");
            this.Property(t => t.in_vipxf_tludr).HasColumnName("in_vipxf_tludr");
            this.Property(t => t.in_vipxf_tluom).HasColumnName("in_vipxf_tluom");
            this.Property(t => t.en_vcpcd_key).HasColumnName("en_vcpcd_key");
            this.Property(t => t.in_vipxf_upcnt).HasColumnName("in_vipxf_upcnt");
            this.Property(t => t.in_vipxf_auddt).HasColumnName("in_vipxf_auddt");
            this.Property(t => t.en_vend_1099f).HasColumnName("en_vend_1099f");
            this.Property(t => t.en_1099_key).HasColumnName("en_1099_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.in_vipxf_ovtfct).HasColumnName("in_vipxf_ovtfct");
            this.Property(t => t.gl_acct_contra).HasColumnName("gl_acct_contra");
            this.Property(t => t.gl_acct_interpo).HasColumnName("gl_acct_interpo");
            this.Property(t => t.in_vipxf_bklvlpercent).HasColumnName("in_vipxf_bklvlpercent");
            this.Property(t => t.en_cstcnt_rop).HasColumnName("en_cstcnt_rop");
            this.Property(t => t.en_cstcnt_plan).HasColumnName("en_cstcnt_plan");
        }
    }
}
