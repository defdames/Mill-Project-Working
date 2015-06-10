using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_shopstp_tblMap : EntityTypeConfiguration<pm_shopstp_tbl>
    {
        public pm_shopstp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key, t.in_item_key, t.im_pack_key, t.sf_rout_key, t.sf_opseq_key, t.sf_step_seq });

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

            this.Property(t => t.sf_rtstp_ubflg)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sf_crew_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("pm_shopstp_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.sf_step_seq).HasColumnName("sf_step_seq");
            this.Property(t => t.sf_rsrce_key).HasColumnName("sf_rsrce_key");
            this.Property(t => t.sf_rtstp_stdtm).HasColumnName("sf_rtstp_stdtm");
            this.Property(t => t.sf_rtstp_ubflg).HasColumnName("sf_rtstp_ubflg");
            this.Property(t => t.fm_prtins_key).HasColumnName("fm_prtins_key");
            this.Property(t => t.pm_shopstp_acttm).HasColumnName("pm_shopstp_acttm");
            this.Property(t => t.pm_shopstp_upcnt).HasColumnName("pm_shopstp_upcnt");
            this.Property(t => t.sf_crew_key).HasColumnName("sf_crew_key");
            this.Property(t => t.sf_crew_qty).HasColumnName("sf_crew_qty");
        }
    }
}
