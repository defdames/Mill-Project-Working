using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class backorder_by_class1Map : EntityTypeConfiguration<backorder_by_class1>
    {
        public backorder_by_class1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.in_alloc_ordid, t.in_alloc_line });

            // Properties
            this.Property(t => t.in_alloc_ordid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_alloc_line)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("backorder_by_class1");
            this.Property(t => t.in_alloc_ordid).HasColumnName("in_alloc_ordid");
            this.Property(t => t.in_alloc_line).HasColumnName("in_alloc_line");
            this.Property(t => t.aqty).HasColumnName("aqty");
        }
    }
}
