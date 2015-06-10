using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class china_marketMap : EntityTypeConfiguration<china_market>
    {
        public china_marketMap()
        {
            // Primary Key
            this.HasKey(t => t.china_market1);

            // Properties
            this.Property(t => t.china_market1)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("china_market");
            this.Property(t => t.china_market1).HasColumnName("china_market");
        }
    }
}
