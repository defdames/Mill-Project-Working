using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_remt_extMap : EntityTypeConfiguration<en_remt_ext>
    {
        public en_remt_extMap()
        {
            // Primary Key
            this.HasKey(t => t.en_remt_key);

            // Properties
            this.Property(t => t.en_remt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.remit_to_name)
                .HasMaxLength(60);

            this.Property(t => t.xref_remit_to_name)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("en_remt_ext");
            this.Property(t => t.en_remt_key).HasColumnName("en_remt_key");
            this.Property(t => t.remit_to_name).HasColumnName("remit_to_name");
            this.Property(t => t.xref_remit_to_name).HasColumnName("xref_remit_to_name");
            this.Property(t => t.en_remt_upcnt).HasColumnName("en_remt_upcnt");
        }
    }
}
