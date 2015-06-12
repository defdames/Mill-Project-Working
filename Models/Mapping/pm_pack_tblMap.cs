using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_pack_tblMap : EntityTypeConfiguration<pm_pack_tbl>
    {
        public pm_pack_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key, t.sf_ingrd_key, t.im_pack_key, t.sf_opseq_key });

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

            this.Property(t => t.sf_ingrd_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.sf_opseq_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pm_pack_pkuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pm_pack_tranuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pm_pack_blkuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_fpo_batchid)
                .HasMaxLength(15);

            this.Property(t => t.sf_ptdept_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("pm_pack_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.sf_ingrd_key).HasColumnName("sf_ingrd_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.pm_pack_reqqty).HasColumnName("pm_pack_reqqty");
            this.Property(t => t.pm_pack_repqty).HasColumnName("pm_pack_repqty");
            this.Property(t => t.pm_pack_orgqty).HasColumnName("pm_pack_orgqty");
            this.Property(t => t.pm_pack_pkuom).HasColumnName("pm_pack_pkuom");
            this.Property(t => t.pm_pack_tranuom).HasColumnName("pm_pack_tranuom");
            this.Property(t => t.sf_ptitmpk_yldfac).HasColumnName("sf_ptitmpk_yldfac");
            this.Property(t => t.pm_pack_nbereqqty).HasColumnName("pm_pack_nbereqqty");
            this.Property(t => t.pm_pack_nberepqty).HasColumnName("pm_pack_nberepqty");
            this.Property(t => t.pm_pack_aberepqty).HasColumnName("pm_pack_aberepqty");
            this.Property(t => t.pm_pack_orgnbeqty).HasColumnName("pm_pack_orgnbeqty");
            this.Property(t => t.pm_pack_blkuom).HasColumnName("pm_pack_blkuom");
            this.Property(t => t.pm_pack_frzqty).HasColumnName("pm_pack_frzqty");
            this.Property(t => t.pm_pack_frzcst).HasColumnName("pm_pack_frzcst");
            this.Property(t => t.im_instr_key).HasColumnName("im_instr_key");
            this.Property(t => t.pn_fpo_batchid).HasColumnName("pn_fpo_batchid");
            this.Property(t => t.sf_ptdept_key).HasColumnName("sf_ptdept_key");
            this.Property(t => t.pm_pack_crtdt).HasColumnName("pm_pack_crtdt");
            this.Property(t => t.pm_pack_chgdt).HasColumnName("pm_pack_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.pm_pack_upcnt).HasColumnName("pm_pack_upcnt");
        }
    }
}
