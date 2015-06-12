using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class inventory_loc_usrMap : EntityTypeConfiguration<inventory_loc_usr>
    {
        public inventory_loc_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ldate, t.item, t.loc });

            // Properties
            this.Property(t => t.item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pack)
                .HasMaxLength(10);

            this.Property(t => t.lot)
                .HasMaxLength(40);

            this.Property(t => t.loc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.iuser)
                .HasMaxLength(40);

            this.Property(t => t.usedwhere)
                .HasMaxLength(40);

            this.Property(t => t.remarks)
                .HasMaxLength(300);

            this.Property(t => t.usedfrom)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("inventory_loc_usr");
            this.Property(t => t.ldate).HasColumnName("ldate");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.pack).HasColumnName("pack");
            this.Property(t => t.lot).HasColumnName("lot");
            this.Property(t => t.loc).HasColumnName("loc");
            this.Property(t => t.iuser).HasColumnName("iuser");
            this.Property(t => t.usedwhere).HasColumnName("usedwhere");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.amtused).HasColumnName("amtused");
            this.Property(t => t.usedfrom).HasColumnName("usedfrom");
        }
    }
}
