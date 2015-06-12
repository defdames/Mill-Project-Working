using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_vacc1_tblMap : EntityTypeConfiguration<en_vacc1_tbl>
    {
        public en_vacc1_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.en_vacc1_value });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_vacc1_value)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_vacc1_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_vacct_attrib1)
                .HasMaxLength(10);

            this.Property(t => t.en_vacct_attrib2)
                .HasMaxLength(10);

            this.Property(t => t.en_vacct_attrib3)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_vacc1_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.en_vacc1_value).HasColumnName("en_vacc1_value");
            this.Property(t => t.en_vacc1_desc).HasColumnName("en_vacc1_desc");
            this.Property(t => t.en_vacc1_upcnt).HasColumnName("en_vacc1_upcnt");
            this.Property(t => t.en_vacct_inadt).HasColumnName("en_vacct_inadt");
            this.Property(t => t.en_vacct_attrib1).HasColumnName("en_vacct_attrib1");
            this.Property(t => t.en_vacct_attrib2).HasColumnName("en_vacct_attrib2");
            this.Property(t => t.en_vacct_attrib3).HasColumnName("en_vacct_attrib3");
        }
    }
}
