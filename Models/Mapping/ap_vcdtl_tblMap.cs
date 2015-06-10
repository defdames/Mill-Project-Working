using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_vcdtl_tblMap : EntityTypeConfiguration<ap_vcdtl_tbl>
    {
        public ap_vcdtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.ap_vchr_type, t.ap_vchr_key, t.ap_vcdtl_line });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ap_vchr_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ap_vchr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_vcdtl_line)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_recpt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_resn_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ap_vcdtl_ref)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ap_vcdtl_mnprf)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ap_vcdtl_stats)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.prog_name)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sa_uid_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ap_vcdtl_remk)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.uom_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_load_key)
                .HasMaxLength(35);

            this.Property(t => t.so_ship_key)
                .HasMaxLength(10);

            this.Property(t => t.en_1099_key)
                .HasMaxLength(10);

            this.Property(t => t.ar_tax_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_vatcd_key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ap_vcdtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.ap_vchr_type).HasColumnName("ap_vchr_type");
            this.Property(t => t.ap_vchr_key).HasColumnName("ap_vchr_key");
            this.Property(t => t.ap_vcdtl_line).HasColumnName("ap_vcdtl_line");
            this.Property(t => t.ap_vcdtl_upcnt).HasColumnName("ap_vcdtl_upcnt");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.po_recpt_key).HasColumnName("po_recpt_key");
            this.Property(t => t.po_dtl_key).HasColumnName("po_dtl_key");
            this.Property(t => t.ap_vcdtl_invqt).HasColumnName("ap_vcdtl_invqt");
            this.Property(t => t.ap_vcdtl_iunitc).HasColumnName("ap_vcdtl_iunitc");
            this.Property(t => t.ap_vcdtl_dedt).HasColumnName("ap_vcdtl_dedt");
            this.Property(t => t.ap_resn_key).HasColumnName("ap_resn_key");
            this.Property(t => t.ap_vcdtl_ref).HasColumnName("ap_vcdtl_ref");
            this.Property(t => t.ap_vcdtl_manpy).HasColumnName("ap_vcdtl_manpy");
            this.Property(t => t.ap_vcdtl_mnprf).HasColumnName("ap_vcdtl_mnprf");
            this.Property(t => t.ap_vcdtl_iunitcf).HasColumnName("ap_vcdtl_iunitcf");
            this.Property(t => t.ap_vcdtl_stats).HasColumnName("ap_vcdtl_stats");
            this.Property(t => t.prog_name).HasColumnName("prog_name");
            this.Property(t => t.sa_uid_key).HasColumnName("sa_uid_key");
            this.Property(t => t.tty_num).HasColumnName("tty_num");
            this.Property(t => t.ap_vcdtl_remk).HasColumnName("ap_vcdtl_remk");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.uom_key).HasColumnName("uom_key");
            this.Property(t => t.ap_vchr_stock).HasColumnName("ap_vchr_stock");
            this.Property(t => t.ap_vcdtl_adjfl).HasColumnName("ap_vcdtl_adjfl");
            this.Property(t => t.so_load_key).HasColumnName("so_load_key");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.ap_vcdtl_miscc).HasColumnName("ap_vcdtl_miscc");
            this.Property(t => t.ap_vcdtl_misccf).HasColumnName("ap_vcdtl_misccf");
            this.Property(t => t.en_vend_1099f).HasColumnName("en_vend_1099f");
            this.Property(t => t.en_1099_key).HasColumnName("en_1099_key");
            this.Property(t => t.ap_vcdtl_taxf).HasColumnName("ap_vcdtl_taxf");
            this.Property(t => t.ap_vcdtl_slsusef).HasColumnName("ap_vcdtl_slsusef");
            this.Property(t => t.ar_tax_key).HasColumnName("ar_tax_key");
            this.Property(t => t.gl_vatcd_key).HasColumnName("gl_vatcd_key");
            this.Property(t => t.gl_vatrate_pct).HasColumnName("gl_vatrate_pct");
            this.Property(t => t.ap_vcdtl_vatc).HasColumnName("ap_vcdtl_vatc");
            this.Property(t => t.ap_vcdtl_vatcf).HasColumnName("ap_vcdtl_vatcf");
            this.Property(t => t.ap_vcdtl_frtinvc).HasColumnName("ap_vcdtl_frtinvc");
            this.Property(t => t.ap_vcdtl_frtcadjc).HasColumnName("ap_vcdtl_frtcadjc");
            this.Property(t => t.ap_vcdtl_othinvc).HasColumnName("ap_vcdtl_othinvc");
            this.Property(t => t.ap_vcdtl_othcadjc).HasColumnName("ap_vcdtl_othcadjc");
            this.Property(t => t.ap_vcdtl_matinvc).HasColumnName("ap_vcdtl_matinvc");
            this.Property(t => t.ap_vcdtl_matcadjc).HasColumnName("ap_vcdtl_matcadjc");
            this.Property(t => t.ap_vcdtl_cmpwtqty).HasColumnName("ap_vcdtl_cmpwtqty");
            this.Property(t => t.ap_vcdtl_morelessf).HasColumnName("ap_vcdtl_morelessf");
            this.Property(t => t.ap_vcdtl_crtdt).HasColumnName("ap_vcdtl_crtdt");
            this.Property(t => t.ap_vcdtl_chgdt).HasColumnName("ap_vcdtl_chgdt");
        }
    }
}
