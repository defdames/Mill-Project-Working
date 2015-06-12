using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class crm_ownerMap : EntityTypeConfiguration<crm_owner>
    {
        public crm_ownerMap()
        {
            // Primary Key
            this.HasKey(t => t.owner);

            // Properties
            this.Property(t => t.owner)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.transactionshipkey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("crm_owner");
            this.Property(t => t.owner).HasColumnName("owner");
            this.Property(t => t.transactionshipkey).HasColumnName("transactionshipkey");
        }
    }
}
