using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_itqct_tblMap : EntityTypeConfiguration<en_itqct_tbl>
    {
        public en_itqct_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_qcmst_key, t.en_itqct_effdt, t.en_item_key, t.im_pack_key, t.en_itqsp_key, t.en_itqsp_effdt });

            // Properties
            this.Property(t => t.en_qcmst_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_itqsp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_qcset_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_itqct_txtv)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_itqct_suom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_itqct_testr)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_itqct_cmnts)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_itqct_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.qc_smpltyp_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_testfreq)
                .HasMaxLength(2);

            this.Property(t => t.qc_lab_key)
                .HasMaxLength(10);

            this.Property(t => t.qc_tstcode_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("en_itqct_tbl");
            this.Property(t => t.en_qcmst_key).HasColumnName("en_qcmst_key");
            this.Property(t => t.en_itqct_effdt).HasColumnName("en_itqct_effdt");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_itqsp_key).HasColumnName("en_itqsp_key");
            this.Property(t => t.en_itqsp_effdt).HasColumnName("en_itqsp_effdt");
            this.Property(t => t.en_itqct_type).HasColumnName("en_itqct_type");
            this.Property(t => t.en_qcset_key).HasColumnName("en_qcset_key");
            this.Property(t => t.en_qcmst_effdt).HasColumnName("en_qcmst_effdt");
            this.Property(t => t.en_itqct_inadt).HasColumnName("en_itqct_inadt");
            this.Property(t => t.en_itqct_tfrq).HasColumnName("en_itqct_tfrq");
            this.Property(t => t.en_itqct_tfrt).HasColumnName("en_itqct_tfrt");
            this.Property(t => t.en_itqct_sfrq).HasColumnName("en_itqct_sfrq");
            this.Property(t => t.en_itqct_valu).HasColumnName("en_itqct_valu");
            this.Property(t => t.en_itqct_minv).HasColumnName("en_itqct_minv");
            this.Property(t => t.en_itqct_maxv).HasColumnName("en_itqct_maxv");
            this.Property(t => t.en_itqct_txtv).HasColumnName("en_itqct_txtv");
            this.Property(t => t.en_itqct_suom).HasColumnName("en_itqct_suom");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.en_itqct_reqdf).HasColumnName("en_itqct_reqdf");
            this.Property(t => t.en_itqct_spcpf).HasColumnName("en_itqct_spcpf");
            this.Property(t => t.en_itqct_coapf).HasColumnName("en_itqct_coapf");
            this.Property(t => t.en_itqct_testr).HasColumnName("en_itqct_testr");
            this.Property(t => t.en_itqct_cmnts).HasColumnName("en_itqct_cmnts");
            this.Property(t => t.en_itqct_crtdt).HasColumnName("en_itqct_crtdt");
            this.Property(t => t.en_itqct_chgdt).HasColumnName("en_itqct_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_itqct_upcnt).HasColumnName("en_itqct_upcnt");
            this.Property(t => t.en_itqct_coavf).HasColumnName("en_itqct_coavf");
            this.Property(t => t.en_itqct_desc).HasColumnName("en_itqct_desc");
            this.Property(t => t.en_itqct_eqmst).HasColumnName("en_itqct_eqmst");
            this.Property(t => t.qc_smpltyp_key).HasColumnName("qc_smpltyp_key");
            this.Property(t => t.en_uom_testfreq).HasColumnName("en_uom_testfreq");
            this.Property(t => t.qc_lab_key).HasColumnName("qc_lab_key");
            this.Property(t => t.en_itqct_mnmxop).HasColumnName("en_itqct_mnmxop");
            this.Property(t => t.en_itqct_tmper).HasColumnName("en_itqct_tmper");
            this.Property(t => t.qc_tstcode_key).HasColumnName("qc_tstcode_key");
            this.Property(t => t.en_itqct_tsttype).HasColumnName("en_itqct_tsttype");
        }
    }
}
