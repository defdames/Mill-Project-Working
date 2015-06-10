using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_matlcst_tblMap : EntityTypeConfiguration<pm_matlcst_tbl>
    {
        public pm_matlcst_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key, t.in_item_key, t.im_pack_key, t.sf_rout_key, t.sf_opseq_key, t.pm_matlcst_outitm, t.pm_matlcst_outpck });

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

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_opseq_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pm_matlcst_outitm)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pm_matlcst_outpck)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pm_matlcst_sku)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("pm_matlcst_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.pm_matlcst_outitm).HasColumnName("pm_matlcst_outitm");
            this.Property(t => t.pm_matlcst_outpck).HasColumnName("pm_matlcst_outpck");
            this.Property(t => t.pm_matlcst_sku).HasColumnName("pm_matlcst_sku");
            this.Property(t => t.pm_matlcst_fqty).HasColumnName("pm_matlcst_fqty");
            this.Property(t => t.pm_matlcst_fubscst).HasColumnName("pm_matlcst_fubscst");
            this.Property(t => t.pm_matlcst_fbscst).HasColumnName("pm_matlcst_fbscst");
            this.Property(t => t.pm_matlcst_fovhcst).HasColumnName("pm_matlcst_fovhcst");
            this.Property(t => t.pm_matlcst_ffdflg).HasColumnName("pm_matlcst_ffdflg");
            this.Property(t => t.pm_matlcst_sqty).HasColumnName("pm_matlcst_sqty");
            this.Property(t => t.pm_matlcst_subscst).HasColumnName("pm_matlcst_subscst");
            this.Property(t => t.pm_matlcst_sbscst).HasColumnName("pm_matlcst_sbscst");
            this.Property(t => t.pm_matlcst_sovhcst).HasColumnName("pm_matlcst_sovhcst");
            this.Property(t => t.pm_matlcst_sfdflg).HasColumnName("pm_matlcst_sfdflg");
            this.Property(t => t.pm_matlcst_eqty).HasColumnName("pm_matlcst_eqty");
            this.Property(t => t.pm_matlcst_eubscst).HasColumnName("pm_matlcst_eubscst");
            this.Property(t => t.pm_matlcst_ebscst).HasColumnName("pm_matlcst_ebscst");
            this.Property(t => t.pm_matlcst_eovhcst).HasColumnName("pm_matlcst_eovhcst");
            this.Property(t => t.pm_matlcst_efdflg).HasColumnName("pm_matlcst_efdflg");
            this.Property(t => t.pm_matlcst_rqty).HasColumnName("pm_matlcst_rqty");
            this.Property(t => t.pm_matlcst_rubscst).HasColumnName("pm_matlcst_rubscst");
            this.Property(t => t.pm_matlcst_rbscst).HasColumnName("pm_matlcst_rbscst");
            this.Property(t => t.pm_matlcst_rovhcst).HasColumnName("pm_matlcst_rovhcst");
            this.Property(t => t.pm_matlcst_rfdflg).HasColumnName("pm_matlcst_rfdflg");
            this.Property(t => t.pm_matlcst_aqty).HasColumnName("pm_matlcst_aqty");
            this.Property(t => t.pm_matlcst_aubscst).HasColumnName("pm_matlcst_aubscst");
            this.Property(t => t.pm_matlcst_abscst).HasColumnName("pm_matlcst_abscst");
            this.Property(t => t.pm_matlcst_aovhcst).HasColumnName("pm_matlcst_aovhcst");
            this.Property(t => t.pm_matlcst_afdflg).HasColumnName("pm_matlcst_afdflg");
            this.Property(t => t.pm_matlcst_pubscst).HasColumnName("pm_matlcst_pubscst");
            this.Property(t => t.pm_matlcst_pbscst).HasColumnName("pm_matlcst_pbscst");
            this.Property(t => t.pm_matlcst_povhcst).HasColumnName("pm_matlcst_povhcst");
            this.Property(t => t.pm_matlcst_upcnt).HasColumnName("pm_matlcst_upcnt");
        }
    }
}
