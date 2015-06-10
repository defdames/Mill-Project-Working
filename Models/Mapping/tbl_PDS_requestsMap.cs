using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tbl_PDS_requestsMap : EntityTypeConfiguration<tbl_PDS_requests>
    {
        public tbl_PDS_requestsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.reqno, t.prodID });

            // Properties
            this.Property(t => t.reqno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.prodID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.requestedby)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.itemcode)
                .HasMaxLength(50);

            this.Property(t => t.market)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.customer)
                .HasMaxLength(255);

            this.Property(t => t.updateexp)
                .HasMaxLength(255);

            this.Property(t => t.otherexp)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tbl_PDS_requests");
            this.Property(t => t.reqno).HasColumnName("reqno");
            this.Property(t => t.prodID).HasColumnName("prodID");
            this.Property(t => t.requestdate).HasColumnName("requestdate");
            this.Property(t => t.requireddate).HasColumnName("requireddate");
            this.Property(t => t.requestedby).HasColumnName("requestedby");
            this.Property(t => t.itemcode).HasColumnName("itemcode");
            this.Property(t => t.market).HasColumnName("market");
            this.Property(t => t.reason1).HasColumnName("reason1");
            this.Property(t => t.reason2).HasColumnName("reason2");
            this.Property(t => t.reason3).HasColumnName("reason3");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.updatepds).HasColumnName("updatepds");
            this.Property(t => t.updateexp).HasColumnName("updateexp");
            this.Property(t => t.other).HasColumnName("other");
            this.Property(t => t.otherexp).HasColumnName("otherexp");
            this.Property(t => t.notes).HasColumnName("notes");
        }
    }
}
