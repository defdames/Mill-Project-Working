using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_delfm_tblMap : EntityTypeConfiguration<ap_delfm_tbl>
    {
        public ap_delfm_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ap_delfm_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_delfm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_delfm_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_frgt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_delfm_cmnts)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ap_resn_key)
                .HasMaxLength(10);

            this.Property(t => t.ap_statecd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_trnsport_key)
                .HasMaxLength(2);

            this.Property(t => t.en_fob_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_minqty)
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_minamt)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("ap_delfm_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ap_delfm_key).HasColumnName("ap_delfm_key");
            this.Property(t => t.ap_delfm_upcnt).HasColumnName("ap_delfm_upcnt");
            this.Property(t => t.ap_delfm_name).HasColumnName("ap_delfm_name");
            this.Property(t => t.ap_delfm_shmth).HasColumnName("ap_delfm_shmth");
            this.Property(t => t.ap_delfm_holdf).HasColumnName("ap_delfm_holdf");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_whs_key).HasColumnName("en_whs_key");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.ap_delfm_cmnts).HasColumnName("ap_delfm_cmnts");
            this.Property(t => t.ap_delfm_taxf).HasColumnName("ap_delfm_taxf");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.ap_statecd_key).HasColumnName("ap_statecd_key");
            this.Property(t => t.ap_delfm_type).HasColumnName("ap_delfm_type");
            this.Property(t => t.en_trnsport_key).HasColumnName("en_trnsport_key");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
            this.Property(t => t.ap_delfm_minqty).HasColumnName("ap_delfm_minqty");
            this.Property(t => t.en_uom_minqty).HasColumnName("en_uom_minqty");
            this.Property(t => t.ap_delfm_minamt).HasColumnName("ap_delfm_minamt");
            this.Property(t => t.gl_crncy_minamt).HasColumnName("gl_crncy_minamt");
        }
    }
}
