using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class whsxfer_packing_list_sriMap : EntityTypeConfiguration<whsxfer_packing_list_sri>
    {
        public whsxfer_packing_list_sriMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_wthdr_key, t.in_wthdr_crtdt, t.in_wthdr_towhs, t.in_wthdr_frwhs, t.in_wtdtl_stat, t.in_wtdtl_key, t.in_wtdtl_shsdt, t.in_wtdtl_reqqt, t.in_wtdtl_shpqt, t.in_desc, t.in_item_key, t.en_frtitem_key, t.HdrKey, t.ItemKey, t.FrWhsLine1, t.ToWhsLine1, t.NoPkg, t.OrdrQty, t.fromname, t.toname, t.gl_cmp_key });

            // Properties
            this.Property(t => t.in_wthdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.in_wthdr_towhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_wthdr_frwhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_wtdtl_stat)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_wtdtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ItemDesc)
                .HasMaxLength(60);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Item)
                .HasMaxLength(27);

            this.Property(t => t.en_frtitem_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HdrKey)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.LineRemark)
                .HasMaxLength(188);

            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(27);

            this.Property(t => t.LotKey)
                .HasMaxLength(25);

            this.Property(t => t.InsNo)
                .HasMaxLength(12);

            this.Property(t => t.Remarks)
                .HasMaxLength(60);

            this.Property(t => t.FrWhsLine1)
                .IsRequired()
                .HasMaxLength(44);

            this.Property(t => t.FrWhsLine2)
                .HasMaxLength(44);

            this.Property(t => t.FrWhsCSZ)
                .HasMaxLength(44);

            this.Property(t => t.ToWhsLine1)
                .IsRequired()
                .HasMaxLength(44);

            this.Property(t => t.ToWhsLine2)
                .HasMaxLength(66);

            this.Property(t => t.ToWhsCSZ)
                .HasMaxLength(66);

            this.Property(t => t.UoM)
                .HasMaxLength(2);

            this.Property(t => t.LineNbr)
                .HasMaxLength(17);

            this.Property(t => t.CarrDesc)
                .HasMaxLength(20);

            this.Property(t => t.fromname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.toname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("whsxfer_packing_list_sri");
            this.Property(t => t.in_wthdr_key).HasColumnName("in_wthdr_key");
            this.Property(t => t.in_wthdr_crtdt).HasColumnName("in_wthdr_crtdt");
            this.Property(t => t.in_wthdr_towhs).HasColumnName("in_wthdr_towhs");
            this.Property(t => t.in_wthdr_frwhs).HasColumnName("in_wthdr_frwhs");
            this.Property(t => t.in_wtdtl_stat).HasColumnName("in_wtdtl_stat");
            this.Property(t => t.in_wtdtl_key).HasColumnName("in_wtdtl_key");
            this.Property(t => t.in_wtdtl_shsdt).HasColumnName("in_wtdtl_shsdt");
            this.Property(t => t.in_wtdtl_reqqt).HasColumnName("in_wtdtl_reqqt");
            this.Property(t => t.in_wtdtl_shpqt).HasColumnName("in_wtdtl_shpqt");
            this.Property(t => t.in_desc).HasColumnName("in_desc");
            this.Property(t => t.ItemDesc).HasColumnName("ItemDesc");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.Item).HasColumnName("Item");
            this.Property(t => t.en_frtitem_key).HasColumnName("en_frtitem_key");
            this.Property(t => t.HdrKey).HasColumnName("HdrKey");
            this.Property(t => t.LineRemark).HasColumnName("LineRemark");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.LotKey).HasColumnName("LotKey");
            this.Property(t => t.InsNo).HasColumnName("InsNo");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.FrWhsLine1).HasColumnName("FrWhsLine1");
            this.Property(t => t.FrWhsLine2).HasColumnName("FrWhsLine2");
            this.Property(t => t.FrWhsCSZ).HasColumnName("FrWhsCSZ");
            this.Property(t => t.ToWhsLine1).HasColumnName("ToWhsLine1");
            this.Property(t => t.ToWhsLine2).HasColumnName("ToWhsLine2");
            this.Property(t => t.ToWhsCSZ).HasColumnName("ToWhsCSZ");
            this.Property(t => t.UoM).HasColumnName("UoM");
            this.Property(t => t.NoPkg).HasColumnName("NoPkg");
            this.Property(t => t.OrdrQty).HasColumnName("OrdrQty");
            this.Property(t => t.ShipQty).HasColumnName("ShipQty");
            this.Property(t => t.LineNbr).HasColumnName("LineNbr");
            this.Property(t => t.CarrDesc).HasColumnName("CarrDesc");
            this.Property(t => t.fromname).HasColumnName("fromname");
            this.Property(t => t.toname).HasColumnName("toname");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
