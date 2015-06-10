using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_resn_tblMap : EntityTypeConfiguration<ap_resn_tbl>
    {
        public ap_resn_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ap_resn_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ap_resn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_resn_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ap_resn_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ap_resn_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.ap_resn_desc).HasColumnName("ap_resn_desc");
            this.Property(t => t.ap_resn_upcnt).HasColumnName("ap_resn_upcnt");
            this.Property(t => t.ap_resn_type).HasColumnName("ap_resn_type");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.ap_resn_recalc).HasColumnName("ap_resn_recalc");
        }
    }
}
