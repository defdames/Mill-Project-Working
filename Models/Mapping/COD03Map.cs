using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class COD03Map : EntityTypeConfiguration<COD03>
    {
        public COD03Map()
        {
            // Primary Key
            this.HasKey(t => new { t.dtlWTDetail, t.dtlWTOrder, t.dtlItemID, t.dtlInstructions });

            // Properties
            this.Property(t => t.dtlWTDetail)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dtlWTOrder)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.dtlItemID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.dtlInstructions)
                .IsRequired()
                .HasMaxLength(1786);

            // Table & Column Mappings
            this.ToTable("COD03");
            this.Property(t => t.dtlWTDetail).HasColumnName("dtlWTDetail");
            this.Property(t => t.dtlWTOrder).HasColumnName("dtlWTOrder");
            this.Property(t => t.dtlItemID).HasColumnName("dtlItemID");
            this.Property(t => t.dtlInstructions).HasColumnName("dtlInstructions");
            this.Property(t => t.ikey).HasColumnName("ikey");
        }
    }
}
