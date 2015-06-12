using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pss_listMap : EntityTypeConfiguration<pss_list>
    {
        public pss_listMap()
        {
            // Primary Key
            this.HasKey(t => t.pss_id);

            // Properties
            this.Property(t => t.region)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.production_plant)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.shipkey)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_lot_key)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.accept_reject)
                .HasMaxLength(20);

            this.Property(t => t.tc_ref_no)
                .HasMaxLength(50);

            this.Property(t => t.user_entered)
                .HasMaxLength(200);

            this.Property(t => t.user_updated)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("pss_list");
            this.Property(t => t.pss_id).HasColumnName("pss_id");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.production_plant).HasColumnName("production_plant");
            this.Property(t => t.shipkey).HasColumnName("shipkey");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.en_lot_key).HasColumnName("en_lot_key");
            this.Property(t => t.date_sent).HasColumnName("date_sent");
            this.Property(t => t.accept_reject).HasColumnName("accept_reject");
            this.Property(t => t.reason_for_rejection).HasColumnName("reason_for_rejection");
            this.Property(t => t.tc_ref_no).HasColumnName("tc_ref_no");
            this.Property(t => t.pss_requirement).HasColumnName("pss_requirement");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.user_entered).HasColumnName("user_entered");
            this.Property(t => t.user_entered_date).HasColumnName("user_entered_date");
            this.Property(t => t.user_updated).HasColumnName("user_updated");
            this.Property(t => t.user_updated_date).HasColumnName("user_updated_date");
        }
    }
}
