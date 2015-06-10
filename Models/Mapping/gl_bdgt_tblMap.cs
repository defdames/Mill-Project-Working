using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_bdgt_tblMap : EntityTypeConfiguration<gl_bdgt_tbl>
    {
        public gl_bdgt_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_bdgt_id, t.gl_perod_year });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_bdgt_id)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_bdgtwt_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_bdgt_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gl_bdgt_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_bdgt_id).HasColumnName("gl_bdgt_id");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.gl_bdgtwt_key).HasColumnName("gl_bdgtwt_key");
            this.Property(t => t.gl_bdgt_desc).HasColumnName("gl_bdgt_desc");
            this.Property(t => t.gl_bdgt_upcnt).HasColumnName("gl_bdgt_upcnt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_bdgt_chgdt).HasColumnName("gl_bdgt_chgdt");
            this.Property(t => t.gl_bdgt_crtdt).HasColumnName("gl_bdgt_crtdt");
        }
    }
}
