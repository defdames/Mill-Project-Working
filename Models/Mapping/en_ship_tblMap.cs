using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_ship_tblMap : EntityTypeConfiguration<en_ship_tbl>
    {
        public en_ship_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.en_ship_key);

            // Properties
            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_ship_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_ship_ctgy)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.en_ship_taxf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_ship_rslen)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_ship_via)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_comp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_ship_cmnts)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_frgt_key)
                .HasMaxLength(10);

            this.Property(t => t.en_sltyp_key)
                .HasMaxLength(10);

            this.Property(t => t.en_shipprgrp_key1)
                .HasMaxLength(10);

            this.Property(t => t.en_shipprgrp_key2)
                .HasMaxLength(10);

            this.Property(t => t.en_shipprgrp_key3)
                .HasMaxLength(10);

            this.Property(t => t.en_shipprgrp_key4)
                .HasMaxLength(10);

            this.Property(t => t.en_shipprgrp_key5)
                .HasMaxLength(10);

            this.Property(t => t.en_shipprgrp_key6)
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.en_service_key)
                .HasMaxLength(10);

            this.Property(t => t.en_ship_shpkminlbl)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_ship_shpkmaxlbl)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_ship_shpknxtlbl)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_ship_shpkinfmt)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_ship_shpkoutfmt)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_ship_plabelfmt)
                .HasMaxLength(20);

            this.Property(t => t.en_ship_chlabelfmt)
                .HasMaxLength(20);

            this.Property(t => t.en_ship_storeid)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .HasMaxLength(4);

            this.Property(t => t.en_enduse_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_ship_tbl");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.en_ship_name).HasColumnName("en_ship_name");
            this.Property(t => t.en_ship_pri).HasColumnName("en_ship_pri");
            this.Property(t => t.en_ship_ctgy).HasColumnName("en_ship_ctgy");
            this.Property(t => t.en_ship_taxf).HasColumnName("en_ship_taxf");
            this.Property(t => t.en_tax_key).HasColumnName("en_tax_key");
            this.Property(t => t.en_ship_rslen).HasColumnName("en_ship_rslen");
            this.Property(t => t.en_ship_via).HasColumnName("en_ship_via");
            this.Property(t => t.en_comp_key).HasColumnName("en_comp_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.en_ship_crtdt).HasColumnName("en_ship_crtdt");
            this.Property(t => t.en_ship_chgdt).HasColumnName("en_ship_chgdt");
            this.Property(t => t.en_ship_cmnts).HasColumnName("en_ship_cmnts");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.en_ship_dyely).HasColumnName("en_ship_dyely");
            this.Property(t => t.en_ship_intf).HasColumnName("en_ship_intf");
            this.Property(t => t.en_ship_snglwhs).HasColumnName("en_ship_snglwhs");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.en_sltyp_key).HasColumnName("en_sltyp_key");
            this.Property(t => t.en_shipprgrp_key1).HasColumnName("en_shipprgrp_key1");
            this.Property(t => t.en_shipprgrp_key2).HasColumnName("en_shipprgrp_key2");
            this.Property(t => t.en_shipprgrp_key3).HasColumnName("en_shipprgrp_key3");
            this.Property(t => t.en_shipprgrp_key4).HasColumnName("en_shipprgrp_key4");
            this.Property(t => t.en_shipprgrp_key5).HasColumnName("en_shipprgrp_key5");
            this.Property(t => t.en_shipprgrp_key6).HasColumnName("en_shipprgrp_key6");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.en_ship_shpkreqf).HasColumnName("en_ship_shpkreqf");
            this.Property(t => t.en_ship_shpkminlbl).HasColumnName("en_ship_shpkminlbl");
            this.Property(t => t.en_ship_shpkmaxlbl).HasColumnName("en_ship_shpkmaxlbl");
            this.Property(t => t.en_ship_shpknxtlbl).HasColumnName("en_ship_shpknxtlbl");
            this.Property(t => t.en_ship_shpkinfmt).HasColumnName("en_ship_shpkinfmt");
            this.Property(t => t.en_ship_shpkoutfmt).HasColumnName("en_ship_shpkoutfmt");
            this.Property(t => t.en_ship_bcconfigf).HasColumnName("en_ship_bcconfigf");
            this.Property(t => t.en_ship_ovrridsof).HasColumnName("en_ship_ovrridsof");
            this.Property(t => t.en_ship_multipof).HasColumnName("en_ship_multipof");
            this.Property(t => t.en_ship_noprntlbs).HasColumnName("en_ship_noprntlbs");
            this.Property(t => t.en_ship_nochldlbs).HasColumnName("en_ship_nochldlbs");
            this.Property(t => t.en_ship_sndcasef).HasColumnName("en_ship_sndcasef");
            this.Property(t => t.en_ship_sndpltf).HasColumnName("en_ship_sndpltf");
            this.Property(t => t.en_ship_sndshpcntf).HasColumnName("en_ship_sndshpcntf");
            this.Property(t => t.en_ship_plabelfmt).HasColumnName("en_ship_plabelfmt");
            this.Property(t => t.en_ship_chlabelfmt).HasColumnName("en_ship_chlabelfmt");
            this.Property(t => t.en_ship_storeid).HasColumnName("en_ship_storeid");
            this.Property(t => t.en_ship_storef).HasColumnName("en_ship_storef");
            this.Property(t => t.en_ship_ucceanf).HasColumnName("en_ship_ucceanf");
            this.Property(t => t.en_ship_upcnt).HasColumnName("en_ship_upcnt");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.en_enduse_key).HasColumnName("en_enduse_key");
        }
    }
}
