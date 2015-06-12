using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_dtladj_tblMap : EntityTypeConfiguration<so_dtladj_tbl>
    {
        public so_dtladj_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_hdr_key, t.so_dtl_key, t.so_dtladj_key, t.so_dtladj_keytyp });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.so_dtladj_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtladj_keytyp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.so_dtladj_uom)
                .HasMaxLength(2);

            this.Property(t => t.so_dtladj_proc)
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
            this.ToTable("so_dtladj_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.so_dtladj_key).HasColumnName("so_dtladj_key");
            this.Property(t => t.so_dtladj_keytyp).HasColumnName("so_dtladj_keytyp");
            this.Property(t => t.so_dtladj_upcnt).HasColumnName("so_dtladj_upcnt");
            this.Property(t => t.so_dtladj_crtdt).HasColumnName("so_dtladj_crtdt");
            this.Property(t => t.so_dtladj_chgdt).HasColumnName("so_dtladj_chgdt");
            this.Property(t => t.so_dtladj_seq).HasColumnName("so_dtladj_seq");
            this.Property(t => t.so_dtladj_ordefdt).HasColumnName("so_dtladj_ordefdt");
            this.Property(t => t.so_dtladj_ordiadt).HasColumnName("so_dtladj_ordiadt");
            this.Property(t => t.so_dtladj_shpefdt).HasColumnName("so_dtladj_shpefdt");
            this.Property(t => t.so_dtladj_shpiadt).HasColumnName("so_dtladj_shpiadt");
            this.Property(t => t.so_dtladj_ctuff).HasColumnName("so_dtladj_ctuff");
            this.Property(t => t.so_dtladj_uom).HasColumnName("so_dtladj_uom");
            this.Property(t => t.so_dtladj_entcompf).HasColumnName("so_dtladj_entcompf");
            this.Property(t => t.so_dtladj_proc).HasColumnName("so_dtladj_proc");
            this.Property(t => t.pc_tmplt_key).HasColumnName("pc_tmplt_key");
            this.Property(t => t.so_dtladj_cttyp).HasColumnName("so_dtladj_cttyp");
            this.Property(t => t.so_dtladj_ctval).HasColumnName("so_dtladj_ctval");
            this.Property(t => t.so_dtladj_cashdisf).HasColumnName("so_dtladj_cashdisf");
            this.Property(t => t.so_dtladj_itemizef).HasColumnName("so_dtladj_itemizef");
            this.Property(t => t.so_dtladj_ovrridef).HasColumnName("so_dtladj_ovrridef");
            this.Property(t => t.so_dtladj_taxf).HasColumnName("so_dtladj_taxf");
            this.Property(t => t.so_dtladj_basisf).HasColumnName("so_dtladj_basisf");
            this.Property(t => t.so_dtladj_addchnf).HasColumnName("so_dtladj_addchnf");
            this.Property(t => t.so_dtladj_credchgf).HasColumnName("so_dtladj_credchgf");
            this.Property(t => t.so_dtladj_manualf).HasColumnName("so_dtladj_manualf");
            this.Property(t => t.so_dtladj_commf).HasColumnName("so_dtladj_commf");
            this.Property(t => t.so_dtladj_examtcf).HasColumnName("so_dtladj_examtcf");
            this.Property(t => t.so_dtladj_examtc).HasColumnName("so_dtladj_examtc");
            this.Property(t => t.so_dtladj_examtncp).HasColumnName("so_dtladj_examtncp");
            this.Property(t => t.so_dtladj_exaccrcf).HasColumnName("so_dtladj_exaccrcf");
            this.Property(t => t.so_dtladj_exaccrc).HasColumnName("so_dtladj_exaccrc");
            this.Property(t => t.so_dtladj_exaccrcp).HasColumnName("so_dtladj_exaccrcp");
            this.Property(t => t.so_dtladj_valaccr).HasColumnName("so_dtladj_valaccr");
            this.Property(t => t.so_dtladj_grossf).HasColumnName("so_dtladj_grossf");
            this.Property(t => t.so_dtladj_appseq).HasColumnName("so_dtladj_appseq");
            this.Property(t => t.pc_pcomp_key).HasColumnName("pc_pcomp_key");
            this.Property(t => t.so_dtladj_vatc).HasColumnName("so_dtladj_vatc");
            this.Property(t => t.so_dtladj_vatcf).HasColumnName("so_dtladj_vatcf");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.so_dtladj_incicprcf).HasColumnName("so_dtladj_incicprcf");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.so_dtladj_compforf).HasColumnName("so_dtladj_compforf");
        }
    }
}
