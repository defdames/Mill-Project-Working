using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_cycnt_extMap : EntityTypeConfiguration<in_cycnt_ext>
    {
        public in_cycnt_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.in_cycnt_key, t.in_cycnt_seqno });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_cycnt_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_cycnt_seqno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("in_cycnt_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_cycnt_key).HasColumnName("in_cycnt_key");
            this.Property(t => t.in_cycnt_seqno).HasColumnName("in_cycnt_seqno");
            this.Property(t => t.in_cycnt_adjqty).HasColumnName("in_cycnt_adjqty");
            this.Property(t => t.in_cycnt_orgcnt).HasColumnName("in_cycnt_orgcnt");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_cyhist_cost).HasColumnName("in_cyhist_cost");
            this.Property(t => t.in_cycnt_upcnt).HasColumnName("in_cycnt_upcnt");
        }
    }
}
