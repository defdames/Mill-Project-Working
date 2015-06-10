using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_load_tblMap : EntityTypeConfiguration<so_load_tbl>
    {
        public so_load_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_whs_key, t.so_load_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_load_key)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.en_carr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_loadpf_key)
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_service_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_load_ref)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_load_appttm)
                .HasMaxLength(5);

            this.Property(t => t.so_load_awtuom)
                .HasMaxLength(2);

            this.Property(t => t.so_load_ewtuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_load_railct)
                .HasMaxLength(20);

            this.Property(t => t.so_load_rout)
                .HasMaxLength(20);

            this.Property(t => t.so_load_pronum)
                .HasMaxLength(30);

            this.Property(t => t.so_load_vechid)
                .HasMaxLength(10);

            this.Property(t => t.so_load_trailerid)
                .HasMaxLength(20);

            this.Property(t => t.so_load_routedesc)
                .HasMaxLength(60);

            this.Property(t => t.so_load_msgtext)
                .HasMaxLength(255);

            this.Property(t => t.gl_cmp_assoc)
                .HasMaxLength(2);

            this.Property(t => t.in_whs_assoc)
                .HasMaxLength(4);

            this.Property(t => t.so_load_assoc)
                .HasMaxLength(35);

            this.Property(t => t.en_carr_orig)
                .HasMaxLength(10);

            this.Property(t => t.en_carr_chgby)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("so_load_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.so_load_key).HasColumnName("so_load_key");
            this.Property(t => t.so_ship_date).HasColumnName("so_ship_date");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.en_loadpf_key).HasColumnName("en_loadpf_key");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_service_key).HasColumnName("en_service_key");
            this.Property(t => t.so_load_ref).HasColumnName("so_load_ref");
            this.Property(t => t.so_load_state).HasColumnName("so_load_state");
            this.Property(t => t.so_load_appttm).HasColumnName("so_load_appttm");
            this.Property(t => t.so_load_actwt).HasColumnName("so_load_actwt");
            this.Property(t => t.so_load_awtuom).HasColumnName("so_load_awtuom");
            this.Property(t => t.so_load_estwt).HasColumnName("so_load_estwt");
            this.Property(t => t.so_load_ewtuom).HasColumnName("so_load_ewtuom");
            this.Property(t => t.so_load_eqwt).HasColumnName("so_load_eqwt");
            this.Property(t => t.so_load_leqwt).HasColumnName("so_load_leqwt");
            this.Property(t => t.so_load_railct).HasColumnName("so_load_railct");
            this.Property(t => t.so_load_rout).HasColumnName("so_load_rout");
            this.Property(t => t.so_load_pronum).HasColumnName("so_load_pronum");
            this.Property(t => t.so_load_drctf).HasColumnName("so_load_drctf");
            this.Property(t => t.so_load_carrf).HasColumnName("so_load_carrf");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.so_load_vechid).HasColumnName("so_load_vechid");
            this.Property(t => t.so_load_trailerid).HasColumnName("so_load_trailerid");
            this.Property(t => t.so_load_avouchf).HasColumnName("so_load_avouchf");
            this.Property(t => t.so_load_routedesc).HasColumnName("so_load_routedesc");
            this.Property(t => t.so_load_upcnt).HasColumnName("so_load_upcnt");
            this.Property(t => t.so_load_msgtext).HasColumnName("so_load_msgtext");
            this.Property(t => t.gl_cmp_assoc).HasColumnName("gl_cmp_assoc");
            this.Property(t => t.in_whs_assoc).HasColumnName("in_whs_assoc");
            this.Property(t => t.so_load_assoc).HasColumnName("so_load_assoc");
            this.Property(t => t.en_carr_orig).HasColumnName("en_carr_orig");
            this.Property(t => t.en_carr_chgby).HasColumnName("en_carr_chgby");
            this.Property(t => t.en_carr_chgdt).HasColumnName("en_carr_chgdt");
        }
    }
}
