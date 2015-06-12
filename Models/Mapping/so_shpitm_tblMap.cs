using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_shpitm_tblMap : EntityTypeConfiguration<so_shpitm_tbl>
    {
        public so_shpitm_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_ship_entity, t.so_ship_key, t.so_ship_ordtp, t.so_shpitm_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_ship_entity)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_ship_ordtp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.so_shpitm_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.so_prod_key)
                .HasMaxLength(20);

            this.Property(t => t.so_shpitm_wtuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_frtitem_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_uom_afill)
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_dmd)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_ship_dmdent)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_profit)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_profit)
                .HasMaxLength(4);

            this.Property(t => t.so_shpitm_cstuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_enduse_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_assoc)
                .HasMaxLength(2);

            this.Property(t => t.so_ship_entassoc)
                .HasMaxLength(4);

            this.Property(t => t.so_ship_assoc)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("so_shpitm_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_ship_entity).HasColumnName("so_ship_entity");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.so_ship_ordtp).HasColumnName("so_ship_ordtp");
            this.Property(t => t.so_shpitm_key).HasColumnName("so_shpitm_key");
            this.Property(t => t.so_shpitm_dmdln).HasColumnName("so_shpitm_dmdln");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.so_shpqt_qty).HasColumnName("so_shpqt_qty");
            this.Property(t => t.so_shpitm_pot).HasColumnName("so_shpitm_pot");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.so_shpitm_adjfl).HasColumnName("so_shpitm_adjfl");
            this.Property(t => t.so_shpitm_drctf).HasColumnName("so_shpitm_drctf");
            this.Property(t => t.so_shpitm_wtuom).HasColumnName("so_shpitm_wtuom");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.so_shpitm_grnomwt).HasColumnName("so_shpitm_grnomwt");
            this.Property(t => t.so_shpitm_gractwt).HasColumnName("so_shpitm_gractwt");
            this.Property(t => t.so_shpitm_afill).HasColumnName("so_shpitm_afill");
            this.Property(t => t.en_uom_afill).HasColumnName("en_uom_afill");
            this.Property(t => t.gl_cmp_dmd).HasColumnName("gl_cmp_dmd");
            this.Property(t => t.so_ship_dmdent).HasColumnName("so_ship_dmdent");
            this.Property(t => t.gl_cmp_profit).HasColumnName("gl_cmp_profit");
            this.Property(t => t.so_brnch_profit).HasColumnName("so_brnch_profit");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.so_shpitm_nobkordf).HasColumnName("so_shpitm_nobkordf");
            this.Property(t => t.so_shpitm_upcnt).HasColumnName("so_shpitm_upcnt");
            this.Property(t => t.so_shpitm_intinv).HasColumnName("so_shpitm_intinv");
            this.Property(t => t.so_shpitm_extcost).HasColumnName("so_shpitm_extcost");
            this.Property(t => t.so_shpitm_cstuom).HasColumnName("so_shpitm_cstuom");
            this.Property(t => t.so_shpitm_bmcst).HasColumnName("so_shpitm_bmcst");
            this.Property(t => t.so_shpitm_bmocst).HasColumnName("so_shpitm_bmocst");
            this.Property(t => t.so_shpitm_brcst).HasColumnName("so_shpitm_brcst");
            this.Property(t => t.so_shpitm_brocst).HasColumnName("so_shpitm_brocst");
            this.Property(t => t.so_shpitm_pmcst).HasColumnName("so_shpitm_pmcst");
            this.Property(t => t.so_shpitm_pmocst).HasColumnName("so_shpitm_pmocst");
            this.Property(t => t.so_shpitm_prcst).HasColumnName("so_shpitm_prcst");
            this.Property(t => t.so_shpitm_procst).HasColumnName("so_shpitm_procst");
            this.Property(t => t.so_shpitm_cdcst).HasColumnName("so_shpitm_cdcst");
            this.Property(t => t.so_shpitm_frtcst).HasColumnName("so_shpitm_frtcst");
            this.Property(t => t.so_shpitm_mktcst).HasColumnName("so_shpitm_mktcst");
            this.Property(t => t.so_shpitm_othcst).HasColumnName("so_shpitm_othcst");
            this.Property(t => t.so_shpitm_seqkey).HasColumnName("so_shpitm_seqkey");
            this.Property(t => t.so_enduse_key).HasColumnName("so_enduse_key");
            this.Property(t => t.gl_cmp_assoc).HasColumnName("gl_cmp_assoc");
            this.Property(t => t.so_ship_entassoc).HasColumnName("so_ship_entassoc");
            this.Property(t => t.so_ship_assoc).HasColumnName("so_ship_assoc");
            this.Property(t => t.so_shpitm_assoc).HasColumnName("so_shpitm_assoc");
        }
    }
}
