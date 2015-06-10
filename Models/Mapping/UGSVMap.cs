using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class UGSVMap : EntityTypeConfiguration<UGSV>
    {
        public UGSVMap()
        {
            // Primary Key
            this.HasKey(t => t.SVSGMN);

            // Properties
            this.Property(t => t.SVSIAN)
                .HasMaxLength(255);

            this.Property(t => t.SVSGMN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SVSGVL)
                .HasMaxLength(255);

            this.Property(t => t.SVLDES)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("UGSV");
            this.Property(t => t.SVSIAN).HasColumnName("SVSIAN");
            this.Property(t => t.SVSGMN).HasColumnName("SVSGMN");
            this.Property(t => t.SVSGVL).HasColumnName("SVSGVL");
            this.Property(t => t.SVLDES).HasColumnName("SVLDES");
            this.Property(t => t.SVSGTP).HasColumnName("SVSGTP");
            this.Property(t => t.SVDEF).HasColumnName("SVDEF");
        }
    }
}
