using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class harmonized_codes_tbl_usrMap : EntityTypeConfiguration<harmonized_codes_tbl_usr>
    {
        public harmonized_codes_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.code);

            // Properties
            this.Property(t => t.code)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.english)
                .HasMaxLength(255);

            this.Property(t => t.nafta)
                .HasMaxLength(255);

            this.Property(t => t.spanish)
                .HasMaxLength(255);

            this.Property(t => t.Export_License_Required)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("harmonized_codes_tbl_usr");
            this.Property(t => t.code).HasColumnName("code");
            this.Property(t => t.english).HasColumnName("english");
            this.Property(t => t.nafta).HasColumnName("nafta");
            this.Property(t => t.spanish).HasColumnName("spanish");
            this.Property(t => t.Export_License_Required).HasColumnName("Export License Required");
        }
    }
}
