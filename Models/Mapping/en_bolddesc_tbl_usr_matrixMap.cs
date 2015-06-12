using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_bolddesc_tbl_usr_matrixMap : EntityTypeConfiguration<en_bolddesc_tbl_usr_matrix>
    {
        public en_bolddesc_tbl_usr_matrixMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.en_mode_key, t.en_mode_UK });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.en_mode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mode_UK)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_bolddesc_tbl_usr_matrix");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_mode_UK).HasColumnName("en_mode_UK");
            this.Property(t => t.ORDER).HasColumnName("ORDER");
        }
    }
}
