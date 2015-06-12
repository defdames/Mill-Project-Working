using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class agent_sampleMap : EntityTypeConfiguration<agent_sample>
    {
        public agent_sampleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Contact, t.AgentKey, t.Agent, t.ShipCity, t.ShipState, t.Country, t.ShipName, t.SchShipDate, t.OrderNo, t.ShipToContact, t.im_adres_line1, t.im_adres_line2, t.im_adres_line3, t.so_hdr_remks, t.phone });

            // Properties
            this.Property(t => t.Contact)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.AgentKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Agent)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ShipCity)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ShipState)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Location)
                .HasMaxLength(43);

            this.Property(t => t.ShipName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SalesType)
                .HasMaxLength(10);

            this.Property(t => t.Product)
                .HasMaxLength(60);

            this.Property(t => t.ProductCode)
                .HasMaxLength(60);

            this.Property(t => t.MktSeg)
                .HasMaxLength(30);

            this.Property(t => t.PackDesc)
                .HasMaxLength(999);

            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ShipToContact)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_line1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_line2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_adres_line3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_hdr_remks)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.phone)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("agent_sample");
            this.Property(t => t.Contact).HasColumnName("Contact");
            this.Property(t => t.AgentKey).HasColumnName("AgentKey");
            this.Property(t => t.Agent).HasColumnName("Agent");
            this.Property(t => t.ShipCity).HasColumnName("ShipCity");
            this.Property(t => t.ShipState).HasColumnName("ShipState");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.SalesType).HasColumnName("SalesType");
            this.Property(t => t.Product).HasColumnName("Product");
            this.Property(t => t.ProductCode).HasColumnName("ProductCode");
            this.Property(t => t.MktSeg).HasColumnName("MktSeg");
            this.Property(t => t.NoPkg).HasColumnName("NoPkg");
            this.Property(t => t.PackDesc).HasColumnName("PackDesc");
            this.Property(t => t.SchShipDate).HasColumnName("SchShipDate");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.ShipToContact).HasColumnName("ShipToContact");
            this.Property(t => t.im_adres_line1).HasColumnName("im_adres_line1");
            this.Property(t => t.im_adres_line2).HasColumnName("im_adres_line2");
            this.Property(t => t.im_adres_line3).HasColumnName("im_adres_line3");
            this.Property(t => t.so_hdr_remks).HasColumnName("so_hdr_remks");
            this.Property(t => t.phone).HasColumnName("phone");
        }
    }
}
