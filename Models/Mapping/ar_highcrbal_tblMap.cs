using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_highcrbal_tblMap : EntityTypeConfiguration<ar_highcrbal_tbl>
    {
        public ar_highcrbal_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ar_entity_key, t.ar_entity_type, t.gl_cmp_key, t.ar_perod_seqno });

            // Properties
            this.Property(t => t.ar_entity_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_entity_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_perod_seqno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ar_highcrbal_tbl");
            this.Property(t => t.ar_entity_key).HasColumnName("ar_entity_key");
            this.Property(t => t.ar_entity_type).HasColumnName("ar_entity_type");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_perod_seqno).HasColumnName("ar_perod_seqno");
            this.Property(t => t.ar_highcrbal_bal).HasColumnName("ar_highcrbal_bal");
            this.Property(t => t.ar_highcrbal_exp).HasColumnName("ar_highcrbal_exp");
            this.Property(t => t.ar_highcrbal_upcnt).HasColumnName("ar_highcrbal_upcnt");
        }
    }
}
