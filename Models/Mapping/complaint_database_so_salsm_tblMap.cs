using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class complaint_database_so_salsm_tblMap : EntityTypeConfiguration<complaint_database_so_salsm_tbl>
    {
        public complaint_database_so_salsm_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_salsm_name, t.so_salsm_city });

            // Properties
            this.Property(t => t.so_salsm_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_city)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("complaint_database_so_salsm_tbl");
            this.Property(t => t.so_salsm_name).HasColumnName("so_salsm_name");
            this.Property(t => t.so_salsm_city).HasColumnName("so_salsm_city");
        }
    }
}
