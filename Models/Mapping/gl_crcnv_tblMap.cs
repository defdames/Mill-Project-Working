using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_crcnv_tblMap : EntityTypeConfiguration<gl_crcnv_tbl>
    {
        public gl_crcnv_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_crncy_from, t.gl_crncy_to, t.gl_crcnv_date });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_from)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_crncy_to)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_crcnv_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gl_crcnv_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_crncy_from).HasColumnName("gl_crncy_from");
            this.Property(t => t.gl_crncy_to).HasColumnName("gl_crncy_to");
            this.Property(t => t.gl_crcnv_date).HasColumnName("gl_crcnv_date");
            this.Property(t => t.gl_crcnv_rate).HasColumnName("gl_crcnv_rate");
            this.Property(t => t.gl_crcnv_desc).HasColumnName("gl_crcnv_desc");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_crcnv_chgdt).HasColumnName("gl_crcnv_chgdt");
            this.Property(t => t.gl_crcnv_crtdt).HasColumnName("gl_crcnv_crtdt");
            this.Property(t => t.gl_crcnv_upcnt).HasColumnName("gl_crcnv_upcnt");
            this.Property(t => t.gl_crcnv_fac1).HasColumnName("gl_crcnv_fac1");
            this.Property(t => t.gl_crcnv_fac2).HasColumnName("gl_crcnv_fac2");
            this.Property(t => t.gl_crcnv_tolr).HasColumnName("gl_crcnv_tolr");
        }
    }
}
