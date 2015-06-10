using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class distdb_periodmo_tbl_usrMap : EntityTypeConfiguration<distdb_periodmo_tbl_usr>
    {
        public distdb_periodmo_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.mo_id, t.Month });

            // Properties
            this.Property(t => t.mo_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Month)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("distdb_periodmo_tbl_usr");
            this.Property(t => t.mo_id).HasColumnName("mo_id");
            this.Property(t => t.Month).HasColumnName("Month");
        }
    }
}
