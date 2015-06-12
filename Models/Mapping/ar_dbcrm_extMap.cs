using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_dbcrm_extMap : EntityTypeConfiguration<ar_dbcrm_ext>
    {
        public ar_dbcrm_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_brnch_key, t.ar_dbcrm_type, t.ar_dbcrm_key, t.ar_dbcrdtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ar_dbcrm_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_dbcrm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_dbcrdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.comments)
                .HasMaxLength(255);

            this.Property(t => t.product_returned)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ar_dbcrm_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_brnch_key).HasColumnName("in_brnch_key");
            this.Property(t => t.ar_dbcrm_type).HasColumnName("ar_dbcrm_type");
            this.Property(t => t.ar_dbcrm_key).HasColumnName("ar_dbcrm_key");
            this.Property(t => t.ar_dbcrdtl_key).HasColumnName("ar_dbcrdtl_key");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.product_returned).HasColumnName("product_returned");
            this.Property(t => t.ar_dbcrm_upcnt).HasColumnName("ar_dbcrm_upcnt");
        }
    }
}
