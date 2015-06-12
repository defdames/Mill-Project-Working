using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_comcd_tblMap : EntityTypeConfiguration<en_comcd_tbl>
    {
        public en_comcd_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_comcd_key);

            // Properties
            this.Property(t => t.en_comcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_comcd_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_comcd_indcd)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_comcd_tbl");
            this.Property(t => t.en_comcd_key).HasColumnName("en_comcd_key");
            this.Property(t => t.en_comcd_desc).HasColumnName("en_comcd_desc");
            this.Property(t => t.en_comcd_upcnt).HasColumnName("en_comcd_upcnt");
            this.Property(t => t.en_comcd_indcd).HasColumnName("en_comcd_indcd");
            this.Property(t => t.en_comcd_dtypc).HasColumnName("en_comcd_dtypc");
            this.Property(t => t.en_uom_key).HasColumnName("en_uom_key");
            this.Property(t => t.en_comcd_crtdt).HasColumnName("en_comcd_crtdt");
            this.Property(t => t.en_comcd_chgdt).HasColumnName("en_comcd_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
