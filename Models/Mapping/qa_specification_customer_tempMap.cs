using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class qa_specification_customer_tempMap : EntityTypeConfiguration<qa_specification_customer_temp>
    {
        public qa_specification_customer_tempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Item, t.SpecEffDate, t.SpecInadtDate, t.Recent });

            // Properties
            this.Property(t => t.Item)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SpecGrpKey)
                .HasMaxLength(36);

            this.Property(t => t.TestName)
                .HasMaxLength(10);

            this.Property(t => t.QualValue)
                .HasMaxLength(60);

            this.Property(t => t.TestUoM)
                .HasMaxLength(30);

            this.Property(t => t.Recent)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_qcmst_desc)
                .HasMaxLength(60);

            this.Property(t => t.en_ship_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("qa_specification_customer_temp");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.SpecEffDate).HasColumnName("SpecEffDate");
            this.Property(t => t.SpecInadtDate).HasColumnName("SpecInadtDate");
            this.Property(t => t.SpecGrpKey).HasColumnName("SpecGrpKey");
            this.Property(t => t.TestName).HasColumnName("TestName");
            this.Property(t => t.MinValue).HasColumnName("MinValue");
            this.Property(t => t.MaxValue).HasColumnName("MaxValue");
            this.Property(t => t.TargetValue).HasColumnName("TargetValue");
            this.Property(t => t.QualValue).HasColumnName("QualValue");
            this.Property(t => t.TestUoM).HasColumnName("TestUoM");
            this.Property(t => t.Recent).HasColumnName("Recent");
            this.Property(t => t.en_qcmst_desc).HasColumnName("en_qcmst_desc");
            this.Property(t => t.en_itqct_reqdf).HasColumnName("en_itqct_reqdf");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
