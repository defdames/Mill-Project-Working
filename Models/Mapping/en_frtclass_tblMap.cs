using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_frtclass_tblMap : EntityTypeConfiguration<en_frtclass_tbl>
    {
        public en_frtclass_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_frtclass_key);

            // Properties
            this.Property(t => t.en_frtclass_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frtclass_desc)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("en_frtclass_tbl");
            this.Property(t => t.en_frtclass_key).HasColumnName("en_frtclass_key");
            this.Property(t => t.en_frtclass_desc).HasColumnName("en_frtclass_desc");
            this.Property(t => t.en_frtclass_upcnt).HasColumnName("en_frtclass_upcnt");
        }
    }
}
