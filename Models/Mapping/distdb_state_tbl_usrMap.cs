using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class distdb_state_tbl_usrMap : EntityTypeConfiguration<distdb_state_tbl_usr>
    {
        public distdb_state_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.state_id);

            // Properties
            this.Property(t => t.state_id)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.state_name)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("distdb_state_tbl_usr");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.state_name).HasColumnName("state_name");
        }
    }
}
