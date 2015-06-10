using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_mktseg_usr_newMap : EntityTypeConfiguration<en_mktseg_usr_new>
    {
        public en_mktseg_usr_newMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_mktseg_key1, t.en_mktseg_desc });

            // Properties
            this.Property(t => t.en_mktseg_key1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.en_mktseg_key2)
                .HasMaxLength(50);

            this.Property(t => t.en_mktseg_desc)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("en_mktseg_usr_new");
            this.Property(t => t.en_mktseg_key1).HasColumnName("en_mktseg_key1");
            this.Property(t => t.en_mktseg_key2).HasColumnName("en_mktseg_key2");
            this.Property(t => t.en_mktseg_desc).HasColumnName("en_mktseg_desc");
        }
    }
}
