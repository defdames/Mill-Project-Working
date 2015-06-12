using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pn_pmatl_tblMap : EntityTypeConfiguration<pn_pmatl_tbl>
    {
        public pn_pmatl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pn_sched_key, t.in_item_key, t.pn_pordr_reqdt, t.pn_pordr_seq, t.pn_pmatl_key });

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

            this.Property(t => t.pn_pordr_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pn_pmatl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pn_pmatl_ip)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sf_ingrd_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_pkitm_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pn_pmatl_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_pmatl_inpk)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.sf_rout_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pn_pmatl_fpack)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("pn_pmatl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pn_sched_key).HasColumnName("pn_sched_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pn_pordr_reqdt).HasColumnName("pn_pordr_reqdt");
            this.Property(t => t.pn_pordr_seq).HasColumnName("pn_pordr_seq");
            this.Property(t => t.pn_pmatl_key).HasColumnName("pn_pmatl_key");
            this.Property(t => t.pn_pmatl_reqdt).HasColumnName("pn_pmatl_reqdt");
            this.Property(t => t.pn_pmatl_ip).HasColumnName("pn_pmatl_ip");
            this.Property(t => t.sf_ingrd_key).HasColumnName("sf_ingrd_key");
            this.Property(t => t.in_pkitm_key).HasColumnName("in_pkitm_key");
            this.Property(t => t.sf_opseq_key).HasColumnName("sf_opseq_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.pn_pmatl_nomqty).HasColumnName("pn_pmatl_nomqty");
            this.Property(t => t.pn_pmatl_qty).HasColumnName("pn_pmatl_qty");
            this.Property(t => t.pn_pmatl_uom).HasColumnName("pn_pmatl_uom");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.pn_pmatl_inpk).HasColumnName("pn_pmatl_inpk");
            this.Property(t => t.sf_rout_key).HasColumnName("sf_rout_key");
            this.Property(t => t.pn_pmatl_fpack).HasColumnName("pn_pmatl_fpack");
            this.Property(t => t.pn_pmatl_upcnt).HasColumnName("pn_pmatl_upcnt");
        }
    }
}
