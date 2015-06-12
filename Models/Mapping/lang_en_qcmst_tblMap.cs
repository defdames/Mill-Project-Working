using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class lang_en_qcmst_tblMap : EntityTypeConfiguration<lang_en_qcmst_tbl>
    {
        public lang_en_qcmst_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_qcmst_key, t.language });

            // Properties
            this.Property(t => t.en_qcmst_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.language)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_qcmst_desc)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("lang_en_qcmst_tbl");
            this.Property(t => t.en_qcmst_key).HasColumnName("en_qcmst_key");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.en_qcmst_desc).HasColumnName("en_qcmst_desc");
        }
    }
}
