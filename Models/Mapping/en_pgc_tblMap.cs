using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_pgc_tblMap : EntityTypeConfiguration<en_pgc_tbl>
    {
        public en_pgc_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_pgc_key);

            // Properties
            this.Property(t => t.en_pgc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_pgc_dsc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_pgc_stat)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_pgc_cmnts)
                .IsRequired()
                .HasMaxLength(999);

            this.Property(t => t.en_plc_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_pgc_tbl");
            this.Property(t => t.en_pgc_key).HasColumnName("en_pgc_key");
            this.Property(t => t.en_pgc_upcnt).HasColumnName("en_pgc_upcnt");
            this.Property(t => t.en_pgc_dsc).HasColumnName("en_pgc_dsc");
            this.Property(t => t.en_pgc_crtdt).HasColumnName("en_pgc_crtdt");
            this.Property(t => t.en_pgc_chgdt).HasColumnName("en_pgc_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_pgc_stat).HasColumnName("en_pgc_stat");
            this.Property(t => t.en_pgc_cmnts).HasColumnName("en_pgc_cmnts");
            this.Property(t => t.en_plc_key).HasColumnName("en_plc_key");
        }
    }
}
