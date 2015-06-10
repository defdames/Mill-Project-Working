using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class check_stkmv_whitmpkMap : EntityTypeConfiguration<check_stkmv_whitmpk>
    {
        public check_stkmv_whitmpkMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_whs_key, t.in_item_key, t.im_pack_key });

            // Properties
            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("check_stkmv_whitmpk");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_stkmv_eoh).HasColumnName("in_stkmv_eoh");
            this.Property(t => t.in_whitmpk_qoh).HasColumnName("in_whitmpk_qoh");
        }
    }
}
