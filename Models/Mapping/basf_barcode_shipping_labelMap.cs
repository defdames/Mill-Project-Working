using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class basf_barcode_shipping_labelMap : EntityTypeConfiguration<basf_barcode_shipping_label>
    {
        public basf_barcode_shipping_labelMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Product, t.OrderNo, t.Whse, t.ProdDesc, t.SerialNo, t.bcSerial, t.gl_cmp_key });

            // Properties
            this.Property(t => t.Product)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LineNbr)
                .HasMaxLength(2);

            this.Property(t => t.Whse)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ProdDesc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.hdrCustPartNo)
                .HasMaxLength(255);

            this.Property(t => t.CustPartNo)
                .HasMaxLength(517);

            this.Property(t => t.bcCustPart)
                .HasMaxLength(259);

            this.Property(t => t.CustPONo)
                .HasMaxLength(31);

            this.Property(t => t.bcPONo)
                .HasMaxLength(29);

            this.Property(t => t.LotNbr)
                .HasMaxLength(25);

            this.Property(t => t.NofN)
                .HasMaxLength(10);

            this.Property(t => t.LotNo)
                .HasMaxLength(30);

            this.Property(t => t.bcLotNo)
                .HasMaxLength(28);

            this.Property(t => t.HdrDtlKey)
                .HasMaxLength(13);

            this.Property(t => t.NetWt)
                .HasMaxLength(17);

            this.Property(t => t.bcNetWt)
                .HasMaxLength(19);

            this.Property(t => t.ReInspectDate)
                .HasMaxLength(9);

            this.Property(t => t.MfgDate)
                .HasMaxLength(10);

            this.Property(t => t.bcMfgDate)
                .HasMaxLength(9);

            this.Property(t => t.ContType)
                .HasMaxLength(15);

            this.Property(t => t.bcContType)
                .HasMaxLength(12);

            this.Property(t => t.SerialNo)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.bcSerial)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Health)
                .HasMaxLength(6);

            this.Property(t => t.Flammability)
                .HasMaxLength(6);

            this.Property(t => t.Reactivity)
                .HasMaxLength(6);

            this.Property(t => t.NewSeqno)
                .HasMaxLength(14);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.bcNetWtKG)
                .HasMaxLength(19);

            this.Property(t => t.NetWtKG)
                .HasMaxLength(17);

            // Table & Column Mappings
            this.ToTable("basf_barcode_shipping_label");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.LineNbr).HasColumnName("LineNbr");
            this.Property(t => t.Whse).HasColumnName("Whse");
            this.Property(t => t.ProdDesc).HasColumnName("ProdDesc");
            this.Property(t => t.hdrCustPartNo).HasColumnName("hdrCustPartNo");
            this.Property(t => t.CustPartNo).HasColumnName("CustPartNo");
            this.Property(t => t.bcCustPart).HasColumnName("bcCustPart");
            this.Property(t => t.CustPONo).HasColumnName("CustPONo");
            this.Property(t => t.bcPONo).HasColumnName("bcPONo");
            this.Property(t => t.LotNbr).HasColumnName("LotNbr");
            this.Property(t => t.NofN).HasColumnName("NofN");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.bcLotNo).HasColumnName("bcLotNo");
            this.Property(t => t.HdrDtlKey).HasColumnName("HdrDtlKey");
            this.Property(t => t.GrossWt).HasColumnName("GrossWt");
            this.Property(t => t.NetWt).HasColumnName("NetWt");
            this.Property(t => t.bcNetWt).HasColumnName("bcNetWt");
            this.Property(t => t.TareWt).HasColumnName("TareWt");
            this.Property(t => t.nTareWt).HasColumnName("nTareWt");
            this.Property(t => t.ReInspectDate).HasColumnName("ReInspectDate");
            this.Property(t => t.MfgDate).HasColumnName("MfgDate");
            this.Property(t => t.bcMfgDate).HasColumnName("bcMfgDate");
            this.Property(t => t.ContType).HasColumnName("ContType");
            this.Property(t => t.bcContType).HasColumnName("bcContType");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.SerialNo).HasColumnName("SerialNo");
            this.Property(t => t.bcSerial).HasColumnName("bcSerial");
            this.Property(t => t.Health).HasColumnName("Health");
            this.Property(t => t.Flammability).HasColumnName("Flammability");
            this.Property(t => t.Reactivity).HasColumnName("Reactivity");
            this.Property(t => t.NewSeqno).HasColumnName("NewSeqno");
            this.Property(t => t.IncrBy).HasColumnName("IncrBy");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.bcNetWtKG).HasColumnName("bcNetWtKG");
            this.Property(t => t.NetWtKG).HasColumnName("NetWtKG");
        }
    }
}
