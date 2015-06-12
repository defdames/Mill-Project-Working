using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_stpbk_tblMap : EntityTypeConfiguration<pm_stpbk_tbl>
    {
        public pm_stpbk_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key, t.in_item_key, t.im_pack_key, t.sf_rout_key, t.sf_opseq_key, t.sf_step_seq, t.pm_stpbk_key });

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

            this.Property(t => t.pm_stpbk_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_rsrce_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sf_crew_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("pm_stpbk_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.sf_step_seq).HasColumnName("sf_step_seq");
            this.Property(t => t.pm_stpbk_key).HasColumnName("pm_stpbk_key");
            this.Property(t => t.sf_rsrce_key).HasColumnName("sf_rsrce_key");
            this.Property(t => t.pm_stpbk_bdte).HasColumnName("pm_stpbk_bdte");
            this.Property(t => t.pm_stpbk_bqty).HasColumnName("pm_stpbk_bqty");
            this.Property(t => t.pm_stpbk_shift).HasColumnName("pm_stpbk_shift");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.pm_stpbk_upcnt).HasColumnName("pm_stpbk_upcnt");
            this.Property(t => t.sf_crew_key).HasColumnName("sf_crew_key");
            this.Property(t => t.sf_crew_qty).HasColumnName("sf_crew_qty");
        }
    }
}
