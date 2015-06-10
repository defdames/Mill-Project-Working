using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class glb_ESL_Country_CodeMap : EntityTypeConfiguration<glb_ESL_Country_Code>
    {
        public glb_ESL_Country_CodeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.Country_Name, t.Country_Code });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Country_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Country_Code)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("glb_ESL_Country_Code");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Country_Name).HasColumnName("Country_Name");
            this.Property(t => t.Country_Code).HasColumnName("Country_Code");
        }
    }
}
