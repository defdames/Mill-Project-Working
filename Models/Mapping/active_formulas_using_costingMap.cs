using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class active_formulas_using_costingMap : EntityTypeConfiguration<active_formulas_using_costing>
    {
        public active_formulas_using_costingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Plant, t.Active_Formula, t.Active_Rout_Key, t.Active_Formula_V, t.sf_frmla_effdt, t.gl_cmp_key, t.sg, t.batch_uom, t.in_item_spgvt });

            // Properties
            this.Property(t => t.Plant)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Active_Formula)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Active_Rout_Key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Active_Formula_V)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_ingrd_key)
                .HasMaxLength(20);

            this.Property(t => t.sf_ingrd_uom)
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Unit_Cost_UOM)
                .HasMaxLength(2);

            this.Property(t => t.batch_uom)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("active_formulas_using_costing");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.Active_Formula).HasColumnName("Active Formula");
            this.Property(t => t.Active_Rout_Key).HasColumnName("Active Rout Key");
            this.Property(t => t.Active_Formula_V).HasColumnName("Active Formula V");
            this.Property(t => t.sf_frmla_effdt).HasColumnName("sf_frmla_effdt");
            this.Property(t => t.sf_ingrd_key).HasColumnName("sf_ingrd_key");
            this.Property(t => t.sf_ingrd_io).HasColumnName("sf_ingrd_io");
            this.Property(t => t.sf_ingrd_qty).HasColumnName("sf_ingrd_qty");
            this.Property(t => t.sf_ingrd_uom).HasColumnName("sf_ingrd_uom");
            this.Property(t => t.ingredient_cost).HasColumnName("ingredient_cost");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.Unit_Cost_UOM).HasColumnName("Unit Cost UOM");
            this.Property(t => t.sg).HasColumnName("sg");
            this.Property(t => t.totalcost).HasColumnName("totalcost");
            this.Property(t => t.actual_input_cost).HasColumnName("actual_input_cost");
            this.Property(t => t.batch_uom).HasColumnName("batch_uom");
            this.Property(t => t.in_item_spgvt).HasColumnName("in_item_spgvt");
        }
    }
}
