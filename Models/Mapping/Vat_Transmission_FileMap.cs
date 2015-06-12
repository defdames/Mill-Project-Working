using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Vat_Transmission_FileMap : EntityTypeConfiguration<Vat_Transmission_File>
    {
        public Vat_Transmission_FileMap()
        {
            // Primary Key
            this.HasKey(t => t.tkey);

            // Properties
            this.Property(t => t.Line)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Vat_Transmission_File");
            this.Property(t => t.Line).HasColumnName("Line");
            this.Property(t => t.tkey).HasColumnName("tkey");
        }
    }
}
