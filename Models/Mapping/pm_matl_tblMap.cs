using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_matl_tblMap : EntityTypeConfiguration<pm_matl_tbl>
    {
        public pm_matl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key, t.pm_matl_key });

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

            this.Property(t => t.pm_matl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pm_matl_ip)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sf_ingrd_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_pkitm_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pm_matl_inpk)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pm_matl_fpack)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pm_matl_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pm_matl_tranuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pm_matl_fuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_ingrd_iotp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pm_matl_chnord)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("pm_matl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.pm_matl_key).HasColumnName("pm_matl_key");
            this.Property(t => t.pm_matl_ip).HasColumnName("pm_matl_ip");
            this.Property(t => t.sf_ingrd_key).HasColumnName("sf_ingrd_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_pkitm_key).HasColumnName("in_pkitm_key");
            this.Property(t => t.pm_matl_inpk).HasColumnName("pm_matl_inpk");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.pm_matl_seq).HasColumnName("pm_matl_seq");
            this.Property(t => t.pm_matl_fpack).HasColumnName("pm_matl_fpack");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.pm_matl_qty).HasColumnName("pm_matl_qty");
            this.Property(t => t.pm_matl_nomqty).HasColumnName("pm_matl_nomqty");
            this.Property(t => t.pm_matl_issqt).HasColumnName("pm_matl_issqt");
            this.Property(t => t.pm_matl_retqt).HasColumnName("pm_matl_retqt");
            this.Property(t => t.pm_matl_totaq).HasColumnName("pm_matl_totaq");
            this.Property(t => t.pm_matl_pikqt).HasColumnName("pm_matl_pikqt");
            this.Property(t => t.pm_matl_pickd).HasColumnName("pm_matl_pickd");
            this.Property(t => t.pm_matl_cnsmd).HasColumnName("pm_matl_cnsmd");
            this.Property(t => t.pm_matl_scpqt).HasColumnName("pm_matl_scpqt");
            this.Property(t => t.pm_matl_recqt).HasColumnName("pm_matl_recqt");
            this.Property(t => t.pm_matl_uom).HasColumnName("pm_matl_uom");
            this.Property(t => t.pm_matl_tranuom).HasColumnName("pm_matl_tranuom");
            this.Property(t => t.pm_matl_fqty).HasColumnName("pm_matl_fqty");
            this.Property(t => t.pm_matl_fuom).HasColumnName("pm_matl_fuom");
            this.Property(t => t.sf_ingrd_iotp).HasColumnName("sf_ingrd_iotp");
            this.Property(t => t.pm_matl_reqdt).HasColumnName("pm_matl_reqdt");
            this.Property(t => t.pm_matl_bkflsh).HasColumnName("pm_matl_bkflsh");
            this.Property(t => t.pm_matl_rwrkf).HasColumnName("pm_matl_rwrkf");
            this.Property(t => t.pm_matl_upcnt).HasColumnName("pm_matl_upcnt");
            this.Property(t => t.pm_matl_chnord).HasColumnName("pm_matl_chnord");
        }
    }
}
