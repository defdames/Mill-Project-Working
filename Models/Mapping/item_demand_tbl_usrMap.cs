using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class item_demand_tbl_usrMap : EntityTypeConfiguration<item_demand_tbl_usr>
    {
        public item_demand_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.item);

            // Properties
            this.Property(t => t.item)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Source_Location)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("item_demand_tbl_usr");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.onhand_qty).HasColumnName("onhand_qty");
            this.Property(t => t.demand).HasColumnName("demand");
            this.Property(t => t.excess_demand).HasColumnName("excess_demand");
            this.Property(t => t.Review).HasColumnName("Review");
            this.Property(t => t.Reviewed).HasColumnName("Reviewed");
            this.Property(t => t.DateTime_Stamp).HasColumnName("DateTime_Stamp");
            this.Property(t => t.Source_Location).HasColumnName("Source_Location");
            this.Property(t => t.FreeStock).HasColumnName("FreeStock");
            this.Property(t => t.Alcqt).HasColumnName("Alcqt");
        }
    }
}
