using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sa_compxs_tblMap : EntityTypeConfiguration<sa_compxs_tbl>
    {
        public sa_compxs_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sa_xsentty_key, t.sa_xsentty_type, t.sa_comp_key });

            // Properties
            this.Property(t => t.sa_xsentty_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sa_xsentty_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sa_comp_key)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("sa_compxs_tbl");
            this.Property(t => t.sa_xsentty_key).HasColumnName("sa_xsentty_key");
            this.Property(t => t.sa_xsentty_type).HasColumnName("sa_xsentty_type");
            this.Property(t => t.sa_comp_key).HasColumnName("sa_comp_key");
            this.Property(t => t.sa_compxs_mode).HasColumnName("sa_compxs_mode");
            this.Property(t => t.sa_compxs_upcnt).HasColumnName("sa_compxs_upcnt");
        }
    }
}
