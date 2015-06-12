using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sf_ingrd_tblMap : EntityTypeConfiguration<sf_ingrd_tbl>
    {
        public sf_ingrd_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.sf_plant_key, t.sf_frmla_key, t.sf_frmla_ver, t.sf_ingrd_key, t.sf_ingrd_io });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.sf_plant_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.sf_frmla_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_frmla_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_ingrd_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sf_ingrd_io)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sf_ingrd_iotp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sf_ingrd_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.sf_ingrd_actuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.pc_pcomp_key)
                .HasMaxLength(10);

            this.Property(t => t.sf_ingrd_sbkey)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("sf_ingrd_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.sf_plant_key).HasColumnName("sf_plant_key");
            this.Property(t => t.sf_frmla_key).HasColumnName("sf_frmla_key");
            this.Property(t => t.sf_frmla_ver).HasColumnName("sf_frmla_ver");
            this.Property(t => t.sf_ingrd_key).HasColumnName("sf_ingrd_key");
            this.Property(t => t.sf_ingrd_io).HasColumnName("sf_ingrd_io");
            this.Property(t => t.sf_ingrd_iotp).HasColumnName("sf_ingrd_iotp");
            this.Property(t => t.sf_ingrd_qty).HasColumnName("sf_ingrd_qty");
            this.Property(t => t.sf_ingrd_uom).HasColumnName("sf_ingrd_uom");
            this.Property(t => t.sf_ingrd_bspc).HasColumnName("sf_ingrd_bspc");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.sf_ingrd_actqt).HasColumnName("sf_ingrd_actqt");
            this.Property(t => t.sf_ingrd_actuom).HasColumnName("sf_ingrd_actuom");
            this.Property(t => t.sf_ingrd_scltp).HasColumnName("sf_ingrd_scltp");
            this.Property(t => t.sf_ingrd_scmax).HasColumnName("sf_ingrd_scmax");
            this.Property(t => t.sf_ingrd_scmin).HasColumnName("sf_ingrd_scmin");
            this.Property(t => t.sf_ingrd_stpsz).HasColumnName("sf_ingrd_stpsz");
            this.Property(t => t.sf_ingrd_entsq).HasColumnName("sf_ingrd_entsq");
            this.Property(t => t.sf_ingrd_yld).HasColumnName("sf_ingrd_yld");
            this.Property(t => t.sf_ingrd_asinfctr).HasColumnName("sf_ingrd_asinfctr");
            this.Property(t => t.pc_pcomp_key).HasColumnName("pc_pcomp_key");
            this.Property(t => t.pc_favchdr_key).HasColumnName("pc_favchdr_key");
            this.Property(t => t.fm_ingins_key).HasColumnName("fm_ingins_key");
            this.Property(t => t.sf_ingrd_sbgrp).HasColumnName("sf_ingrd_sbgrp");
            this.Property(t => t.sf_ingrd_sbkey).HasColumnName("sf_ingrd_sbkey");
            this.Property(t => t.sf_ingrd_upcnt).HasColumnName("sf_ingrd_upcnt");
            this.Property(t => t.sf_ingrd_opyld).HasColumnName("sf_ingrd_opyld");
            this.Property(t => t.sf_ingrd_allowsubf).HasColumnName("sf_ingrd_allowsubf");
        }
    }
}
