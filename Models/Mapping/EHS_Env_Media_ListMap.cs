using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EHS_Env_Media_ListMap : EntityTypeConfiguration<EHS_Env_Media_List>
    {
        public EHS_Env_Media_ListMap()
        {
            // Primary Key
            this.HasKey(t => t.Description);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EHS Env Media List");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
