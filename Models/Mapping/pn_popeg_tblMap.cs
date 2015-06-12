using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pn_popeg_tblMap : EntityTypeConfiguration<pn_popeg_tbl>
    {
        public pn_popeg_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.pn_popeg_pk);

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

            this.Property(t => t.pn_entty_sourc)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_pordr_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_popeg_dmdtyp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_popeg_dmdsrc)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_popeg_ordtyp)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_popeg_ordid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pn_popeg_dmdco)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pn_popeg_dmdenttp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pn_popeg_dmditem)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pn_popeg_dmdentid)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pn_popeg_dmdpack)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.pn_popeg_pk)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pn_popeg_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pn_sched_key).HasColumnName("pn_sched_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pn_entty_sourc).HasColumnName("pn_entty_sourc");
            this.Property(t => t.pn_pordr_type).HasColumnName("pn_pordr_type");
            this.Property(t => t.pn_pordr_reqdt).HasColumnName("pn_pordr_reqdt");
            this.Property(t => t.pn_popeg_dmdtyp).HasColumnName("pn_popeg_dmdtyp");
            this.Property(t => t.pn_popeg_dmdsrc).HasColumnName("pn_popeg_dmdsrc");
            this.Property(t => t.pn_popeg_ordtyp).HasColumnName("pn_popeg_ordtyp");
            this.Property(t => t.pn_popeg_ordid).HasColumnName("pn_popeg_ordid");
            this.Property(t => t.pn_popeg_orddtl).HasColumnName("pn_popeg_orddtl");
            this.Property(t => t.pn_popeg_ordqt).HasColumnName("pn_popeg_ordqt");
            this.Property(t => t.pn_popeg_reqdt).HasColumnName("pn_popeg_reqdt");
            this.Property(t => t.pn_popeg_upcnt).HasColumnName("pn_popeg_upcnt");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.pn_popeg_dmdco).HasColumnName("pn_popeg_dmdco");
            this.Property(t => t.pn_popeg_dmdenttp).HasColumnName("pn_popeg_dmdenttp");
            this.Property(t => t.pn_popeg_dmditem).HasColumnName("pn_popeg_dmditem");
            this.Property(t => t.pn_popeg_dmdentid).HasColumnName("pn_popeg_dmdentid");
            this.Property(t => t.pn_popeg_dmdpack).HasColumnName("pn_popeg_dmdpack");
            this.Property(t => t.pn_popeg_subtyp).HasColumnName("pn_popeg_subtyp");
            this.Property(t => t.pn_popeg_pk).HasColumnName("pn_popeg_pk");
        }
    }
}
