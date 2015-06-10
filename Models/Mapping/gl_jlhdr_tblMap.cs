using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_jlhdr_tblMap : EntityTypeConfiguration<gl_jlhdr_tbl>
    {
        public gl_jlhdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.gl_jlnum_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_jlnum_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_jlhdr_desc)
                .IsRequired()
                .HasMaxLength(90);

            this.Property(t => t.gl_jlhdr_refno)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_jlhdr_crncy)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_jlhdr_status)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gl_jlhdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_jlnum_key).HasColumnName("gl_jlnum_key");
            this.Property(t => t.gl_jlhdr_date).HasColumnName("gl_jlhdr_date");
            this.Property(t => t.gl_jlhdr_desc).HasColumnName("gl_jlhdr_desc");
            this.Property(t => t.gl_jlhdr_refno).HasColumnName("gl_jlhdr_refno");
            this.Property(t => t.gl_jlnum_type).HasColumnName("gl_jlnum_type");
            this.Property(t => t.gl_jlhdr_crncy).HasColumnName("gl_jlhdr_crncy");
            this.Property(t => t.gl_jlhdr_status).HasColumnName("gl_jlhdr_status");
            this.Property(t => t.gl_jlhdr_revers).HasColumnName("gl_jlhdr_revers");
            this.Property(t => t.gl_tran_key).HasColumnName("gl_tran_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_jlhdr_chgdt).HasColumnName("gl_jlhdr_chgdt");
            this.Property(t => t.gl_jlhdr_crtdt).HasColumnName("gl_jlhdr_crtdt");
            this.Property(t => t.gl_jlhdr_upcnt).HasColumnName("gl_jlhdr_upcnt");
            this.Property(t => t.gl_jlhdr_asofdt).HasColumnName("gl_jlhdr_asofdt");
            this.Property(t => t.gl_jlhdr_intcmpf).HasColumnName("gl_jlhdr_intcmpf");
            this.Property(t => t.gl_journaltype_id).HasColumnName("gl_journaltype_id");
        }
    }
}
