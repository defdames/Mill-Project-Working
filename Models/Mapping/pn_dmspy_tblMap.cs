using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pn_dmspy_tblMap : EntityTypeConfiguration<pn_dmspy_tbl>
    {
        public pn_dmspy_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.pn_dmspy_pk);

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_sched_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pn_sched_entty)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pn_dmspy_fl)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_doc_type)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_doc_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pn_loc_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_ref_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pn_dmspy_dmdco)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_dmspy_dmdenttp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_dmspy_dmdentid)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_dmspy_dmditem)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pn_dmspy_dmdpack)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pn_dmspy_wtdswhs)
                .HasMaxLength(4);

            this.Property(t => t.pn_dmspy_pk)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pn_dmspy_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pn_sched_key).HasColumnName("pn_sched_key");
            this.Property(t => t.pn_sched_entty).HasColumnName("pn_sched_entty");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pn_date).HasColumnName("pn_date");
            this.Property(t => t.pn_dmspy_fl).HasColumnName("pn_dmspy_fl");
            this.Property(t => t.pn_doc_type).HasColumnName("pn_doc_type");
            this.Property(t => t.pn_doc_key).HasColumnName("pn_doc_key");
            this.Property(t => t.pn_dtl_key).HasColumnName("pn_dtl_key");
            this.Property(t => t.pn_loc_key).HasColumnName("pn_loc_key");
            this.Property(t => t.pn_qty).HasColumnName("pn_qty");
            this.Property(t => t.pn_ref_key).HasColumnName("pn_ref_key");
            this.Property(t => t.pn_edate).HasColumnName("pn_edate");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.pn_dmspy_upcnt).HasColumnName("pn_dmspy_upcnt");
            this.Property(t => t.pn_dmspy_dmdco).HasColumnName("pn_dmspy_dmdco");
            this.Property(t => t.pn_dmspy_dmdenttp).HasColumnName("pn_dmspy_dmdenttp");
            this.Property(t => t.pn_dmspy_dmdentid).HasColumnName("pn_dmspy_dmdentid");
            this.Property(t => t.pn_dmspy_dmditem).HasColumnName("pn_dmspy_dmditem");
            this.Property(t => t.pn_dmspy_dmdpack).HasColumnName("pn_dmspy_dmdpack");
            this.Property(t => t.pn_dmspy_subtyp).HasColumnName("pn_dmspy_subtyp");
            this.Property(t => t.pn_dmspy_wtdswhs).HasColumnName("pn_dmspy_wtdswhs");
            this.Property(t => t.pn_dmspy_pk).HasColumnName("pn_dmspy_pk");
        }
    }
}
