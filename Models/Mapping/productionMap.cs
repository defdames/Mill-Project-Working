using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class productionMap : EntityTypeConfiguration<production>
    {
        public productionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.date, t.item });

            // Properties
            this.Property(t => t.system)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.item)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.grade)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.feed)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.plant)
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("production");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.system).HasColumnName("system");
            this.Property(t => t.item).HasColumnName("item");
            this.Property(t => t.grade).HasColumnName("grade");
            this.Property(t => t.mtlpermillhr).HasColumnName("mtlpermillhr");
            this.Property(t => t.stdpermillhr).HasColumnName("stdpermillhr");
            this.Property(t => t.percofstd).HasColumnName("percofstd");
            this.Property(t => t.avgpastepermillhr).HasColumnName("avgpastepermillhr");
            this.Property(t => t.metalin).HasColumnName("metalin");
            this.Property(t => t.metalout).HasColumnName("metalout");
            this.Property(t => t.tothrsavail).HasColumnName("tothrsavail");
            this.Property(t => t.tothrsrun).HasColumnName("tothrsrun");
            this.Property(t => t.gain1).HasColumnName("gain1");
            this.Property(t => t.percruneff).HasColumnName("percruneff");
            this.Property(t => t.days).HasColumnName("days");
            this.Property(t => t.percvol1).HasColumnName("percvol1");
            this.Property(t => t.percyeild).HasColumnName("percyeild");
            this.Property(t => t.pastefrommills).HasColumnName("pastefrommills");
            this.Property(t => t.feed).HasColumnName("feed");
            this.Property(t => t.mills).HasColumnName("mills");
            this.Property(t => t.shifts).HasColumnName("shifts");
            this.Property(t => t.pasteperday).HasColumnName("pasteperday");
            this.Property(t => t.basketmaterial).HasColumnName("basketmaterial");
            this.Property(t => t.basketmaterialsame).HasColumnName("basketmaterialsame");
            this.Property(t => t.basketmaterialoth).HasColumnName("basketmaterialoth");
            this.Property(t => t.basketmaterialutot).HasColumnName("basketmaterialutot");
            this.Property(t => t.gain2).HasColumnName("gain2");
            this.Property(t => t.noofmills).HasColumnName("noofmills");
            this.Property(t => t.filtercakewt).HasColumnName("filtercakewt");
            this.Property(t => t.numberoffc).HasColumnName("numberoffc");
            this.Property(t => t.weightperfc).HasColumnName("weightperfc");
            this.Property(t => t.percvol2).HasColumnName("percvol2");
            this.Property(t => t.hrspermill).HasColumnName("hrspermill");
            this.Property(t => t.poundsmetalpermill).HasColumnName("poundsmetalpermill");
            this.Property(t => t.poundsmperhronfc).HasColumnName("poundsmperhronfc");
            this.Property(t => t.metalbatchsize).HasColumnName("metalbatchsize");
            this.Property(t => t.classhrs).HasColumnName("classhrs");
            this.Property(t => t.plant).HasColumnName("plant");
        }
    }
}
