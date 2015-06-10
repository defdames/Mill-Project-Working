using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class distdb_cprdprof_tbl_usrMap : EntityTypeConfiguration<distdb_cprdprof_tbl_usr>
    {
        public distdb_cprdprof_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.customer, t.location, t.grade });

            // Properties
            this.Property(t => t.customer)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.location)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.grade)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.status)
                .HasMaxLength(10);

            this.Property(t => t.userid)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("distdb_cprdprof_tbl_usr");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.grade).HasColumnName("grade");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.userid).HasColumnName("userid");
            this.Property(t => t.datetime_stamp).HasColumnName("datetime_stamp");
        }
    }
}
