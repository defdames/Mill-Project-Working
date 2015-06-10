using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lang_pds_mainMap : EntityTypeConfiguration<lang_pds_main>
    {
        public lang_pds_mainMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Item, t.language });

            // Properties
            this.Property(t => t.Item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("lang_pds_main");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.Descriptions).HasColumnName("Descriptions");
            this.Property(t => t.Application).HasColumnName("Application");
            this.Property(t => t.notes).HasColumnName("notes");
            this.Property(t => t.FormulatingGuidelines).HasColumnName("FormulatingGuidelines");
            this.Property(t => t.ProductDescriptor1).HasColumnName("ProductDescriptor1");
            this.Property(t => t.ProductDescriptor2).HasColumnName("ProductDescriptor2");
            this.Property(t => t.ProductDescriptor3).HasColumnName("ProductDescriptor3");
            this.Property(t => t.ProductDescriptor4).HasColumnName("ProductDescriptor4");
            this.Property(t => t.ProductDescriptor5).HasColumnName("ProductDescriptor5");
        }
    }
}
