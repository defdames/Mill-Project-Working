using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_aging_jeMap : EntityTypeConfiguration<ap_aging_je>
    {
        public ap_aging_jeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Acct, t.gl_cmp_key });

            // Properties
            this.Property(t => t.Acct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ap_aging_je");
            this.Property(t => t.Acct).HasColumnName("Acct");
            this.Property(t => t.Amt).HasColumnName("Amt");
            this.Property(t => t.GlDate).HasColumnName("GlDate");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
