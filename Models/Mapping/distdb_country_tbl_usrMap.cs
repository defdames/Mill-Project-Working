using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class distdb_country_tbl_usrMap : EntityTypeConfiguration<distdb_country_tbl_usr>
    {
        public distdb_country_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.country);

            // Properties
            this.Property(t => t.country)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("distdb_country_tbl_usr");
            this.Property(t => t.country).HasColumnName("country");
        }
    }
}
