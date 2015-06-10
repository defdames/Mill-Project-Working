using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pn_porpk_tblMap : EntityTypeConfiguration<pn_porpk_tbl>
    {
        public pn_porpk_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pn_sched_key, t.in_item_key, t.im_pack_key, t.pn_entty_sourc, t.pn_pordr_reqdt, t.pn_pordr_seq });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_sched_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pn_entty_sourc)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_pordr_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("pn_porpk_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pn_sched_key).HasColumnName("pn_sched_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.pn_entty_sourc).HasColumnName("pn_entty_sourc");
            this.Property(t => t.pn_pordr_reqdt).HasColumnName("pn_pordr_reqdt");
            this.Property(t => t.pn_pordr_seq).HasColumnName("pn_pordr_seq");
            this.Property(t => t.pn_porpk_ordqt).HasColumnName("pn_porpk_ordqt");
            this.Property(t => t.pn_porpk_yldfac).HasColumnName("pn_porpk_yldfac");
            this.Property(t => t.pn_porpk_yldblk).HasColumnName("pn_porpk_yldblk");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.pn_porpk_upcnt).HasColumnName("pn_porpk_upcnt");
        }
    }
}
