using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class item_planned_tbl_usrMap : EntityTypeConfiguration<item_planned_tbl_usr>
    {
        public item_planned_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.item_plan_id);

            // Properties
            this.Property(t => t.item)
                .HasMaxLength(30);

            this.Property(t => t.remarks)
                .HasMaxLength(80);

            this.Property(t => t.sm_remarks)
                .HasMaxLength(80);

            this.Property(t => t.other_location)
                .HasMaxLength(4);

            this.Property(t => t.revised_qty_msg)
                .HasMaxLength(80);

            this.Property(t => t.revised_date_msg)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("item_planned_tbl_usr");
            this.Property(t => t.item_plan_id).HasColumnName("item_plan_id");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.planned_date).HasColumnName("planned_date");
            this.Property(t => t.planned_qty).HasColumnName("planned_qty");
            this.Property(t => t.actual_qty).HasColumnName("actual_qty");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.datetime_stamp).HasColumnName("datetime_stamp");
            this.Property(t => t.revised_date).HasColumnName("revised_date");
            this.Property(t => t.sm_remarks).HasColumnName("sm_remarks");
            this.Property(t => t.other_location).HasColumnName("other_location");
            this.Property(t => t.revised_qty_msg).HasColumnName("revised_qty_msg");
            this.Property(t => t.revised_date_msg).HasColumnName("revised_date_msg");
        }
    }
}
