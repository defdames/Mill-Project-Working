using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ComplaintDatabase_HyperlinksMap : EntityTypeConfiguration<ComplaintDatabase_Hyperlinks>
    {
        public ComplaintDatabase_HyperlinksMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Link_Description)
                .HasMaxLength(500);

            this.Property(t => t.Hyperlink)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ComplaintDatabase_Hyperlinks");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ComplaintID).HasColumnName("ComplaintID");
            this.Property(t => t.Link_Description).HasColumnName("Link Description");
            this.Property(t => t.Hyperlink).HasColumnName("Hyperlink");
        }
    }
}
