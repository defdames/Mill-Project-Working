using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class in_wthdr_extMap : EntityTypeConfiguration<in_wthdr_ext>
    {
        public in_wthdr_extMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gl_cmp_key, t.in_wthdr_towhs, t.in_wthdr_key });

            // Properties
            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_wthdr_towhs)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_wthdr_key)
                .IsRequired()
                .HasMaxLength(10);

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

            this.Property(t => t.port_discharge)
                .HasMaxLength(60);

            this.Property(t => t.booknum)
                .HasMaxLength(60);

            this.Property(t => t.xvessel_name)
                .HasMaxLength(255);

            this.Property(t => t.xwport_of_loading)
                .HasMaxLength(255);

            this.Property(t => t.container_size)
                .HasMaxLength(20);

            this.Property(t => t.in_wthdr_instrux)
                .HasMaxLength(255);

            this.Property(t => t.po_number)
                .HasMaxLength(10);

            this.Property(t => t.en_mode_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("in_wthdr_ext");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.in_wthdr_towhs).HasColumnName("in_wthdr_towhs");
            this.Property(t => t.in_wthdr_key).HasColumnName("in_wthdr_key");
            this.Property(t => t.ex_ship_mark1).HasColumnName("ex_ship_mark1");
            this.Property(t => t.ex_ship_mark2).HasColumnName("ex_ship_mark2");
            this.Property(t => t.ex_ship_mark3).HasColumnName("ex_ship_mark3");
            this.Property(t => t.ex_ship_mark4).HasColumnName("ex_ship_mark4");
            this.Property(t => t.ex_ship_mark5).HasColumnName("ex_ship_mark5");
            this.Property(t => t.ex_ship_mark6).HasColumnName("ex_ship_mark6");
            this.Property(t => t.port_discharge).HasColumnName("port_discharge");
            this.Property(t => t.booknum).HasColumnName("booknum");
            this.Property(t => t.xvessel_name).HasColumnName("xvessel_name");
            this.Property(t => t.xwport_of_loading).HasColumnName("xwport_of_loading");
            this.Property(t => t.container_size).HasColumnName("container_size");
            this.Property(t => t.in_wthdr_instrux).HasColumnName("in_wthdr_instrux");
            this.Property(t => t.deliver_date).HasColumnName("deliver_date");
            this.Property(t => t.po_number).HasColumnName("po_number");
            this.Property(t => t.en_mode_key).HasColumnName("en_mode_key");
            this.Property(t => t.in_wthdr_upcnt).HasColumnName("in_wthdr_upcnt");
        }
    }
}
