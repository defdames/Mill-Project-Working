using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_shop_tblMap : EntityTypeConfiguration<pm_shop_tbl>
    {
        public pm_shop_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pm_shop_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pm_shop_ordtp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pm_shop_chnord)
                .HasMaxLength(10);

            this.Property(t => t.sf_prcss_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_frmla_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pm_shop_dflot)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.pm_shop_buom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pm_shop_cust)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pm_acct_grp)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pm_shop_apkey)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pn_fpo_batchid)
                .HasMaxLength(15);

            this.Property(t => t.sf_ptdept_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pm_shop_xrefid)
                .HasMaxLength(32);

            this.Property(t => t.pn_fpo_remks)
                .HasMaxLength(60);

            this.Property(t => t.pn_fpo_refkey)
                .HasMaxLength(20);

            this.Property(t => t.pn_fpo_refkey2)
                .HasMaxLength(20);

            this.Property(t => t.pn_fpo_refkey3)
                .HasMaxLength(20);

            this.Property(t => t.pm_shop_relby)
                .HasMaxLength(8);

            this.Property(t => t.pm_shop_cmplby)
                .HasMaxLength(8);

            this.Property(t => t.pm_shop_prclsby)
                .HasMaxLength(8);

            this.Property(t => t.pm_shop_clsby)
                .HasMaxLength(8);

            this.Property(t => t.pm_shop_cmbord)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("pm_shop_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.pm_shop_ordtp).HasColumnName("pm_shop_ordtp");
            this.Property(t => t.pm_shop_subtyp).HasColumnName("pm_shop_subtyp");
            this.Property(t => t.pm_shop_stat).HasColumnName("pm_shop_stat");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pm_shop_chnord).HasColumnName("pm_shop_chnord");
            this.Property(t => t.sf_prcss_key).HasColumnName("sf_prcss_key");
            this.Property(t => t.sf_prcss_ver).HasColumnName("sf_prcss_ver");
            this.Property(t => t.sf_frmla_key).HasColumnName("sf_frmla_key");
            this.Property(t => t.sf_frmla_ver).HasColumnName("sf_frmla_ver");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.pm_shop_dflot).HasColumnName("pm_shop_dflot");
            this.Property(t => t.pm_shop_bqty).HasColumnName("pm_shop_bqty");
            this.Property(t => t.pm_shop_buom).HasColumnName("pm_shop_buom");
            this.Property(t => t.pm_shop_nombqty).HasColumnName("pm_shop_nombqty");
            this.Property(t => t.pm_shop_orgbqty).HasColumnName("pm_shop_orgbqty");
            this.Property(t => t.pm_shop_orgnbqty).HasColumnName("pm_shop_orgnbqty");
            this.Property(t => t.pm_shop_stdt).HasColumnName("pm_shop_stdt");
            this.Property(t => t.pm_shop_reldt).HasColumnName("pm_shop_reldt");
            this.Property(t => t.pm_shop_duedt).HasColumnName("pm_shop_duedt");
            this.Property(t => t.pm_shop_entdt).HasColumnName("pm_shop_entdt");
            this.Property(t => t.pm_shop_pstdt).HasColumnName("pm_shop_pstdt");
            this.Property(t => t.pm_shop_cmpldt).HasColumnName("pm_shop_cmpldt");
            this.Property(t => t.pm_shop_prclsdt).HasColumnName("pm_shop_prclsdt");
            this.Property(t => t.pm_shop_clsdt).HasColumnName("pm_shop_clsdt");
            this.Property(t => t.im_instr_key).HasColumnName("im_instr_key");
            this.Property(t => t.pm_shop_cust).HasColumnName("pm_shop_cust");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.pm_acct_grp).HasColumnName("pm_acct_grp");
            this.Property(t => t.pm_shop_alflg).HasColumnName("pm_shop_alflg");
            this.Property(t => t.pm_shop_apkey).HasColumnName("pm_shop_apkey");
            this.Property(t => t.pm_shop_apver).HasColumnName("pm_shop_apver");
            this.Property(t => t.pm_shop_type).HasColumnName("pm_shop_type");
            this.Property(t => t.pn_fpo_batchid).HasColumnName("pn_fpo_batchid");
            this.Property(t => t.pm_shop_cstadjf).HasColumnName("pm_shop_cstadjf");
            this.Property(t => t.so_dtl_expeditef).HasColumnName("so_dtl_expeditef");
            this.Property(t => t.sf_ptdept_key).HasColumnName("sf_ptdept_key");
            this.Property(t => t.pm_shop_shift).HasColumnName("pm_shop_shift");
            this.Property(t => t.pm_shop_rwtype).HasColumnName("pm_shop_rwtype");
            this.Property(t => t.pm_shop_upcnt).HasColumnName("pm_shop_upcnt");
            this.Property(t => t.pm_shop_xrefid).HasColumnName("pm_shop_xrefid");
            this.Property(t => t.pn_fpo_remks).HasColumnName("pn_fpo_remks");
            this.Property(t => t.pn_fpo_refkey).HasColumnName("pn_fpo_refkey");
            this.Property(t => t.pn_fpo_refkey2).HasColumnName("pn_fpo_refkey2");
            this.Property(t => t.pn_fpo_refkey3).HasColumnName("pn_fpo_refkey3");
            this.Property(t => t.pm_shop_relby).HasColumnName("pm_shop_relby");
            this.Property(t => t.pm_shop_cmplby).HasColumnName("pm_shop_cmplby");
            this.Property(t => t.pm_shop_prclsby).HasColumnName("pm_shop_prclsby");
            this.Property(t => t.pm_shop_clsby).HasColumnName("pm_shop_clsby");
            this.Property(t => t.pm_shop_cmbord).HasColumnName("pm_shop_cmbord");
        }
    }
}
