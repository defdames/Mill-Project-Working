using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Mill_InstructionMap : EntityTypeConfiguration<Mill_Instruction>
    {
        public Mill_InstructionMap()
        {
            // Primary Key
            this.HasKey(t => t.Instruction_ID);

            // Properties
            this.Property(t => t.Instruction_ID)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Form_Number)
                .HasMaxLength(15);

            this.Property(t => t.LINE_1)
                .HasMaxLength(60);

            this.Property(t => t.LINE_2)
                .HasMaxLength(50);

            this.Property(t => t.LINE_3)
                .HasMaxLength(50);

            this.Property(t => t.LINE_4)
                .HasMaxLength(50);

            this.Property(t => t.LINE_5)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("Mill Instructions");
            this.Property(t => t.Instruction_ID).HasColumnName("Instruction ID");
            this.Property(t => t.Form_Number).HasColumnName("Form Number");
            this.Property(t => t.LINE_1).HasColumnName("LINE 1");
            this.Property(t => t.LINE_2).HasColumnName("LINE 2");
            this.Property(t => t.LINE_3).HasColumnName("LINE 3");
            this.Property(t => t.LINE_4).HasColumnName("LINE 4");
            this.Property(t => t.LINE_5).HasColumnName("LINE 5");
        }
    }
}
