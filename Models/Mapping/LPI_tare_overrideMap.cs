using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class LPI_tare_overrideMap : EntityTypeConfiguration<LPI_tare_override>
    {
        public LPI_tare_overrideMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.im_pack_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("LPI_tare_override");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.tareweightkgs).HasColumnName("tareweightkgs");
            this.Property(t => t.tareweightlbs).HasColumnName("tareweightlbs");
        }
    }
}
