using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_dtlpr_tblMap : EntityTypeConfiguration<so_dtlpr_tbl>
    {
        public so_dtlpr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_hdr_key, t.so_dtl_key });

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

            this.Property(t => t.so_dtlpr_prcwhs)
                .HasMaxLength(4);

            this.Property(t => t.so_dtlpr_prcuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_dtlpr_ccpcd)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_dtlpr_pragrq)
                .HasMaxLength(10);

            this.Property(t => t.so_dtlpr_patmplt)
                .HasMaxLength(10);

            this.Property(t => t.so_dtlpr_batmpp)
                .HasMaxLength(10);

            this.Property(t => t.pc_bsphdr_key)
                .HasMaxLength(10);

            this.Property(t => t.so_dtlpr_audit)
                .HasMaxLength(76);

            this.Property(t => t.ar_tax_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_wtuom)
                .HasMaxLength(2);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_analuom)
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_trfpr)
                .HasMaxLength(3);

            this.Property(t => t.pc_bsprhd_trfpr)
                .HasMaxLength(10);

            this.Property(t => t.ar_tax_trfpr)
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_artrfpr)
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_aptrfpr)
                .HasMaxLength(10);

            this.Property(t => t.so_dtlpr_trfexsus)
                .HasMaxLength(20);

            this.Property(t => t.so_dtlpr_prodrq)
                .HasMaxLength(20);

            this.Property(t => t.pc_agrmt_key)
                .HasMaxLength(10);

            this.Property(t => t.pc_agrhdr_prod)
                .HasMaxLength(20);

            this.Property(t => t.sa_user_key)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("so_dtlpr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.so_dtlpr_prcwhs).HasColumnName("so_dtlpr_prcwhs");
            this.Property(t => t.so_dtlpr_prcuom).HasColumnName("so_dtlpr_prcuom");
            this.Property(t => t.so_dtlpr_qtypuom).HasColumnName("so_dtlpr_qtypuom");
            this.Property(t => t.so_dtlpr_prcqty).HasColumnName("so_dtlpr_prcqty");
            this.Property(t => t.so_dtlpr_cep).HasColumnName("so_dtlpr_cep");
            this.Property(t => t.so_dtlpr_fprcf).HasColumnName("so_dtlpr_fprcf");
            this.Property(t => t.so_dtlpr_ccpcd).HasColumnName("so_dtlpr_ccpcd");
            this.Property(t => t.so_dtlpr_prcfl).HasColumnName("so_dtlpr_prcfl");
            this.Property(t => t.so_dtlpr_pragrq).HasColumnName("so_dtlpr_pragrq");
            this.Property(t => t.so_dtlpr_patmplt).HasColumnName("so_dtlpr_patmplt");
            this.Property(t => t.so_dtlpr_batmpp).HasColumnName("so_dtlpr_batmpp");
            this.Property(t => t.pc_bsphdr_key).HasColumnName("pc_bsphdr_key");
            this.Property(t => t.pc_bsprdt_key).HasColumnName("pc_bsprdt_key");
            this.Property(t => t.so_dtlpr_audit).HasColumnName("so_dtlpr_audit");
            this.Property(t => t.so_dtlpr_frgcmb).HasColumnName("so_dtlpr_frgcmb");
            this.Property(t => t.so_dtlpr_basec).HasColumnName("so_dtlpr_basec");
            this.Property(t => t.so_dtlpr_basecf).HasColumnName("so_dtlpr_basecf");
            this.Property(t => t.so_dtlpr_eudlvdcf).HasColumnName("so_dtlpr_eudlvdcf");
            this.Property(t => t.so_dtlpr_eudlvdacf).HasColumnName("so_dtlpr_eudlvdacf");
            this.Property(t => t.so_dtlpr_edlvdcf).HasColumnName("so_dtlpr_edlvdcf");
            this.Property(t => t.so_dtlpr_eeldsccf).HasColumnName("so_dtlpr_eeldsccf");
            this.Property(t => t.so_dtlpr_eelcomcf).HasColumnName("so_dtlpr_eelcomcf");
            this.Property(t => t.so_dtlpr_eeltaxcf).HasColumnName("so_dtlpr_eeltaxcf");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.so_dtlpr_tax1).HasColumnName("so_dtlpr_tax1");
            this.Property(t => t.so_dtlpr_tax2).HasColumnName("so_dtlpr_tax2");
            this.Property(t => t.so_dtlpr_tax3).HasColumnName("so_dtlpr_tax3");
            this.Property(t => t.so_dtlpr_tax4).HasColumnName("so_dtlpr_tax4");
            this.Property(t => t.so_dtlpr_tax5).HasColumnName("so_dtlpr_tax5");
            this.Property(t => t.so_dtlpr_tax1cf).HasColumnName("so_dtlpr_tax1cf");
            this.Property(t => t.so_dtlpr_tax2cf).HasColumnName("so_dtlpr_tax2cf");
            this.Property(t => t.so_dtlpr_tax3cf).HasColumnName("so_dtlpr_tax3cf");
            this.Property(t => t.so_dtlpr_tax4cf).HasColumnName("so_dtlpr_tax4cf");
            this.Property(t => t.so_dtlpr_tax5cf).HasColumnName("so_dtlpr_tax5cf");
            this.Property(t => t.so_dtlpr_etotbillc).HasColumnName("so_dtlpr_etotbillc");
            this.Property(t => t.so_dtlpr_ettbillcf).HasColumnName("so_dtlpr_ettbillcf");
            this.Property(t => t.so_dtlpr_eaccrcf).HasColumnName("so_dtlpr_eaccrcf");
            this.Property(t => t.so_dtlpr_edlvdacf).HasColumnName("so_dtlpr_edlvdacf");
            this.Property(t => t.so_dtlpr_frgtshpwt).HasColumnName("so_dtlpr_frgtshpwt");
            this.Property(t => t.so_dtlpr_ebasecf).HasColumnName("so_dtlpr_ebasecf");
            this.Property(t => t.so_dtlpr_ebasec).HasColumnName("so_dtlpr_ebasec");
            this.Property(t => t.so_dtlpr_ebasecp).HasColumnName("so_dtlpr_ebasecp");
            this.Property(t => t.so_dtlpr_adjbasecf).HasColumnName("so_dtlpr_adjbasecf");
            this.Property(t => t.so_dtlpr_eadbasecf).HasColumnName("so_dtlpr_eadbasecf");
            this.Property(t => t.so_dtlpr_upcnt).HasColumnName("so_dtlpr_upcnt");
            this.Property(t => t.en_uom_wtuom).HasColumnName("en_uom_wtuom");
            this.Property(t => t.so_dtlpr_ogroprcwt).HasColumnName("so_dtlpr_ogroprcwt");
            this.Property(t => t.so_dtlpr_onetprcwt).HasColumnName("so_dtlpr_onetprcwt");
            this.Property(t => t.so_dtlpr_eprcactf).HasColumnName("so_dtlpr_eprcactf");
            this.Property(t => t.so_dtlpr_efrtactf).HasColumnName("so_dtlpr_efrtactf");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.so_dtlpr_vatc).HasColumnName("so_dtlpr_vatc");
            this.Property(t => t.so_dtlpr_vatcf).HasColumnName("so_dtlpr_vatcf");
            this.Property(t => t.so_dtlpr_prcorddt).HasColumnName("so_dtlpr_prcorddt");
            this.Property(t => t.so_dtlpr_prcshpdt).HasColumnName("so_dtlpr_prcshpdt");
            this.Property(t => t.so_dtlpr_quoteprcf).HasColumnName("so_dtlpr_quoteprcf");
            this.Property(t => t.en_uom_analuom).HasColumnName("en_uom_analuom");
            this.Property(t => t.so_dtlpr_analqty).HasColumnName("so_dtlpr_analqty");
            this.Property(t => t.gl_crncy_trfpr).HasColumnName("gl_crncy_trfpr");
            this.Property(t => t.pc_bsprhd_trfpr).HasColumnName("pc_bsprhd_trfpr");
            this.Property(t => t.pc_bsprdt_trfpr).HasColumnName("pc_bsprdt_trfpr");
            this.Property(t => t.so_dtlpr_trfbasecs).HasColumnName("so_dtlpr_trfbasecs");
            this.Property(t => t.so_dtlpr_trfebascs).HasColumnName("so_dtlpr_trfebascs");
            this.Property(t => t.so_dtlpr_trfetotcs).HasColumnName("so_dtlpr_trfetotcs");
            this.Property(t => t.so_dtlpr_trftax1cs).HasColumnName("so_dtlpr_trftax1cs");
            this.Property(t => t.so_dtlpr_trftax2cs).HasColumnName("so_dtlpr_trftax2cs");
            this.Property(t => t.so_dtlpr_trftax3cs).HasColumnName("so_dtlpr_trftax3cs");
            this.Property(t => t.so_dtlpr_trftax4cs).HasColumnName("so_dtlpr_trftax4cs");
            this.Property(t => t.so_dtlpr_trftax5cs).HasColumnName("so_dtlpr_trftax5cs");
            this.Property(t => t.so_dtlpr_trfvatcs).HasColumnName("so_dtlpr_trfvatcs");
            this.Property(t => t.ar_tax_trfpr).HasColumnName("ar_tax_trfpr");
            this.Property(t => t.gl_vatcd_artrfpr).HasColumnName("gl_vatcd_artrfpr");
            this.Property(t => t.gl_vatcd_aptrfpr).HasColumnName("gl_vatcd_aptrfpr");
            this.Property(t => t.so_dtlpr_trfexsus).HasColumnName("so_dtlpr_trfexsus");
            this.Property(t => t.so_dtlpr_ppcindrq).HasColumnName("so_dtlpr_ppcindrq");
            this.Property(t => t.so_dtlpr_prodrq).HasColumnName("so_dtlpr_prodrq");
            this.Property(t => t.so_dtlpr_agrhdrq).HasColumnName("so_dtlpr_agrhdrq");
            this.Property(t => t.so_dtlpr_unitadjcf).HasColumnName("so_dtlpr_unitadjcf");
            this.Property(t => t.so_dtlpr_icbasecf).HasColumnName("so_dtlpr_icbasecf");
            this.Property(t => t.so_dtlpr_eicbasecf).HasColumnName("so_dtlpr_eicbasecf");
            this.Property(t => t.so_dtlpr_ettpretaxcf).HasColumnName("so_dtlpr_ettpretaxcf");
            this.Property(t => t.so_dtlpr_expaccrcf).HasColumnName("so_dtlpr_expaccrcf");
            this.Property(t => t.pc_agrmt_key).HasColumnName("pc_agrmt_key");
            this.Property(t => t.pc_agrhdr_ppcind).HasColumnName("pc_agrhdr_ppcind");
            this.Property(t => t.pc_agrhdr_prod).HasColumnName("pc_agrhdr_prod");
            this.Property(t => t.pc_agrhdr_key).HasColumnName("pc_agrhdr_key");
            this.Property(t => t.pc_agrdtl_key).HasColumnName("pc_agrdtl_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.so_dtlpr_lastprcdt).HasColumnName("so_dtlpr_lastprcdt");
        }
    }
}
