using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_qcmst_tblMap : EntityTypeConfiguration<en_qcmst_tbl>
    {
        public en_qcmst_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_qcmst_key, t.en_qcmst_effdt });

            // Properties
            this.Property(t => t.en_qcmst_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_qcmst_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_qcmst_txtv)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.en_qcmst_suom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_qcmst_cmnts)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.qc_smpltyp_key)
                .HasMaxLength(10);

            this.Property(t => t.qc_lab_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_testfreq)
                .HasMaxLength(2);

            this.Property(t => t.qc_tstcode_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("en_qcmst_tbl");
            this.Property(t => t.en_qcmst_key).HasColumnName("en_qcmst_key");
            this.Property(t => t.en_qcmst_effdt).HasColumnName("en_qcmst_effdt");
            this.Property(t => t.en_qcmst_type).HasColumnName("en_qcmst_type");
            this.Property(t => t.en_qcmst_inadt).HasColumnName("en_qcmst_inadt");
            this.Property(t => t.en_qcmst_desc).HasColumnName("en_qcmst_desc");
            this.Property(t => t.en_qcmst_tfrq).HasColumnName("en_qcmst_tfrq");
            this.Property(t => t.en_qcmst_tfrt).HasColumnName("en_qcmst_tfrt");
            this.Property(t => t.en_qcmst_sfrq).HasColumnName("en_qcmst_sfrq");
            this.Property(t => t.en_qcmst_valu).HasColumnName("en_qcmst_valu");
            this.Property(t => t.en_qcmst_minv).HasColumnName("en_qcmst_minv");
            this.Property(t => t.en_qcmst_maxv).HasColumnName("en_qcmst_maxv");
            this.Property(t => t.en_qcmst_txtv).HasColumnName("en_qcmst_txtv");
            this.Property(t => t.en_qcmst_suom).HasColumnName("en_qcmst_suom");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.en_qcmst_cmnts).HasColumnName("en_qcmst_cmnts");
            this.Property(t => t.en_qcmst_crtdt).HasColumnName("en_qcmst_crtdt");
            this.Property(t => t.en_qcmst_chgdt).HasColumnName("en_qcmst_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_qcmst_upcnt).HasColumnName("en_qcmst_upcnt");
            this.Property(t => t.qc_smpltyp_key).HasColumnName("qc_smpltyp_key");
            this.Property(t => t.qc_lab_key).HasColumnName("qc_lab_key");
            this.Property(t => t.en_uom_testfreq).HasColumnName("en_uom_testfreq");
            this.Property(t => t.en_qcmst_mnmxop).HasColumnName("en_qcmst_mnmxop");
            this.Property(t => t.en_qcmst_tmper).HasColumnName("en_qcmst_tmper");
            this.Property(t => t.qc_tstcode_key).HasColumnName("qc_tstcode_key");
            this.Property(t => t.en_qcmst_tsttype).HasColumnName("en_qcmst_tsttype");
        }
    }
}
