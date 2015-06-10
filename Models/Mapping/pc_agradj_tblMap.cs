using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pc_agradj_tblMap : EntityTypeConfiguration<pc_agradj_tbl>
    {
        public pc_agradj_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pc_agrmt_key, t.pc_agrhdr_ppcind, t.pc_agrhdr_prod, t.pc_agrhdr_key, t.pc_agrdtl_key, t.pc_agradj_key, t.pc_agradj_keytyp });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_agrmt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agrhdr_ppcind)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pc_agrhdr_prod)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pc_agrhdr_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pc_agrdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pc_agradj_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agradj_keytyp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pc_agradj_uom)
                .HasMaxLength(2);

            this.Property(t => t.pc_agradj_proc)
                .HasMaxLength(32);

            this.Property(t => t.pc_tmplt_key)
                .HasMaxLength(10);

            this.Property(t => t.en_vend_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("pc_agradj_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pc_agrmt_key).HasColumnName("pc_agrmt_key");
            this.Property(t => t.pc_agrhdr_ppcind).HasColumnName("pc_agrhdr_ppcind");
            this.Property(t => t.pc_agrhdr_prod).HasColumnName("pc_agrhdr_prod");
            this.Property(t => t.pc_agrhdr_key).HasColumnName("pc_agrhdr_key");
            this.Property(t => t.pc_agrdtl_key).HasColumnName("pc_agrdtl_key");
            this.Property(t => t.pc_agradj_key).HasColumnName("pc_agradj_key");
            this.Property(t => t.pc_agradj_keytyp).HasColumnName("pc_agradj_keytyp");
            this.Property(t => t.pc_agradj_upcnt).HasColumnName("pc_agradj_upcnt");
            this.Property(t => t.pc_agradj_crtdt).HasColumnName("pc_agradj_crtdt");
            this.Property(t => t.pc_agradj_chgdt).HasColumnName("pc_agradj_chgdt");
            this.Property(t => t.pc_agradj_seq).HasColumnName("pc_agradj_seq");
            this.Property(t => t.pc_agradj_ordefdt).HasColumnName("pc_agradj_ordefdt");
            this.Property(t => t.pc_agradj_ordiadt).HasColumnName("pc_agradj_ordiadt");
            this.Property(t => t.pc_agradj_shpefdt).HasColumnName("pc_agradj_shpefdt");
            this.Property(t => t.pc_agradj_shpiadt).HasColumnName("pc_agradj_shpiadt");
            this.Property(t => t.pc_agradj_ctuff).HasColumnName("pc_agradj_ctuff");
            this.Property(t => t.pc_agradj_uom).HasColumnName("pc_agradj_uom");
            this.Property(t => t.pc_agradj_entcompf).HasColumnName("pc_agradj_entcompf");
            this.Property(t => t.pc_agradj_proc).HasColumnName("pc_agradj_proc");
            this.Property(t => t.pc_tmplt_key).HasColumnName("pc_tmplt_key");
            this.Property(t => t.pc_agradj_cttyp).HasColumnName("pc_agradj_cttyp");
            this.Property(t => t.pc_agradj_ctval).HasColumnName("pc_agradj_ctval");
            this.Property(t => t.pc_agradj_cashdisf).HasColumnName("pc_agradj_cashdisf");
            this.Property(t => t.pc_agradj_itemizef).HasColumnName("pc_agradj_itemizef");
            this.Property(t => t.pc_agradj_ovrridef).HasColumnName("pc_agradj_ovrridef");
            this.Property(t => t.pc_agradj_taxf).HasColumnName("pc_agradj_taxf");
            this.Property(t => t.pc_agradj_basisf).HasColumnName("pc_agradj_basisf");
            this.Property(t => t.pc_agradj_addchnf).HasColumnName("pc_agradj_addchnf");
            this.Property(t => t.pc_agradj_credchgf).HasColumnName("pc_agradj_credchgf");
            this.Property(t => t.pc_agradj_manualf).HasColumnName("pc_agradj_manualf");
            this.Property(t => t.pc_agradj_commf).HasColumnName("pc_agradj_commf");
            this.Property(t => t.pc_agradj_examtcf).HasColumnName("pc_agradj_examtcf");
            this.Property(t => t.pc_agradj_examtc).HasColumnName("pc_agradj_examtc");
            this.Property(t => t.pc_agradj_exaccrcf).HasColumnName("pc_agradj_exaccrcf");
            this.Property(t => t.pc_agradj_exaccrc).HasColumnName("pc_agradj_exaccrc");
            this.Property(t => t.pc_agradj_valaccr).HasColumnName("pc_agradj_valaccr");
            this.Property(t => t.pc_agradj_grossf).HasColumnName("pc_agradj_grossf");
            this.Property(t => t.pc_agradj_appseq).HasColumnName("pc_agradj_appseq");
            this.Property(t => t.pc_agradj_incicprcf).HasColumnName("pc_agradj_incicprcf");
            this.Property(t => t.en_vend_key).HasColumnName("en_vend_key");
            this.Property(t => t.pc_agradj_compforf).HasColumnName("pc_agradj_compforf");
        }
    }
}
