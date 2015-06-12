using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CapitalProject_AccountMap : EntityTypeConfiguration<CapitalProject_Account>
    {
        public CapitalProject_AccountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.AccountCode, t.AccountDesc, t.Grouping });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.AccountCode)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.AccountDesc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Grouping)
                .IsRequired()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("CapitalProject_Account");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.AccountCode).HasColumnName("AccountCode");
            this.Property(t => t.AccountDesc).HasColumnName("AccountDesc");
            this.Property(t => t.Grouping).HasColumnName("Grouping");
        }
    }
}
