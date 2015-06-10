using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class COC02Map : EntityTypeConfiguration<COC02>
    {
        public COC02Map()
        {
            // Primary Key
            this.HasKey(t => new { t.hdrBillToID, t.hdrCstBllShp, t.hdrCustID, t.hdrShipToID });

            // Properties
            this.Property(t => t.hdrBillToID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrCstBllShp)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.hdrCustID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrCustName)
                .HasMaxLength(30);

            this.Property(t => t.hdrShipToID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrStreet01)
                .HasMaxLength(67);

            this.Property(t => t.hdrStreet02)
                .HasMaxLength(67);

            this.Property(t => t.hdrStreet03)
                .HasMaxLength(67);

            this.Property(t => t.hdrCtStZp)
                .HasMaxLength(67);

            // Table & Column Mappings
            this.ToTable("COC02");
            this.Property(t => t.hdrBillToID).HasColumnName("hdrBillToID");
            this.Property(t => t.hdrCstBllShp).HasColumnName("hdrCstBllShp");
            this.Property(t => t.hdrCustID).HasColumnName("hdrCustID");
            this.Property(t => t.hdrCustName).HasColumnName("hdrCustName");
            this.Property(t => t.hdrShipToID).HasColumnName("hdrShipToID");
            this.Property(t => t.hdrStreet01).HasColumnName("hdrStreet01");
            this.Property(t => t.hdrStreet02).HasColumnName("hdrStreet02");
            this.Property(t => t.hdrStreet03).HasColumnName("hdrStreet03");
            this.Property(t => t.hdrCtStZp).HasColumnName("hdrCtStZp");
        }
    }
}
