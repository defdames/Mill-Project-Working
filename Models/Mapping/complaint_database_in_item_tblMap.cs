using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class complaint_database_in_item_tblMap : EntityTypeConfiguration<complaint_database_in_item_tbl>
    {
        public complaint_database_in_item_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_item_key, t.in_desc, t.in_comcd_key });

            // Properties
            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.in_comcd_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("complaint_database_in_item_tbl");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_desc).HasColumnName("in_desc");
            this.Property(t => t.in_comcd_key).HasColumnName("in_comcd_key");
        }
    }
}
