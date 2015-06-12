using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_tran_tblMap : EntityTypeConfiguration<in_tran_tbl>
    {
        public in_tran_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_tran_key, t.in_tran_type, t.in_trandtl_key });

            // Properties
            this.Property(t => t.in_tran_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_tran_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_trandtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_location)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_demand)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_lot_key)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.in_locn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_afill)
                .HasMaxLength(2);

            this.Property(t => t.in_tran_enttp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_tran_entid)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_tran_demandid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_tran_demandtp)
                .HasMaxLength(1);

            this.Property(t => t.in_tran_origin)
                .HasMaxLength(35);

            this.Property(t => t.in_tran_origintp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.in_tran_origentid)
                .HasMaxLength(10);

            this.Property(t => t.in_tran_origenttp)
                .HasMaxLength(10);

            this.Property(t => t.in_tran_refdoc)
                .HasMaxLength(35);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_uom_measured)
                .HasMaxLength(2);

            this.Property(t => t.en_uom_alternate)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("in_tran_tbl");
            this.Property(t => t.in_tran_key).HasColumnName("in_tran_key");
            this.Property(t => t.in_tran_type).HasColumnName("in_tran_type");
            this.Property(t => t.in_trandtl_key).HasColumnName("in_trandtl_key");
            this.Property(t => t.in_trnum_key).HasColumnName("in_trnum_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_cmp_location).HasColumnName("gl_cmp_location");
            this.Property(t => t.gl_cmp_demand).HasColumnName("gl_cmp_demand");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_lot_key).HasColumnName("in_lot_key");
            this.Property(t => t.in_locn_key).HasColumnName("in_locn_key");
            this.Property(t => t.in_tran_qty).HasColumnName("in_tran_qty");
            this.Property(t => t.in_tran_afill).HasColumnName("in_tran_afill");
            this.Property(t => t.en_uom_afill).HasColumnName("en_uom_afill");
            this.Property(t => t.in_tran_extcst).HasColumnName("in_tran_extcst");
            this.Property(t => t.in_tran_enttp).HasColumnName("in_tran_enttp");
            this.Property(t => t.in_tran_entid).HasColumnName("in_tran_entid");
            this.Property(t => t.in_tran_demandid).HasColumnName("in_tran_demandid");
            this.Property(t => t.in_tran_demandtp).HasColumnName("in_tran_demandtp");
            this.Property(t => t.in_tran_demandline).HasColumnName("in_tran_demandline");
            this.Property(t => t.in_tran_origin).HasColumnName("in_tran_origin");
            this.Property(t => t.in_tran_origintp).HasColumnName("in_tran_origintp");
            this.Property(t => t.in_tran_originline).HasColumnName("in_tran_originline");
            this.Property(t => t.in_tran_origentid).HasColumnName("in_tran_origentid");
            this.Property(t => t.in_tran_origenttp).HasColumnName("in_tran_origenttp");
            this.Property(t => t.in_tran_refdoc).HasColumnName("in_tran_refdoc");
            this.Property(t => t.in_tran_date).HasColumnName("in_tran_date");
            this.Property(t => t.in_tran_sysdt).HasColumnName("in_tran_sysdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_tran_mqty).HasColumnName("in_tran_mqty");
            this.Property(t => t.en_uom_measured).HasColumnName("en_uom_measured");
            this.Property(t => t.in_tran_aqty).HasColumnName("in_tran_aqty");
            this.Property(t => t.en_subtype_key).HasColumnName("en_subtype_key");
            this.Property(t => t.en_uom_alternate).HasColumnName("en_uom_alternate");
            this.Property(t => t.gl_trace_key).HasColumnName("gl_trace_key");
        }
    }
}
