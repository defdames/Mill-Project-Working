using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_prod_tblMap : EntityTypeConfiguration<en_prod_tbl>
    {
        public en_prod_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_prod_key);

            // Properties
            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_prod_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_catlg_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_pgc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_ppc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_prod_wtuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_prod_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_prod_vluom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_prod_trdnm)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_prod_ccpcd)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_prod_stats)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_prod_trdmk)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_prod_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.en_prod_smuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_uom_orderdef)
                .HasMaxLength(2);

            this.Property(t => t.en_uom_pricedef)
                .HasMaxLength(2);

            this.Property(t => t.en_uom_tarewgt)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_cmdtypc_key)
                .HasMaxLength(10);

            this.Property(t => t.en_uom_analuom)
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_profit)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_profit)
                .HasMaxLength(4);

            this.Property(t => t.en_brand_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("en_prod_tbl");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.en_prod_desc).HasColumnName("en_prod_desc");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_catlg_key).HasColumnName("en_catlg_key");
            this.Property(t => t.en_prod_rwrkc).HasColumnName("en_prod_rwrkc");
            this.Property(t => t.en_prod_wslec).HasColumnName("en_prod_wslec");
            this.Property(t => t.en_prod_rstkc).HasColumnName("en_prod_rstkc");
            this.Property(t => t.en_pgc_key).HasColumnName("en_pgc_key");
            this.Property(t => t.en_ppc_key).HasColumnName("en_ppc_key");
            this.Property(t => t.en_tax_key).HasColumnName("en_tax_key");
            this.Property(t => t.en_prod_shpwt).HasColumnName("en_prod_shpwt");
            this.Property(t => t.en_prod_wtuom).HasColumnName("en_prod_wtuom");
            this.Property(t => t.en_prod_uom).HasColumnName("en_prod_uom");
            this.Property(t => t.en_prod_vol).HasColumnName("en_prod_vol");
            this.Property(t => t.en_prod_vluom).HasColumnName("en_prod_vluom");
            this.Property(t => t.en_prod_shipf).HasColumnName("en_prod_shipf");
            this.Property(t => t.en_prod_stdf).HasColumnName("en_prod_stdf");
            this.Property(t => t.en_prod_kitf).HasColumnName("en_prod_kitf");
            this.Property(t => t.en_prod_packf).HasColumnName("en_prod_packf");
            this.Property(t => t.en_prod_exptf).HasColumnName("en_prod_exptf");
            this.Property(t => t.en_prod_authf).HasColumnName("en_prod_authf");
            this.Property(t => t.en_prod_taxf).HasColumnName("en_prod_taxf");
            this.Property(t => t.en_prod_mnmrg).HasColumnName("en_prod_mnmrg");
            this.Property(t => t.en_prod_trdnm).HasColumnName("en_prod_trdnm");
            this.Property(t => t.en_prod_minqt).HasColumnName("en_prod_minqt");
            this.Property(t => t.en_prod_maxqt).HasColumnName("en_prod_maxqt");
            this.Property(t => t.en_prod_crtdt).HasColumnName("en_prod_crtdt");
            this.Property(t => t.en_prod_ccpcd).HasColumnName("en_prod_ccpcd");
            this.Property(t => t.en_prod_stats).HasColumnName("en_prod_stats");
            this.Property(t => t.en_prod_saldt).HasColumnName("en_prod_saldt");
            this.Property(t => t.en_prod_mnpct).HasColumnName("en_prod_mnpct");
            this.Property(t => t.en_prod_trdmk).HasColumnName("en_prod_trdmk");
            this.Property(t => t.en_prod_chgdt).HasColumnName("en_prod_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_prod_drctf).HasColumnName("en_prod_drctf");
            this.Property(t => t.en_prod_cmnts).HasColumnName("en_prod_cmnts");
            this.Property(t => t.en_prod_smsze).HasColumnName("en_prod_smsze");
            this.Property(t => t.en_prod_smuom).HasColumnName("en_prod_smuom");
            this.Property(t => t.en_prod_upcnt).HasColumnName("en_prod_upcnt");
            this.Property(t => t.en_prod_ffltm).HasColumnName("en_prod_ffltm");
            this.Property(t => t.en_prod_piktm).HasColumnName("en_prod_piktm");
            this.Property(t => t.en_prod_pltqt).HasColumnName("en_prod_pltqt");
            this.Property(t => t.en_uom_orderdef).HasColumnName("en_uom_orderdef");
            this.Property(t => t.en_uom_pricedef).HasColumnName("en_uom_pricedef");
            this.Property(t => t.en_prod_tarewgt).HasColumnName("en_prod_tarewgt");
            this.Property(t => t.en_uom_tarewgt).HasColumnName("en_uom_tarewgt");
            this.Property(t => t.en_cmdtypc_key).HasColumnName("en_cmdtypc_key");
            this.Property(t => t.en_uom_analuom).HasColumnName("en_uom_analuom");
            this.Property(t => t.en_prod_restrictf).HasColumnName("en_prod_restrictf");
            this.Property(t => t.gl_cmp_profit).HasColumnName("gl_cmp_profit");
            this.Property(t => t.so_brnch_profit).HasColumnName("so_brnch_profit");
            this.Property(t => t.en_brand_key).HasColumnName("en_brand_key");
            this.Property(t => t.en_prod_mktoordqty).HasColumnName("en_prod_mktoordqty");
            this.Property(t => t.en_prod_mktoordf).HasColumnName("en_prod_mktoordf");
        }
    }
}
