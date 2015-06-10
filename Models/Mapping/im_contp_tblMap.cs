using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_contp_tblMap : EntityTypeConfiguration<im_contp_tbl>
    {
        public im_contp_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.im_contp_key);

            // Properties
            this.Property(t => t.im_contp_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_contp_name)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_contp_desc)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("im_contp_tbl");
            this.Property(t => t.im_contp_key).HasColumnName("im_contp_key");
            this.Property(t => t.im_contp_name).HasColumnName("im_contp_name");
            this.Property(t => t.im_contp_desc).HasColumnName("im_contp_desc");
            this.Property(t => t.im_contp_upcnt).HasColumnName("im_contp_upcnt");
        }
    }
}
