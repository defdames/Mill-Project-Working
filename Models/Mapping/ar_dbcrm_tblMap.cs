using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_dbcrm_tblMap : EntityTypeConfiguration<ar_dbcrm_tbl>
    {
        public ar_dbcrm_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_brnch_key, t.ar_dbcrm_type, t.ar_dbcrm_key, t.ar_dbcrdtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_brnch_key)
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

            this.Property(t => t.so_prod_key)
                .HasMaxLength(20);

            this.Property(t => t.ar_dbcrm_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ar_dbcrm_reascd)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_dbcrm_sltyp)
                .HasMaxLength(10);

            this.Property(t => t.ar_dbcrm_prcuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_dbcrm_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_uom_wtuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_uom_afill)
                .HasMaxLength(2);

            this.Property(t => t.ar_dbcrm_skuuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

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

            this.Property(t => t.so_enduse_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_assoc)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_assoc)
                .HasMaxLength(4);

            this.Property(t => t.ar_dbcrm_typeassoc)
                .HasMaxLength(1);

            this.Property(t => t.ar_dbcrm_assoc)
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_alternate)
                .HasMaxLength(2);

            this.Property(t => t.so_brand_key)
                .HasMaxLength(20);

            this.Property(t => t.gl_misc_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ar_dbcrm_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_brnch_key).HasColumnName("in_brnch_key");
            this.Property(t => t.ar_dbcrm_type).HasColumnName("ar_dbcrm_type");
            this.Property(t => t.ar_dbcrm_key).HasColumnName("ar_dbcrm_key");
            this.Property(t => t.ar_dbcrdtl_key).HasColumnName("ar_dbcrdtl_key");
            this.Property(t => t.ar_ivdtl_key).HasColumnName("ar_ivdtl_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.ar_dbcrm_cramt).HasColumnName("ar_dbcrm_cramt");
            this.Property(t => t.ar_dbcrm_remk).HasColumnName("ar_dbcrm_remk");
            this.Property(t => t.ar_dbcrm_rchgc).HasColumnName("ar_dbcrm_rchgc");
            this.Property(t => t.ar_dbcrm_cramtf).HasColumnName("ar_dbcrm_cramtf");
            this.Property(t => t.ar_dbcrm_rchgcf).HasColumnName("ar_dbcrm_rchgcf");
            this.Property(t => t.ar_dbcrm_reascd).HasColumnName("ar_dbcrm_reascd");
            this.Property(t => t.ar_dbcrm_qty).HasColumnName("ar_dbcrm_qty");
            this.Property(t => t.ar_dbcrm_sltyp).HasColumnName("ar_dbcrm_sltyp");
            this.Property(t => t.ar_dbcrm_adjfl).HasColumnName("ar_dbcrm_adjfl");
            this.Property(t => t.ar_dbcrm_updlimit).HasColumnName("ar_dbcrm_updlimit");
            this.Property(t => t.ar_dbcrm_pot).HasColumnName("ar_dbcrm_pot");
            this.Property(t => t.ar_dtlprnm_key).HasColumnName("ar_dtlprnm_key");
            this.Property(t => t.ar_dbcrm_prcuom).HasColumnName("ar_dbcrm_prcuom");
            this.Property(t => t.ar_dbcrm_desc).HasColumnName("ar_dbcrm_desc");
            this.Property(t => t.ar_dbcrm_upcnt).HasColumnName("ar_dbcrm_upcnt");
            this.Property(t => t.ar_dbcrm_grnomwt).HasColumnName("ar_dbcrm_grnomwt");
            this.Property(t => t.ar_dbcrm_gractwt).HasColumnName("ar_dbcrm_gractwt");
            this.Property(t => t.en_uom_wtuom).HasColumnName("en_uom_wtuom");
            this.Property(t => t.ar_dbcrm_afill).HasColumnName("ar_dbcrm_afill");
            this.Property(t => t.en_uom_afill).HasColumnName("en_uom_afill");
            this.Property(t => t.ar_dbcrm_skuqty).HasColumnName("ar_dbcrm_skuqty");
            this.Property(t => t.ar_dbcrm_skuuom).HasColumnName("ar_dbcrm_skuuom");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.ar_dbcrm_vatc).HasColumnName("ar_dbcrm_vatc");
            this.Property(t => t.ar_dbcrm_vatcf).HasColumnName("ar_dbcrm_vatcf");
            this.Property(t => t.ar_dbcrm_disitmf).HasColumnName("ar_dbcrm_disitmf");
            this.Property(t => t.so_ship_date).HasColumnName("so_ship_date");
            this.Property(t => t.gl_cmp_profit).HasColumnName("gl_cmp_profit");
            this.Property(t => t.so_brnch_profit).HasColumnName("so_brnch_profit");
            this.Property(t => t.gl_cmp_ship).HasColumnName("gl_cmp_ship");
            this.Property(t => t.so_brnch_ship).HasColumnName("so_brnch_ship");
            this.Property(t => t.so_shpitm_intinv).HasColumnName("so_shpitm_intinv");
            this.Property(t => t.ar_dbcrm_revint).HasColumnName("ar_dbcrm_revint");
            this.Property(t => t.so_enduse_key).HasColumnName("so_enduse_key");
            this.Property(t => t.gl_cmp_assoc).HasColumnName("gl_cmp_assoc");
            this.Property(t => t.so_brnch_assoc).HasColumnName("so_brnch_assoc");
            this.Property(t => t.ar_dbcrm_typeassoc).HasColumnName("ar_dbcrm_typeassoc");
            this.Property(t => t.ar_dbcrm_assoc).HasColumnName("ar_dbcrm_assoc");
            this.Property(t => t.ar_dbcrdtl_assoc).HasColumnName("ar_dbcrdtl_assoc");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.ar_dbcrm_altqty).HasColumnName("ar_dbcrm_altqty");
            this.Property(t => t.en_uom_alternate).HasColumnName("en_uom_alternate");
            this.Property(t => t.so_brand_key).HasColumnName("so_brand_key");
            this.Property(t => t.gl_misc_key).HasColumnName("gl_misc_key");
        }
    }
}
