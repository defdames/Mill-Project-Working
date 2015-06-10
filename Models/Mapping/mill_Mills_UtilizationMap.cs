using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class mill_Mills_UtilizationMap : EntityTypeConfiguration<mill_Mills_Utilization>
    {
        public mill_Mills_UtilizationMap()
        {
            // Primary Key
            this.HasKey(t => t.Mills_Utilization_ID);

            // Properties
            this.Property(t => t.Mill_ID)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.System)
                .HasMaxLength(255);

            this.Property(t => t.Run_Code)
                .HasMaxLength(255);

            this.Property(t => t.Shift)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.sa_user_key)
                .HasMaxLength(20);

            this.Property(t => t.Item_Number)
                .HasMaxLength(255);

            this.Property(t => t.Shift_Category)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Created_by)
                .HasMaxLength(255);

            this.Property(t => t.Modified_by)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("mill_Mills_Utilization");
            this.Property(t => t.Mills_Utilization_ID).HasColumnName("Mills_Utilization_ID");
            this.Property(t => t.Mill_ID).HasColumnName("Mill_ID");
            this.Property(t => t.System).HasColumnName("System");
            this.Property(t => t.Run_Code).HasColumnName("Run_Code");
            this.Property(t => t.Start_Time).HasColumnName("Start_Time");
            this.Property(t => t.Stop_Time).HasColumnName("Stop_Time");
            this.Property(t => t.Shift).HasColumnName("Shift");
            this.Property(t => t.Shift_Start_Date).HasColumnName("Shift_Start_Date");
            this.Property(t => t.Mill_Hours_Booked).HasColumnName("Mill_Hours_Booked");
            this.Property(t => t.Shift_Start_Time).HasColumnName("Shift_Start_Time");
            this.Property(t => t.Shift_Stop_Time).HasColumnName("Shift_Stop_Time");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.SO_Number).HasColumnName("SO_Number");
            this.Property(t => t.Item_Number).HasColumnName("Item_Number");
            this.Property(t => t.Shift_Category).HasColumnName("Shift_Category");
            this.Property(t => t.Mill_temp).HasColumnName("Mill_temp");
            this.Property(t => t.D10).HasColumnName("D10");
            this.Property(t => t.D50).HasColumnName("D50");
            this.Property(t => t.D90).HasColumnName("D90");
            this.Property(t => t.D98).HasColumnName("D98");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.Created_date).HasColumnName("Created_date");
            this.Property(t => t.Modified_date).HasColumnName("Modified_date");
            this.Property(t => t.Created_by).HasColumnName("Created_by");
            this.Property(t => t.Modified_by).HasColumnName("Modified_by");
        }
    }
}
