using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class released_orders_tbl_usrMap : EntityTypeConfiguration<released_orders_tbl_usr>
    {
        public released_orders_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderNo, t.LineNbr, t.Type });

            // Properties
            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LineNbr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Item)
                .HasMaxLength(20);

            this.Property(t => t.Product)
                .HasMaxLength(40);

            this.Property(t => t.Status)
                .HasMaxLength(4);

            this.Property(t => t.Released_Remarks)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("released_orders_tbl_usr");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.LineNbr).HasColumnName("LineNbr");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.Demand_Qty).HasColumnName("Demand_Qty");
            this.Property(t => t.Promise_Date).HasColumnName("Promise_Date");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Released_Date).HasColumnName("Released_Date");
            this.Property(t => t.Released_Qty).HasColumnName("Released_Qty");
            this.Property(t => t.Released_Remarks).HasColumnName("Released_Remarks");
            this.Property(t => t.DateTime_Stamp).HasColumnName("DateTime_Stamp");
            this.Property(t => t.Alcqt).HasColumnName("Alcqt");
        }
    }
}
