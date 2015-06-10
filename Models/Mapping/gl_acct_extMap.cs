using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_acct_extMap : EntityTypeConfiguration<gl_acct_ext>
    {
        public gl_acct_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_acct_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.interco_gl_cmp_key)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("gl_acct_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.interco_gl_cmp_key).HasColumnName("interco_gl_cmp_key");
            this.Property(t => t.gl_acct_upcnt).HasColumnName("gl_acct_upcnt");
        }
    }
}
