using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Mill_Instructions_HTMap : EntityTypeConfiguration<Mill_Instructions_HT>
    {
        public Mill_Instructions_HTMap()
        {
            // Primary Key
            this.HasKey(t => t.Instruction_ID);

            // Properties
            this.Property(t => t.Instruction_ID)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.LINE1)
                .HasMaxLength(100);

            this.Property(t => t.LINE2)
                .HasMaxLength(100);

            this.Property(t => t.LINE3)
                .HasMaxLength(100);

            this.Property(t => t.LINE4)
                .HasMaxLength(100);

            this.Property(t => t.LINE5)
                .HasMaxLength(100);

            this.Property(t => t.LINE6)
                .HasMaxLength(100);

            this.Property(t => t.LINE7)
                .HasMaxLength(100);

            this.Property(t => t.LINE9)
                .HasMaxLength(100);

            this.Property(t => t.BD1)
                .HasMaxLength(25);

            this.Property(t => t.BD2)
                .HasMaxLength(25);

            this.Property(t => t.BD3)
                .HasMaxLength(25);

            this.Property(t => t.BD4)
                .HasMaxLength(25);

            this.Property(t => t.BD5)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Mill Instructions HT");
            this.Property(t => t.Instruction_ID).HasColumnName("Instruction ID");
            this.Property(t => t.LINE1).HasColumnName("LINE1");
            this.Property(t => t.LINE2).HasColumnName("LINE2");
            this.Property(t => t.LINE3).HasColumnName("LINE3");
            this.Property(t => t.LINE4).HasColumnName("LINE4");
            this.Property(t => t.LINE5).HasColumnName("LINE5");
            this.Property(t => t.LINE6).HasColumnName("LINE6");
            this.Property(t => t.LINE7).HasColumnName("LINE7");
            this.Property(t => t.LINE8).HasColumnName("LINE8");
            this.Property(t => t.LINE9).HasColumnName("LINE9");
            this.Property(t => t.BD1).HasColumnName("BD1");
            this.Property(t => t.BD2).HasColumnName("BD2");
            this.Property(t => t.BD3).HasColumnName("BD3");
            this.Property(t => t.BD4).HasColumnName("BD4");
            this.Property(t => t.BD5).HasColumnName("BD5");
        }
    }
}
