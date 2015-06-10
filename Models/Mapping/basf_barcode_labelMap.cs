using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class basf_barcode_labelMap : EntityTypeConfiguration<basf_barcode_label>
    {
        public basf_barcode_labelMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.BASF_Code)
                .HasMaxLength(255);

            this.Property(t => t.BASF_Code_2_)
                .HasMaxLength(255);

            this.Property(t => t.BASF_MATERIAL_DESC_for_Label)
                .HasMaxLength(255);

            this.Property(t => t.Plant)
                .HasMaxLength(255);

            this.Property(t => t.SILBERLINE_Material_Description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("basf_barcode_label");
            this.Property(t => t.BASF_Code).HasColumnName("BASF Code");
            this.Property(t => t.BASF_Code_2_).HasColumnName("BASF Code 2 ");
            this.Property(t => t.BASF_MATERIAL_DESC_for_Label).HasColumnName("BASF MATERIAL DESC for Label");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.SILBERLINE_Material_Description).HasColumnName("SILBERLINE Material Description");
            this.Property(t => t.id).HasColumnName("id");
        }
    }
}
