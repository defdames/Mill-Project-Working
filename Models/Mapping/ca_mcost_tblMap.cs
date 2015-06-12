using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ca_mcost_tblMap : EntityTypeConfiguration<ca_mcost_tbl>
    {
        public ca_mcost_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.in_item_key, t.sf_prcss_key, t.sf_prcss_ver, t.ca_mcost_effdt, t.ca_cstyp_id });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_prcss_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_prcss_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ca_cstyp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_frmla_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ca_mcost_iotp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sf_ingrd_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ca_mcost_runsizeUOM)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ca_mcost_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.sf_prcss_key).HasColumnName("sf_prcss_key");
            this.Property(t => t.sf_prcss_ver).HasColumnName("sf_prcss_ver");
            this.Property(t => t.ca_mcost_effdt).HasColumnName("ca_mcost_effdt");
            this.Property(t => t.ca_cstyp_id).HasColumnName("ca_cstyp_id");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.ca_mcost_inadt).HasColumnName("ca_mcost_inadt");
            this.Property(t => t.ca_mcost_lcsdt).HasColumnName("ca_mcost_lcsdt");
            this.Property(t => t.ca_mcost_mtldt).HasColumnName("ca_mcost_mtldt");
            this.Property(t => t.ca_mcost_resdt).HasColumnName("ca_mcost_resdt");
            this.Property(t => t.ca_mcost_ovhdt).HasColumnName("ca_mcost_ovhdt");
            this.Property(t => t.ca_mcost_matl).HasColumnName("ca_mcost_matl");
            this.Property(t => t.ca_mcost_mtloh).HasColumnName("ca_mcost_mtloh");
            this.Property(t => t.ca_mcost_rsrce).HasColumnName("ca_mcost_rsrce");
            this.Property(t => t.ca_mcost_rsroh).HasColumnName("ca_mcost_rsroh");
            this.Property(t => t.ca_mcost_subcn).HasColumnName("ca_mcost_subcn");
            this.Property(t => t.ca_mcost_suboh).HasColumnName("ca_mcost_suboh");
            this.Property(t => t.ca_mcost_cstdr).HasColumnName("ca_mcost_cstdr");
            this.Property(t => t.sf_frmla_key).HasColumnName("sf_frmla_key");
            this.Property(t => t.sf_frmla_ver).HasColumnName("sf_frmla_ver");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.ca_mcost_oprt).HasColumnName("ca_mcost_oprt");
            this.Property(t => t.ca_mcost_apflg).HasColumnName("ca_mcost_apflg");
            this.Property(t => t.ca_mcost_ordqt).HasColumnName("ca_mcost_ordqt");
            this.Property(t => t.ca_mcost_alflg).HasColumnName("ca_mcost_alflg");
            this.Property(t => t.ca_mcost_iotp).HasColumnName("ca_mcost_iotp");
            this.Property(t => t.sf_ingrd_uom).HasColumnName("sf_ingrd_uom");
            this.Property(t => t.ca_mcost_nrvf).HasColumnName("ca_mcost_nrvf");
            this.Property(t => t.ca_mcost_sqtyflag).HasColumnName("ca_mcost_sqtyflag");
            this.Property(t => t.ca_mcost_formulaqty).HasColumnName("ca_mcost_formulaqty");
            this.Property(t => t.ca_mcost_otherqty).HasColumnName("ca_mcost_otherqty");
            this.Property(t => t.ca_mcost_runsizeqty).HasColumnName("ca_mcost_runsizeqty");
            this.Property(t => t.ca_mcost_runsizeUOM).HasColumnName("ca_mcost_runsizeUOM");
            this.Property(t => t.ca_mcost_upcnt).HasColumnName("ca_mcost_upcnt");
            this.Property(t => t.ca_mcost_othcst).HasColumnName("ca_mcost_othcst");
            this.Property(t => t.ca_mcost_mktcst).HasColumnName("ca_mcost_mktcst");
            this.Property(t => t.ca_mcost_frtcst).HasColumnName("ca_mcost_frtcst");
            this.Property(t => t.ca_mcost_cdcst).HasColumnName("ca_mcost_cdcst");
            this.Property(t => t.ca_mcost_procst).HasColumnName("ca_mcost_procst");
            this.Property(t => t.ca_mcost_prcst).HasColumnName("ca_mcost_prcst");
            this.Property(t => t.ca_mcost_brocst).HasColumnName("ca_mcost_brocst");
            this.Property(t => t.ca_mcost_brcst).HasColumnName("ca_mcost_brcst");
            this.Property(t => t.ca_mcost_pmocst).HasColumnName("ca_mcost_pmocst");
            this.Property(t => t.ca_mcost_pmcst).HasColumnName("ca_mcost_pmcst");
            this.Property(t => t.ca_mcost_bmocst).HasColumnName("ca_mcost_bmocst");
            this.Property(t => t.ca_mcost_bmcst).HasColumnName("ca_mcost_bmcst");
            this.Property(t => t.ca_mcost_ioflag).HasColumnName("ca_mcost_ioflag");
            this.Property(t => t.ca_mcost_mpamethod).HasColumnName("ca_mcost_mpamethod");
            this.Property(t => t.ca_mcost_marketratio).HasColumnName("ca_mcost_marketratio");
            this.Property(t => t.ca_mcost_otherratio).HasColumnName("ca_mcost_otherratio");
        }
    }
}
