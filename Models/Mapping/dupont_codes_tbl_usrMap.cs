using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class dupont_codes_tbl_usrMap : EntityTypeConfiguration<dupont_codes_tbl_usr>
    {
        public dupont_codes_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DupontKey, t.GlobalCode });

            // Properties
            this.Property(t => t.DupontKey)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.GlobalCode)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SMCode)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Hazard)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_pack_key)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("dupont_codes_tbl_usr");
            this.Property(t => t.DupontKey).HasColumnName("DupontKey");
            this.Property(t => t.GlobalCode).HasColumnName("GlobalCode");
            this.Property(t => t.SMCode).HasColumnName("SMCode");
            this.Property(t => t.Hazard).HasColumnName("Hazard");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
        }
    }
}
