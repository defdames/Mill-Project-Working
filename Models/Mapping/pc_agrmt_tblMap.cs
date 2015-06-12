using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class pc_agrmt_tblMap : EntityTypeConfiguration<pc_agrmt_tbl>
    {
        public pc_agrmt_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.pc_agrmt_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_agrmt_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agrmt_desc)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.pc_agrmt_exdesc)
                .HasMaxLength(255);

            this.Property(t => t.pc_type_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agrmt_aprvby)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_uom_qtylim)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.pc_agrmt_slsmgr)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pc_agrmt_slsrep)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_cust_key)
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_key)
                .HasMaxLength(10);

            this.Property(t => t.pc_agrmt_cpono)
                .HasMaxLength(25);

            this.Property(t => t.pc_agrmt_cmptnm)
                .HasMaxLength(30);

            this.Property(t => t.pc_agrmt_cmptsrc)
                .HasMaxLength(30);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.pc_agrmt_crtby)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("pc_agrmt_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.pc_agrmt_key).HasColumnName("pc_agrmt_key");
            this.Property(t => t.pc_agrmt_desc).HasColumnName("pc_agrmt_desc");
            this.Property(t => t.pc_agrmt_exdesc).HasColumnName("pc_agrmt_exdesc");
            this.Property(t => t.pc_type_key).HasColumnName("pc_type_key");
            this.Property(t => t.pc_agrmt_aprvf).HasColumnName("pc_agrmt_aprvf");
            this.Property(t => t.pc_agrmt_aprvby).HasColumnName("pc_agrmt_aprvby");
            this.Property(t => t.pc_agrmt_inact).HasColumnName("pc_agrmt_inact");
            this.Property(t => t.pc_agrmt_ordefdt).HasColumnName("pc_agrmt_ordefdt");
            this.Property(t => t.pc_agrmt_ordiadt).HasColumnName("pc_agrmt_ordiadt");
            this.Property(t => t.pc_agrmt_shpefdt).HasColumnName("pc_agrmt_shpefdt");
            this.Property(t => t.pc_agrmt_shpiadt).HasColumnName("pc_agrmt_shpiadt");
            this.Property(t => t.pc_type_limit).HasColumnName("pc_type_limit");
            this.Property(t => t.pc_agrmt_limenfat).HasColumnName("pc_agrmt_limenfat");
            this.Property(t => t.pc_agrmt_limtrkat).HasColumnName("pc_agrmt_limtrkat");
            this.Property(t => t.pc_agrmt_cuslmt).HasColumnName("pc_agrmt_cuslmt");
            this.Property(t => t.pc_agrmt_billmt).HasColumnName("pc_agrmt_billmt");
            this.Property(t => t.pc_agrmt_shplmt).HasColumnName("pc_agrmt_shplmt");
            this.Property(t => t.en_uom_qtylim).HasColumnName("en_uom_qtylim");
            this.Property(t => t.pc_agrmt_qty).HasColumnName("pc_agrmt_qty");
            this.Property(t => t.pc_agrmt_tolbasis).HasColumnName("pc_agrmt_tolbasis");
            this.Property(t => t.pc_agrmt_undtol).HasColumnName("pc_agrmt_undtol");
            this.Property(t => t.pc_agrmt_ovrtol).HasColumnName("pc_agrmt_ovrtol");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.pc_agrmt_min).HasColumnName("pc_agrmt_min");
            this.Property(t => t.pc_agrmt_max).HasColumnName("pc_agrmt_max");
            this.Property(t => t.pc_agrmt_enhsetupf).HasColumnName("pc_agrmt_enhsetupf");
            this.Property(t => t.pc_agrmt_splitf).HasColumnName("pc_agrmt_splitf");
            this.Property(t => t.pc_agrmt_slsmgr).HasColumnName("pc_agrmt_slsmgr");
            this.Property(t => t.pc_agrmt_slsrep).HasColumnName("pc_agrmt_slsrep");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.pc_agrmt_cpono).HasColumnName("pc_agrmt_cpono");
            this.Property(t => t.pc_agrmt_cmptnm).HasColumnName("pc_agrmt_cmptnm");
            this.Property(t => t.pc_agrmt_cmptsrc).HasColumnName("pc_agrmt_cmptsrc");
            this.Property(t => t.pc_agrmt_cmptdt).HasColumnName("pc_agrmt_cmptdt");
            this.Property(t => t.pc_agrmt_crtdt).HasColumnName("pc_agrmt_crtdt");
            this.Property(t => t.pc_agrmt_chgdt).HasColumnName("pc_agrmt_chgdt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
            this.Property(t => t.pc_agrmt_upcnt).HasColumnName("pc_agrmt_upcnt");
            this.Property(t => t.pc_agrmt_reprchgf).HasColumnName("pc_agrmt_reprchgf");
            this.Property(t => t.pc_agrmt_crtby).HasColumnName("pc_agrmt_crtby");
        }
    }
}
