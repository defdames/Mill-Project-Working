using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_ingrd_tblMap : EntityTypeConfiguration<en_ingrd_tbl>
    {
        public en_ingrd_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_frmla_key, t.en_frmla_ver, t.en_ingrd_key, t.en_ingrd_io });

            // Properties
            this.Property(t => t.en_frmla_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_frmla_ver)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_ingrd_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.en_ingrd_io)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_ingrd_iotp)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.en_ingrd_uom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.en_ingrd_actuom)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.en_ingrd_sbkey)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("en_ingrd_tbl");
            this.Property(t => t.en_frmla_key).HasColumnName("en_frmla_key");
            this.Property(t => t.en_frmla_ver).HasColumnName("en_frmla_ver");
            this.Property(t => t.en_ingrd_key).HasColumnName("en_ingrd_key");
            this.Property(t => t.en_ingrd_io).HasColumnName("en_ingrd_io");
            this.Property(t => t.en_ingrd_iotp).HasColumnName("en_ingrd_iotp");
            this.Property(t => t.en_ingrd_qty).HasColumnName("en_ingrd_qty");
            this.Property(t => t.en_ingrd_uom).HasColumnName("en_ingrd_uom");
            this.Property(t => t.en_ingrd_bspc).HasColumnName("en_ingrd_bspc");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.en_ingrd_actqt).HasColumnName("en_ingrd_actqt");
            this.Property(t => t.en_ingrd_actuom).HasColumnName("en_ingrd_actuom");
            this.Property(t => t.en_ingrd_scltp).HasColumnName("en_ingrd_scltp");
            this.Property(t => t.en_ingrd_scmax).HasColumnName("en_ingrd_scmax");
            this.Property(t => t.en_ingrd_entsq).HasColumnName("en_ingrd_entsq");
            this.Property(t => t.en_ingrd_scmin).HasColumnName("en_ingrd_scmin");
            this.Property(t => t.en_ingrd_stpsz).HasColumnName("en_ingrd_stpsz");
            this.Property(t => t.en_ingrd_yld).HasColumnName("en_ingrd_yld");
            this.Property(t => t.fm_ingins_key).HasColumnName("fm_ingins_key");
            this.Property(t => t.en_ingrd_asinfctr).HasColumnName("en_ingrd_asinfctr");
            this.Property(t => t.en_ingrd_sbgrp).HasColumnName("en_ingrd_sbgrp");
            this.Property(t => t.en_ingrd_sbkey).HasColumnName("en_ingrd_sbkey");
            this.Property(t => t.en_ingrd_upcnt).HasColumnName("en_ingrd_upcnt");
            this.Property(t => t.en_ingrd_allowsubf).HasColumnName("en_ingrd_allowsubf");
        }
    }
}
