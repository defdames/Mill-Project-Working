using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_vend_tblMap : EntityTypeConfiguration<en_vend_tbl>
    {
        public en_vend_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_vend_key);

            // Properties
            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_vend_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_vend_audno)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_vend_fob)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_vend_altky)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_comp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_terms_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_vend_inact)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_vend_taxid)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.en_sicc_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_vend_city)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_vend_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_vend_catgy)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.en_vend_sdesc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_vend_perfl)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_vend_type)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_vend_1cmp)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_vend_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.en_paycd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            this.Property(t => t.en_1099_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_vend_tbl");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.en_vend_upcnt).HasColumnName("en_vend_upcnt");
            this.Property(t => t.en_vend_name).HasColumnName("en_vend_name");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_vend_audno).HasColumnName("en_vend_audno");
            this.Property(t => t.en_vend_fob).HasColumnName("en_vend_fob");
            this.Property(t => t.en_vend_altky).HasColumnName("en_vend_altky");
            this.Property(t => t.en_vend_sdisc).HasColumnName("en_vend_sdisc");
            this.Property(t => t.en_comp_key).HasColumnName("en_comp_key");
            this.Property(t => t.en_crncy_key).HasColumnName("en_crncy_key");
            this.Property(t => t.en_vend_shmth).HasColumnName("en_vend_shmth");
            this.Property(t => t.en_vend_holdf).HasColumnName("en_vend_holdf");
            this.Property(t => t.en_vend_pri).HasColumnName("en_vend_pri");
            this.Property(t => t.en_terms_key).HasColumnName("en_terms_key");
            this.Property(t => t.en_vend_crdlt).HasColumnName("en_vend_crdlt");
            this.Property(t => t.en_vend_toltp).HasColumnName("en_vend_toltp");
            this.Property(t => t.en_vend_tlamt).HasColumnName("en_vend_tlamt");
            this.Property(t => t.en_vend_inact).HasColumnName("en_vend_inact");
            this.Property(t => t.en_vend_taxid).HasColumnName("en_vend_taxid");
            this.Property(t => t.en_vend_paytp).HasColumnName("en_vend_paytp");
            this.Property(t => t.en_vend_crtdt).HasColumnName("en_vend_crtdt");
            this.Property(t => t.en_vend_chgdt).HasColumnName("en_vend_chgdt");
            this.Property(t => t.en_vend_auddt).HasColumnName("en_vend_auddt");
            this.Property(t => t.en_sicc_key).HasColumnName("en_sicc_key");
            this.Property(t => t.en_vend_city).HasColumnName("en_vend_city");
            this.Property(t => t.en_vend_state).HasColumnName("en_vend_state");
            this.Property(t => t.en_vend_catgy).HasColumnName("en_vend_catgy");
            this.Property(t => t.en_vend_sdesc).HasColumnName("en_vend_sdesc");
            this.Property(t => t.en_vend_perfl).HasColumnName("en_vend_perfl");
            this.Property(t => t.en_vend_type).HasColumnName("en_vend_type");
            this.Property(t => t.en_vend_1cmp).HasColumnName("en_vend_1cmp");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_vend_cmnts).HasColumnName("en_vend_cmnts");
            this.Property(t => t.en_vend_miscf).HasColumnName("en_vend_miscf");
            this.Property(t => t.en_vend_1099f).HasColumnName("en_vend_1099f");
            this.Property(t => t.en_lang_key).HasColumnName("en_lang_key");
            this.Property(t => t.en_vend_curf).HasColumnName("en_vend_curf");
            this.Property(t => t.en_paycd_key).HasColumnName("en_paycd_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_vend_intf).HasColumnName("en_vend_intf");
            this.Property(t => t.en_vend_ovtfct).HasColumnName("en_vend_ovtfct");
            this.Property(t => t.en_vend_sendpof).HasColumnName("en_vend_sendpof");
            this.Property(t => t.en_1099_key).HasColumnName("en_1099_key");
            this.Property(t => t.en_vend_sendasnf).HasColumnName("en_vend_sendasnf");
        }
    }
}
