using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_boldesc_tbl_usr_sapMap : EntityTypeConfiguration<en_boldesc_tbl_usr_sap>
    {
        public en_boldesc_tbl_usr_sapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_frtitem_key, t.en_mode_key, t.en_hazard_flg, t.en_bol_desc1, t.en_bol_desc2, t.en_bol_desc3, t.en_bol_desc4, t.en_bol_desc5 });

            // Properties
            this.Property(t => t.en_frtitem_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_hazard_flg)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_bol_desc1)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_bol_desc2)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_bol_desc3)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_bol_desc4)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.en_bol_desc5)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("en_boldesc_tbl_usr_sap");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_hazard_flg).HasColumnName("en_hazard_flg");
            this.Property(t => t.en_bol_desc1).HasColumnName("en_bol_desc1");
            this.Property(t => t.en_bol_desc2).HasColumnName("en_bol_desc2");
            this.Property(t => t.en_bol_desc3).HasColumnName("en_bol_desc3");
            this.Property(t => t.en_bol_desc4).HasColumnName("en_bol_desc4");
            this.Property(t => t.en_bol_desc5).HasColumnName("en_bol_desc5");
        }
    }
}
