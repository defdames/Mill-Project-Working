using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class COE01Map : EntityTypeConfiguration<COE01>
    {
        public COE01Map()
        {
            // Primary Key
            this.HasKey(t => new { t.hdrWhseToID, t.hdrLocationID, t.hdrLotID, t.hdrPlantID, t.hdrWTOrder, t.hdrBOL, t.hdrUOM });

            // Properties
            this.Property(t => t.hdrWhseToID)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.hdrStreet01)
                .HasMaxLength(44);

            this.Property(t => t.hdrStreet02)
                .HasMaxLength(44);

            this.Property(t => t.hdrCityStateZip)
                .HasMaxLength(44);

            this.Property(t => t.CustPartNo)
                .HasMaxLength(60);

            this.Property(t => t.hdrLocationID)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.hdrLotID)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.hdrPlantID)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.hdrItemDesc)
                .HasMaxLength(60);

            this.Property(t => t.hdrItemID)
                .HasMaxLength(27);

            this.Property(t => t.hdrWTOrder)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hdrBOL)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.hdrUOM)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("COE01");
            this.Property(t => t.hdrWhseToID).HasColumnName("hdrWhseToID");
            this.Property(t => t.hdrStreet01).HasColumnName("hdrStreet01");
            this.Property(t => t.hdrStreet02).HasColumnName("hdrStreet02");
            this.Property(t => t.hdrCityStateZip).HasColumnName("hdrCityStateZip");
            this.Property(t => t.CustPartNo).HasColumnName("CustPartNo");
            this.Property(t => t.hdrLocationID).HasColumnName("hdrLocationID");
            this.Property(t => t.hdrLotID).HasColumnName("hdrLotID");
            this.Property(t => t.hdrMnfctrdDate).HasColumnName("hdrMnfctrdDate");
            this.Property(t => t.hdrPlantID).HasColumnName("hdrPlantID");
            this.Property(t => t.hdrItemDesc).HasColumnName("hdrItemDesc");
            this.Property(t => t.hdrItemID).HasColumnName("hdrItemID");
            this.Property(t => t.hdrQuantity).HasColumnName("hdrQuantity");
            this.Property(t => t.hdrWTOrder).HasColumnName("hdrWTOrder");
            this.Property(t => t.hdrBOL).HasColumnName("hdrBOL");
            this.Property(t => t.hdrUOM).HasColumnName("hdrUOM");
            this.Property(t => t.linenbr).HasColumnName("linenbr");
        }
    }
}
