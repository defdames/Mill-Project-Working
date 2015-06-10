using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_rsccst_tblMap : EntityTypeConfiguration<pm_rsccst_tbl>
    {
        public pm_rsccst_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key, t.in_item_key, t.im_pack_key, t.sf_rout_key, t.sf_opseq_key, t.sf_step_seq, t.sf_rsrce_key });

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

            this.Property(t => t.sf_step_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_rsrce_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pm_rsccst_screw)
                .HasMaxLength(10);

            this.Property(t => t.pm_rsccst_rcrew)
                .HasMaxLength(10);

            this.Property(t => t.pm_rsccst_acrew)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("pm_rsccst_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.sf_step_seq).HasColumnName("sf_step_seq");
            this.Property(t => t.sf_rsrce_key).HasColumnName("sf_rsrce_key");
            this.Property(t => t.pm_rsccst_frztm).HasColumnName("pm_rsccst_frztm");
            this.Property(t => t.pm_rsccst_fubscst).HasColumnName("pm_rsccst_fubscst");
            this.Property(t => t.pm_rsccst_fbscst).HasColumnName("pm_rsccst_fbscst");
            this.Property(t => t.pm_rsccst_fovhcst).HasColumnName("pm_rsccst_fovhcst");
            this.Property(t => t.pm_rsccst_ffdflg).HasColumnName("pm_rsccst_ffdflg");
            this.Property(t => t.pm_rsccst_sdrtm).HasColumnName("pm_rsccst_sdrtm");
            this.Property(t => t.pm_rsccst_subscst).HasColumnName("pm_rsccst_subscst");
            this.Property(t => t.pm_rsccst_sbscst).HasColumnName("pm_rsccst_sbscst");
            this.Property(t => t.pm_rsccst_sovhcst).HasColumnName("pm_rsccst_sovhcst");
            this.Property(t => t.pm_rsccst_sfdflg).HasColumnName("pm_rsccst_sfdflg");
            this.Property(t => t.pm_rsccst_exptm).HasColumnName("pm_rsccst_exptm");
            this.Property(t => t.pm_rsccst_eubscst).HasColumnName("pm_rsccst_eubscst");
            this.Property(t => t.pm_rsccst_ebscst).HasColumnName("pm_rsccst_ebscst");
            this.Property(t => t.pm_rsccst_eovhcst).HasColumnName("pm_rsccst_eovhcst");
            this.Property(t => t.pm_rsccst_efdflg).HasColumnName("pm_rsccst_efdflg");
            this.Property(t => t.pm_rsccst_reqtm).HasColumnName("pm_rsccst_reqtm");
            this.Property(t => t.pm_rsccst_rubscst).HasColumnName("pm_rsccst_rubscst");
            this.Property(t => t.pm_rsccst_rbscst).HasColumnName("pm_rsccst_rbscst");
            this.Property(t => t.pm_rsccst_rovhcst).HasColumnName("pm_rsccst_rovhcst");
            this.Property(t => t.pm_rsccst_rfdflg).HasColumnName("pm_rsccst_rfdflg");
            this.Property(t => t.pm_rsccst_acttm).HasColumnName("pm_rsccst_acttm");
            this.Property(t => t.pm_rsccst_aubscst).HasColumnName("pm_rsccst_aubscst");
            this.Property(t => t.pm_rsccst_abscst).HasColumnName("pm_rsccst_abscst");
            this.Property(t => t.pm_rsccst_aovhcst).HasColumnName("pm_rsccst_aovhcst");
            this.Property(t => t.pm_rsccst_afdflg).HasColumnName("pm_rsccst_afdflg");
            this.Property(t => t.pm_rsccst_upcnt).HasColumnName("pm_rsccst_upcnt");
            this.Property(t => t.pm_rsccst_screw).HasColumnName("pm_rsccst_screw");
            this.Property(t => t.pm_rsccst_scrwqty).HasColumnName("pm_rsccst_scrwqty");
            this.Property(t => t.pm_rsccst_rcrew).HasColumnName("pm_rsccst_rcrew");
            this.Property(t => t.pm_rsccst_rcrwqty).HasColumnName("pm_rsccst_rcrwqty");
            this.Property(t => t.pm_rsccst_acrew).HasColumnName("pm_rsccst_acrew");
            this.Property(t => t.pm_rsccst_acrwqty).HasColumnName("pm_rsccst_acrwqty");
        }
    }
}
