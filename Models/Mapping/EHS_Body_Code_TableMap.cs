using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class EHS_Body_Code_TableMap : EntityTypeConfiguration<EHS_Body_Code_Table>
    {
        public EHS_Body_Code_TableMap()
        {
            // Primary Key
            this.HasKey(t => new { t.number, t.description });

            // Properties
            this.Property(t => t.number)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("EHS Body Code Table");
            this.Property(t => t.number).HasColumnName("number");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
