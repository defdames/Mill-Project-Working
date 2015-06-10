using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class bol_sohdrins_childMap : EntityTypeConfiguration<bol_sohdrins_child>
    {
        public bol_sohdrins_childMap()
        {
            // Primary Key
            this.HasKey(t => new { t.so_load_key, t.in_whs_key });

            // Properties
            this.Property(t => t.im_incls_key)
                .HasMaxLength(10);

            this.Property(t => t.sohdrins_text_value)
                .HasMaxLength(1786);

            this.Property(t => t.so_load_key)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("bol_sohdrins_child");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.im_incls_key).HasColumnName("im_incls_key");
            this.Property(t => t.sohdrins_text_value).HasColumnName("sohdrins_text_value");
            this.Property(t => t.so_load_key).HasColumnName("so_load_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
        }
    }
}
