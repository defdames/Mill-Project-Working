using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class COA_retest_get_dataMap : EntityTypeConfiguration<COA_retest_get_data>
    {
        public COA_retest_get_dataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_item_key, t.en_lot_key, t.en_qcmst_key });

            // Properties
            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.en_qcmst_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_lotqc_reslt)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("COA_retest_get_data");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.en_lot_key).HasColumnName("en_lot_key");
            this.Property(t => t.en_qcmst_key).HasColumnName("en_qcmst_key");
            this.Property(t => t.en_lotqc_value).HasColumnName("en_lotqc_value");
            this.Property(t => t.en_lotqc_reslt).HasColumnName("en_lotqc_reslt");
            this.Property(t => t.en_lotqc_tstdt).HasColumnName("en_lotqc_tstdt");
        }
    }
}
