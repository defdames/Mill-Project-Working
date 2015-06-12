using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class bam_astquickreceipthistoryMap : EntityTypeConfiguration<bam_astquickreceipthistory>
    {
        public bam_astquickreceipthistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.historyID, t.companyKey, t.branchKey, t.invoiceKey });

            // Properties
            this.Property(t => t.historyID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.companyKey)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.branchKey)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.invoiceKey)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("bam_astquickreceipthistory", "qqassist");
            this.Property(t => t.historyID).HasColumnName("historyID");
            this.Property(t => t.companyKey).HasColumnName("companyKey");
            this.Property(t => t.branchKey).HasColumnName("branchKey");
            this.Property(t => t.invoiceKey).HasColumnName("invoiceKey");
            this.Property(t => t.transactiondate).HasColumnName("transactiondate");
        }
    }
}
