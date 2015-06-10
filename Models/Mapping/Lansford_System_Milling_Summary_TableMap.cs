using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Lansford_System_Milling_Summary_TableMap : EntityTypeConfiguration<Lansford_System_Milling_Summary_Table>
    {
        public Lansford_System_Milling_Summary_TableMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.AIR_TIME)
                .HasMaxLength(255);

            this.Property(t => t.GRADE)
                .HasMaxLength(255);

            this.Property(t => t.DIL)
                .HasMaxLength(50);

            this.Property(t => t.MILLS)
                .HasMaxLength(255);

            this.Property(t => t.BATCH_NO_)
                .HasMaxLength(50);

            this.Property(t => t.PRESS_NO_)
                .HasMaxLength(50);

            this.Property(t => t.SYS)
                .HasMaxLength(255);

            this.Property(t => t.COMP__NO_)
                .HasMaxLength(255);

            this.Property(t => t.WASH)
                .HasMaxLength(255);

            this.Property(t => t.GRIND_HRS)
                .HasMaxLength(255);

            this.Property(t => t.RUN_HRS)
                .HasMaxLength(255);

            this.Property(t => t.LOT_NO_)
                .HasMaxLength(50);

            this.Property(t => t.C1ST_PASS)
                .HasMaxLength(255);

            this.Property(t => t.C2ND_PASS)
                .HasMaxLength(255);

            this.Property(t => t.X1ST_PASS_)
                .HasMaxLength(255);

            this.Property(t => t.X2ND_PASS_)
                .HasMaxLength(255);

            this.Property(t => t.CHECK_SCRE)
                .HasMaxLength(255);

            this.Property(t => t.XCHECK_SCRE)
                .HasMaxLength(255);

            this.Property(t => t.HIFLASH)
                .HasMaxLength(255);

            this.Property(t => t.OLEIC_LOT_)
                .HasMaxLength(255);

            this.Property(t => t.STEARIC_LO)
                .HasMaxLength(255);

            this.Property(t => t.CLASSIFIED)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Lansford System Milling Summary Table");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AIR_TIME).HasColumnName("AIR_TIME");
            this.Property(t => t.GRADE).HasColumnName("GRADE");
            this.Property(t => t.DIL).HasColumnName("DIL");
            this.Property(t => t.DATE).HasColumnName("DATE");
            this.Property(t => t.MILLS).HasColumnName("MILLS");
            this.Property(t => t.BATCH_NO_).HasColumnName("BATCH_NO_");
            this.Property(t => t.PRESS_NO_).HasColumnName("PRESS_NO_");
            this.Property(t => t.SYS).HasColumnName("SYS");
            this.Property(t => t.COMP__NO_).HasColumnName("COMP__NO_");
            this.Property(t => t.WASH).HasColumnName("WASH");
            this.Property(t => t.GRIND_HRS).HasColumnName("GRIND_HRS");
            this.Property(t => t.RUN_HRS).HasColumnName("RUN_HRS");
            this.Property(t => t.LOT_NO_).HasColumnName("LOT_NO_");
            this.Property(t => t.C1ST_PASS).HasColumnName("1ST_PASS");
            this.Property(t => t.C2ND_PASS).HasColumnName("2ND_PASS");
            this.Property(t => t.X1ST_PASS_).HasColumnName("X1ST_PASS_");
            this.Property(t => t.X2ND_PASS_).HasColumnName("X2ND_PASS_");
            this.Property(t => t.CHECK_SCRE).HasColumnName("CHECK_SCRE");
            this.Property(t => t.XCHECK_SCRE).HasColumnName("XCHECK_SCRE");
            this.Property(t => t.HIFLASH).HasColumnName("HIFLASH");
            this.Property(t => t.OLEIC_LOT_).HasColumnName("OLEIC_LOT_");
            this.Property(t => t.STEARIC_LO).HasColumnName("STEARIC_LO");
            this.Property(t => t.CLASSIFIED).HasColumnName("CLASSIFIED");
        }
    }
}
