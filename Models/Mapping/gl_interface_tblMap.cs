using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class gl_interface_tblMap : EntityTypeConfiguration<gl_interface_tbl>
    {
        public gl_interface_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_interface_seqno, t.gl_subpost_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_interface_entty)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_interface_entid)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_interface_srce)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_interface_docty)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_interface_docno)
                .HasMaxLength(10);

            this.Property(t => t.gl_interface_seqno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_acct_key)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.gl_interface_ref1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_interface_ref2)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_interface_ref3)
                .HasMaxLength(20);

            this.Property(t => t.gl_interface_ref4)
                .HasMaxLength(20);

            this.Property(t => t.gl_interface_ref5)
                .HasMaxLength(20);

            this.Property(t => t.gl_interface_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.gl_interface_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_bkcd_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.gl_subpost_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_cmp_orig)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_intface_origdoc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.gl_intface_origent)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.gl_intface_3rdpart)
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .HasMaxLength(6);

            this.Property(t => t.so_prod_key)
                .HasMaxLength(20);

            this.Property(t => t.gl_invacctgrp_key)
                .HasMaxLength(10);

            this.Property(t => t.so_brand_key)
                .HasMaxLength(20);

            this.Property(t => t.gl_misc_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("gl_interface_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_interface_entty).HasColumnName("gl_interface_entty");
            this.Property(t => t.gl_interface_entid).HasColumnName("gl_interface_entid");
            this.Property(t => t.gl_interface_srce).HasColumnName("gl_interface_srce");
            this.Property(t => t.gl_interface_docty).HasColumnName("gl_interface_docty");
            this.Property(t => t.gl_interface_docno).HasColumnName("gl_interface_docno");
            this.Property(t => t.gl_interface_seqno).HasColumnName("gl_interface_seqno");
            this.Property(t => t.gl_acct_key).HasColumnName("gl_acct_key");
            this.Property(t => t.sl_dist_key).HasColumnName("sl_dist_key");
            this.Property(t => t.gl_interface_date).HasColumnName("gl_interface_date");
            this.Property(t => t.gl_interface_postf).HasColumnName("gl_interface_postf");
            this.Property(t => t.gl_interface_upcnt).HasColumnName("gl_interface_upcnt");
            this.Property(t => t.gl_tran_key).HasColumnName("gl_tran_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.gl_interface_dbamt).HasColumnName("gl_interface_dbamt");
            this.Property(t => t.gl_interface_cramt).HasColumnName("gl_interface_cramt");
            this.Property(t => t.gl_interface_ref1).HasColumnName("gl_interface_ref1");
            this.Property(t => t.gl_interface_ref2).HasColumnName("gl_interface_ref2");
            this.Property(t => t.gl_interface_ref3).HasColumnName("gl_interface_ref3");
            this.Property(t => t.gl_interface_ref4).HasColumnName("gl_interface_ref4");
            this.Property(t => t.gl_interface_ref5).HasColumnName("gl_interface_ref5");
            this.Property(t => t.gl_interface_crtdt).HasColumnName("gl_interface_crtdt");
            this.Property(t => t.gl_perod_seqno).HasColumnName("gl_perod_seqno");
            this.Property(t => t.gl_errcd_key).HasColumnName("gl_errcd_key");
            this.Property(t => t.gl_interface_desc).HasColumnName("gl_interface_desc");
            this.Property(t => t.gl_interface_qty).HasColumnName("gl_interface_qty");
            this.Property(t => t.gl_interface_uom).HasColumnName("gl_interface_uom");
            this.Property(t => t.gl_interface_key).HasColumnName("gl_interface_key");
            this.Property(t => t.gl_interface_apprv).HasColumnName("gl_interface_apprv");
            this.Property(t => t.gl_interface_docln).HasColumnName("gl_interface_docln");
            this.Property(t => t.gl_bkcd_key).HasColumnName("gl_bkcd_key");
            this.Property(t => t.gl_bkcd_jnum).HasColumnName("gl_bkcd_jnum");
            this.Property(t => t.gl_intface_dbamtcf).HasColumnName("gl_intface_dbamtcf");
            this.Property(t => t.gl_intface_cramtcf).HasColumnName("gl_intface_cramtcf");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.gl_interface_rate).HasColumnName("gl_interface_rate");
            this.Property(t => t.gl_intface_origto3).HasColumnName("gl_intface_origto3");
            this.Property(t => t.gl_intface_tobase).HasColumnName("gl_intface_tobase");
            this.Property(t => t.gl_intface_asofdt).HasColumnName("gl_intface_asofdt");
            this.Property(t => t.gl_subpost_key).HasColumnName("gl_subpost_key");
            this.Property(t => t.gl_cmp_orig).HasColumnName("gl_cmp_orig");
            this.Property(t => t.gl_intface_origdoc).HasColumnName("gl_intface_origdoc");
            this.Property(t => t.gl_intface_origent).HasColumnName("gl_intface_origent");
            this.Property(t => t.gl_intface_intcmpf).HasColumnName("gl_intface_intcmpf");
            this.Property(t => t.gl_interface_fctf).HasColumnName("gl_interface_fctf");
            this.Property(t => t.gl_pdbal_postf).HasColumnName("gl_pdbal_postf");
            this.Property(t => t.gl_intface_3rdpart).HasColumnName("gl_intface_3rdpart");
            this.Property(t => t.gl_trace_key).HasColumnName("gl_trace_key");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.so_prod_key).HasColumnName("so_prod_key");
            this.Property(t => t.ca_lot_key).HasColumnName("ca_lot_key");
            this.Property(t => t.Ca_susp_key).HasColumnName("Ca_susp_key");
            this.Property(t => t.ca_susp_prntkey).HasColumnName("ca_susp_prntkey");
            this.Property(t => t.ca_susplink_key).HasColumnName("ca_susplink_key");
            this.Property(t => t.gl_costing_flag).HasColumnName("gl_costing_flag");
            this.Property(t => t.ca_costgllink_key).HasColumnName("ca_costgllink_key");
            this.Property(t => t.ca_costgllink_subtype).HasColumnName("ca_costgllink_subtype");
            this.Property(t => t.gl_invacctgrp_key).HasColumnName("gl_invacctgrp_key");
            this.Property(t => t.so_brand_key).HasColumnName("so_brand_key");
            this.Property(t => t.gl_misc_key).HasColumnName("gl_misc_key");
        }
    }
}
