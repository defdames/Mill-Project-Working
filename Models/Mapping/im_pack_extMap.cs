using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_pack_extMap : EntityTypeConfiguration<im_pack_ext>
    {
        public im_pack_extMap()
        {
            // Primary Key
            this.HasKey(t => t.im_pack_key);

            // Properties
            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.im_pack_bolpack)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_pack_bolpack_sll)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("im_pack_ext");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.im_pack_bolpack).HasColumnName("im_pack_bolpack");
            this.Property(t => t.im_pack_upcnt).HasColumnName("im_pack_upcnt");
            this.Property(t => t.im_pack_bolpack_sll).HasColumnName("im_pack_bolpack_sll");
        }
    }
}
