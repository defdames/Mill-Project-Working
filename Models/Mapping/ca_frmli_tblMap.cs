using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ca_frmli_tblMap : EntityTypeConfiguration<ca_frmli_tbl>
    {
        public ca_frmli_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_prcss_key, t.sf_prcss_ver, t.sf_frmla_key, t.sf_frmla_ver, t.ca_frmlo_effdt, t.ca_frmlo_cstyp, t.sf_ingrd_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_prcss_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_prcss_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_frmla_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_frmla_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ca_frmlo_cstyp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_ingrd_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whitm_sourc)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ca_frmli_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_prcss_key).HasColumnName("sf_prcss_key");
            this.Property(t => t.sf_prcss_ver).HasColumnName("sf_prcss_ver");
            this.Property(t => t.sf_frmla_key).HasColumnName("sf_frmla_key");
            this.Property(t => t.sf_frmla_ver).HasColumnName("sf_frmla_ver");
            this.Property(t => t.ca_frmlo_effdt).HasColumnName("ca_frmlo_effdt");
            this.Property(t => t.ca_frmlo_cstyp).HasColumnName("ca_frmlo_cstyp");
            this.Property(t => t.sf_ingrd_key).HasColumnName("sf_ingrd_key");
            this.Property(t => t.ca_frmlo_inadt).HasColumnName("ca_frmlo_inadt");
            this.Property(t => t.ca_frmli_csmth).HasColumnName("ca_frmli_csmth");
            this.Property(t => t.ca_frmli_qpa).HasColumnName("ca_frmli_qpa");
            this.Property(t => t.sf_ingrd_yld).HasColumnName("sf_ingrd_yld");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.ca_frmli_mtlv).HasColumnName("ca_frmli_mtlv");
            this.Property(t => t.ca_frmli_ohv).HasColumnName("ca_frmli_ohv");
            this.Property(t => t.in_mohcd_fdflg).HasColumnName("in_mohcd_fdflg");
            this.Property(t => t.in_mohcd_factr).HasColumnName("in_mohcd_factr");
            this.Property(t => t.in_mohcd_dollr).HasColumnName("in_mohcd_dollr");
            this.Property(t => t.ca_frmli_formulaqty).HasColumnName("ca_frmli_formulaqty");
            this.Property(t => t.ca_frmli_upcnt).HasColumnName("ca_frmli_upcnt");
            this.Property(t => t.ca_frmli_bmcst).HasColumnName("ca_frmli_bmcst");
            this.Property(t => t.ca_frmli_bmocst).HasColumnName("ca_frmli_bmocst");
            this.Property(t => t.ca_frmli_pmcst).HasColumnName("ca_frmli_pmcst");
            this.Property(t => t.ca_frmli_pmocst).HasColumnName("ca_frmli_pmocst");
            this.Property(t => t.ca_frmli_brcst).HasColumnName("ca_frmli_brcst");
            this.Property(t => t.ca_frmli_brocst).HasColumnName("ca_frmli_brocst");
            this.Property(t => t.ca_frmli_prcst).HasColumnName("ca_frmli_prcst");
            this.Property(t => t.ca_frmli_procst).HasColumnName("ca_frmli_procst");
            this.Property(t => t.ca_frmli_cdcst).HasColumnName("ca_frmli_cdcst");
            this.Property(t => t.ca_frmli_frtcst).HasColumnName("ca_frmli_frtcst");
            this.Property(t => t.ca_frmli_mktcst).HasColumnName("ca_frmli_mktcst");
            this.Property(t => t.ca_frmli_othcst).HasColumnName("ca_frmli_othcst");
            this.Property(t => t.in_whitm_sourc).HasColumnName("in_whitm_sourc");
            this.Property(t => t.sf_ingrd_opyld).HasColumnName("sf_ingrd_opyld");
        }
    }
}
