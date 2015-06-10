using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class china_enduserMap : EntityTypeConfiguration<china_enduser>
    {
        public china_enduserMap()
        {
            // Primary Key
            this.HasKey(t => t.china_enduser1);

            // Properties
            this.Property(t => t.china_enduser1)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("china_enduser");
            this.Property(t => t.china_enduser1).HasColumnName("china_enduser");
        }
    }
}
