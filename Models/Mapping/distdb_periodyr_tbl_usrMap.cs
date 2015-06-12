using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class distdb_periodyr_tbl_usrMap : EntityTypeConfiguration<distdb_periodyr_tbl_usr>
    {
        public distdb_periodyr_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.period_yr);

            // Properties
            this.Property(t => t.period_yr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("distdb_periodyr_tbl_usr");
            this.Property(t => t.period_yr).HasColumnName("period_yr");
            this.Property(t => t.datetime_stamp).HasColumnName("datetime_stamp");
        }
    }
}
