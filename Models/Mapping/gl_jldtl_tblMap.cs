using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_jldtl_tblMap : EntityTypeConfiguration<gl_jldtl_tbl>
    {
        public gl_jldtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_jlnum_key, t.gl_jldtl_line, t.gl_cmp_post });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_jlnum_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_jldtl_line)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_jldtl_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_cmp_post)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("gl_jldtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_jlnum_key).HasColumnName("gl_jlnum_key");
            this.Property(t => t.gl_jldtl_line).HasColumnName("gl_jldtl_line");
            this.Property(t => t.gl_jlhdr_date).HasColumnName("gl_jlhdr_date");
            this.Property(t => t.gl_jldtl_desc).HasColumnName("gl_jldtl_desc");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_jldtl_chgdt).HasColumnName("gl_jldtl_chgdt");
            this.Property(t => t.gl_jldtl_crtdt).HasColumnName("gl_jldtl_crtdt");
            this.Property(t => t.gl_jldtl_upcnt).HasColumnName("gl_jldtl_upcnt");
            this.Property(t => t.gl_cmp_post).HasColumnName("gl_cmp_post");
            this.Property(t => t.gl_jldtl_cramtc).HasColumnName("gl_jldtl_cramtc");
            this.Property(t => t.gl_jldtl_cramtcf).HasColumnName("gl_jldtl_cramtcf");
            this.Property(t => t.gl_jldtl_dbamtc).HasColumnName("gl_jldtl_dbamtc");
            this.Property(t => t.gl_jldtl_dbamtcf).HasColumnName("gl_jldtl_dbamtcf");
        }
    }
}
