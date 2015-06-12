using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class distdb_periodid_tbl_usrMap : EntityTypeConfiguration<distdb_periodid_tbl_usr>
    {
        public distdb_periodid_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.period_id);

            // Properties
            this.Property(t => t.period_id)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("distdb_periodid_tbl_usr");
            this.Property(t => t.period_id).HasColumnName("period_id");
            this.Property(t => t.datetime_stamp).HasColumnName("datetime_stamp");
        }
    }
}
