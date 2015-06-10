using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class distdb_agent_tbl_usrMap : EntityTypeConfiguration<distdb_agent_tbl_usr>
    {
        public distdb_agent_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.so_salsm_key);

            // Properties
            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_salsm_name)
                .HasMaxLength(30);

            this.Property(t => t.so_salsm_lname)
                .HasMaxLength(80);

            this.Property(t => t.so_salsm_sname)
                .HasMaxLength(20);

            this.Property(t => t.so_salsm_terrpt)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("distdb_agent_tbl_usr");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.so_salsm_name).HasColumnName("so_salsm_name");
            this.Property(t => t.so_salsm_lname).HasColumnName("so_salsm_lname");
            this.Property(t => t.so_salsm_sname).HasColumnName("so_salsm_sname");
            this.Property(t => t.so_salsm_terrpt).HasColumnName("so_salsm_terrpt");
        }
    }
}
