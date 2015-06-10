using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class SignupSheetMap : EntityTypeConfiguration<SignupSheet>
    {
        public SignupSheetMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FirstName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SignupSheet");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Slot).HasColumnName("Slot");
            this.Property(t => t.DateSigned).HasColumnName("DateSigned");
        }
    }
}
