using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_mktseg_usrMap : EntityTypeConfiguration<en_mktseg_usr>
    {
        public en_mktseg_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_mktseg_key, t.en_mktseg_desc });

            // Properties
            this.Property(t => t.en_mktseg_key)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.en_mktseg_desc)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("en_mktseg_usr");
            this.Property(t => t.en_mktseg_key).HasColumnName("en_mktseg_key");
            this.Property(t => t.en_mktseg_desc).HasColumnName("en_mktseg_desc");
        }
    }
}
