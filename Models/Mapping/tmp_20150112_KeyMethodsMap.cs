using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_20150112_KeyMethodsMap : EntityTypeConfiguration<tmp_20150112_KeyMethods>
    {
        public tmp_20150112_KeyMethodsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JSA_Category, t.JSA__, t.Key_Method__ });

            // Properties
            this.Property(t => t.JSA_Category)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JSA__)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tmp_20150112_KeyMethods");
            this.Property(t => t.JSA_Category).HasColumnName("JSA Category");
            this.Property(t => t.JSA__).HasColumnName("JSA #");
            this.Property(t => t.Key_Method__).HasColumnName("Key Method #");
            this.Property(t => t.Sequence_of_Steps).HasColumnName("Sequence of Steps");
            this.Property(t => t.Key_Factor).HasColumnName("Key Factor");
            this.Property(t => t.Key_Safety).HasColumnName("Key Safety");
        }
    }
}
