using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_ship_tblMap : EntityTypeConfiguration<so_ship_tbl>
    {
        public so_ship_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_ship_entity, t.so_ship_key, t.so_ship_ordtp });

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

            this.Property(t => t.so_ship_dmdid)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_ship_bolno)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.so_ship_remks)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ar_ivhdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_cmp_dmd)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_ship_dmdent)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_icshp_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_load_key)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.so_ship_wtuom)
                .HasMaxLength(2);

            this.Property(t => t.so_ship_prcwtuom)
                .HasMaxLength(2);

            this.Property(t => t.so_ship_frgtshpuom)
                .HasMaxLength(2);

            this.Property(t => t.ap_vchr_key)
                .HasMaxLength(10);

            this.Property(t => t.so_ship_tofrgtzn)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_ship_pronum)
                .HasMaxLength(30);

            this.Property(t => t.so_ship_overclass)
                .HasMaxLength(10);

            this.Property(t => t.en_frtclass_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_ship_apcrncy)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_cmp_assoc)
                .HasMaxLength(2);

            this.Property(t => t.so_ship_entassoc)
                .HasMaxLength(4);

            this.Property(t => t.so_ship_assoc)
                .HasMaxLength(10);

            this.Property(t => t.so_enduse_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("so_ship_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_ship_entity).HasColumnName("so_ship_entity");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.so_ship_ordtp).HasColumnName("so_ship_ordtp");
            this.Property(t => t.so_ship_dmdid).HasColumnName("so_ship_dmdid");
            this.Property(t => t.comp_date_key).HasColumnName("comp_date_key");
            this.Property(t => t.so_ship_pri).HasColumnName("so_ship_pri");
            this.Property(t => t.so_ship_bolno).HasColumnName("so_ship_bolno");
            this.Property(t => t.so_ship_remks).HasColumnName("so_ship_remks");
            this.Property(t => t.ar_ivhdr_key).HasColumnName("ar_ivhdr_key");
            this.Property(t => t.gl_tran_key).HasColumnName("gl_tran_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.gl_cmp_dmd).HasColumnName("gl_cmp_dmd");
            this.Property(t => t.so_ship_dmdent).HasColumnName("so_ship_dmdent");
            this.Property(t => t.so_icshp_key).HasColumnName("so_icshp_key");
            this.Property(t => t.so_load_key).HasColumnName("so_load_key");
            this.Property(t => t.so_ship_actwt).HasColumnName("so_ship_actwt");
            this.Property(t => t.so_ship_frgtwt).HasColumnName("so_ship_frgtwt");
            this.Property(t => t.so_ship_wtuom).HasColumnName("so_ship_wtuom");
            this.Property(t => t.so_ship_adjfl).HasColumnName("so_ship_adjfl");
            this.Property(t => t.so_ship_date).HasColumnName("so_ship_date");
            this.Property(t => t.so_ship_prcwtuom).HasColumnName("so_ship_prcwtuom");
            this.Property(t => t.so_ship_frgtshipwt).HasColumnName("so_ship_frgtshipwt");
            this.Property(t => t.so_ship_frgtshpuom).HasColumnName("so_ship_frgtshpuom");
            this.Property(t => t.ap_vchr_key).HasColumnName("ap_vchr_key");
            this.Property(t => t.gl_apcnv_rate).HasColumnName("gl_apcnv_rate");
            this.Property(t => t.gl_arcnv_rate).HasColumnName("gl_arcnv_rate");
            this.Property(t => t.so_ship_autofrcmbf).HasColumnName("so_ship_autofrcmbf");
            this.Property(t => t.so_ship_tofrgtzn).HasColumnName("so_ship_tofrgtzn");
            this.Property(t => t.so_ship_pronum).HasColumnName("so_ship_pronum");
            this.Property(t => t.so_ship_drctf).HasColumnName("so_ship_drctf");
            this.Property(t => t.so_ship_overclass).HasColumnName("so_ship_overclass");
            this.Property(t => t.en_frtclass_key).HasColumnName("en_frtclass_key");
            this.Property(t => t.so_ship_ogroprcwt).HasColumnName("so_ship_ogroprcwt");
            this.Property(t => t.so_ship_onetprcwt).HasColumnName("so_ship_onetprcwt");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.so_ship_prcorddt).HasColumnName("so_ship_prcorddt");
            this.Property(t => t.so_ship_prcshpdt).HasColumnName("so_ship_prcshpdt");
            this.Property(t => t.so_ship_eustat).HasColumnName("so_ship_eustat");
            this.Property(t => t.so_ship_eustatdt).HasColumnName("so_ship_eustatdt");
            this.Property(t => t.so_ship_apcrncy).HasColumnName("so_ship_apcrncy");
            this.Property(t => t.so_ship_upcnt).HasColumnName("so_ship_upcnt");
            this.Property(t => t.so_ship_recptdt).HasColumnName("so_ship_recptdt");
            this.Property(t => t.so_ship_aporigto3).HasColumnName("so_ship_aporigto3");
            this.Property(t => t.so_ship_aptobase).HasColumnName("so_ship_aptobase");
            this.Property(t => t.so_ship_arorigto3).HasColumnName("so_ship_arorigto3");
            this.Property(t => t.so_ship_artobase).HasColumnName("so_ship_artobase");
            this.Property(t => t.so_ship_autoinvf).HasColumnName("so_ship_autoinvf");
            this.Property(t => t.gl_cmp_assoc).HasColumnName("gl_cmp_assoc");
            this.Property(t => t.so_ship_entassoc).HasColumnName("so_ship_entassoc");
            this.Property(t => t.so_ship_assoc).HasColumnName("so_ship_assoc");
            this.Property(t => t.so_xivnum_key).HasColumnName("so_xivnum_key");
            this.Property(t => t.so_enduse_key).HasColumnName("so_enduse_key");
        }
    }
}
