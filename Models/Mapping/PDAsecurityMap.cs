using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class PDAsecurityMap : EntityTypeConfiguration<PDAsecurity>
    {
        public PDAsecurityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.WinLoginName, t.Market, t.Status });

            // Properties
            this.Property(t => t.WinLoginName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Market)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PDAsecurity");
            this.Property(t => t.WinLoginName).HasColumnName("WinLoginName");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Market).HasColumnName("Market");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
