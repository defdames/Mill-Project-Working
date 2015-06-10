using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tblTruckScheduleMap : EntityTypeConfiguration<tblTruckSchedule>
    {
        public tblTruckScheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.in_wthdr_key);

            // Properties
            this.Property(t => t.in_wthdr_via)
                .HasMaxLength(255);

            this.Property(t => t.in_item_key)
                .HasMaxLength(255);

            this.Property(t => t.in_wthdr_frwhs)
                .HasMaxLength(255);

            this.Property(t => t.in_wthdr_towhs)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tblTruckSchedule");
            this.Property(t => t.in_wthdr_key).HasColumnName("in_wthdr_key");
            this.Property(t => t.in_wthdr_reqdt).HasColumnName("in_wthdr_reqdt");
            this.Property(t => t.in_wthdr_via).HasColumnName("in_wthdr_via");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_wthdr_frwhs).HasColumnName("in_wthdr_frwhs");
            this.Property(t => t.in_wthdr_towhs).HasColumnName("in_wthdr_towhs");
            this.Property(t => t.in_wtdtl_stat).HasColumnName("in_wtdtl_stat");
        }
    }
}
