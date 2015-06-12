using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pm_tran_tblMap : EntityTypeConfiguration<pm_tran_tbl>
    {
        public pm_tran_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.pm_shop_key, t.pm_tran_type, t.pm_tran_key });

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

            this.Property(t => t.pm_tran_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pm_tran_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pm_tran_bulkuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pm_tran_packuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_mohcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_rsrce_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_ptdept_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.sf_crew_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("pm_tran_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.pm_shop_key).HasColumnName("pm_shop_key");
            this.Property(t => t.pm_tran_type).HasColumnName("pm_tran_type");
            this.Property(t => t.pm_tran_key).HasColumnName("pm_tran_key");
            this.Property(t => t.pm_tran_time).HasColumnName("pm_tran_time");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.pm_matl_key).HasColumnName("pm_matl_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pm_tran_bulkqty).HasColumnName("pm_tran_bulkqty");
            this.Property(t => t.pm_tran_bulkuom).HasColumnName("pm_tran_bulkuom");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.pm_tran_packqty).HasColumnName("pm_tran_packqty");
            this.Property(t => t.pm_tran_packuom).HasColumnName("pm_tran_packuom");
            this.Property(t => t.pm_tran_bscst).HasColumnName("pm_tran_bscst");
            this.Property(t => t.pm_tran_actcst).HasColumnName("pm_tran_actcst");
            this.Property(t => t.pm_tran_ovhcst).HasColumnName("pm_tran_ovhcst");
            this.Property(t => t.in_mohcd_key).HasColumnName("in_mohcd_key");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.sf_rsrce_key).HasColumnName("sf_rsrce_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.sf_step_seq).HasColumnName("sf_step_seq");
            this.Property(t => t.pm_stpbk_key).HasColumnName("pm_stpbk_key");
            this.Property(t => t.pm_tran_rsrctm).HasColumnName("pm_tran_rsrctm");
            this.Property(t => t.pm_tran_fdflg).HasColumnName("pm_tran_fdflg");
            this.Property(t => t.pm_tran_factr).HasColumnName("pm_tran_factr");
            this.Property(t => t.pm_tran_dollr).HasColumnName("pm_tran_dollr");
            this.Property(t => t.sf_cstdr_id).HasColumnName("sf_cstdr_id");
            this.Property(t => t.pm_tran_ubflg).HasColumnName("pm_tran_ubflg");
            this.Property(t => t.pm_tran_mrbnf).HasColumnName("pm_tran_mrbnf");
            this.Property(t => t.pm_stpbk_shift).HasColumnName("pm_stpbk_shift");
            this.Property(t => t.sf_ptdept_key).HasColumnName("sf_ptdept_key");
            this.Property(t => t.sf_crew_key).HasColumnName("sf_crew_key");
            this.Property(t => t.sf_crew_qty).HasColumnName("sf_crew_qty");
            this.Property(t => t.gl_trace_key).HasColumnName("gl_trace_key");
            this.Property(t => t.pm_tran_upcnt).HasColumnName("pm_tran_upcnt");
        }
    }
}
