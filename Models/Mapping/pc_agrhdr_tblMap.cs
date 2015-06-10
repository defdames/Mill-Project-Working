using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pc_agrhdr_tblMap : EntityTypeConfiguration<pc_agrhdr_tbl>
    {
        public pc_agrhdr_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pc_agrmt_key, t.pc_agrhdr_ppcind, t.pc_agrhdr_prod, t.pc_agrhdr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_agrmt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agrhdr_ppcind)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pc_agrhdr_prod)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.pc_agrhdr_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pc_agrhdr_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.pc_agrhdr_cmnts)
                .HasMaxLength(255);

            this.Property(t => t.en_uom_qtylim)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_agrhdr_brkuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_agrhdr_bpruom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_uom_analuom)
                .HasMaxLength(2);

            this.Property(t => t.pc_bsprhd_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_frtclass_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agrhdr_inzone)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agrhdr_sfzone)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agrhdr_stzone)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_whs_key)
                .HasMaxLength(4);

            this.Property(t => t.sf_plant_key)
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.pc_agrhdr_cmptftrm)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agrhdr_cmptuom)
                .HasMaxLength(2);

            this.Property(t => t.gl_cmp_ship)
                .HasMaxLength(2);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("pc_agrhdr_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pc_agrmt_key).HasColumnName("pc_agrmt_key");
            this.Property(t => t.pc_agrhdr_ppcind).HasColumnName("pc_agrhdr_ppcind");
            this.Property(t => t.pc_agrhdr_prod).HasColumnName("pc_agrhdr_prod");
            this.Property(t => t.pc_agrhdr_key).HasColumnName("pc_agrhdr_key");
            this.Property(t => t.pc_agrhdr_desc).HasColumnName("pc_agrhdr_desc");
            this.Property(t => t.pc_agrhdr_cmnts).HasColumnName("pc_agrhdr_cmnts");
            this.Property(t => t.pc_agrhdr_inact).HasColumnName("pc_agrhdr_inact");
            this.Property(t => t.pc_agrhdr_ordefff).HasColumnName("pc_agrhdr_ordefff");
            this.Property(t => t.pc_agrhdr_ordefdt).HasColumnName("pc_agrhdr_ordefdt");
            this.Property(t => t.pc_agrhdr_ordiadt).HasColumnName("pc_agrhdr_ordiadt");
            this.Property(t => t.pc_agrhdr_shpefff).HasColumnName("pc_agrhdr_shpefff");
            this.Property(t => t.pc_agrhdr_shpefdt).HasColumnName("pc_agrhdr_shpefdt");
            this.Property(t => t.pc_agrhdr_shpiadt).HasColumnName("pc_agrhdr_shpiadt");
            this.Property(t => t.pc_agrhdr_brkbasis).HasColumnName("pc_agrhdr_brkbasis");
            this.Property(t => t.pc_agrhdr_brktyp).HasColumnName("pc_agrhdr_brktyp");
            this.Property(t => t.en_uom_qtylim).HasColumnName("en_uom_qtylim");
            this.Property(t => t.pc_agrhdr_qty).HasColumnName("pc_agrhdr_qty");
            this.Property(t => t.pc_agrhdr_tolbasis).HasColumnName("pc_agrhdr_tolbasis");
            this.Property(t => t.pc_agrhdr_undtol).HasColumnName("pc_agrhdr_undtol");
            this.Property(t => t.pc_agrhdr_ovrtol).HasColumnName("pc_agrhdr_ovrtol");
            this.Property(t => t.pc_agrhdr_brkuom).HasColumnName("pc_agrhdr_brkuom");
            this.Property(t => t.pc_agrhdr_min).HasColumnName("pc_agrhdr_min");
            this.Property(t => t.pc_agrhdr_max).HasColumnName("pc_agrhdr_max");
            this.Property(t => t.pc_agrhdr_bprind).HasColumnName("pc_agrhdr_bprind");
            this.Property(t => t.pc_agrhdr_bpruom).HasColumnName("pc_agrhdr_bpruom");
            this.Property(t => t.pc_agrhdr_basepr).HasColumnName("pc_agrhdr_basepr");
            this.Property(t => t.en_uom_analuom).HasColumnName("en_uom_analuom");
            this.Property(t => t.pc_agrhdr_analqty).HasColumnName("pc_agrhdr_analqty");
            this.Property(t => t.pc_agrhdr_aoneqty).HasColumnName("pc_agrhdr_aoneqty");
            this.Property(t => t.pc_agrhdr_allowpr).HasColumnName("pc_agrhdr_allowpr");
            this.Property(t => t.pc_agrhdr_allwdpaf).HasColumnName("pc_agrhdr_allwdpaf");
            this.Property(t => t.pc_agrhdr_prcactf).HasColumnName("pc_agrhdr_prcactf");
            this.Property(t => t.pc_agrhdr_frgactf).HasColumnName("pc_agrhdr_frgactf");
            this.Property(t => t.pc_agrhdr_splitf).HasColumnName("pc_agrhdr_splitf");
            this.Property(t => t.pc_agrhdr_cfprcf).HasColumnName("pc_agrhdr_cfprcf");
            this.Property(t => t.pc_bsprhd_key).HasColumnName("pc_bsprhd_key");
            this.Property(t => t.en_frtclass_key).HasColumnName("en_frtclass_key");
            this.Property(t => t.pc_agrhdr_inzone).HasColumnName("pc_agrhdr_inzone");
            this.Property(t => t.pc_agrhdr_sfzone).HasColumnName("pc_agrhdr_sfzone");
            this.Property(t => t.pc_agrhdr_stzone).HasColumnName("pc_agrhdr_stzone");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.pc_agrhdr_cmptftrm).HasColumnName("pc_agrhdr_cmptftrm");
            this.Property(t => t.pc_agrhdr_cmptuom).HasColumnName("pc_agrhdr_cmptuom");
            this.Property(t => t.pc_agrhdr_cmptprc).HasColumnName("pc_agrhdr_cmptprc");
            this.Property(t => t.gl_cmp_ship).HasColumnName("gl_cmp_ship");
            this.Property(t => t.pc_agrhdr_crtdt).HasColumnName("pc_agrhdr_crtdt");
            this.Property(t => t.pc_agrhdr_chgdt).HasColumnName("pc_agrhdr_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.pc_agrhdr_upcnt).HasColumnName("pc_agrhdr_upcnt");
            this.Property(t => t.pc_agrhdr_reprchgf).HasColumnName("pc_agrhdr_reprchgf");
        }
    }
}
