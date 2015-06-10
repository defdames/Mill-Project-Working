using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_ivadj_tblMap : EntityTypeConfiguration<ar_ivadj_tbl>
    {
        public ar_ivadj_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ar_ivhdr_key, t.ar_ivdtl_key, t.ar_ivadj_key, t.ar_ivadj_keytyp });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ivdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ar_ivadj_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ivadj_keytyp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ar_ivadj_uom)
                .HasMaxLength(2);

            this.Property(t => t.ar_ivadj_proc)
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
            this.ToTable("ar_ivadj_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.ar_ivdtl_key).HasColumnName("ar_ivdtl_key");
            this.Property(t => t.ar_ivadj_key).HasColumnName("ar_ivadj_key");
            this.Property(t => t.ar_ivadj_keytyp).HasColumnName("ar_ivadj_keytyp");
            this.Property(t => t.ar_ivadj_upcnt).HasColumnName("ar_ivadj_upcnt");
            this.Property(t => t.ar_ivadj_crtdt).HasColumnName("ar_ivadj_crtdt");
            this.Property(t => t.ar_ivadj_chgdt).HasColumnName("ar_ivadj_chgdt");
            this.Property(t => t.ar_ivadj_seq).HasColumnName("ar_ivadj_seq");
            this.Property(t => t.ar_ivadj_ordefdt).HasColumnName("ar_ivadj_ordefdt");
            this.Property(t => t.ar_ivadj_ordiadt).HasColumnName("ar_ivadj_ordiadt");
            this.Property(t => t.ar_ivadj_shpefdt).HasColumnName("ar_ivadj_shpefdt");
            this.Property(t => t.ar_ivadj_shpiadt).HasColumnName("ar_ivadj_shpiadt");
            this.Property(t => t.ar_ivadj_ctuff).HasColumnName("ar_ivadj_ctuff");
            this.Property(t => t.ar_ivadj_uom).HasColumnName("ar_ivadj_uom");
            this.Property(t => t.ar_ivadj_entcompf).HasColumnName("ar_ivadj_entcompf");
            this.Property(t => t.ar_ivadj_proc).HasColumnName("ar_ivadj_proc");
            this.Property(t => t.pc_tmplt_key).HasColumnName("pc_tmplt_key");
            this.Property(t => t.ar_ivadj_cttyp).HasColumnName("ar_ivadj_cttyp");
            this.Property(t => t.ar_ivadj_ctval).HasColumnName("ar_ivadj_ctval");
            this.Property(t => t.ar_ivadj_cashdisf).HasColumnName("ar_ivadj_cashdisf");
            this.Property(t => t.ar_ivadj_itemizef).HasColumnName("ar_ivadj_itemizef");
            this.Property(t => t.ar_ivadj_ovrridef).HasColumnName("ar_ivadj_ovrridef");
            this.Property(t => t.ar_ivadj_taxf).HasColumnName("ar_ivadj_taxf");
            this.Property(t => t.ar_ivadj_basisf).HasColumnName("ar_ivadj_basisf");
            this.Property(t => t.ar_ivadj_addchnf).HasColumnName("ar_ivadj_addchnf");
            this.Property(t => t.ar_ivadj_credchgf).HasColumnName("ar_ivadj_credchgf");
            this.Property(t => t.ar_ivadj_manualf).HasColumnName("ar_ivadj_manualf");
            this.Property(t => t.ar_ivadj_commf).HasColumnName("ar_ivadj_commf");
            this.Property(t => t.ar_ivadj_examtcf).HasColumnName("ar_ivadj_examtcf");
            this.Property(t => t.ar_ivadj_examtc).HasColumnName("ar_ivadj_examtc");
            this.Property(t => t.ar_ivadj_examtncp).HasColumnName("ar_ivadj_examtncp");
            this.Property(t => t.ar_ivadj_exaccrcf).HasColumnName("ar_ivadj_exaccrcf");
            this.Property(t => t.ar_ivadj_exaccrc).HasColumnName("ar_ivadj_exaccrc");
            this.Property(t => t.ar_ivadj_exaccrcp).HasColumnName("ar_ivadj_exaccrcp");
            this.Property(t => t.ar_ivadj_valaccr).HasColumnName("ar_ivadj_valaccr");
            this.Property(t => t.ar_ivadj_grossf).HasColumnName("ar_ivadj_grossf");
            this.Property(t => t.ar_ivadj_appseq).HasColumnName("ar_ivadj_appseq");
            this.Property(t => t.ar_ivadj_extactf).HasColumnName("ar_ivadj_extactf");
            this.Property(t => t.pc_pcomp_key).HasColumnName("pc_pcomp_key");
            this.Property(t => t.ar_ivadj_vatc).HasColumnName("ar_ivadj_vatc");
            this.Property(t => t.ar_ivadj_vatcf).HasColumnName("ar_ivadj_vatcf");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.ar_ivadj_incicprcf).HasColumnName("ar_ivadj_incicprcf");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.ar_ivadj_compforf).HasColumnName("ar_ivadj_compforf");
        }
    }
}
