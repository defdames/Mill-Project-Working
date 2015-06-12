using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class feed_planned_tbl_usrMap : EntityTypeConfiguration<feed_planned_tbl_usr>
    {
        public feed_planned_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.feed_plan_id);

            // Properties
            this.Property(t => t.feed)
                .HasMaxLength(30);

            this.Property(t => t.remarks)
                .HasMaxLength(80);

            this.Property(t => t.request_location)
                .HasMaxLength(6);

            this.Property(t => t.source_location)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("feed_planned_tbl_usr");
            this.Property(t => t.feed_plan_id).HasColumnName("feed_plan_id");
            this.Property(t => t.feed).HasColumnName("feed");
            this.Property(t => t.planned_date).HasColumnName("planned_date");
            this.Property(t => t.planned_qty).HasColumnName("planned_qty");
            this.Property(t => t.actual_qty).HasColumnName("actual_qty");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.datetime_stamp).HasColumnName("datetime_stamp");
            this.Property(t => t.request_location).HasColumnName("request_location");
            this.Property(t => t.source_location).HasColumnName("source_location");
        }
    }
}
