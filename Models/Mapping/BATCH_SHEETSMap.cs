using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class BATCH_SHEETSMap : EntityTypeConfiguration<BATCH_SHEETS>
    {
        public BATCH_SHEETSMap()
        {
            // Primary Key
            this.HasKey(t => t.Row);

            // Properties
            this.Property(t => t.DATE)
                .HasMaxLength(500);

            this.Property(t => t.MIXER)
                .HasMaxLength(500);

            this.Property(t => t.GRADE)
                .HasMaxLength(500);

            this.Property(t => t.BATCH_NUMBER)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY)
                .HasMaxLength(500);

            this.Property(t => t.TYPE_OF_DRUM)
                .HasMaxLength(500);

            this.Property(t => t.WEIGHT_PER_DRUM)
                .HasMaxLength(500);

            this.Property(t => t.NUMBER_OF_DRUMS)
                .HasMaxLength(500);

            this.Property(t => t.WEIGHT_PRODUCED)
                .HasMaxLength(500);

            this.Property(t => t.REVISION_DATE)
                .HasMaxLength(500);

            this.Property(t => t.FORM_VERSION)
                .HasMaxLength(500);

            this.Property(t => t.MIXER_BATCH_SHEET)
                .HasMaxLength(500);

            this.Property(t => t.C02_INST)
                .HasMaxLength(500);

            this.Property(t => t.SAMPLE_AND_LABEL)
                .HasMaxLength(500);

            this.Property(t => t.INGRED)
                .HasMaxLength(1000);

            this.Property(t => t.POT_FORMULA)
                .HasMaxLength(500);

            this.Property(t => t.BLADE_SPEED)
                .HasMaxLength(500);

            this.Property(t => t.SPEED)
                .HasMaxLength(1000);

            this.Property(t => t.PRESS_DATA)
                .HasMaxLength(1000);

            this.Property(t => t.EXPIRATION_DATE)
                .HasMaxLength(500);

            this.Property(t => t.STORAGE)
                .HasMaxLength(500);

            this.Property(t => t.THEOR_WT)
                .HasMaxLength(500);

            this.Property(t => t.OPER)
                .HasMaxLength(500);

            this.Property(t => t.OPER_Copy)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("BATCH_SHEETS");
            this.Property(t => t.Row).HasColumnName("Row");
            this.Property(t => t.DATE).HasColumnName("DATE");
            this.Property(t => t.MIXER).HasColumnName("MIXER");
            this.Property(t => t.GRADE).HasColumnName("GRADE");
            this.Property(t => t.BATCH_NUMBER).HasColumnName("BATCH NUMBER");
            this.Property(t => t.INGREDIENT).HasColumnName("INGREDIENT");
            this.Property(t => t.LOT_NO).HasColumnName("LOT NO");
            this.Property(t => t.AMOUNT).HasColumnName("AMOUNT");
            this.Property(t => t.LOADED_BY).HasColumnName("LOADED BY");
            this.Property(t => t.MIXING_INSTRUCTIONS).HasColumnName("MIXING INSTRUCTIONS");
            this.Property(t => t.TYPE_OF_DRUM).HasColumnName("TYPE OF DRUM");
            this.Property(t => t.WEIGHT_PER_DRUM).HasColumnName("WEIGHT PER DRUM");
            this.Property(t => t.NUMBER_OF_DRUMS).HasColumnName("NUMBER OF DRUMS");
            this.Property(t => t.WEIGHT_PRODUCED).HasColumnName("WEIGHT PRODUCED");
            this.Property(t => t.REVISION_DATE).HasColumnName("REVISION DATE");
            this.Property(t => t.FORM_VERSION).HasColumnName("FORM VERSION");
            this.Property(t => t.MIXER_BATCH_SHEET).HasColumnName("MIXER BATCH SHEET");
            this.Property(t => t.C02_INST).HasColumnName("02 INST");
            this.Property(t => t.SAMPLE_AND_LABEL).HasColumnName("SAMPLE AND LABEL");
            this.Property(t => t.INGRED).HasColumnName("INGRED");
            this.Property(t => t.POT_FORMULA).HasColumnName("POT FORMULA");
            this.Property(t => t.BLADE_SPEED).HasColumnName("BLADE SPEED");
            this.Property(t => t.SPEED).HasColumnName("SPEED");
            this.Property(t => t.PRESS_DATA).HasColumnName("PRESS DATA");
            this.Property(t => t.EXPIRATION_DATE).HasColumnName("EXPIRATION DATE");
            this.Property(t => t.STORAGE).HasColumnName("STORAGE");
            this.Property(t => t.THEOR_WT).HasColumnName("THEOR WT");
            this.Property(t => t.OPER).HasColumnName("OPER");
            this.Property(t => t.OPER_Copy).HasColumnName("OPER Copy");
        }
    }
}
