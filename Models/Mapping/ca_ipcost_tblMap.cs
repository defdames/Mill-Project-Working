using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ca_ipcost_tblMap : EntityTypeConfiguration<ca_ipcost_tbl>
    {
        public ca_ipcost_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.im_pack_key, t.in_item_key, t.ca_itpck_effdt, t.ca_cstyp_id });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ca_cstyp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_itmpk_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_itmpk_cntnr)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_stat)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_pack_type)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_pack_uid)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.bm_asy_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ca_ipcost_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.ca_itpck_effdt).HasColumnName("ca_itpck_effdt");
            this.Property(t => t.ca_cstyp_id).HasColumnName("ca_cstyp_id");
            this.Property(t => t.im_itmpk_qty).HasColumnName("im_itmpk_qty");
            this.Property(t => t.im_itmpk_uom).HasColumnName("im_itmpk_uom");
            this.Property(t => t.ca_itpck_inadt).HasColumnName("ca_itpck_inadt");
            this.Property(t => t.ca_itpck_lcsdt).HasColumnName("ca_itpck_lcsdt");
            this.Property(t => t.im_itmpk_cntnr).HasColumnName("im_itmpk_cntnr");
            this.Property(t => t.im_pack_chgdt).HasColumnName("im_pack_chgdt");
            this.Property(t => t.im_pack_stat).HasColumnName("im_pack_stat");
            this.Property(t => t.im_pack_type).HasColumnName("im_pack_type");
            this.Property(t => t.im_pack_uid).HasColumnName("im_pack_uid");
            this.Property(t => t.ca_ipcost_ordqt).HasColumnName("ca_ipcost_ordqt");
            this.Property(t => t.bm_asy_key).HasColumnName("bm_asy_key");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.ca_itpck_cmth).HasColumnName("ca_itpck_cmth");
            this.Property(t => t.in_mohcd_fdflg).HasColumnName("in_mohcd_fdflg");
            this.Property(t => t.in_mohcd_factr).HasColumnName("in_mohcd_factr");
            this.Property(t => t.in_mohcd_dollr).HasColumnName("in_mohcd_dollr");
            this.Property(t => t.ca_ipcost_nomqty).HasColumnName("ca_ipcost_nomqty");
            this.Property(t => t.im_pkcst_upcnt).HasColumnName("im_pkcst_upcnt");
            this.Property(t => t.ca_ipcost_numpk).HasColumnName("ca_ipcost_numpk");
            this.Property(t => t.ca_itpck_cst).HasColumnName("ca_itpck_cst");
            this.Property(t => t.ca_ipmtl_cst).HasColumnName("ca_ipmtl_cst");
            this.Property(t => t.ca_ipres_cst).HasColumnName("ca_ipres_cst");
            this.Property(t => t.ca_ipovh_cst).HasColumnName("ca_ipovh_cst");
            this.Property(t => t.ca_ipmtloh_cst).HasColumnName("ca_ipmtloh_cst");
            this.Property(t => t.ca_ipresoh_cst).HasColumnName("ca_ipresoh_cst");
            this.Property(t => t.ca_item_cst).HasColumnName("ca_item_cst");
            this.Property(t => t.ca_ipcost_bmcst).HasColumnName("ca_ipcost_bmcst");
            this.Property(t => t.ca_ipcost_bmocst).HasColumnName("ca_ipcost_bmocst");
            this.Property(t => t.ca_ipcost_pmcst).HasColumnName("ca_ipcost_pmcst");
            this.Property(t => t.ca_ipcost_pmocst).HasColumnName("ca_ipcost_pmocst");
            this.Property(t => t.ca_ipcost_brcst).HasColumnName("ca_ipcost_brcst");
            this.Property(t => t.ca_ipcost_brocst).HasColumnName("ca_ipcost_brocst");
            this.Property(t => t.ca_ipcost_prcst).HasColumnName("ca_ipcost_prcst");
            this.Property(t => t.ca_ipcost_procst).HasColumnName("ca_ipcost_procst");
            this.Property(t => t.ca_ipcost_cdcst).HasColumnName("ca_ipcost_cdcst");
            this.Property(t => t.ca_ipcost_frtcst).HasColumnName("ca_ipcost_frtcst");
            this.Property(t => t.ca_ipcost_mktcst).HasColumnName("ca_ipcost_mktcst");
            this.Property(t => t.ca_ipcost_othcst).HasColumnName("ca_ipcost_othcst");
        }
    }
}
