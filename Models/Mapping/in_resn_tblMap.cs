using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_resn_tblMap : EntityTypeConfiguration<in_resn_tbl>
    {
        public in_resn_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_resn_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_resn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_resn_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("in_resn_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_resn_key).HasColumnName("in_resn_key");
            this.Property(t => t.in_resn_desc).HasColumnName("in_resn_desc");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.in_resn_crtdt).HasColumnName("in_resn_crtdt");
            this.Property(t => t.in_resn_chgdt).HasColumnName("in_resn_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_resn_upcnt).HasColumnName("in_resn_upcnt");
            this.Property(t => t.in_resn_updinvf).HasColumnName("in_resn_updinvf");
            this.Property(t => t.in_resn_Stduse).HasColumnName("in_resn_Stduse");
            this.Property(t => t.in_resn_Recnuse).HasColumnName("in_resn_Recnuse");
            this.Property(t => t.in_resn_financeUse).HasColumnName("in_resn_financeUse");
            this.Property(t => t.in_resn_updwhsf).HasColumnName("in_resn_updwhsf");
        }
    }
}
