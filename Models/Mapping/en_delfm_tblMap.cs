using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_delfm_tblMap : EntityTypeConfiguration<en_delfm_tbl>
    {
        public en_delfm_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_delfm_key);

            // Properties
            this.Property(t => t.en_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_delfm_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_vend_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_delfm_inact)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_comp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_frgt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_delfm_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.en_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .HasMaxLength(4);

            this.Property(t => t.en_fob_key)
                .HasMaxLength(10);

            this.Property(t => t.en_trnsport_key)
                .HasMaxLength(2);

            this.Property(t => t.en_statecd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_recv)
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("en_delfm_tbl");
            this.Property(t => t.en_delfm_key).HasColumnName("en_delfm_key");
            this.Property(t => t.en_delfm_upcnt).HasColumnName("en_delfm_upcnt");
            this.Property(t => t.en_delfm_name).HasColumnName("en_delfm_name");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.en_delfm_shmth).HasColumnName("en_delfm_shmth");
            this.Property(t => t.en_delfm_holdf).HasColumnName("en_delfm_holdf");
            this.Property(t => t.en_delfm_toltp).HasColumnName("en_delfm_toltp");
            this.Property(t => t.en_delfm_tlamt).HasColumnName("en_delfm_tlamt");
            this.Property(t => t.en_delfm_inact).HasColumnName("en_delfm_inact");
            this.Property(t => t.en_delfm_crtdt).HasColumnName("en_delfm_crtdt");
            this.Property(t => t.en_delfm_chgdt).HasColumnName("en_delfm_chgdt");
            this.Property(t => t.en_comp_key).HasColumnName("en_comp_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_whs_key).HasColumnName("en_whs_key");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.en_delfm_cmnts).HasColumnName("en_delfm_cmnts");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_delfm_miscf).HasColumnName("en_delfm_miscf");
            this.Property(t => t.en_delfm_taxf).HasColumnName("en_delfm_taxf");
            this.Property(t => t.en_resn_key).HasColumnName("en_resn_key");
            this.Property(t => t.en_crncy_key).HasColumnName("en_crncy_key");
            this.Property(t => t.en_delfm_intf).HasColumnName("en_delfm_intf");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
            this.Property(t => t.en_trnsport_key).HasColumnName("en_trnsport_key");
            this.Property(t => t.en_statecd_key).HasColumnName("en_statecd_key");
            this.Property(t => t.in_whs_recv).HasColumnName("in_whs_recv");
        }
    }
}
