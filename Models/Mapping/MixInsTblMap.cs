using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class MixInsTblMap : EntityTypeConfiguration<MixInsTbl>
    {
        public MixInsTblMap()
        {
            // Primary Key
            this.HasKey(t => t.SpecialT_Code);

            // Properties
            this.Property(t => t.SpecialT_Code)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Special_Treatment_Ins)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("MixInsTbl");
            this.Property(t => t.SpecialT_Code).HasColumnName("SpecialT Code");
            this.Property(t => t.Special_Treatment_Ins).HasColumnName("Special Treatment Ins");
        }
    }
}
