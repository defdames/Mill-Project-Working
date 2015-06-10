using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_vatcd_tblMap : EntityTypeConfiguration<gl_vatcd_tbl>
    {
        public gl_vatcd_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_vatcd_id, t.gl_vatcd_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_vatcd_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_vatcd_ardec)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_vatcd_ardeci)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_vatcd_apdec)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_vatcd_apdeci)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_vatcd_appos)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_vatcd_apposi)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_vatcd_aprec)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_vatcd_apreci)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_vatcd_apunr)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.gl_vatcd_apunri)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_acct_whldtax)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("gl_vatcd_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_vatcd_id).HasColumnName("gl_vatcd_id");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatcd_desc).HasColumnName("gl_vatcd_desc");
            this.Property(t => t.gl_vatcd_tp).HasColumnName("gl_vatcd_tp");
            this.Property(t => t.gl_vatcd_qlf).HasColumnName("gl_vatcd_qlf");
            this.Property(t => t.gl_vatcd_recp).HasColumnName("gl_vatcd_recp");
            this.Property(t => t.gl_vatcd_unrp).HasColumnName("gl_vatcd_unrp");
            this.Property(t => t.gl_vatcd_arap).HasColumnName("gl_vatcd_arap");
            this.Property(t => t.gl_vatcd_ardec).HasColumnName("gl_vatcd_ardec");
            this.Property(t => t.gl_vatcd_ardeci).HasColumnName("gl_vatcd_ardeci");
            this.Property(t => t.gl_vatcd_apdec).HasColumnName("gl_vatcd_apdec");
            this.Property(t => t.gl_vatcd_apdeci).HasColumnName("gl_vatcd_apdeci");
            this.Property(t => t.gl_vatcd_appos).HasColumnName("gl_vatcd_appos");
            this.Property(t => t.gl_vatcd_apposi).HasColumnName("gl_vatcd_apposi");
            this.Property(t => t.gl_vatcd_aprec).HasColumnName("gl_vatcd_aprec");
            this.Property(t => t.gl_vatcd_apreci).HasColumnName("gl_vatcd_apreci");
            this.Property(t => t.gl_vatcd_apunr).HasColumnName("gl_vatcd_apunr");
            this.Property(t => t.gl_vatcd_apunri).HasColumnName("gl_vatcd_apunri");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_vatcd_chgdt).HasColumnName("gl_vatcd_chgdt");
            this.Property(t => t.gl_vatcd_upcnt).HasColumnName("gl_vatcd_upcnt");
            this.Property(t => t.gl_vatcd_crtdt).HasColumnName("gl_vatcd_crtdt");
            this.Property(t => t.gl_vatcd_whldtaxf).HasColumnName("gl_vatcd_whldtaxf");
            this.Property(t => t.gl_acct_whldtax).HasColumnName("gl_acct_whldtax");
        }
    }
}
