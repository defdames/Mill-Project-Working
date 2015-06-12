using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class po_recpt_tblMap : EntityTypeConfiguration<po_recpt_tbl>
    {
        public po_recpt_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.po_recpt_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.po_recpt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.po_recpt_shpco)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_recpt_methd)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_recpt_mnfst)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_recpt_bolno)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_recpt_shprf)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_recpt_recby)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.po_recpt_remk)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.po_recpt_wtuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.en_fob_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_trnsport_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_ship_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_sales)
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_sales)
                .HasMaxLength(4);

            this.Property(t => t.en_carr_key)
                .HasMaxLength(10);

            this.Property(t => t.so_ship_logical)
                .HasMaxLength(10);

            this.Property(t => t.in_whs_unload)
                .HasMaxLength(4);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            this.Property(t => t.en_serv_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("po_recpt_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.po_recpt_key).HasColumnName("po_recpt_key");
            this.Property(t => t.po_hdr_key).HasColumnName("po_hdr_key");
            this.Property(t => t.po_recpt_shpdt).HasColumnName("po_recpt_shpdt");
            this.Property(t => t.po_recpt_recdt).HasColumnName("po_recpt_recdt");
            this.Property(t => t.po_recpt_shpco).HasColumnName("po_recpt_shpco");
            this.Property(t => t.po_recpt_methd).HasColumnName("po_recpt_methd");
            this.Property(t => t.po_recpt_mnfst).HasColumnName("po_recpt_mnfst");
            this.Property(t => t.po_recpt_bolno).HasColumnName("po_recpt_bolno");
            this.Property(t => t.po_recpt_shprf).HasColumnName("po_recpt_shprf");
            this.Property(t => t.po_recpt_recby).HasColumnName("po_recpt_recby");
            this.Property(t => t.po_recpt_remk).HasColumnName("po_recpt_remk");
            this.Property(t => t.po_recpt_boxs).HasColumnName("po_recpt_boxs");
            this.Property(t => t.po_recpt_wght).HasColumnName("po_recpt_wght");
            this.Property(t => t.po_recpt_wtuom).HasColumnName("po_recpt_wtuom");
            this.Property(t => t.po_recpt_chgdt).HasColumnName("po_recpt_chgdt");
            this.Property(t => t.po_recpt_crtdt).HasColumnName("po_recpt_crtdt");
            this.Property(t => t.po_recpt_rate).HasColumnName("po_recpt_rate");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.po_recpt_frmth).HasColumnName("po_recpt_frmth");
            this.Property(t => t.po_recpt_eustatf).HasColumnName("po_recpt_eustatf");
            this.Property(t => t.po_recpt_eustatdt).HasColumnName("po_recpt_eustatdt");
            this.Property(t => t.en_fob_key).HasColumnName("en_fob_key");
            this.Property(t => t.en_trnsport_key).HasColumnName("en_trnsport_key");
            this.Property(t => t.po_recpt_upcnt).HasColumnName("po_recpt_upcnt");
            this.Property(t => t.so_ship_key).HasColumnName("so_ship_key");
            this.Property(t => t.gl_cmp_sales).HasColumnName("gl_cmp_sales");
            this.Property(t => t.so_brnch_sales).HasColumnName("so_brnch_sales");
            this.Property(t => t.en_carr_key).HasColumnName("en_carr_key");
            this.Property(t => t.so_ship_logical).HasColumnName("so_ship_logical");
            this.Property(t => t.po_unload_key).HasColumnName("po_unload_key");
            this.Property(t => t.in_whs_unload).HasColumnName("in_whs_unload");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.en_serv_key).HasColumnName("en_serv_key");
            this.Property(t => t.po_recpt_tobase).HasColumnName("po_recpt_tobase");
            this.Property(t => t.po_recpt_tothird).HasColumnName("po_recpt_tothird");
        }
    }
}
