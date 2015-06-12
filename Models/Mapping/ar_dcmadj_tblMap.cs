using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_dcmadj_tblMap : EntityTypeConfiguration<ar_dcmadj_tbl>
    {
        public ar_dcmadj_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ar_dbcrm_type, t.ar_dbcrm_key, t.ar_dbcrdtl_key, t.ar_dcmadj_key, t.ar_dcmadj_keytyp });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_dbcrm_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_dbcrm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_dbcrdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ar_dcmadj_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_dcmadj_keytyp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ar_dcmadj_uom)
                .HasMaxLength(2);

            this.Property(t => t.ar_dcmadj_proc)
                .HasMaxLength(32);

            this.Property(t => t.pc_tmplt_key)
                .HasMaxLength(10);

            this.Property(t => t.pc_pcomp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_vend_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ar_dcmadj_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ar_dbcrm_type).HasColumnName("ar_dbcrm_type");
            this.Property(t => t.ar_dbcrm_key).HasColumnName("ar_dbcrm_key");
            this.Property(t => t.ar_dbcrdtl_key).HasColumnName("ar_dbcrdtl_key");
            this.Property(t => t.ar_dcmadj_key).HasColumnName("ar_dcmadj_key");
            this.Property(t => t.ar_dcmadj_keytyp).HasColumnName("ar_dcmadj_keytyp");
            this.Property(t => t.ar_dcmadj_upcnt).HasColumnName("ar_dcmadj_upcnt");
            this.Property(t => t.ar_dcmadj_crtdt).HasColumnName("ar_dcmadj_crtdt");
            this.Property(t => t.ar_dcmadj_chgdt).HasColumnName("ar_dcmadj_chgdt");
            this.Property(t => t.ar_dcmadj_seq).HasColumnName("ar_dcmadj_seq");
            this.Property(t => t.ar_dcmadj_ordefdt).HasColumnName("ar_dcmadj_ordefdt");
            this.Property(t => t.ar_dcmadj_ordiadt).HasColumnName("ar_dcmadj_ordiadt");
            this.Property(t => t.ar_dcmadj_shpefdt).HasColumnName("ar_dcmadj_shpefdt");
            this.Property(t => t.ar_dcmadj_shpiadt).HasColumnName("ar_dcmadj_shpiadt");
            this.Property(t => t.ar_dcmadj_ctuff).HasColumnName("ar_dcmadj_ctuff");
            this.Property(t => t.ar_dcmadj_uom).HasColumnName("ar_dcmadj_uom");
            this.Property(t => t.ar_dcmadj_entcompf).HasColumnName("ar_dcmadj_entcompf");
            this.Property(t => t.ar_dcmadj_proc).HasColumnName("ar_dcmadj_proc");
            this.Property(t => t.pc_tmplt_key).HasColumnName("pc_tmplt_key");
            this.Property(t => t.ar_dcmadj_cttyp).HasColumnName("ar_dcmadj_cttyp");
            this.Property(t => t.ar_dcmadj_ctval).HasColumnName("ar_dcmadj_ctval");
            this.Property(t => t.ar_dcmadj_cashdisf).HasColumnName("ar_dcmadj_cashdisf");
            this.Property(t => t.ar_dcmadj_itemizef).HasColumnName("ar_dcmadj_itemizef");
            this.Property(t => t.ar_dcmadj_ovrridef).HasColumnName("ar_dcmadj_ovrridef");
            this.Property(t => t.ar_dcmadj_taxf).HasColumnName("ar_dcmadj_taxf");
            this.Property(t => t.ar_dcmadj_basisf).HasColumnName("ar_dcmadj_basisf");
            this.Property(t => t.ar_dcmadj_addchnf).HasColumnName("ar_dcmadj_addchnf");
            this.Property(t => t.ar_dcmadj_credchgf).HasColumnName("ar_dcmadj_credchgf");
            this.Property(t => t.ar_dcmadj_manualf).HasColumnName("ar_dcmadj_manualf");
            this.Property(t => t.ar_dcmadj_commf).HasColumnName("ar_dcmadj_commf");
            this.Property(t => t.ar_dcmadj_examtcf).HasColumnName("ar_dcmadj_examtcf");
            this.Property(t => t.ar_dcmadj_examtc).HasColumnName("ar_dcmadj_examtc");
            this.Property(t => t.ar_dcmadj_examtncp).HasColumnName("ar_dcmadj_examtncp");
            this.Property(t => t.ar_dcmadj_exaccrcf).HasColumnName("ar_dcmadj_exaccrcf");
            this.Property(t => t.ar_dcmadj_exaccrc).HasColumnName("ar_dcmadj_exaccrc");
            this.Property(t => t.ar_dcmadj_exaccrcp).HasColumnName("ar_dcmadj_exaccrcp");
            this.Property(t => t.ar_dcmadj_valaccr).HasColumnName("ar_dcmadj_valaccr");
            this.Property(t => t.ar_dcmadj_grossf).HasColumnName("ar_dcmadj_grossf");
            this.Property(t => t.ar_dcmadj_appseq).HasColumnName("ar_dcmadj_appseq");
            this.Property(t => t.ar_dcmadj_extactf).HasColumnName("ar_dcmadj_extactf");
            this.Property(t => t.pc_pcomp_key).HasColumnName("pc_pcomp_key");
            this.Property(t => t.ar_dcmadj_vatc).HasColumnName("ar_dcmadj_vatc");
            this.Property(t => t.ar_dcmadj_vatcf).HasColumnName("ar_dcmadj_vatcf");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.ar_dcmadj_incicprcf).HasColumnName("ar_dcmadj_incicprcf");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.ar_dcmadj_compforf).HasColumnName("ar_dcmadj_compforf");
        }
    }
}
