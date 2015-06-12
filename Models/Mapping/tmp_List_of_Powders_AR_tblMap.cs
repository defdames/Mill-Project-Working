using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tmp_List_of_Powders_AR_tblMap : EntityTypeConfiguration<tmp_List_of_Powders_AR_tbl>
    {
        public tmp_List_of_Powders_AR_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Company)
                .HasMaxLength(10);

            this.Property(t => t.Plant)
                .HasMaxLength(10);

            this.Property(t => t.frmkey)
                .HasMaxLength(50);

            this.Property(t => t.Ing)
                .HasMaxLength(50);

            this.Property(t => t.UOM)
                .HasMaxLength(5);

            this.Property(t => t.Manufacture)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tmp_List_of_Powders_AR_tbl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.frmkey).HasColumnName("frmkey");
            this.Property(t => t.Ing).HasColumnName("Ing");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.UOM).HasColumnName("UOM");
            this.Property(t => t.Manufacture).HasColumnName("Manufacture");
            this.Property(t => t.L).HasColumnName("L");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
