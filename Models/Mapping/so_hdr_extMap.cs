using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class so_hdr_extMap : EntityTypeConfiguration<so_hdr_ext>
    {
        public so_hdr_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.so_brnch_key, t.so_hdr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.so_brnch_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.so_hdr_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_instrux)
                .HasMaxLength(255);

            this.Property(t => t.ex_ship_mark1)
                .HasMaxLength(60);

            this.Property(t => t.ex_ship_mark2)
                .HasMaxLength(40);

            this.Property(t => t.ex_ship_mark3)
                .HasMaxLength(40);

            this.Property(t => t.ex_ship_mark4)
                .HasMaxLength(40);

            this.Property(t => t.ex_ship_mark5)
                .HasMaxLength(40);

            this.Property(t => t.ex_ship_mark6)
                .HasMaxLength(40);

            this.Property(t => t.ex_dimensions1)
                .HasMaxLength(40);

            this.Property(t => t.ex_dimensions2)
                .HasMaxLength(40);

            this.Property(t => t.ex_dimensions3)
                .HasMaxLength(40);

            this.Property(t => t.ex_dimensions4)
                .HasMaxLength(40);

            this.Property(t => t.ex_ship)
                .HasMaxLength(30);

            this.Property(t => t.ex_via)
                .HasMaxLength(30);

            this.Property(t => t.ex_pay_terms)
                .HasMaxLength(255);

            this.Property(t => t.ex_sales_terms)
                .HasMaxLength(40);

            this.Property(t => t.ltd_direct_ship)
                .HasMaxLength(6);

            this.Property(t => t.so_hdr_spec_instrux)
                .HasMaxLength(999);

            this.Property(t => t.so_hdr_enclosure)
                .HasMaxLength(255);

            this.Property(t => t.floor_load)
                .HasMaxLength(30);

            this.Property(t => t.so_hdr_port_discharge)
                .HasMaxLength(60);

            this.Property(t => t.so_hdr_booknum)
                .HasMaxLength(60);

            this.Property(t => t.ex_ship_container)
                .HasMaxLength(30);

            this.Property(t => t.xvessel_name)
                .HasMaxLength(255);

            this.Property(t => t.xvoyage_number)
                .HasMaxLength(255);

            this.Property(t => t.xwport_of_loading)
                .HasMaxLength(255);

            this.Property(t => t.zord_ack)
                .HasMaxLength(255);

            this.Property(t => t.zsmx_doc)
                .HasMaxLength(30);

            this.Property(t => t.zitn)
                .HasMaxLength(30);

            this.Property(t => t.container_size)
                .HasMaxLength(20);

            this.Property(t => t.marks_remarks)
                .HasMaxLength(100);

            this.Property(t => t.zcontact)
                .HasMaxLength(35);

            this.Property(t => t.seal_number)
                .HasMaxLength(35);

            this.Property(t => t.inter_complete)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("so_hdr_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.so_brnch_key).HasColumnName("so_brnch_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.so_hdr_instrux).HasColumnName("so_hdr_instrux");
            this.Property(t => t.ex_ship_mark1).HasColumnName("ex_ship_mark1");
            this.Property(t => t.ex_ship_mark2).HasColumnName("ex_ship_mark2");
            this.Property(t => t.ex_ship_mark3).HasColumnName("ex_ship_mark3");
            this.Property(t => t.ex_ship_mark4).HasColumnName("ex_ship_mark4");
            this.Property(t => t.ex_ship_mark5).HasColumnName("ex_ship_mark5");
            this.Property(t => t.ex_ship_mark6).HasColumnName("ex_ship_mark6");
            this.Property(t => t.ex_dimensions1).HasColumnName("ex_dimensions1");
            this.Property(t => t.ex_dimensions2).HasColumnName("ex_dimensions2");
            this.Property(t => t.ex_dimensions3).HasColumnName("ex_dimensions3");
            this.Property(t => t.ex_dimensions4).HasColumnName("ex_dimensions4");
            this.Property(t => t.ex_ship).HasColumnName("ex_ship");
            this.Property(t => t.ex_via).HasColumnName("ex_via");
            this.Property(t => t.ex_pay_terms).HasColumnName("ex_pay_terms");
            this.Property(t => t.ex_sales_terms).HasColumnName("ex_sales_terms");
            this.Property(t => t.ltd_direct_ship).HasColumnName("ltd_direct_ship");
            this.Property(t => t.so_hdr_spec_instrux).HasColumnName("so_hdr_spec_instrux");
            this.Property(t => t.so_hdr_enclosure).HasColumnName("so_hdr_enclosure");
            this.Property(t => t.so_hdr_pallets).HasColumnName("so_hdr_pallets");
            this.Property(t => t.floor_load).HasColumnName("floor_load");
            this.Property(t => t.so_hdr_port_discharge).HasColumnName("so_hdr_port_discharge");
            this.Property(t => t.so_hdr_secshipto).HasColumnName("so_hdr_secshipto");
            this.Property(t => t.so_hdr_booknum).HasColumnName("so_hdr_booknum");
            this.Property(t => t.ex_ship_container).HasColumnName("ex_ship_container");
            this.Property(t => t.xvessel_name).HasColumnName("xvessel_name");
            this.Property(t => t.xvoyage_number).HasColumnName("xvoyage_number");
            this.Property(t => t.xwport_of_loading).HasColumnName("xwport_of_loading");
            this.Property(t => t.zord_ack).HasColumnName("zord_ack");
            this.Property(t => t.zsmx_doc).HasColumnName("zsmx_doc");
            this.Property(t => t.zitn).HasColumnName("zitn");
            this.Property(t => t.container_size).HasColumnName("container_size");
            this.Property(t => t.marks_remarks).HasColumnName("marks_remarks");
            this.Property(t => t.deliver_date).HasColumnName("deliver_date");
            this.Property(t => t.zcontact).HasColumnName("zcontact");
            this.Property(t => t.seal_number).HasColumnName("seal_number");
            this.Property(t => t.so_hdr_upcnt).HasColumnName("so_hdr_upcnt");
            this.Property(t => t.inter_complete).HasColumnName("inter_complete");
            this.Property(t => t.so_hdr_shsdt).HasColumnName("so_hdr_shsdt");
        }
    }
}
