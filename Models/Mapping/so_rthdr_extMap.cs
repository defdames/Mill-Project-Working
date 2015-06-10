using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_rthdr_extMap : EntityTypeConfiguration<so_rthdr_ext>
    {
        public so_rthdr_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_rthdr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_rthdr_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("so_rthdr_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_rthdr_key).HasColumnName("so_rthdr_key");
            this.Property(t => t.return_explanation).HasColumnName("return_explanation");
            this.Property(t => t.so_rthdr_upcnt).HasColumnName("so_rthdr_upcnt");
        }
    }
}
