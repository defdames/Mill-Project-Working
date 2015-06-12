using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pn_item_tblMap : EntityTypeConfiguration<pn_item_tbl>
    {
        public pn_item_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pn_sched_key, t.in_item_key, t.sf_plant_key, t.im_pack_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_sched_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pn_item_flag)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_item_sourc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_item_srcwhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("pn_item_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pn_sched_key).HasColumnName("pn_sched_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pn_item_plndt).HasColumnName("pn_item_plndt");
            this.Property(t => t.pn_item_upcnt).HasColumnName("pn_item_upcnt");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.pn_item_flag).HasColumnName("pn_item_flag");
            this.Property(t => t.pn_item_sourc).HasColumnName("pn_item_sourc");
            this.Property(t => t.pn_item_srcwhs).HasColumnName("pn_item_srcwhs");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
        }
    }
}
