using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_qctst_tblMap : EntityTypeConfiguration<en_qctst_tbl>
    {
        public en_qctst_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_qcset_key, t.en_qcmst_key, t.en_qcmst_effdt });

            // Properties
            this.Property(t => t.en_qcset_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_qcmst_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_qctst_tbl");
            this.Property(t => t.en_qcset_key).HasColumnName("en_qcset_key");
            this.Property(t => t.en_qcmst_key).HasColumnName("en_qcmst_key");
            this.Property(t => t.en_qcmst_effdt).HasColumnName("en_qcmst_effdt");
        }
    }
}
