using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mill_Shift_CategoriesMap : EntityTypeConfiguration<mill_Shift_Categories>
    {
        public mill_Shift_CategoriesMap()
        {
            // Primary Key
            this.HasKey(t => t.Shift_catagories_ID);

            // Properties
            this.Property(t => t.Category)
                .HasMaxLength(255);

            this.Property(t => t.Category_Description)
                .HasMaxLength(255);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Created_by)
                .HasMaxLength(255);

            this.Property(t => t.Modified_by)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("mill_Shift_Categories");
            this.Property(t => t.Shift_catagories_ID).HasColumnName("Shift_catagories_ID");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.Category_Description).HasColumnName("Category_Description");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.Created_date).HasColumnName("Created_date");
            this.Property(t => t.Modified_date).HasColumnName("Modified_date");
            this.Property(t => t.Created_by).HasColumnName("Created_by");
            this.Property(t => t.Modified_by).HasColumnName("Modified_by");
        }
    }
}
