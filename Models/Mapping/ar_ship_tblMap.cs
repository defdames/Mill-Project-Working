using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ar_ship_tblMap : EntityTypeConfiguration<ar_ship_tbl>
    {
        public ar_ship_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.ar_ship_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ar_ship_taxf)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ar_tax_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_terr)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_via)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ar_ship_ctgy)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.ar_ship_tacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ar_ship_dacct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ar_ship_cmnts)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.en_stats_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_exemno)
                .HasMaxLength(25);

            this.Property(t => t.en_frgt_key)
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

            this.Property(t => t.en_frtzone_key)
                .HasMaxLength(10);

            this.Property(t => t.en_geocode_key)
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_plabelfmt)
                .HasMaxLength(20);

            this.Property(t => t.ar_ship_chlabelfmt)
                .HasMaxLength(20);

            this.Property(t => t.ar_ship_storeid)
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_cnsgnwhs)
                .HasMaxLength(4);

            this.Property(t => t.so_enduse_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ar_ship_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.ar_ship_name).HasColumnName("ar_ship_name");
            this.Property(t => t.ar_ship_taxf).HasColumnName("ar_ship_taxf");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.ar_ship_terr).HasColumnName("ar_ship_terr");
            this.Property(t => t.ar_ship_via).HasColumnName("ar_ship_via");
            this.Property(t => t.ar_ship_pri).HasColumnName("ar_ship_pri");
            this.Property(t => t.ar_ship_ctgy).HasColumnName("ar_ship_ctgy");
            this.Property(t => t.ar_ship_tacct).HasColumnName("ar_ship_tacct");
            this.Property(t => t.ar_ship_dacct).HasColumnName("ar_ship_dacct");
            this.Property(t => t.ar_ship_cmnts).HasColumnName("ar_ship_cmnts");
            this.Property(t => t.ar_ship_dyely).HasColumnName("ar_ship_dyely");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.ar_ship_snglwhs).HasColumnName("ar_ship_snglwhs");
            this.Property(t => t.ar_ship_exemno).HasColumnName("ar_ship_exemno");
            this.Property(t => t.ar_ship_exemdt).HasColumnName("ar_ship_exemdt");
            this.Property(t => t.en_frgt_key).HasColumnName("en_frgt_key");
            this.Property(t => t.en_shipprgrp_key1).HasColumnName("en_shipprgrp_key1");
            this.Property(t => t.en_shipprgrp_key2).HasColumnName("en_shipprgrp_key2");
            this.Property(t => t.en_shipprgrp_key3).HasColumnName("en_shipprgrp_key3");
            this.Property(t => t.en_shipprgrp_key4).HasColumnName("en_shipprgrp_key4");
            this.Property(t => t.en_shipprgrp_key5).HasColumnName("en_shipprgrp_key5");
            this.Property(t => t.en_shipprgrp_key6).HasColumnName("en_shipprgrp_key6");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.en_frtzone_key).HasColumnName("en_frtzone_key");
            this.Property(t => t.en_geocode_key).HasColumnName("en_geocode_key");
            this.Property(t => t.ar_ship_upcnt).HasColumnName("ar_ship_upcnt");
            this.Property(t => t.ar_ship_eprcactf).HasColumnName("ar_ship_eprcactf");
            this.Property(t => t.ar_ship_efrtactf).HasColumnName("ar_ship_efrtactf");
            this.Property(t => t.ar_ship_type).HasColumnName("ar_ship_type");
            this.Property(t => t.ar_ship_bcconfigf).HasColumnName("ar_ship_bcconfigf");
            this.Property(t => t.ar_ship_ovrridsof).HasColumnName("ar_ship_ovrridsof");
            this.Property(t => t.ar_ship_multipof).HasColumnName("ar_ship_multipof");
            this.Property(t => t.ar_ship_noprntlbs).HasColumnName("ar_ship_noprntlbs");
            this.Property(t => t.ar_ship_nochldlbs).HasColumnName("ar_ship_nochldlbs");
            this.Property(t => t.ar_ship_sndcasef).HasColumnName("ar_ship_sndcasef");
            this.Property(t => t.ar_ship_sndpltf).HasColumnName("ar_ship_sndpltf");
            this.Property(t => t.ar_ship_sndshpcntf).HasColumnName("ar_ship_sndshpcntf");
            this.Property(t => t.ar_ship_plabelfmt).HasColumnName("ar_ship_plabelfmt");
            this.Property(t => t.ar_ship_chlabelfmt).HasColumnName("ar_ship_chlabelfmt");
            this.Property(t => t.ar_ship_storeid).HasColumnName("ar_ship_storeid");
            this.Property(t => t.ar_ship_storef).HasColumnName("ar_ship_storef");
            this.Property(t => t.ar_ship_cnsgnwhs).HasColumnName("ar_ship_cnsgnwhs");
            this.Property(t => t.ar_ship_ucceanf).HasColumnName("ar_ship_ucceanf");
            this.Property(t => t.en_vatmthd_key).HasColumnName("en_vatmthd_key");
            this.Property(t => t.so_enduse_key).HasColumnName("so_enduse_key");
        }
    }
}
