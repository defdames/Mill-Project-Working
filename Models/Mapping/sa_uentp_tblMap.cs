using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sa_uentp_tblMap : EntityTypeConfiguration<sa_uentp_tbl>
    {
        public sa_uentp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sa_user_key, t.gl_cmp_key, t.sa_uentp_entyp, t.sa_uentp_entid });

            // Properties
            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_uentp_entyp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sa_uentp_entid)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("sa_uentp_tbl");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sa_uentp_entyp).HasColumnName("sa_uentp_entyp");
            this.Property(t => t.sa_uentp_entid).HasColumnName("sa_uentp_entid");
            this.Property(t => t.sa_uentp_upcnt).HasColumnName("sa_uentp_upcnt");
        }
    }
}
