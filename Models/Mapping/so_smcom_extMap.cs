using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_smcom_extMap : EntityTypeConfiguration<so_smcom_ext>
    {
        public so_smcom_extMap()
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

            this.Property(t => t.so_prim_agt)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("so_smcom_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.ar_cust_key).HasColumnName("ar_cust_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.so_pgc_key).HasColumnName("so_pgc_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.so_smcom_effdt).HasColumnName("so_smcom_effdt");
            this.Property(t => t.so_prim_agt).HasColumnName("so_prim_agt");
            this.Property(t => t.so_smcom_inadt).HasColumnName("so_smcom_inadt");
            this.Property(t => t.so_smcom_upcnt).HasColumnName("so_smcom_upcnt");
        }
    }
}
