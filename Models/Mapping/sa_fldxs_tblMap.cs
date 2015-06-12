using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sa_fldxs_tblMap : EntityTypeConfiguration<sa_fldxs_tbl>
    {
        public sa_fldxs_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sa_xsentty_key, t.sa_xsentty_type, t.sa_comp_key, t.sa_field_key });

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

            this.Property(t => t.sa_field_key)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("sa_fldxs_tbl");
            this.Property(t => t.sa_xsentty_key).HasColumnName("sa_xsentty_key");
            this.Property(t => t.sa_xsentty_type).HasColumnName("sa_xsentty_type");
            this.Property(t => t.sa_comp_key).HasColumnName("sa_comp_key");
            this.Property(t => t.sa_field_key).HasColumnName("sa_field_key");
            this.Property(t => t.sa_fldxs_mode).HasColumnName("sa_fldxs_mode");
            this.Property(t => t.sa_fldxs_upcnt).HasColumnName("sa_fldxs_upcnt");
        }
    }
}
