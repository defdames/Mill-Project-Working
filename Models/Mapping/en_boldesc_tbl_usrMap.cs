using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_boldesc_tbl_usrMap : EntityTypeConfiguration<en_boldesc_tbl_usr>
    {
        public en_boldesc_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_frtitem_key, t.en_mode_key });

            // Properties
            this.Property(t => t.en_frtitem_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_bol_desc1)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.en_bol_desc2)
                .HasMaxLength(60);

            this.Property(t => t.en_bol_desc3)
                .HasMaxLength(60);

            this.Property(t => t.en_bol_desc4)
                .HasMaxLength(60);

            this.Property(t => t.en_bol_desc5)
                .HasMaxLength(60);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            this.Property(t => t.un_number)
                .HasMaxLength(20);

            this.Property(t => t.packing_group)
                .HasMaxLength(1);

            this.Property(t => t.class_division)
                .HasMaxLength(3);

            this.Property(t => t.emergency_numberd)
                .HasMaxLength(20);

            this.Property(t => t.emergency_numberf)
                .HasMaxLength(30);

            this.Property(t => t.shipping_name)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("en_boldesc_tbl_usr");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_hazard_flg).HasColumnName("en_hazard_flg");
            this.Property(t => t.en_bol_desc1).HasColumnName("en_bol_desc1");
            this.Property(t => t.en_bol_desc2).HasColumnName("en_bol_desc2");
            this.Property(t => t.en_bol_desc3).HasColumnName("en_bol_desc3");
            this.Property(t => t.en_bol_desc4).HasColumnName("en_bol_desc4");
            this.Property(t => t.en_bol_desc5).HasColumnName("en_bol_desc5");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.un_number).HasColumnName("un_number");
            this.Property(t => t.packing_group).HasColumnName("packing_group");
            this.Property(t => t.class_division).HasColumnName("class_division");
            this.Property(t => t.emergency_numberd).HasColumnName("emergency_numberd");
            this.Property(t => t.emergency_numberf).HasColumnName("emergency_numberf");
            this.Property(t => t.shipping_name).HasColumnName("shipping_name");
        }
    }
}
