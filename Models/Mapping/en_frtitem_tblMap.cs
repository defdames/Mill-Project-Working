using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_frtitem_tblMap : EntityTypeConfiguration<en_frtitem_tbl>
    {
        public en_frtitem_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_frtitem_key);

            // Properties
            this.Property(t => t.en_frtitem_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frtclass_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frtitem_desc)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("en_frtitem_tbl");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.en_frtclass_key).HasColumnName("en_frtclass_key");
            this.Property(t => t.en_frtitem_desc).HasColumnName("en_frtitem_desc");
            this.Property(t => t.en_frtitem_upcnt).HasColumnName("en_frtitem_upcnt");
        }
    }
}
