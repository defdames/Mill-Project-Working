using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class generic_no_pkg_tbl_usrMap : EntityTypeConfiguration<generic_no_pkg_tbl_usr>
    {
        public generic_no_pkg_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.no_pkg_key, t.no_pkg_inc });

            // Properties
            this.Property(t => t.no_pkg_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.no_pkg_inc)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("generic_no_pkg_tbl_usr");
            this.Property(t => t.no_pkg_key).HasColumnName("no_pkg_key");
            this.Property(t => t.no_pkg_inc).HasColumnName("no_pkg_inc");
        }
    }
}
