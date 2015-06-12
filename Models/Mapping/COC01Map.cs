using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class COC01Map : EntityTypeConfiguration<COC01>
    {
        public COC01Map()
        {
            // Primary Key
            this.HasKey(t => new { t.hdrCustPartID, t.hdrCustPOID, t.hdrINT, t.hdrLoadID, t.hdrLocationID, t.hdrLotID, t.hdrPlantID, t.hdrProductDesc, t.hdrProductID, t.hdrSalesDetail, t.hdrSalesOrder, t.hdrShipToID, t.hdrUOM });

            // Properties
            this.Property(t => t.hdrCustPartID)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.hdrCustPOID)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.hdrINT)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrLoadID)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.hdrLocationID)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.hdrLotID)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.hdrPlantID)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.hdrProductDesc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.hdrProductID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.hdrSalesDetail)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hdrSalesOrder)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrShipToID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrUOM)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .HasMaxLength(4);

            this.Property(t => t.in_lot_key)
                .HasMaxLength(25);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("COC01");
            this.Property(t => t.hdrCustPartID).HasColumnName("hdrCustPartID");
            this.Property(t => t.hdrCustPOID).HasColumnName("hdrCustPOID");
            this.Property(t => t.hdrINT).HasColumnName("hdrINT");
            this.Property(t => t.hdrLoadID).HasColumnName("hdrLoadID");
            this.Property(t => t.hdrLocationID).HasColumnName("hdrLocationID");
            this.Property(t => t.hdrLotID).HasColumnName("hdrLotID");
            this.Property(t => t.hdrMnfctrdDate).HasColumnName("hdrMnfctrdDate");
            this.Property(t => t.hdrPlantID).HasColumnName("hdrPlantID");
            this.Property(t => t.hdrProductDesc).HasColumnName("hdrProductDesc");
            this.Property(t => t.hdrProductID).HasColumnName("hdrProductID");
            this.Property(t => t.hdrQuantity).HasColumnName("hdrQuantity");
            this.Property(t => t.hdrSalesDetail).HasColumnName("hdrSalesDetail");
            this.Property(t => t.hdrSalesOrder).HasColumnName("hdrSalesOrder");
            this.Property(t => t.hdrShipToID).HasColumnName("hdrShipToID");
            this.Property(t => t.hdrUOM).HasColumnName("hdrUOM");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
        }
    }
}
