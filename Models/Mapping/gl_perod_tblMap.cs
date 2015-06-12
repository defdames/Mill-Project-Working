using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_perod_tblMap : EntityTypeConfiguration<gl_perod_tbl>
    {
        public gl_perod_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_perod_seqno });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_perod_currp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_perod_openp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_perod_seqno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_adjid)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_perod_aropenp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_perod_apopenp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_perod_poopenp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_perod_soopenp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_perod_inopenp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_perod_pmopenp)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("gl_perod_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
            this.Property(t => t.gl_perod_stdt).HasColumnName("gl_perod_stdt");
            this.Property(t => t.gl_perod_enddt).HasColumnName("gl_perod_enddt");
            this.Property(t => t.gl_perod_currp).HasColumnName("gl_perod_currp");
            this.Property(t => t.gl_perod_openp).HasColumnName("gl_perod_openp");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_perod_chgdt).HasColumnName("gl_perod_chgdt");
            this.Property(t => t.gl_perod_crtdt).HasColumnName("gl_perod_crtdt");
            this.Property(t => t.gl_perod_type).HasColumnName("gl_perod_type");
            this.Property(t => t.gl_perod_seqno).HasColumnName("gl_perod_seqno");
            this.Property(t => t.gl_perod_adjid).HasColumnName("gl_perod_adjid");
            this.Property(t => t.gl_perod_aropenp).HasColumnName("gl_perod_aropenp");
            this.Property(t => t.gl_perod_apopenp).HasColumnName("gl_perod_apopenp");
            this.Property(t => t.gl_perod_poopenp).HasColumnName("gl_perod_poopenp");
            this.Property(t => t.gl_perod_soopenp).HasColumnName("gl_perod_soopenp");
            this.Property(t => t.gl_perod_inopenp).HasColumnName("gl_perod_inopenp");
            this.Property(t => t.gl_perod_pmopenp).HasColumnName("gl_perod_pmopenp");
            this.Property(t => t.gl_perod_upcnt).HasColumnName("gl_perod_upcnt");
        }
    }
}
