using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_crncy_tblMap : EntityTypeConfiguration<gl_crncy_tbl>
    {
        public gl_crncy_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_crncy_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_crncy_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_crncy_apgain)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_crncy_aploss)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_crncy_argain)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_crncy_arloss)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("gl_crncy_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.gl_crncy_desc).HasColumnName("gl_crncy_desc");
            this.Property(t => t.gl_crncy_upcnt).HasColumnName("gl_crncy_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_crncy_chgdt).HasColumnName("gl_crncy_chgdt");
            this.Property(t => t.gl_crncy_crtdt).HasColumnName("gl_crncy_crtdt");
            this.Property(t => t.gl_crncy_curp).HasColumnName("gl_crncy_curp");
            this.Property(t => t.gl_crncy_conv).HasColumnName("gl_crncy_conv");
            this.Property(t => t.gl_crncy_bpdp).HasColumnName("gl_crncy_bpdp");
            this.Property(t => t.gl_crncy_apgain).HasColumnName("gl_crncy_apgain");
            this.Property(t => t.gl_crncy_aploss).HasColumnName("gl_crncy_aploss");
            this.Property(t => t.gl_crncy_argain).HasColumnName("gl_crncy_argain");
            this.Property(t => t.gl_crncy_arloss).HasColumnName("gl_crncy_arloss");
        }
    }
}
