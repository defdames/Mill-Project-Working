using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_dtlpr_tblMap : EntityTypeConfiguration<ar_dtlpr_tbl>
    {
        public ar_dtlpr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ar_dtlprnm_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_dtlprnm_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ar_tax_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_analuom)
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_trfpr)
                .HasMaxLength(3);

            this.Property(t => t.ar_tax_trfpr)
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_artrfpr)
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_aptrfpr)
                .HasMaxLength(10);

            this.Property(t => t.ar_dtlpr_trfexsus)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ar_dtlpr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ar_dtlprnm_key).HasColumnName("ar_dtlprnm_key");
            this.Property(t => t.ar_dtlpr_etotbillc).HasColumnName("ar_dtlpr_etotbillc");
            this.Property(t => t.ar_dtlpr_ettbillcf).HasColumnName("ar_dtlpr_ettbillcf");
            this.Property(t => t.ar_dtlpr_basec).HasColumnName("ar_dtlpr_basec");
            this.Property(t => t.ar_dtlpr_basecf).HasColumnName("ar_dtlpr_basecf");
            this.Property(t => t.ar_dtlpr_eeltaxcf).HasColumnName("ar_dtlpr_eeltaxcf");
            this.Property(t => t.ar_dtlpr_eeldsccf).HasColumnName("ar_dtlpr_eeldsccf");
            this.Property(t => t.ar_dtlpr_eelcomcf).HasColumnName("ar_dtlpr_eelcomcf");
            this.Property(t => t.ar_dtlpr_eudlvdcf).HasColumnName("ar_dtlpr_eudlvdcf");
            this.Property(t => t.ar_dtlpr_eudlvdacf).HasColumnName("ar_dtlpr_eudlvdacf");
            this.Property(t => t.ar_dtlpr_edlvdcf).HasColumnName("ar_dtlpr_edlvdcf");
            this.Property(t => t.ar_dtlpr_edlvdacf).HasColumnName("ar_dtlpr_edlvdacf");
            this.Property(t => t.ar_dtlpr_ebasec).HasColumnName("ar_dtlpr_ebasec");
            this.Property(t => t.ar_dtlpr_ebasecf).HasColumnName("ar_dtlpr_ebasecf");
            this.Property(t => t.ar_dtlpr_ebasecp).HasColumnName("ar_dtlpr_ebasecp");
            this.Property(t => t.ar_dtlpr_eaccrcf).HasColumnName("ar_dtlpr_eaccrcf");
            this.Property(t => t.ar_dtlpr_tax1c).HasColumnName("ar_dtlpr_tax1c");
            this.Property(t => t.ar_dtlpr_tax1cf).HasColumnName("ar_dtlpr_tax1cf");
            this.Property(t => t.ar_dtlpr_tax2c).HasColumnName("ar_dtlpr_tax2c");
            this.Property(t => t.ar_dtlpr_tax2cf).HasColumnName("ar_dtlpr_tax2cf");
            this.Property(t => t.ar_dtlpr_tax3c).HasColumnName("ar_dtlpr_tax3c");
            this.Property(t => t.ar_dtlpr_tax3cf).HasColumnName("ar_dtlpr_tax3cf");
            this.Property(t => t.ar_dtlpr_tax4c).HasColumnName("ar_dtlpr_tax4c");
            this.Property(t => t.ar_dtlpr_tax4cf).HasColumnName("ar_dtlpr_tax4cf");
            this.Property(t => t.ar_dtlpr_tax5c).HasColumnName("ar_dtlpr_tax5c");
            this.Property(t => t.ar_dtlpr_tax5cf).HasColumnName("ar_dtlpr_tax5cf");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.ar_dtlpr_adjbasecf).HasColumnName("ar_dtlpr_adjbasecf");
            this.Property(t => t.ar_dtlpr_eadbasecf).HasColumnName("ar_dtlpr_eadbasecf");
            this.Property(t => t.ar_dtlpr_upcnt).HasColumnName("ar_dtlpr_upcnt");
            this.Property(t => t.ar_dtlpr_extactf).HasColumnName("ar_dtlpr_extactf");
            this.Property(t => t.ar_dtlpr_eprcactf).HasColumnName("ar_dtlpr_eprcactf");
            this.Property(t => t.ar_dtlpr_efrtactf).HasColumnName("ar_dtlpr_efrtactf");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.ar_dtlpr_vatc).HasColumnName("ar_dtlpr_vatc");
            this.Property(t => t.ar_dtlpr_vatcf).HasColumnName("ar_dtlpr_vatcf");
            this.Property(t => t.ar_dtlpr_quoteprcf).HasColumnName("ar_dtlpr_quoteprcf");
            this.Property(t => t.en_uom_analuom).HasColumnName("en_uom_analuom");
            this.Property(t => t.ar_dtlpr_analqty).HasColumnName("ar_dtlpr_analqty");
            this.Property(t => t.gl_crncy_trfpr).HasColumnName("gl_crncy_trfpr");
            this.Property(t => t.ar_dtlpr_trfbasecs).HasColumnName("ar_dtlpr_trfbasecs");
            this.Property(t => t.ar_dtlpr_trfebascs).HasColumnName("ar_dtlpr_trfebascs");
            this.Property(t => t.ar_dtlpr_trfetotcs).HasColumnName("ar_dtlpr_trfetotcs");
            this.Property(t => t.ar_dtlpr_trftax1cs).HasColumnName("ar_dtlpr_trftax1cs");
            this.Property(t => t.ar_dtlpr_trftax2cs).HasColumnName("ar_dtlpr_trftax2cs");
            this.Property(t => t.ar_dtlpr_trftax3cs).HasColumnName("ar_dtlpr_trftax3cs");
            this.Property(t => t.ar_dtlpr_trftax4cs).HasColumnName("ar_dtlpr_trftax4cs");
            this.Property(t => t.ar_dtlpr_trftax5cs).HasColumnName("ar_dtlpr_trftax5cs");
            this.Property(t => t.ar_dtlpr_trfvatcs).HasColumnName("ar_dtlpr_trfvatcs");
            this.Property(t => t.ar_tax_trfpr).HasColumnName("ar_tax_trfpr");
            this.Property(t => t.gl_vatcd_artrfpr).HasColumnName("gl_vatcd_artrfpr");
            this.Property(t => t.gl_vatcd_aptrfpr).HasColumnName("gl_vatcd_aptrfpr");
            this.Property(t => t.ar_dtlpr_trfexsus).HasColumnName("ar_dtlpr_trfexsus");
            this.Property(t => t.ar_dtlpr_icbasecf).HasColumnName("ar_dtlpr_icbasecf");
            this.Property(t => t.ar_dtlpr_eicbasecf).HasColumnName("ar_dtlpr_eicbasecf");
            this.Property(t => t.ar_dtlpr_expaccrcf).HasColumnName("ar_dtlpr_expaccrcf");
        }
    }
}
