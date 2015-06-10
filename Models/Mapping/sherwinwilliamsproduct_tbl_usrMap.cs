using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sherwinwilliamsproduct_tbl_usrMap : EntityTypeConfiguration<sherwinwilliamsproduct_tbl_usr>
    {
        public sherwinwilliamsproduct_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SWcode, t.SWproduct, t.SMCproduct });

            // Properties
            this.Property(t => t.SWcode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SWproduct)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SMCproduct)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sherwinwilliamsproduct_tbl_usr");
            this.Property(t => t.SWcode).HasColumnName("SWcode");
            this.Property(t => t.SWproduct).HasColumnName("SWproduct");
            this.Property(t => t.SMCproduct).HasColumnName("SMCproduct");
        }
    }
}
