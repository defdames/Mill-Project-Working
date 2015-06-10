using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class SysOpSheetMap : EntityTypeConfiguration<SysOpSheet>
    {
        public SysOpSheetMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Item_ID)
                .HasMaxLength(255);

            this.Property(t => t.Plant)
                .HasMaxLength(255);

            this.Property(t => t.System)
                .HasMaxLength(255);

            this.Property(t => t.MillsUsed)
                .HasMaxLength(255);

            this.Property(t => t.MillAirflow)
                .HasMaxLength(255);

            this.Property(t => t.ScalperMesh)
                .HasMaxLength(255);

            this.Property(t => t.ChargeVar)
                .HasMaxLength(255);

            this.Property(t => t.DrainType)
                .HasMaxLength(255);

            this.Property(t => t.DilutionSolvent)
                .HasMaxLength(255);

            this.Property(t => t.MillDilutionGals)
                .HasMaxLength(255);

            this.Property(t => t.FinalDilutionSolvent)
                .HasMaxLength(255);

            this.Property(t => t.DilutionSetPoint)
                .HasMaxLength(255);

            this.Property(t => t.FinalDilutionGals)
                .HasMaxLength(255);

            this.Property(t => t.DrainLightMinutes)
                .HasMaxLength(255);

            this.Property(t => t.ScalperScreens)
                .HasMaxLength(255);

            this.Property(t => t.FirstPass)
                .HasMaxLength(255);

            this.Property(t => t.FirstPassMesh)
                .HasMaxLength(255);

            this.Property(t => t.FirstPassSolvent)
                .HasMaxLength(255);

            this.Property(t => t.FirstPassFlow)
                .HasMaxLength(255);

            this.Property(t => t.SecondPass)
                .HasMaxLength(255);

            this.Property(t => t.SecondPassMesh)
                .HasMaxLength(255);

            this.Property(t => t.SecondPassSolvent)
                .HasMaxLength(255);

            this.Property(t => t.SecondPassFlow)
                .HasMaxLength(255);

            this.Property(t => t.CheckScreenMesh)
                .HasMaxLength(255);

            this.Property(t => t.CheckScreenFlow)
                .HasMaxLength(255);

            this.Property(t => t.NumbersOfScreens)
                .HasMaxLength(255);

            this.Property(t => t.Comments)
                .HasMaxLength(255);

            this.Property(t => t.CheckScreens)
                .HasMaxLength(255);

            this.Property(t => t.PressesUsed)
                .HasMaxLength(255);

            this.Property(t => t.PressWash)
                .HasMaxLength(255);

            this.Property(t => t.AirTime)
                .HasMaxLength(255);

            this.Property(t => t.Press1Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press2Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press3Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press4Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press6Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press11Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press12Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press13Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press14Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press15Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press16Wash)
                .HasMaxLength(255);

            this.Property(t => t.Revision)
                .HasMaxLength(255);

            this.Property(t => t.CentrifugeSetting)
                .HasMaxLength(255);

            this.Property(t => t.BMNV)
                .HasMaxLength(255);

            this.Property(t => t.VarsolTo)
                .HasMaxLength(255);

            this.Property(t => t.RPMs)
                .HasMaxLength(255);

            this.Property(t => t.Remarks)
                .HasMaxLength(255);

            this.Property(t => t.Press5Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press7Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press8Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press9Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press10Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press17Wash)
                .HasMaxLength(255);

            this.Property(t => t.Press18Wash)
                .HasMaxLength(255);

            this.Property(t => t.TotalFlow)
                .HasMaxLength(255);

            this.Property(t => t.Varsol_Valve_PID1)
                .HasMaxLength(255);

            this.Property(t => t.Varsol_Valve_PID2)
                .HasMaxLength(255);

            this.Property(t => t.Varsol_Valve_PID3)
                .HasMaxLength(255);

            this.Property(t => t.Varsol_Valve_Output_MIN)
                .HasMaxLength(255);

            this.Property(t => t.Varsol_Valve_Output_MAX)
                .HasMaxLength(255);

            this.Property(t => t.Material_Valve_PID1)
                .HasMaxLength(255);

            this.Property(t => t.Material_Valve_PID2)
                .HasMaxLength(255);

            this.Property(t => t.Material_Valve_PID3)
                .HasMaxLength(255);

            this.Property(t => t.Material_Valve_Output_MIN)
                .HasMaxLength(255);

            this.Property(t => t.Material_Valve_Output_MAX)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("SysOpSheets");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Item_ID).HasColumnName("Item ID");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.System).HasColumnName("System");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.MillsUsed).HasColumnName("MillsUsed");
            this.Property(t => t.MillAirflow).HasColumnName("MillAirflow");
            this.Property(t => t.ScalperMesh).HasColumnName("ScalperMesh");
            this.Property(t => t.ChargeVar).HasColumnName("ChargeVar");
            this.Property(t => t.DrainType).HasColumnName("DrainType");
            this.Property(t => t.DilutionSolvent).HasColumnName("DilutionSolvent");
            this.Property(t => t.MillDilutionGals).HasColumnName("MillDilutionGals");
            this.Property(t => t.FinalDilutionSolvent).HasColumnName("FinalDilutionSolvent");
            this.Property(t => t.DilutionSetPoint).HasColumnName("DilutionSetPoint");
            this.Property(t => t.FinalDilutionGals).HasColumnName("FinalDilutionGals");
            this.Property(t => t.DrainLightMinutes).HasColumnName("DrainLightMinutes");
            this.Property(t => t.ScalperScreens).HasColumnName("ScalperScreens");
            this.Property(t => t.FirstPass).HasColumnName("FirstPass");
            this.Property(t => t.FirstPassMesh).HasColumnName("FirstPassMesh");
            this.Property(t => t.FirstPassSolvent).HasColumnName("FirstPassSolvent");
            this.Property(t => t.FirstPassFlow).HasColumnName("FirstPassFlow");
            this.Property(t => t.SecondPass).HasColumnName("SecondPass");
            this.Property(t => t.SecondPassMesh).HasColumnName("SecondPassMesh");
            this.Property(t => t.SecondPassSolvent).HasColumnName("SecondPassSolvent");
            this.Property(t => t.SecondPassFlow).HasColumnName("SecondPassFlow");
            this.Property(t => t.CheckScreenMesh).HasColumnName("CheckScreenMesh");
            this.Property(t => t.CheckScreenFlow).HasColumnName("CheckScreenFlow");
            this.Property(t => t.NumbersOfScreens).HasColumnName("NumbersOfScreens");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.CheckScreens).HasColumnName("CheckScreens");
            this.Property(t => t.PressesUsed).HasColumnName("PressesUsed");
            this.Property(t => t.PressWash).HasColumnName("PressWash");
            this.Property(t => t.AirTime).HasColumnName("AirTime");
            this.Property(t => t.Press1Wash).HasColumnName("Press1Wash");
            this.Property(t => t.Press2Wash).HasColumnName("Press2Wash");
            this.Property(t => t.Press3Wash).HasColumnName("Press3Wash");
            this.Property(t => t.Press4Wash).HasColumnName("Press4Wash");
            this.Property(t => t.Press6Wash).HasColumnName("Press6Wash");
            this.Property(t => t.Press11Wash).HasColumnName("Press11Wash");
            this.Property(t => t.Press12Wash).HasColumnName("Press12Wash");
            this.Property(t => t.Press13Wash).HasColumnName("Press13Wash");
            this.Property(t => t.Press14Wash).HasColumnName("Press14Wash");
            this.Property(t => t.Press15Wash).HasColumnName("Press15Wash");
            this.Property(t => t.Press16Wash).HasColumnName("Press16Wash");
            this.Property(t => t.Revision).HasColumnName("Revision");
            this.Property(t => t.CentrifugeSetting).HasColumnName("CentrifugeSetting");
            this.Property(t => t.BMNV).HasColumnName("BMNV");
            this.Property(t => t.VarsolTo).HasColumnName("VarsolTo");
            this.Property(t => t.RPMs).HasColumnName("RPMs");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.Press5Wash).HasColumnName("Press5Wash");
            this.Property(t => t.Press7Wash).HasColumnName("Press7Wash");
            this.Property(t => t.Press8Wash).HasColumnName("Press8Wash");
            this.Property(t => t.Press9Wash).HasColumnName("Press9Wash");
            this.Property(t => t.Press10Wash).HasColumnName("Press10Wash");
            this.Property(t => t.Press17Wash).HasColumnName("Press17Wash");
            this.Property(t => t.Press18Wash).HasColumnName("Press18Wash");
            this.Property(t => t.TotalFlow).HasColumnName("TotalFlow");
            this.Property(t => t.Varsol_Valve_PID1).HasColumnName("Varsol Valve PID1");
            this.Property(t => t.Varsol_Valve_PID2).HasColumnName("Varsol Valve PID2");
            this.Property(t => t.Varsol_Valve_PID3).HasColumnName("Varsol Valve PID3");
            this.Property(t => t.Varsol_Valve_Output_MIN).HasColumnName("Varsol Valve Output MIN");
            this.Property(t => t.Varsol_Valve_Output_MAX).HasColumnName("Varsol Valve Output MAX");
            this.Property(t => t.Material_Valve_PID1).HasColumnName("Material Valve PID1");
            this.Property(t => t.Material_Valve_PID2).HasColumnName("Material Valve PID2");
            this.Property(t => t.Material_Valve_PID3).HasColumnName("Material Valve PID3");
            this.Property(t => t.Material_Valve_Output_MIN).HasColumnName("Material Valve Output MIN");
            this.Property(t => t.Material_Valve_Output_MAX).HasColumnName("Material Valve Output MAX");
            this.Property(t => t.Agitator).HasColumnName("Agitator");
            this.Property(t => t.Slurry_Pump).HasColumnName("Slurry Pump");
            this.Property(t => t.Mag_Tank_Pump).HasColumnName("Mag Tank Pump");
            this.Property(t => t.Lobe_Pump).HasColumnName("Lobe Pump");
            this.Property(t => t.Dilution_Pump).HasColumnName("Dilution Pump");
            this.Property(t => t.Centrifuge).HasColumnName("Centrifuge");
            this.Property(t => t.Cent_Feed_Pump).HasColumnName("Cent Feed Pump");
            this.Property(t => t.Cent_Ret_Pump).HasColumnName("Cent Ret Pump");
            this.Property(t => t.C1st_pass_Trails_Pump).HasColumnName("1st pass Trails Pump");
            this.Property(t => t.Chk_Screen_Feed_Pump).HasColumnName("Chk Screen Feed Pump");
        }
    }
}
