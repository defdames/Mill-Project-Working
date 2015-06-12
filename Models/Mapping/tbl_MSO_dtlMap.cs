using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tbl_MSO_dtlMap : EntityTypeConfiguration<tbl_MSO_dtl>
    {
        public tbl_MSO_dtlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MSOno, t.qty, t.Description, t.weight, t.linenumber });

            // Properties
            this.Property(t => t.MSOno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.qty)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HazMat)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.weight)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.harmonized_code)
                .HasMaxLength(50);

            this.Property(t => t.export_license_need)
                .HasMaxLength(50);

            this.Property(t => t.country_of_origin)
                .HasMaxLength(50);

            this.Property(t => t.linenumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("tbl_MSO_dtl");
            this.Property(t => t.MSOno).HasColumnName("MSOno");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.HazMat).HasColumnName("HazMat");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.weight).HasColumnName("weight");
            this.Property(t => t.harmonized_code).HasColumnName("harmonized code");
            this.Property(t => t.export_license_need).HasColumnName("export license need");
            this.Property(t => t.country_of_origin).HasColumnName("country of origin");
            this.Property(t => t.value).HasColumnName("value");
            this.Property(t => t.linenumber).HasColumnName("linenumber");
        }
    }
}
