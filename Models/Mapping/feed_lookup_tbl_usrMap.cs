using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class feed_lookup_tbl_usrMap : EntityTypeConfiguration<feed_lookup_tbl_usr>
    {
        public feed_lookup_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.feed);

            // Properties
            this.Property(t => t.feed)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.where_used)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("feed_lookup_tbl_usr");
            this.Property(t => t.feed).HasColumnName("feed");
            this.Property(t => t.where_used).HasColumnName("where_used");
            this.Property(t => t.datetime_stamp).HasColumnName("datetime_stamp");
        }
    }
}
