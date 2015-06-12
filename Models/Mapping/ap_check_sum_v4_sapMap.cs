using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_check_sum_v4_sapMap : EntityTypeConfiguration<ap_check_sum_v4_sap>
    {
        public ap_check_sum_v4_sapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ap_chek_key, t.gl_cmp_key, t.gl_crncy_key });

            // Properties
            this.Property(t => t.ap_chek_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("ap_check_sum_v4_sap");
            this.Property(t => t.ap_chek_key).HasColumnName("ap_chek_key");
            this.Property(t => t.sumnet).HasColumnName("sumnet");
            this.Property(t => t.sumnetsgd).HasColumnName("sumnetsgd");
            this.Property(t => t.sumdisc).HasColumnName("sumdisc");
            this.Property(t => t.sumgross).HasColumnName("sumgross");
            this.Property(t => t.sumgrosssgd).HasColumnName("sumgrosssgd");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
        }
    }
}
