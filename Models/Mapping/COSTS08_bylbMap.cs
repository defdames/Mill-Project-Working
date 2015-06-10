using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class COSTS08_bylbMap : EntityTypeConfiguration<COSTS08_bylb>
    {
        public COSTS08_bylbMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ACT_FCST, t.gl_cmp_key, t.in_whs_key, t.in_item_key, t.im_pack_key, t.CostYr });

            // Properties
            this.Property(t => t.ACT_FCST)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.CostYr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COSTS08_bylb");
            this.Property(t => t.ACT_FCST).HasColumnName("ACT_FCST");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.CostYr).HasColumnName("CostYr");
            this.Property(t => t.Cost).HasColumnName("Cost");
        }
    }
}
