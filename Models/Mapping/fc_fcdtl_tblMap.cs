using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class fc_fcdtl_tblMap : EntityTypeConfiguration<fc_fcdtl_tbl>
    {
        public fc_fcdtl_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.fc_fcst_numbr, t.fc_fcdtl_strdt, t.fc_fcdtl_bpkey });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.fc_fcst_numbr)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.fc_fcdtl_bpkey)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("fc_fcdtl_tbl");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.fc_fcst_numbr).HasColumnName("fc_fcst_numbr");
            this.Property(t => t.fc_fcdtl_strdt).HasColumnName("fc_fcdtl_strdt");
            this.Property(t => t.fc_fcdtl_bpkey).HasColumnName("fc_fcdtl_bpkey");
            this.Property(t => t.fc_fcdtl_enddt).HasColumnName("fc_fcdtl_enddt");
            this.Property(t => t.fc_fcdtl_qty).HasColumnName("fc_fcdtl_qty");
            this.Property(t => t.fc_fcdtl_acqty).HasColumnName("fc_fcdtl_acqty");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.fc_fcdtl_upcnt).HasColumnName("fc_fcdtl_upcnt");
        }
    }
}
