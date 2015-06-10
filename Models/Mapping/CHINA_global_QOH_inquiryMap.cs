using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_global_QOH_inquiryMap : EntityTypeConfiguration<CHINA_global_QOH_inquiry>
    {
        public CHINA_global_QOH_inquiryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.item, t.ware, t.Company });

            // Properties
            this.Property(t => t.item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ware)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Packloc)
                .HasMaxLength(10);

            this.Property(t => t.Packlot)
                .HasMaxLength(25);

            this.Property(t => t.Packkey)
                .HasMaxLength(6);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_global_QOH_inquiry");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.ware).HasColumnName("ware");
            this.Property(t => t.Packloc).HasColumnName("Packloc");
            this.Property(t => t.Packlot).HasColumnName("Packlot");
            this.Property(t => t.Packkey).HasColumnName("Packkey");
            this.Property(t => t.Packqty).HasColumnName("Packqty");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.in_lot_qoh).HasColumnName("in_lot_qoh");
            this.Property(t => t.upload_date).HasColumnName("upload_date");
            this.Property(t => t.packcost).HasColumnName("packcost");
        }
    }
}
