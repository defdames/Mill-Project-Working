using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class crm_top_customer_nameMap : EntityTypeConfiguration<crm_top_customer_name>
    {
        public crm_top_customer_nameMap()
        {
            // Primary Key
            this.HasKey(t => new { t.top_customer_name, t.Region });

            // Properties
            this.Property(t => t.top_customer_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.transactionshipkey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SalesForceID)
                .HasMaxLength(200);

            this.Property(t => t.Region)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("crm_top_customer_name");
            this.Property(t => t.top_customer_name).HasColumnName("top_customer_name");
            this.Property(t => t.transactionshipkey).HasColumnName("transactionshipkey");
            this.Property(t => t.SalesForceID).HasColumnName("SalesForceID");
            this.Property(t => t.Region).HasColumnName("Region");
        }
    }
}
