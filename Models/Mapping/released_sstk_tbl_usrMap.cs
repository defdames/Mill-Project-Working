using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class released_sstk_tbl_usrMap : EntityTypeConfiguration<released_sstk_tbl_usr>
    {
        public released_sstk_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.item_sstk_id);

            // Properties
            this.Property(t => t.whse)
                .HasMaxLength(6);

            this.Property(t => t.item)
                .HasMaxLength(20);

            this.Property(t => t.pack)
                .HasMaxLength(6);

            this.Property(t => t.released_remarks)
                .HasMaxLength(60);

            this.Property(t => t.transfer_id)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("released_sstk_tbl_usr");
            this.Property(t => t.item_sstk_id).HasColumnName("item_sstk_id");
            this.Property(t => t.whse).HasColumnName("whse");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.pack).HasColumnName("pack");
            this.Property(t => t.released_date).HasColumnName("released_date");
            this.Property(t => t.released_qty).HasColumnName("released_qty");
            this.Property(t => t.released_remarks).HasColumnName("released_remarks");
            this.Property(t => t.transfer_id).HasColumnName("transfer_id");
            this.Property(t => t.datetime_stamp).HasColumnName("datetime_stamp");
        }
    }
}
