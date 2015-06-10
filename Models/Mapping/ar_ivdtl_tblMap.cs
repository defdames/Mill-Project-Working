using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_ivdtl_tblMap : EntityTypeConfiguration<ar_ivdtl_tbl>
    {
        public ar_ivdtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_brnch_key, t.ar_ivhdr_key, t.ar_ivdtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ivdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ar_ivdtl_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.so_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_sltyp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ivdtl_prcuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_ivdtl_ouom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_uom_afill)
                .HasMaxLength(2);

            this.Property(t => t.en_uom_wtuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_analuom)
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_profit)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_profit)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_ship)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_ship)
                .HasMaxLength(4);

            this.Property(t => t.gl_crncy_trfpr)
                .HasMaxLength(3);

            this.Property(t => t.ar_tax_trfpr)
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_artrfpr)
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_aptrfpr)
                .HasMaxLength(10);

            this.Property(t => t.pc_bsprhd_trfpr)
                .HasMaxLength(10);

            this.Property(t => t.ar_ivdtl_shfvatregno)
                .HasMaxLength(20);

            this.Property(t => t.ar_ivdtl_shtvatregno)
                .HasMaxLength(20);

            this.Property(t => t.ar_ivdtl_exsus)
                .HasMaxLength(20);

            this.Property(t => t.ar_ivdtl_trfexsus)
                .HasMaxLength(20);

            this.Property(t => t.so_hdr_key)
                .HasMaxLength(10);

            this.Property(t => t.so_enduse_key)
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_alternate)
                .HasMaxLength(2);

            this.Property(t => t.so_brand_key)
                .HasMaxLength(20);

            this.Property(t => t.pc_agrmt_key)
                .HasMaxLength(10);

            this.Property(t => t.pc_agrhdr_prod)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ar_ivdtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_brnch_key).HasColumnName("in_brnch_key");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.ar_ivdtl_key).HasColumnName("ar_ivdtl_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.ar_ivdtl_type).HasColumnName("ar_ivdtl_type");
            this.Property(t => t.in_prod_key).HasColumnName("in_prod_key");
            this.Property(t => t.in_prod_desc).HasColumnName("in_prod_desc");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.so_dtl_unitc).HasColumnName("so_dtl_unitc");
            this.Property(t => t.so_dtl_unitcf).HasColumnName("so_dtl_unitcf");
            this.Property(t => t.ar_ivdtl_extdc).HasColumnName("ar_ivdtl_extdc");
            this.Property(t => t.ar_ivdtl_extdcf).HasColumnName("ar_ivdtl_extdcf");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.ar_tax_amtc).HasColumnName("ar_tax_amtc");
            this.Property(t => t.ar_tax_amtcf).HasColumnName("ar_tax_amtcf");
            this.Property(t => t.en_whs_key).HasColumnName("en_whs_key");
            this.Property(t => t.en_sltyp_key).HasColumnName("en_sltyp_key");
            this.Property(t => t.ar_tax_amt2c).HasColumnName("ar_tax_amt2c");
            this.Property(t => t.ar_tax_amt2cf).HasColumnName("ar_tax_amt2cf");
            this.Property(t => t.ar_tax_amt3c).HasColumnName("ar_tax_amt3c");
            this.Property(t => t.ar_tax_amt3cf).HasColumnName("ar_tax_amt3cf");
            this.Property(t => t.ar_tax_amt4c).HasColumnName("ar_tax_amt4c");
            this.Property(t => t.ar_tax_amt4cf).HasColumnName("ar_tax_amt4cf");
            this.Property(t => t.ar_tax_amt5c).HasColumnName("ar_tax_amt5c");
            this.Property(t => t.ar_tax_amt5cf).HasColumnName("ar_tax_amt5cf");
            this.Property(t => t.ar_ivdtl_adjfl).HasColumnName("ar_ivdtl_adjfl");
            this.Property(t => t.so_shpitm_line).HasColumnName("so_shpitm_line");
            this.Property(t => t.ar_ivdtl_pot).HasColumnName("ar_ivdtl_pot");
            this.Property(t => t.ar_ivdtl_prcuom).HasColumnName("ar_ivdtl_prcuom");
            this.Property(t => t.ar_ivdtl_invqtpuom).HasColumnName("ar_ivdtl_invqtpuom");
            this.Property(t => t.ar_ivdtl_adjbasecf).HasColumnName("ar_ivdtl_adjbasecf");
            this.Property(t => t.ar_ivdtl_eadbasecf).HasColumnName("ar_ivdtl_eadbasecf");
            this.Property(t => t.ar_ivdtl_ouom).HasColumnName("ar_ivdtl_ouom");
            this.Property(t => t.ar_ivdtl_invqtouom).HasColumnName("ar_ivdtl_invqtouom");
            this.Property(t => t.ar_ivdtl_upcnt).HasColumnName("ar_ivdtl_upcnt");
            this.Property(t => t.ar_ivdtl_extactf).HasColumnName("ar_ivdtl_extactf");
            this.Property(t => t.ar_ivdtl_eprcactf).HasColumnName("ar_ivdtl_eprcactf");
            this.Property(t => t.ar_ivdtl_efrtactf).HasColumnName("ar_ivdtl_efrtactf");
            this.Property(t => t.ar_ivdtl_grnomwt).HasColumnName("ar_ivdtl_grnomwt");
            this.Property(t => t.ar_ivdtl_gractwt).HasColumnName("ar_ivdtl_gractwt");
            this.Property(t => t.ar_ivdtl_afill).HasColumnName("ar_ivdtl_afill");
            this.Property(t => t.en_uom_afill).HasColumnName("en_uom_afill");
            this.Property(t => t.en_uom_wtuom).HasColumnName("en_uom_wtuom");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.ar_ivdtl_vatc).HasColumnName("ar_ivdtl_vatc");
            this.Property(t => t.ar_ivdtl_vatcf).HasColumnName("ar_ivdtl_vatcf");
            this.Property(t => t.ar_ivdtl_disitmf).HasColumnName("ar_ivdtl_disitmf");
            this.Property(t => t.so_ship_date).HasColumnName("so_ship_date");
            this.Property(t => t.ar_ivdtl_quoteprcf).HasColumnName("ar_ivdtl_quoteprcf");
            this.Property(t => t.en_uom_analuom).HasColumnName("en_uom_analuom");
            this.Property(t => t.ar_ivdtl_analqty).HasColumnName("ar_ivdtl_analqty");
            this.Property(t => t.gl_cmp_profit).HasColumnName("gl_cmp_profit");
            this.Property(t => t.so_brnch_profit).HasColumnName("so_brnch_profit");
            this.Property(t => t.gl_cmp_ship).HasColumnName("gl_cmp_ship");
            this.Property(t => t.so_brnch_ship).HasColumnName("so_brnch_ship");
            this.Property(t => t.so_shpitm_intinv).HasColumnName("so_shpitm_intinv");
            this.Property(t => t.gl_crncy_trfpr).HasColumnName("gl_crncy_trfpr");
            this.Property(t => t.ar_ivdtl_trfbasecs).HasColumnName("ar_ivdtl_trfbasecs");
            this.Property(t => t.ar_ivdtl_trfebascs).HasColumnName("ar_ivdtl_trfebascs");
            this.Property(t => t.ar_ivdtl_trfetotcs).HasColumnName("ar_ivdtl_trfetotcs");
            this.Property(t => t.ar_ivdtl_trftax1cs).HasColumnName("ar_ivdtl_trftax1cs");
            this.Property(t => t.ar_ivdtl_trftax2cs).HasColumnName("ar_ivdtl_trftax2cs");
            this.Property(t => t.ar_ivdtl_trftax3cs).HasColumnName("ar_ivdtl_trftax3cs");
            this.Property(t => t.ar_ivdtl_trftax4cs).HasColumnName("ar_ivdtl_trftax4cs");
            this.Property(t => t.ar_ivdtl_trftax5cs).HasColumnName("ar_ivdtl_trftax5cs");
            this.Property(t => t.ar_ivdtl_trfvatcs).HasColumnName("ar_ivdtl_trfvatcs");
            this.Property(t => t.ar_tax_trfpr).HasColumnName("ar_tax_trfpr");
            this.Property(t => t.gl_vatcd_artrfpr).HasColumnName("gl_vatcd_artrfpr");
            this.Property(t => t.gl_vatcd_aptrfpr).HasColumnName("gl_vatcd_aptrfpr");
            this.Property(t => t.pc_bsprhd_trfpr).HasColumnName("pc_bsprhd_trfpr");
            this.Property(t => t.pc_bsprdt_trfpr).HasColumnName("pc_bsprdt_trfpr");
            this.Property(t => t.ar_ivdtl_shfvatregno).HasColumnName("ar_ivdtl_shfvatregno");
            this.Property(t => t.ar_ivdtl_shtvatregno).HasColumnName("ar_ivdtl_shtvatregno");
            this.Property(t => t.ar_ivdtl_exsus).HasColumnName("ar_ivdtl_exsus");
            this.Property(t => t.ar_ivdtl_trfexsus).HasColumnName("ar_ivdtl_trfexsus");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_enduse_key).HasColumnName("so_enduse_key");
            this.Property(t => t.ar_ivdtl_icbasecf).HasColumnName("ar_ivdtl_icbasecf");
            this.Property(t => t.ar_ivdtl_eicbasecf).HasColumnName("ar_ivdtl_eicbasecf");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.ar_ivdtl_altqty).HasColumnName("ar_ivdtl_altqty");
            this.Property(t => t.en_uom_alternate).HasColumnName("en_uom_alternate");
            this.Property(t => t.so_brand_key).HasColumnName("so_brand_key");
            this.Property(t => t.pc_agrmt_key).HasColumnName("pc_agrmt_key");
            this.Property(t => t.pc_agrhdr_ppcind).HasColumnName("pc_agrhdr_ppcind");
            this.Property(t => t.pc_agrhdr_prod).HasColumnName("pc_agrhdr_prod");
            this.Property(t => t.pc_agrhdr_key).HasColumnName("pc_agrhdr_key");
            this.Property(t => t.pc_agrdtl_key).HasColumnName("pc_agrdtl_key");
        }
    }
}
