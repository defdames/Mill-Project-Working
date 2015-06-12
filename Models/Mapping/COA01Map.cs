using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class COA01Map : EntityTypeConfiguration<COA01>
    {
        public COA01Map()
        {
            // Primary Key
            this.HasKey(t => new { t.hdrBillToID, t.hdrCustBillShip, t.hdrCustomerID, t.hdrCustPartID, t.hdrCustPOID, t.hdrINT, t.hdrLocationID, t.hdrLotID, t.hdrPlantID, t.hdrProductDesc, t.hdrProductID, t.hdrItemID, t.hdrSalesOrder, t.hdrDtlLine, t.hdrBOL, t.hdrShipToID, t.im_pack_qty, t.gl_cmp_key });

            // Properties
            this.Property(t => t.hdrBillToID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrStreet01)
                .HasMaxLength(67);

            this.Property(t => t.hdrStreet02)
                .HasMaxLength(67);

            this.Property(t => t.hdrStreet03)
                .HasMaxLength(67);

            this.Property(t => t.hdrCityStateZip)
                .HasMaxLength(67);

            this.Property(t => t.hdrCustBillShip)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.hdrCustomerID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrCustomerName)
                .HasMaxLength(30);

            this.Property(t => t.hdrCustPartID)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.hdrCustPOID)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.hdrINT)
                .IsRequired()
                .HasMaxLength(10);

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

            this.Property(t => t.hdrItemID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.hdrSalesOrder)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrDtlLine)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hdrBOL)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.hdrShipToID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrUOM)
                .HasMaxLength(2);

            this.Property(t => t.hdrContainer)
                .HasMaxLength(30);

            this.Property(t => t.hdrDupontGMC)
                .HasMaxLength(30);

            this.Property(t => t.RetestDate)
                .HasMaxLength(9);

            this.Property(t => t.dupontkey)
                .HasMaxLength(30);

            this.Property(t => t.globalcode)
                .HasMaxLength(30);

            this.Property(t => t.smcode)
                .HasMaxLength(30);

            this.Property(t => t.hazard)
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("COA01");
            this.Property(t => t.hdrBillToID).HasColumnName("hdrBillToID");
            this.Property(t => t.hdrStreet01).HasColumnName("hdrStreet01");
            this.Property(t => t.hdrStreet02).HasColumnName("hdrStreet02");
            this.Property(t => t.hdrStreet03).HasColumnName("hdrStreet03");
            this.Property(t => t.hdrCityStateZip).HasColumnName("hdrCityStateZip");
            this.Property(t => t.hdrCustBillShip).HasColumnName("hdrCustBillShip");
            this.Property(t => t.hdrCustomerID).HasColumnName("hdrCustomerID");
            this.Property(t => t.hdrCustomerName).HasColumnName("hdrCustomerName");
            this.Property(t => t.hdrCustPartID).HasColumnName("hdrCustPartID");
            this.Property(t => t.hdrCustPOID).HasColumnName("hdrCustPOID");
            this.Property(t => t.hdrINT).HasColumnName("hdrINT");
            this.Property(t => t.hdrLocationID).HasColumnName("hdrLocationID");
            this.Property(t => t.hdrLotID).HasColumnName("hdrLotID");
            this.Property(t => t.hdrMnfctrdDate).HasColumnName("hdrMnfctrdDate");
            this.Property(t => t.hdrPlantID).HasColumnName("hdrPlantID");
            this.Property(t => t.hdrProductDesc).HasColumnName("hdrProductDesc");
            this.Property(t => t.hdrProductID).HasColumnName("hdrProductID");
            this.Property(t => t.hdrItemID).HasColumnName("hdrItemID");
            this.Property(t => t.hdrQuantity).HasColumnName("hdrQuantity");
            this.Property(t => t.hdrSalesOrder).HasColumnName("hdrSalesOrder");
            this.Property(t => t.hdrDtlLine).HasColumnName("hdrDtlLine");
            this.Property(t => t.hdrBOL).HasColumnName("hdrBOL");
            this.Property(t => t.hdrShipToID).HasColumnName("hdrShipToID");
            this.Property(t => t.hdrUOM).HasColumnName("hdrUOM");
            this.Property(t => t.hdrContainer).HasColumnName("hdrContainer");
            this.Property(t => t.hdrDupontGMC).HasColumnName("hdrDupontGMC");
            this.Property(t => t.RetestDate).HasColumnName("RetestDate");
            this.Property(t => t.dupontkey).HasColumnName("dupontkey");
            this.Property(t => t.globalcode).HasColumnName("globalcode");
            this.Property(t => t.smcode).HasColumnName("smcode");
            this.Property(t => t.hazard).HasColumnName("hazard");
            this.Property(t => t.im_pack_qty).HasColumnName("im_pack_qty");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ApprovedDate).HasColumnName("ApprovedDate");
        }
    }
}
