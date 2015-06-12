using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class demandplanning_excludeditemsMap : EntityTypeConfiguration<demandplanning_excludeditems>
    {
        public demandplanning_excludeditemsMap()
        {
            // Primary Key
            this.HasKey(t => t.en_item_key);

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("demandplanning_excludeditems");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
        }
    }
}
