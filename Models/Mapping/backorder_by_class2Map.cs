using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class backorder_by_class2Map : EntityTypeConfiguration<backorder_by_class2>
    {
        public backorder_by_class2Map()
        {
            // Primary Key
            this.HasKey(t => t.item);

            // Properties
            this.Property(t => t.item)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("backorder_by_class2");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.std).HasColumnName("std");
        }
    }
}
