using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_shlocvat_tblMap : EntityTypeConfiguration<gl_shlocvat_tbl>
    {
        public gl_shlocvat_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.gl_shlocvat_sgid);

            // Properties
            this.Property(t => t.gl_shlocvat_sgid)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_cntry_shpfrom)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_cntry_shpto)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_shlocvat_exon)
                .HasMaxLength(20);

            this.Property(t => t.ar_ship_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_shlocvat_vatreg)
                .HasMaxLength(20);

            this.Property(t => t.gl_vatcd_key)
                .HasMaxLength(10);

            this.Property(t => t.sa_user_key)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gl_shlocvat_tbl");
            this.Property(t => t.gl_shlocvat_sgid).HasColumnName("gl_shlocvat_sgid");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_cntry_shpfrom).HasColumnName("en_cntry_shpfrom");
            this.Property(t => t.en_cntry_shpto).HasColumnName("en_cntry_shpto");
            this.Property(t => t.gl_shlocvat_exon).HasColumnName("gl_shlocvat_exon");
            this.Property(t => t.gl_shlocvat_shptowf).HasColumnName("gl_shlocvat_shptowf");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.gl_shlocvat_vatreg).HasColumnName("gl_shlocvat_vatreg");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_shlocvat_nontaxf).HasColumnName("gl_shlocvat_nontaxf");
            this.Property(t => t.gl_shlocvat_chgdt).HasColumnName("gl_shlocvat_chgdt");
            this.Property(t => t.gl_shlocvat_crtdt).HasColumnName("gl_shlocvat_crtdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_shlocvat_upcnt).HasColumnName("gl_shlocvat_upcnt");
        }
    }
}
