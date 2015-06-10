using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class no_pkg_tbl_usrMap : EntityTypeConfiguration<no_pkg_tbl_usr>
    {
        public no_pkg_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.no_pkg_key, t.no_pkg_inc, t.no_pkg_id });

            // Properties
            this.Property(t => t.no_pkg_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.no_pkg_inc)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.no_pkg_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("no_pkg_tbl_usr");
            this.Property(t => t.no_pkg_key).HasColumnName("no_pkg_key");
            this.Property(t => t.no_pkg_inc).HasColumnName("no_pkg_inc");
            this.Property(t => t.no_pkg_id).HasColumnName("no_pkg_id");
        }
    }
}
