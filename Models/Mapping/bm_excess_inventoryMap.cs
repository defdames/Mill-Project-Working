using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class bm_excess_inventoryMap : EntityTypeConfiguration<bm_excess_inventory>
    {
        public bm_excess_inventoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_item_key, t.gl_perod_year, t.gl_perod_id, t.ExcessFlag, t.in_sstk, t.in_class_key });

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExcessFlag)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_class_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("bm_excess_inventory");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
            this.Property(t => t.OnHand).HasColumnName("OnHand");
            this.Property(t => t.Excess).HasColumnName("Excess");
            this.Property(t => t.ExcessFlag).HasColumnName("ExcessFlag");
            this.Property(t => t.in_sstk).HasColumnName("in_sstk");
            this.Property(t => t.in_class_key).HasColumnName("in_class_key");
        }
    }
}
