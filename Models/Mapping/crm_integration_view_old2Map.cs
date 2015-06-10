using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class crm_integration_view_old2Map : EntityTypeConfiguration<crm_integration_view_old2>
    {
        public crm_integration_view_old2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.GlobalName, t.ShipName, t.TransactionShipKey, t.owner, t.ownerid });

            // Properties
            this.Property(t => t.GlobalName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Region)
                .HasMaxLength(200);

            this.Property(t => t.Company)
                .HasMaxLength(2);

            this.Property(t => t.ShipName)
                .IsRequired()
                .HasMaxLength(84);

            this.Property(t => t.TransactionShipKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TransactionAddressLine1)
                .HasMaxLength(30);

            this.Property(t => t.TransactionAddressLine2)
                .HasMaxLength(30);

            this.Property(t => t.TransactionAddressLine3)
                .HasMaxLength(30);

            this.Property(t => t.TransactionAddressCity)
                .HasMaxLength(20);

            this.Property(t => t.TransactionAddressState)
                .HasMaxLength(10);

            this.Property(t => t.TransactionAddressCountry)
                .HasMaxLength(20);

            this.Property(t => t.TransactionAddressZip)
                .HasMaxLength(10);

            this.Property(t => t.TransactionTelephone)
                .HasMaxLength(20);

            this.Property(t => t.TransactionFax)
                .HasMaxLength(20);

            this.Property(t => t.SampleShipKey)
                .HasMaxLength(10);

            this.Property(t => t.SampleAddressLine1)
                .HasMaxLength(30);

            this.Property(t => t.SampleAddressLine2)
                .HasMaxLength(30);

            this.Property(t => t.SampleAddressLine3)
                .HasMaxLength(30);

            this.Property(t => t.SampleAddressCity)
                .HasMaxLength(20);

            this.Property(t => t.SampleAddressState)
                .HasMaxLength(10);

            this.Property(t => t.SampleAddressCountry)
                .HasMaxLength(20);

            this.Property(t => t.SampleAddressZip)
                .HasMaxLength(10);

            this.Property(t => t.SampleTelephone)
                .HasMaxLength(20);

            this.Property(t => t.SampleFax)
                .HasMaxLength(20);

            this.Property(t => t.SalesForceID)
                .HasMaxLength(1000);

            this.Property(t => t.owner)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ownerid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("crm_integration_view_old2");
            this.Property(t => t.GlobalName).HasColumnName("GlobalName");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.TransactionShipKey).HasColumnName("TransactionShipKey");
            this.Property(t => t.TransactionAddressLine1).HasColumnName("TransactionAddressLine1");
            this.Property(t => t.TransactionAddressLine2).HasColumnName("TransactionAddressLine2");
            this.Property(t => t.TransactionAddressLine3).HasColumnName("TransactionAddressLine3");
            this.Property(t => t.TransactionAddressCity).HasColumnName("TransactionAddressCity");
            this.Property(t => t.TransactionAddressState).HasColumnName("TransactionAddressState");
            this.Property(t => t.TransactionAddressCountry).HasColumnName("TransactionAddressCountry");
            this.Property(t => t.TransactionAddressZip).HasColumnName("TransactionAddressZip");
            this.Property(t => t.TransactionTelephone).HasColumnName("TransactionTelephone");
            this.Property(t => t.TransactionFax).HasColumnName("TransactionFax");
            this.Property(t => t.SampleShipKey).HasColumnName("SampleShipKey");
            this.Property(t => t.SampleAddressLine1).HasColumnName("SampleAddressLine1");
            this.Property(t => t.SampleAddressLine2).HasColumnName("SampleAddressLine2");
            this.Property(t => t.SampleAddressLine3).HasColumnName("SampleAddressLine3");
            this.Property(t => t.SampleAddressCity).HasColumnName("SampleAddressCity");
            this.Property(t => t.SampleAddressState).HasColumnName("SampleAddressState");
            this.Property(t => t.SampleAddressCountry).HasColumnName("SampleAddressCountry");
            this.Property(t => t.SampleAddressZip).HasColumnName("SampleAddressZip");
            this.Property(t => t.SampleTelephone).HasColumnName("SampleTelephone");
            this.Property(t => t.SampleFax).HasColumnName("SampleFax");
            this.Property(t => t.SalesForceID).HasColumnName("SalesForceID");
            this.Property(t => t.owner).HasColumnName("owner");
            this.Property(t => t.ownerid).HasColumnName("ownerid");
            this.Property(t => t.parentid).HasColumnName("parentid");
        }
    }
}
