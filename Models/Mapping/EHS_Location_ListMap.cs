using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EHS_Location_ListMap : EntityTypeConfiguration<EHS_Location_List>
    {
        public EHS_Location_ListMap()
        {
            // Primary Key
            this.HasKey(t => t.Location);

            // Properties
            this.Property(t => t.Location)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EHS Location List");
            this.Property(t => t.Location).HasColumnName("Location");
        }
    }
}
