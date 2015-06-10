using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sa_field_tblMap : EntityTypeConfiguration<sa_field_tbl>
    {
        public sa_field_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sa_comp_key, t.sa_field_key });

            // Properties
            this.Property(t => t.sa_comp_key)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.sa_field_key)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("sa_field_tbl");
            this.Property(t => t.sa_comp_key).HasColumnName("sa_comp_key");
            this.Property(t => t.sa_field_key).HasColumnName("sa_field_key");
        }
    }
}
