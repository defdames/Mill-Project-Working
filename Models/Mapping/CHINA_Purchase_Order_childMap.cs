using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_Purchase_Order_childMap : EntityTypeConfiguration<CHINA_Purchase_Order_child>
    {
        public CHINA_Purchase_Order_childMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Date_ordrd, t.Date_reqrd, t.dtlHdrkey, t.Detlkey, t.ItemKey, t.Qty_ordrd, t.Descr, t.im_pack_key, t.Unit_prce, t.Wh_Key, t.gl_cmp_key });

            // Properties
            this.Property(t => t.dtlHdrkey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Detlkey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PO_key)
                .HasMaxLength(14);

            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FOb_dtl)
                .HasMaxLength(30);

            this.Property(t => t.Descr)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Wh_Key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Desctext)
                .HasMaxLength(60);

            this.Property(t => t.hdr_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_Purchase_Order_child");
            this.Property(t => t.Date_ordrd).HasColumnName("Date_ordrd");
            this.Property(t => t.Date_reqrd).HasColumnName("Date_reqrd");
            this.Property(t => t.dtlHdrkey).HasColumnName("dtlHdrkey");
            this.Property(t => t.Detlkey).HasColumnName("Detlkey");
            this.Property(t => t.PO_key).HasColumnName("PO_key");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.FOb_dtl).HasColumnName("FOb_dtl");
            this.Property(t => t.Qty_ordrd).HasColumnName("Qty_ordrd");
            this.Property(t => t.Descr).HasColumnName("Descr");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.Unit_prce).HasColumnName("Unit_prce");
            this.Property(t => t.Wh_Key).HasColumnName("Wh_Key");
            this.Property(t => t.Desctext).HasColumnName("Desctext");
            this.Property(t => t.Desc_Key).HasColumnName("Desc_Key");
            this.Property(t => t.hdr_key).HasColumnName("hdr_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
