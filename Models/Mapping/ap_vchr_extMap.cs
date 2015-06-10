using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_vchr_extMap : EntityTypeConfiguration<ap_vchr_ext>
    {
        public ap_vchr_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ap_vchr_type, t.ap_vchr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ap_vchr_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ap_vchr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.vendorinvoice)
                .HasMaxLength(60);

            this.Property(t => t.vessel)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("ap_vchr_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ap_vchr_type).HasColumnName("ap_vchr_type");
            this.Property(t => t.ap_vchr_key).HasColumnName("ap_vchr_key");
            this.Property(t => t.vendorinvoice).HasColumnName("vendorinvoice");
            this.Property(t => t.vessel).HasColumnName("vessel");
            this.Property(t => t.vetd).HasColumnName("vetd");
            this.Property(t => t.veta).HasColumnName("veta");
            this.Property(t => t.ap_vchr_upcnt).HasColumnName("ap_vchr_upcnt");
        }
    }
}
