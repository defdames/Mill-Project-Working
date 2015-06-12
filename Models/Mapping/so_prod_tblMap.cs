using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_prod_tblMap : EntityTypeConfiguration<so_prod_tbl>
    {
        public so_prod_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_prod_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_catlg_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_pgc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_ppc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.so_prod_wtuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_prod_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_prod_vluom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brprd_prcls)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.bm_aprt_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_orderdef)
                .HasMaxLength(2);

            this.Property(t => t.en_uom_pricedef)
                .HasMaxLength(2);

            this.Property(t => t.en_uom_tarewgt)
                .HasMaxLength(2);

            this.Property(t => t.en_uom_analuom)
                .HasMaxLength(2);

            this.Property(t => t.so_cmdtypc_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_profit)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_profit)
                .HasMaxLength(4);

            this.Property(t => t.so_brand_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("so_prod_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.so_prod_desc).HasColumnName("so_prod_desc");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.so_catlg_key).HasColumnName("so_catlg_key");
            this.Property(t => t.so_prod_cuma).HasColumnName("so_prod_cuma");
            this.Property(t => t.so_prod_cums).HasColumnName("so_prod_cums");
            this.Property(t => t.so_prod_fcstc).HasColumnName("so_prod_fcstc");
            this.Property(t => t.so_prod_rwrkc).HasColumnName("so_prod_rwrkc");
            this.Property(t => t.so_prod_wslec).HasColumnName("so_prod_wslec");
            this.Property(t => t.so_prod_rstkc).HasColumnName("so_prod_rstkc");
            this.Property(t => t.so_pgc_key).HasColumnName("so_pgc_key");
            this.Property(t => t.so_ppc_key).HasColumnName("so_ppc_key");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.so_prod_shpwt).HasColumnName("so_prod_shpwt");
            this.Property(t => t.so_prod_wtuom).HasColumnName("so_prod_wtuom");
            this.Property(t => t.so_prod_uom).HasColumnName("so_prod_uom");
            this.Property(t => t.so_prod_vol).HasColumnName("so_prod_vol");
            this.Property(t => t.so_prod_vluom).HasColumnName("so_prod_vluom");
            this.Property(t => t.so_prod_shipf).HasColumnName("so_prod_shipf");
            this.Property(t => t.so_prod_cst).HasColumnName("so_prod_cst");
            this.Property(t => t.so_prod_stdf).HasColumnName("so_prod_stdf");
            this.Property(t => t.so_prod_kitf).HasColumnName("so_prod_kitf");
            this.Property(t => t.so_prod_taxf).HasColumnName("so_prod_taxf");
            this.Property(t => t.so_prod_packf).HasColumnName("so_prod_packf");
            this.Property(t => t.so_prod_exptf).HasColumnName("so_prod_exptf");
            this.Property(t => t.so_prod_authf).HasColumnName("so_prod_authf");
            this.Property(t => t.so_prod_pksze).HasColumnName("so_prod_pksze");
            this.Property(t => t.so_brprd_prcls).HasColumnName("so_brprd_prcls");
            this.Property(t => t.so_brprd_mpflag).HasColumnName("so_brprd_mpflag");
            this.Property(t => t.so_brprd_mnmrg).HasColumnName("so_brprd_mnmrg");
            this.Property(t => t.bm_aprt_key).HasColumnName("bm_aprt_key");
            this.Property(t => t.so_prod_upcnt).HasColumnName("so_prod_upcnt");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.so_prod_ffltm).HasColumnName("so_prod_ffltm");
            this.Property(t => t.so_prod_piktm).HasColumnName("so_prod_piktm");
            this.Property(t => t.so_prod_pltqt).HasColumnName("so_prod_pltqt");
            this.Property(t => t.en_uom_orderdef).HasColumnName("en_uom_orderdef");
            this.Property(t => t.en_uom_pricedef).HasColumnName("en_uom_pricedef");
            this.Property(t => t.so_prod_tarewgt).HasColumnName("so_prod_tarewgt");
            this.Property(t => t.en_uom_tarewgt).HasColumnName("en_uom_tarewgt");
            this.Property(t => t.so_prod_restrictf).HasColumnName("so_prod_restrictf");
            this.Property(t => t.en_uom_analuom).HasColumnName("en_uom_analuom");
            this.Property(t => t.so_cmdtypc_key).HasColumnName("so_cmdtypc_key");
            this.Property(t => t.gl_cmp_profit).HasColumnName("gl_cmp_profit");
            this.Property(t => t.so_brnch_profit).HasColumnName("so_brnch_profit");
            this.Property(t => t.so_prod_mktoordf).HasColumnName("so_prod_mktoordf");
            this.Property(t => t.so_prod_mktoordqty).HasColumnName("so_prod_mktoordqty");
            this.Property(t => t.so_brand_key).HasColumnName("so_brand_key");
        }
    }
}
