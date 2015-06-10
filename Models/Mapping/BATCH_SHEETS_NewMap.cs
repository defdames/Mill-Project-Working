using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class BATCH_SHEETS_NewMap : EntityTypeConfiguration<BATCH_SHEETS_New>
    {
        public BATCH_SHEETS_NewMap()
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

            this.Property(t => t.INGREDIENT1)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT2)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT3)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT4)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT5)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT6)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT7)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT8)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT9)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT10)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT11)
                .HasMaxLength(1000);

            this.Property(t => t.INGREDIENT12)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO1)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO2)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO3)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO4)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO5)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO6)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO7)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO8)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO9)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO10)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO11)
                .HasMaxLength(1000);

            this.Property(t => t.LOT_NO12)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT1)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT2)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT3)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT4)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT5)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT6)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT7)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT8)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT9)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT10)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT11)
                .HasMaxLength(1000);

            this.Property(t => t.AMOUNT12)
                .HasMaxLength(1000);

            this.Property(t => t.LOADED_BY1)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY2)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY3)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY4)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY5)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY6)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY7)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY8)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY9)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY10)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY11)
                .HasMaxLength(500);

            this.Property(t => t.LOADED_BY12)
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

            this.Property(t => t.INST2)
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

            this.Property(t => t.Adage_Item_Code)
                .HasMaxLength(200);

            this.Property(t => t.WhichUser)
                .HasMaxLength(50);

            this.Property(t => t.NameofMachine)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BATCH_SHEETS_New");
            this.Property(t => t.Row).HasColumnName("Row");
            this.Property(t => t.DATE).HasColumnName("DATE");
            this.Property(t => t.MIXER).HasColumnName("MIXER");
            this.Property(t => t.GRADE).HasColumnName("GRADE");
            this.Property(t => t.BATCH_NUMBER).HasColumnName("BATCH_NUMBER");
            this.Property(t => t.INGREDIENT1).HasColumnName("INGREDIENT1");
            this.Property(t => t.INGREDIENT2).HasColumnName("INGREDIENT2");
            this.Property(t => t.INGREDIENT3).HasColumnName("INGREDIENT3");
            this.Property(t => t.INGREDIENT4).HasColumnName("INGREDIENT4");
            this.Property(t => t.INGREDIENT5).HasColumnName("INGREDIENT5");
            this.Property(t => t.INGREDIENT6).HasColumnName("INGREDIENT6");
            this.Property(t => t.INGREDIENT7).HasColumnName("INGREDIENT7");
            this.Property(t => t.INGREDIENT8).HasColumnName("INGREDIENT8");
            this.Property(t => t.INGREDIENT9).HasColumnName("INGREDIENT9");
            this.Property(t => t.INGREDIENT10).HasColumnName("INGREDIENT10");
            this.Property(t => t.INGREDIENT11).HasColumnName("INGREDIENT11");
            this.Property(t => t.INGREDIENT12).HasColumnName("INGREDIENT12");
            this.Property(t => t.LOT_NO1).HasColumnName("LOT_NO1");
            this.Property(t => t.LOT_NO2).HasColumnName("LOT_NO2");
            this.Property(t => t.LOT_NO3).HasColumnName("LOT_NO3");
            this.Property(t => t.LOT_NO4).HasColumnName("LOT_NO4");
            this.Property(t => t.LOT_NO5).HasColumnName("LOT_NO5");
            this.Property(t => t.LOT_NO6).HasColumnName("LOT_NO6");
            this.Property(t => t.LOT_NO7).HasColumnName("LOT_NO7");
            this.Property(t => t.LOT_NO8).HasColumnName("LOT_NO8");
            this.Property(t => t.LOT_NO9).HasColumnName("LOT_NO9");
            this.Property(t => t.LOT_NO10).HasColumnName("LOT_NO10");
            this.Property(t => t.LOT_NO11).HasColumnName("LOT_NO11");
            this.Property(t => t.LOT_NO12).HasColumnName("LOT_NO12");
            this.Property(t => t.AMOUNT1).HasColumnName("AMOUNT1");
            this.Property(t => t.AMOUNT2).HasColumnName("AMOUNT2");
            this.Property(t => t.AMOUNT3).HasColumnName("AMOUNT3");
            this.Property(t => t.AMOUNT4).HasColumnName("AMOUNT4");
            this.Property(t => t.AMOUNT5).HasColumnName("AMOUNT5");
            this.Property(t => t.AMOUNT6).HasColumnName("AMOUNT6");
            this.Property(t => t.AMOUNT7).HasColumnName("AMOUNT7");
            this.Property(t => t.AMOUNT8).HasColumnName("AMOUNT8");
            this.Property(t => t.AMOUNT9).HasColumnName("AMOUNT9");
            this.Property(t => t.AMOUNT10).HasColumnName("AMOUNT10");
            this.Property(t => t.AMOUNT11).HasColumnName("AMOUNT11");
            this.Property(t => t.AMOUNT12).HasColumnName("AMOUNT12");
            this.Property(t => t.LOADED_BY1).HasColumnName("LOADED_BY1");
            this.Property(t => t.LOADED_BY2).HasColumnName("LOADED_BY2");
            this.Property(t => t.LOADED_BY3).HasColumnName("LOADED_BY3");
            this.Property(t => t.LOADED_BY4).HasColumnName("LOADED_BY4");
            this.Property(t => t.LOADED_BY5).HasColumnName("LOADED_BY5");
            this.Property(t => t.LOADED_BY6).HasColumnName("LOADED_BY6");
            this.Property(t => t.LOADED_BY7).HasColumnName("LOADED_BY7");
            this.Property(t => t.LOADED_BY8).HasColumnName("LOADED_BY8");
            this.Property(t => t.LOADED_BY9).HasColumnName("LOADED_BY9");
            this.Property(t => t.LOADED_BY10).HasColumnName("LOADED_BY10");
            this.Property(t => t.LOADED_BY11).HasColumnName("LOADED_BY11");
            this.Property(t => t.LOADED_BY12).HasColumnName("LOADED_BY12");
            this.Property(t => t.MIXING_INSTRUCTIONS).HasColumnName("MIXING_INSTRUCTIONS");
            this.Property(t => t.TYPE_OF_DRUM).HasColumnName("TYPE_OF_DRUM");
            this.Property(t => t.WEIGHT_PER_DRUM).HasColumnName("WEIGHT_PER_DRUM");
            this.Property(t => t.NUMBER_OF_DRUMS).HasColumnName("NUMBER_OF_DRUMS");
            this.Property(t => t.WEIGHT_PRODUCED).HasColumnName("WEIGHT_PRODUCED");
            this.Property(t => t.REVISION_DATE).HasColumnName("REVISION_DATE");
            this.Property(t => t.FORM_VERSION).HasColumnName("FORM_VERSION");
            this.Property(t => t.MIXER_BATCH_SHEET).HasColumnName("MIXER_BATCH_SHEET");
            this.Property(t => t.INST2).HasColumnName("INST2");
            this.Property(t => t.SAMPLE_AND_LABEL).HasColumnName("SAMPLE_AND_LABEL");
            this.Property(t => t.INGRED).HasColumnName("INGRED");
            this.Property(t => t.POT_FORMULA).HasColumnName("POT_FORMULA");
            this.Property(t => t.BLADE_SPEED).HasColumnName("BLADE_SPEED");
            this.Property(t => t.SPEED).HasColumnName("SPEED");
            this.Property(t => t.PRESS_DATA).HasColumnName("PRESS_DATA");
            this.Property(t => t.EXPIRATION_DATE).HasColumnName("EXPIRATION_DATE");
            this.Property(t => t.STORAGE).HasColumnName("STORAGE");
            this.Property(t => t.THEOR_WT).HasColumnName("THEOR_WT");
            this.Property(t => t.OPER).HasColumnName("OPER");
            this.Property(t => t.OPER_Copy).HasColumnName("OPER_Copy");
            this.Property(t => t.Adage_Item_Code).HasColumnName("Adage_Item_Code");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
            this.Property(t => t.WhichUser).HasColumnName("WhichUser");
            this.Property(t => t.NameofMachine).HasColumnName("NameofMachine");
        }
    }
}
