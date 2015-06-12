using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ppg_partnoMap : EntityTypeConfiguration<ppg_partno>
    {
        public ppg_partnoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PPGPartNo, t.ProdKey });

            // Properties
            this.Property(t => t.PPGPartNo)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ProdKey)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ppg_partno");
            this.Property(t => t.PPGPartNo).HasColumnName("PPGPartNo");
            this.Property(t => t.ProdKey).HasColumnName("ProdKey");
        }
    }
}
