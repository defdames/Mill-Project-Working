using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class complaint_business_impact_tblMap : EntityTypeConfiguration<complaint_business_impact_tbl>
    {
        public complaint_business_impact_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.TC_no);

            // Properties
            this.Property(t => t.TC_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.T_An_dol_amt)
                .HasMaxLength(50);

            this.Property(t => t.P_An_dol_amt)
                .HasMaxLength(50);

            this.Property(t => t.atrisk)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.claim)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("complaint_business_impact_tbl");
            this.Property(t => t.TC_no).HasColumnName("TC_no");
            this.Property(t => t.T_An_dol_amt).HasColumnName("T_An_dol_amt");
            this.Property(t => t.P_An_dol_amt).HasColumnName("P_An_dol_amt");
            this.Property(t => t.atrisk).HasColumnName("atrisk");
            this.Property(t => t.claim).HasColumnName("claim");
            this.Property(t => t.comments).HasColumnName("comments");
        }
    }
}
