using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_rtdtl_tblMap : EntityTypeConfiguration<so_rtdtl_tbl>
    {
        public so_rtdtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_rthdr_key, t.so_rtdtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_rthdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_rtdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.so_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_rtdtl_rmauom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_resn_code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_rtdtl_skuuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_modified_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.so_rtdtl_whstoretu)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.so_dtl_sltyp)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_rtdtl_creditby)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ar_dbcrm_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_dbcrm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_rtdtl_crreason)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_filluom)
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_rec)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_rec)
                .HasMaxLength(4);

            this.Property(t => t.sa_user_recby)
                .HasMaxLength(8);

            this.Property(t => t.so_enduse_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_alternate)
                .HasMaxLength(2);

            this.Property(t => t.in_origlot_key)
                .HasMaxLength(25);

            this.Property(t => t.po_recpt_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("so_rtdtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_rthdr_key).HasColumnName("so_rthdr_key");
            this.Property(t => t.so_rtdtl_key).HasColumnName("so_rtdtl_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.so_rtdtl_rmaqty).HasColumnName("so_rtdtl_rmaqty");
            this.Property(t => t.so_rtdtl_rmauom).HasColumnName("so_rtdtl_rmauom");
            this.Property(t => t.so_resn_code).HasColumnName("so_resn_code");
            this.Property(t => t.so_rtdtl_stat).HasColumnName("so_rtdtl_stat");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.so_rtdtl_reasontyp).HasColumnName("so_rtdtl_reasontyp");
            this.Property(t => t.so_rtdtl_skuqty).HasColumnName("so_rtdtl_skuqty");
            this.Property(t => t.so_rtdtl_skuuom).HasColumnName("so_rtdtl_skuuom");
            this.Property(t => t.so_rtdtl_scheduldt).HasColumnName("so_rtdtl_scheduldt");
            this.Property(t => t.so_rtdtl_insflag).HasColumnName("so_rtdtl_insflag");
            this.Property(t => t.sa_modified_by).HasColumnName("sa_modified_by");
            this.Property(t => t.so_rtdtl_chgdt).HasColumnName("so_rtdtl_chgdt");
            this.Property(t => t.so_rtdtl_whstoretu).HasColumnName("so_rtdtl_whstoretu");
            this.Property(t => t.so_shpitm_key).HasColumnName("so_shpitm_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.so_dtl_sltyp).HasColumnName("so_dtl_sltyp");
            this.Property(t => t.so_ship_date).HasColumnName("so_ship_date");
            this.Property(t => t.so_shiplot_key).HasColumnName("so_shiplot_key");
            this.Property(t => t.so_rtdtl_directfla).HasColumnName("so_rtdtl_directfla");
            this.Property(t => t.so_rtdtl_creditby).HasColumnName("so_rtdtl_creditby");
            this.Property(t => t.so_rtdtl_creditqt).HasColumnName("so_rtdtl_creditqt");
            this.Property(t => t.ar_dbcrm_type).HasColumnName("ar_dbcrm_type");
            this.Property(t => t.ar_dbcrm_key).HasColumnName("ar_dbcrm_key");
            this.Property(t => t.so_rtdtl_crmoamt).HasColumnName("so_rtdtl_crmoamt");
            this.Property(t => t.so_rtdtl_crreason).HasColumnName("so_rtdtl_crreason");
            this.Property(t => t.so_shiplot_qty).HasColumnName("so_shiplot_qty");
            this.Property(t => t.so_rtdtl_upcnt).HasColumnName("so_rtdtl_upcnt");
            this.Property(t => t.so_rtdtl_fillattr).HasColumnName("so_rtdtl_fillattr");
            this.Property(t => t.so_rtdtl_ctfllqty).HasColumnName("so_rtdtl_ctfllqty");
            this.Property(t => t.en_uom_filluom).HasColumnName("en_uom_filluom");
            this.Property(t => t.gl_cmp_rec).HasColumnName("gl_cmp_rec");
            this.Property(t => t.so_brnch_rec).HasColumnName("so_brnch_rec");
            this.Property(t => t.so_rtdtl_recdt).HasColumnName("so_rtdtl_recdt");
            this.Property(t => t.so_rtdtl_recskuq).HasColumnName("so_rtdtl_recskuq");
            this.Property(t => t.sa_user_recby).HasColumnName("sa_user_recby");
            this.Property(t => t.so_rtdtl_rtfllqty).HasColumnName("so_rtdtl_rtfllqty");
            this.Property(t => t.so_enduse_key).HasColumnName("so_enduse_key");
            this.Property(t => t.so_rtdtl_ctaltqty).HasColumnName("so_rtdtl_ctaltqty");
            this.Property(t => t.en_uom_alternate).HasColumnName("en_uom_alternate");
            this.Property(t => t.in_origlot_key).HasColumnName("in_origlot_key");
            this.Property(t => t.ar_dbcrdtl_key).HasColumnName("ar_dbcrdtl_key");
            this.Property(t => t.po_recpt_key).HasColumnName("po_recpt_key");
        }
    }
}
