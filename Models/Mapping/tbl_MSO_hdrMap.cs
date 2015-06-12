using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tbl_MSO_hdrMap : EntityTypeConfiguration<tbl_MSO_hdr>
    {
        public tbl_MSO_hdrMap()
        {
            // Primary Key
            this.HasKey(t => t.MSOno);

            // Properties
            this.Property(t => t.STname)
                .HasMaxLength(50);

            this.Property(t => t.STaddy1)
                .HasMaxLength(50);

            this.Property(t => t.STaddy2)
                .HasMaxLength(50);

            this.Property(t => t.STaddy3)
                .HasMaxLength(50);

            this.Property(t => t.STphone)
                .HasMaxLength(50);

            this.Property(t => t.SFname)
                .HasMaxLength(50);

            this.Property(t => t.SFaddy1)
                .HasMaxLength(50);

            this.Property(t => t.SFaddy2)
                .HasMaxLength(50);

            this.Property(t => t.SFaddy3)
                .HasMaxLength(50);

            this.Property(t => t.Sender)
                .HasMaxLength(50);

            this.Property(t => t.ShipVia)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl_MSO_hdr");
            this.Property(t => t.MSOno).HasColumnName("MSOno");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.ReqShipDate).HasColumnName("ReqShipDate");
            this.Property(t => t.STname).HasColumnName("STname");
            this.Property(t => t.STaddy1).HasColumnName("STaddy1");
            this.Property(t => t.STaddy2).HasColumnName("STaddy2");
            this.Property(t => t.STaddy3).HasColumnName("STaddy3");
            this.Property(t => t.STphone).HasColumnName("STphone");
            this.Property(t => t.SFname).HasColumnName("SFname");
            this.Property(t => t.SFaddy1).HasColumnName("SFaddy1");
            this.Property(t => t.SFaddy2).HasColumnName("SFaddy2");
            this.Property(t => t.SFaddy3).HasColumnName("SFaddy3");
            this.Property(t => t.HazYes).HasColumnName("HazYes");
            this.Property(t => t.HazNo).HasColumnName("HazNo");
            this.Property(t => t.Sender).HasColumnName("Sender");
            this.Property(t => t.CC).HasColumnName("CC");
            this.Property(t => t.ShipVia).HasColumnName("ShipVia");
            this.Property(t => t.UPS1).HasColumnName("UPS1");
            this.Property(t => t.UPS2).HasColumnName("UPS2");
            this.Property(t => t.UPS3).HasColumnName("UPS3");
            this.Property(t => t.UPS4).HasColumnName("UPS4");
            this.Property(t => t.UPS5).HasColumnName("UPS5");
            this.Property(t => t.Prepaid).HasColumnName("Prepaid");
            this.Property(t => t.Collect).HasColumnName("Collect");
            this.Property(t => t.FDX1).HasColumnName("FDX1");
            this.Property(t => t.FDX2).HasColumnName("FDX2");
            this.Property(t => t.FDX3).HasColumnName("FDX3");
            this.Property(t => t.FDX4).HasColumnName("FDX4");
            this.Property(t => t.FDX5).HasColumnName("FDX5");
            this.Property(t => t.USPS1).HasColumnName("USPS1");
            this.Property(t => t.INSvalue).HasColumnName("INSvalue");
            this.Property(t => t.Declaredvalue).HasColumnName("Declaredvalue");
            this.Property(t => t.comments).HasColumnName("comments");
        }
    }
}
