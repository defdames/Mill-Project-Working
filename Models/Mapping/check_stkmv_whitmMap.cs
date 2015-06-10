using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class check_stkmv_whitmMap : EntityTypeConfiguration<check_stkmv_whitm>
    {
        public check_stkmv_whitmMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_whs_key, t.in_item_key });

            // Properties
            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("check_stkmv_whitm");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_stkmv_eoh).HasColumnName("in_stkmv_eoh");
            this.Property(t => t.in_whitm_qoh).HasColumnName("in_whitm_qoh");
        }
    }
}
