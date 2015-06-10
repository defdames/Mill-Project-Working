using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class otif_dashboard_detail_daily_pictureMap : EntityTypeConfiguration<otif_dashboard_detail_daily_picture>
    {
        public otif_dashboard_detail_daily_pictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.otif, t.so_dtl_shsdt, t.so_dtl_reqdt, t.OrderNo, t.in_prod_key, t.ar_ship_key, t.so_dtl_entdt, t.so_dtl_prmdt, t.en_item_key, t.im_pack_key, t.gl_cmp_key, t.gl_crncy_key, t.so_dtl_key, t.top_customer_name, t.so_dtl_ordqt, t.so_dtl_shpqt, t.so_hdr_cpono, t.sa_created_by, t.sa_modified_by, t.salesmgr, t.so_dtl_shpws });

            // Properties
            this.Property(t => t.monthtime)
                .HasMaxLength(30);

            this.Property(t => t.weektime)
                .HasMaxLength(34);

            this.Property(t => t.otif)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Type)
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .HasMaxLength(10);

            this.Property(t => t.in_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ar_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_ship_name)
                .HasMaxLength(30);

            this.Property(t => t.so_dtl_stats)
                .HasMaxLength(14);

            this.Property(t => t.en_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_city)
                .HasMaxLength(20);

            this.Property(t => t.im_adres_state)
                .HasMaxLength(10);

            this.Property(t => t.prod_status)
                .HasMaxLength(10);

            this.Property(t => t.im_pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.so_dtl_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.top_customer_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_hdr_cpono)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.sa_created_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sa_modified_by)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.salesmgr)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.so_dtl_shpws)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.en_cntry_key)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("otif_dashboard_detail_daily_picture");
            this.Property(t => t.monthtime).HasColumnName("monthtime");
            this.Property(t => t.weektime).HasColumnName("weektime");
            this.Property(t => t.otif).HasColumnName("otif");
            this.Property(t => t.so_dtl_shsdt).HasColumnName("so_dtl_shsdt");
            this.Property(t => t.so_dtl_reqdt).HasColumnName("so_dtl_reqdt");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.Dollars).HasColumnName("Dollars");
            this.Property(t => t.Pounds).HasColumnName("Pounds");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.so_dtl_shpdt).HasColumnName("so_dtl_shpdt");
            this.Property(t => t.in_prod_key).HasColumnName("in_prod_key");
            this.Property(t => t.ar_ship_key).HasColumnName("ar_ship_key");
            this.Property(t => t.en_ship_name).HasColumnName("en_ship_name");
            this.Property(t => t.so_dtl_entdt).HasColumnName("so_dtl_entdt");
            this.Property(t => t.so_dtl_prmdt).HasColumnName("so_dtl_prmdt");
            this.Property(t => t.so_dtl_stats).HasColumnName("so_dtl_stats");
            this.Property(t => t.en_item_key).HasColumnName("en_item_key");
            this.Property(t => t.im_adres_city).HasColumnName("im_adres_city");
            this.Property(t => t.im_adres_state).HasColumnName("im_adres_state");
            this.Property(t => t.prod_status).HasColumnName("prod_status");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
            this.Property(t => t.so_dtl_key).HasColumnName("so_dtl_key");
            this.Property(t => t.top_customer_name).HasColumnName("top_customer_name");
            this.Property(t => t.so_dtl_ordqt).HasColumnName("so_dtl_ordqt");
            this.Property(t => t.so_dtl_shpqt).HasColumnName("so_dtl_shpqt");
            this.Property(t => t.so_hdr_cpono).HasColumnName("so_hdr_cpono");
            this.Property(t => t.sa_created_by).HasColumnName("sa_created_by");
            this.Property(t => t.sa_modified_by).HasColumnName("sa_modified_by");
            this.Property(t => t.salesmgr).HasColumnName("salesmgr");
            this.Property(t => t.so_dtl_shpws).HasColumnName("so_dtl_shpws");
            this.Property(t => t.en_cntry_key).HasColumnName("en_cntry_key");
            this.Property(t => t.daysdiff).HasColumnName("daysdiff");
        }
    }
}
