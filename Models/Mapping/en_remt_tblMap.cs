using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_remt_tblMap : EntityTypeConfiguration<en_remt_tbl>
    {
        public en_remt_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_remt_key);

            // Properties
            this.Property(t => t.en_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_remt_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_bank_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_bank_acctno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_remt_inact)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_remt_taxid)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.en_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_comp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_remt_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .HasMaxLength(4);

            this.Property(t => t.en_1099_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_remt_tbl");
            this.Property(t => t.en_remt_key).HasColumnName("en_remt_key");
            this.Property(t => t.en_remt_upcnt).HasColumnName("en_remt_upcnt");
            this.Property(t => t.en_remt_name).HasColumnName("en_remt_name");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.en_remt_holdf).HasColumnName("en_remt_holdf");
            this.Property(t => t.en_remt_pri).HasColumnName("en_remt_pri");
            this.Property(t => t.en_terms_key).HasColumnName("en_terms_key");
            this.Property(t => t.en_bank_key).HasColumnName("en_bank_key");
            this.Property(t => t.en_bank_acctno).HasColumnName("en_bank_acctno");
            this.Property(t => t.en_remt_invdt).HasColumnName("en_remt_invdt");
            this.Property(t => t.en_remt_crdlt).HasColumnName("en_remt_crdlt");
            this.Property(t => t.en_remt_inact).HasColumnName("en_remt_inact");
            this.Property(t => t.en_remt_taxid).HasColumnName("en_remt_taxid");
            this.Property(t => t.en_remt_paytp).HasColumnName("en_remt_paytp");
            this.Property(t => t.en_crncy_key).HasColumnName("en_crncy_key");
            this.Property(t => t.en_remt_crtdt).HasColumnName("en_remt_crtdt");
            this.Property(t => t.en_remt_chgdt).HasColumnName("en_remt_chgdt");
            this.Property(t => t.en_comp_key).HasColumnName("en_comp_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_remt_cmnts).HasColumnName("en_remt_cmnts");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_remt_1099f).HasColumnName("en_remt_1099f");
            this.Property(t => t.en_remt_miscf).HasColumnName("en_remt_miscf");
            this.Property(t => t.en_remt_curf).HasColumnName("en_remt_curf");
            this.Property(t => t.en_paycd_key).HasColumnName("en_paycd_key");
            this.Property(t => t.en_remt_intf).HasColumnName("en_remt_intf");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.en_1099_key).HasColumnName("en_1099_key");
        }
    }
}
