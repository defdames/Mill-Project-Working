using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ActiveTestMap : EntityTypeConfiguration<ActiveTest>
    {
        public ActiveTestMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_qcmst_key, t.en_qcmst_desc, t.en_qcmst_effdt, t.en_qcmst_inadt });

            // Properties
            this.Property(t => t.en_qcmst_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_qcmst_desc)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("ActiveTests");
            this.Property(t => t.en_qcmst_key).HasColumnName("en_qcmst_key");
            this.Property(t => t.en_qcmst_desc).HasColumnName("en_qcmst_desc");
            this.Property(t => t.en_qcmst_effdt).HasColumnName("en_qcmst_effdt");
            this.Property(t => t.en_qcmst_inadt).HasColumnName("en_qcmst_inadt");
        }
    }
}
