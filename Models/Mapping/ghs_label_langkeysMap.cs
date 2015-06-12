using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ghs_label_langkeysMap : EntityTypeConfiguration<ghs_label_langkeys>
    {
        public ghs_label_langkeysMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dest_en_cntry_key, t.langkey });

            // Properties
            this.Property(t => t.dest_en_cntry_key)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.langkey)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ghs_label_langkeys");
            this.Property(t => t.dest_en_cntry_key).HasColumnName("dest_en_cntry_key");
            this.Property(t => t.langkey).HasColumnName("langkey");
        }
    }
}
