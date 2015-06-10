using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class commodity_codesMap : EntityTypeConfiguration<commodity_codes>
    {
        public commodity_codesMap()
        {
            // Primary Key
            this.HasKey(t => t.in_comcd_key);

            // Properties
            this.Property(t => t.in_comcd_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("commodity_codes");
            this.Property(t => t.in_comcd_key).HasColumnName("in_comcd_key");
        }
    }
}
