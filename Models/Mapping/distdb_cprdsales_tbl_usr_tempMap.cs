using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class distdb_cprdsales_tbl_usr_tempMap : EntityTypeConfiguration<distdb_cprdsales_tbl_usr_temp>
    {
        public distdb_cprdsales_tbl_usr_tempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.customer, t.location, t.grade, t.period_id, t.period_yr, t.period_mo });

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

            this.Property(t => t.period_id)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.period_yr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.period_mo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.userid)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("distdb_cprdsales_tbl_usr_temp");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.grade).HasColumnName("grade");
            this.Property(t => t.period_id).HasColumnName("period_id");
            this.Property(t => t.period_yr).HasColumnName("period_yr");
            this.Property(t => t.period_mo).HasColumnName("period_mo");
            this.Property(t => t.pounds).HasColumnName("pounds");
            this.Property(t => t.dollars).HasColumnName("dollars");
            this.Property(t => t.userid).HasColumnName("userid");
            this.Property(t => t.datetime_stamp).HasColumnName("datetime_stamp");
        }
    }
}
