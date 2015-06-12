using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Lansford_TroomMap : EntityTypeConfiguration<Lansford_Troom>
    {
        public Lansford_TroomMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.WEIGHT)
                .HasMaxLength(255);

            this.Property(t => t.FEED)
                .HasMaxLength(255);

            this.Property(t => t.DATE)
                .HasMaxLength(255);

            this.Property(t => t.BATCH_NO_)
                .HasMaxLength(255);

            this.Property(t => t.X2ND_BATCH)
                .HasMaxLength(255);

            this.Property(t => t.X3RD_BATCH)
                .HasMaxLength(255);

            this.Property(t => t.T1_PRESS)
                .HasMaxLength(255);

            this.Property(t => t.F1_PRESS)
                .HasMaxLength(255);

            this.Property(t => t.REMARKS)
                .HasMaxLength(255);

            this.Property(t => t.DILUTION)
                .HasMaxLength(255);

            this.Property(t => t.LUBE_OIL)
                .HasMaxLength(255);

            this.Property(t => t.AIR_HRS)
                .HasMaxLength(255);

            this.Property(t => t.COMMENTS)
                .HasMaxLength(255);

            this.Property(t => t.COMMENTS_2)
                .HasMaxLength(255);

            this.Property(t => t.AIR_HRS_2)
                .HasMaxLength(255);

            this.Property(t => t.REMARKS_2)
                .HasMaxLength(255);

            this.Property(t => t.REMARKS_3)
                .HasMaxLength(255);

            this.Property(t => t.WEIGHT_2)
                .HasMaxLength(255);

            this.Property(t => t.WEIGHT_3)
                .HasMaxLength(255);

            this.Property(t => t.GRADE)
                .HasMaxLength(255);

            this.Property(t => t.GRADE_2)
                .HasMaxLength(255);

            this.Property(t => t.WASH)
                .HasMaxLength(255);

            this.Property(t => t.CONES)
                .HasMaxLength(255);

            this.Property(t => t.NUMBER)
                .HasMaxLength(50);

            this.Property(t => t.NUMBER1)
                .HasMaxLength(50);

            this.Property(t => t.IDENTIFICA)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Lansford Troom");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.WEIGHT).HasColumnName("WEIGHT");
            this.Property(t => t.FEED).HasColumnName("FEED");
            this.Property(t => t.DATE).HasColumnName("DATE");
            this.Property(t => t.BATCH_NO_).HasColumnName("BATCH_NO_");
            this.Property(t => t.X2ND_BATCH).HasColumnName("X2ND_BATCH");
            this.Property(t => t.X3RD_BATCH).HasColumnName("X3RD_BATCH");
            this.Property(t => t.T1_PRESS).HasColumnName("T1_PRESS");
            this.Property(t => t.F1_PRESS).HasColumnName("F1_PRESS");
            this.Property(t => t.REMARKS).HasColumnName("REMARKS");
            this.Property(t => t.DILUTION).HasColumnName("DILUTION");
            this.Property(t => t.LUBE_OIL).HasColumnName("LUBE_OIL");
            this.Property(t => t.AIR_HRS).HasColumnName("AIR_HRS");
            this.Property(t => t.COMMENTS).HasColumnName("COMMENTS");
            this.Property(t => t.COMMENTS_2).HasColumnName("COMMENTS_2");
            this.Property(t => t.AIR_HRS_2).HasColumnName("AIR_HRS_2");
            this.Property(t => t.REMARKS_2).HasColumnName("REMARKS_2");
            this.Property(t => t.REMARKS_3).HasColumnName("REMARKS_3");
            this.Property(t => t.WEIGHT_2).HasColumnName("WEIGHT_2");
            this.Property(t => t.WEIGHT_3).HasColumnName("WEIGHT_3");
            this.Property(t => t.GRADE).HasColumnName("GRADE");
            this.Property(t => t.GRADE_2).HasColumnName("GRADE_2");
            this.Property(t => t.WASH).HasColumnName("WASH");
            this.Property(t => t.CONES).HasColumnName("CONES");
            this.Property(t => t.NUMBER).HasColumnName("NUMBER");
            this.Property(t => t.NUMBER1).HasColumnName("NUMBER1");
            this.Property(t => t.IDENTIFICA).HasColumnName("IDENTIFICA");
        }
    }
}
