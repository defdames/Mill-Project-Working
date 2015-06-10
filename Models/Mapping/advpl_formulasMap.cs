using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class advpl_formulasMap : EntityTypeConfiguration<advpl_formulas>
    {
        public advpl_formulasMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Input_Output_Item, t.Process_ID, t.Plant, t.Input_Output, t.company });

            // Properties
            this.Property(t => t.Input_Output_Item)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.Process_ID)
                .IsRequired()
                .HasMaxLength(27);

            this.Property(t => t.Plant)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Input)
                .HasMaxLength(57);

            this.Property(t => t.Input_Output)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("advpl_formulas");
            this.Property(t => t.Input_Output_Item).HasColumnName("Input/Output Item");
            this.Property(t => t.Process_ID).HasColumnName("Process ID");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.Input_Ratio__).HasColumnName("Input Ratio %");
            this.Property(t => t.Output_Ratio__).HasColumnName("Output Ratio %");
            this.Property(t => t.Input).HasColumnName("Input");
            this.Property(t => t.Input_Output).HasColumnName("Input/Output");
            this.Property(t => t.company).HasColumnName("company");
        }
    }
}
