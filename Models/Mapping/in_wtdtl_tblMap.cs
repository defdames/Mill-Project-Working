using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_wtdtl_tblMap : EntityTypeConfiguration<in_wtdtl_tbl>
    {
        public in_wtdtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_wthdr_towhs, t.in_wthdr_key, t.in_wtdtl_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_wthdr_towhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_wthdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_wtdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_wtdtl_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.en_carr_key)
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.en_service_key)
                .HasMaxLength(10);

            this.Property(t => t.en_frgt_key)
                .HasMaxLength(10);

            this.Property(t => t.en_loadpf_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("in_wtdtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_wthdr_towhs).HasColumnName("in_wthdr_towhs");
            this.Property(t => t.in_wthdr_key).HasColumnName("in_wthdr_key");
            this.Property(t => t.in_wtdtl_key).HasColumnName("in_wtdtl_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.in_wtdtl_clsdt).HasColumnName("in_wtdtl_clsdt");
            this.Property(t => t.in_wtdtl_entdt).HasColumnName("in_wtdtl_entdt");
            this.Property(t => t.in_wtdtl_prmdt).HasColumnName("in_wtdtl_prmdt");
            this.Property(t => t.in_wtdtl_reqdt).HasColumnName("in_wtdtl_reqdt");
            this.Property(t => t.in_wtdtl_shpdt).HasColumnName("in_wtdtl_shpdt");
            this.Property(t => t.in_wtdtl_recdt).HasColumnName("in_wtdtl_recdt");
            this.Property(t => t.in_wtdtl_reqqt).HasColumnName("in_wtdtl_reqqt");
            this.Property(t => t.in_wtdtl_reqpk).HasColumnName("in_wtdtl_reqpk");
            this.Property(t => t.in_wtdtl_shpqt).HasColumnName("in_wtdtl_shpqt");
            this.Property(t => t.in_wtdtl_shppk).HasColumnName("in_wtdtl_shppk");
            this.Property(t => t.in_wtdtl_recqt).HasColumnName("in_wtdtl_recqt");
            this.Property(t => t.in_wtdtl_recpk).HasColumnName("in_wtdtl_recpk");
            this.Property(t => t.in_wtdtl_retqt).HasColumnName("in_wtdtl_retqt");
            this.Property(t => t.in_wtdtl_retpk).HasColumnName("in_wtdtl_retpk");
            this.Property(t => t.in_wtdtl_insqt).HasColumnName("in_wtdtl_insqt");
            this.Property(t => t.in_wtdtl_inspk).HasColumnName("in_wtdtl_inspk");
            this.Property(t => t.in_wtdtl_pikqt).HasColumnName("in_wtdtl_pikqt");
            this.Property(t => t.in_wtdtl_pikpk).HasColumnName("in_wtdtl_pikpk");
            this.Property(t => t.in_wtdtl_trcst).HasColumnName("in_wtdtl_trcst");
            this.Property(t => t.in_wtdtl_totaq).HasColumnName("in_wtdtl_totaq");
            this.Property(t => t.in_wtdtl_totapk).HasColumnName("in_wtdtl_totapk");
            this.Property(t => t.in_wtdtl_topik).HasColumnName("in_wtdtl_topik");
            this.Property(t => t.in_wtdtl_topikpk).HasColumnName("in_wtdtl_topikpk");
            this.Property(t => t.in_wtdtl_stat).HasColumnName("in_wtdtl_stat");
            this.Property(t => t.in_wtdtl_remk).HasColumnName("in_wtdtl_remk");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.in_wtdtl_chgdt).HasColumnName("in_wtdtl_chgdt");
            this.Property(t => t.in_wtdtl_crtdt).HasColumnName("in_wtdtl_crtdt");
            this.Property(t => t.in_wtdtl_upcnt).HasColumnName("in_wtdtl_upcnt");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.in_wtdtl_shsdt).HasColumnName("in_wtdtl_shsdt");
            this.Property(t => t.in_wtdtl_loadplf).HasColumnName("in_wtdtl_loadplf");
            this.Property(t => t.in_wtdtl_loadqt).HasColumnName("in_wtdtl_loadqt");
            this.Property(t => t.in_wtdtl_loadpk).HasColumnName("in_wtdtl_loadpk");
            this.Property(t => t.in_wtdtl_ldplqt).HasColumnName("in_wtdtl_ldplqt");
            this.Property(t => t.in_wtdtl_ldplpk).HasColumnName("in_wtdtl_ldplpk");
            this.Property(t => t.in_wtdtl_cost).HasColumnName("in_wtdtl_cost");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.in_wtdtl_costsrc).HasColumnName("in_wtdtl_costsrc");
            this.Property(t => t.in_wtdtl_recncnddf).HasColumnName("in_wtdtl_recncnddf");
            this.Property(t => t.in_wtdtl_recncqt).HasColumnName("in_wtdtl_recncqt");
            this.Property(t => t.in_wtdtl_recncpk).HasColumnName("in_wtdtl_recncpk");
            this.Property(t => t.in_wtdtl_tolstf).HasColumnName("in_wtdtl_tolstf");
            this.Property(t => t.in_wtdtl_tollif).HasColumnName("in_wtdtl_tollif");
            this.Property(t => t.in_wtdtl_tolpkf).HasColumnName("in_wtdtl_tolpkf");
            this.Property(t => t.in_wtdtl_tollof).HasColumnName("in_wtdtl_tollof");
            this.Property(t => t.in_wtdtl_tolshf).HasColumnName("in_wtdtl_tolshf");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.in_wtdtl_extcost).HasColumnName("in_wtdtl_extcost");
            this.Property(t => t.in_wtdtl_specf).HasColumnName("in_wtdtl_specf");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.in_wtdtl_nobkordf).HasColumnName("in_wtdtl_nobkordf");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.en_loadpf_key).HasColumnName("en_loadpf_key");
        }
    }
}
