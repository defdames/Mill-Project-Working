using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_smcom_tblMap : EntityTypeConfiguration<so_smcom_tbl>
    {
        public so_smcom_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_salsm_key, t.ar_cust_key, t.ar_ship_key, t.so_pgc_key, t.so_prod_key, t.so_smcom_effdt, t.so_smcom_inadt });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_pgc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.so_smcom_cmuom)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("so_smcom_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.ar_cust_key).HasColumnName("ar_cust_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.so_pgc_key).HasColumnName("so_pgc_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.so_smcom_cmval).HasColumnName("so_smcom_cmval");
            this.Property(t => t.so_smcom_effdt).HasColumnName("so_smcom_effdt");
            this.Property(t => t.so_smcom_inadt).HasColumnName("so_smcom_inadt");
            this.Property(t => t.so_smcom_upcnt).HasColumnName("so_smcom_upcnt");
            this.Property(t => t.so_smcom_cmtypf).HasColumnName("so_smcom_cmtypf");
            this.Property(t => t.so_smcom_cmuom).HasColumnName("so_smcom_cmuom");
        }
    }
}
