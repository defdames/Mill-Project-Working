using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class generic_reportsMap : EntityTypeConfiguration<generic_reports>
    {
        public generic_reportsMap()
        {
            // Primary Key
            this.HasKey(t => t.user);

            // Properties
            this.Property(t => t.user)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.f1)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f2)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f3)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f4)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f5)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f6)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f7)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f8)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f9)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f10)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f11)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f12)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f13)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f14)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.f15)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("generic_reports");
            this.Property(t => t.user).HasColumnName("user");
            this.Property(t => t.f1).HasColumnName("f1");
            this.Property(t => t.f2).HasColumnName("f2");
            this.Property(t => t.f3).HasColumnName("f3");
            this.Property(t => t.f4).HasColumnName("f4");
            this.Property(t => t.f5).HasColumnName("f5");
            this.Property(t => t.f6).HasColumnName("f6");
            this.Property(t => t.f7).HasColumnName("f7");
            this.Property(t => t.f8).HasColumnName("f8");
            this.Property(t => t.f9).HasColumnName("f9");
            this.Property(t => t.f10).HasColumnName("f10");
            this.Property(t => t.f11).HasColumnName("f11");
            this.Property(t => t.f12).HasColumnName("f12");
            this.Property(t => t.f13).HasColumnName("f13");
            this.Property(t => t.f14).HasColumnName("f14");
            this.Property(t => t.f15).HasColumnName("f15");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
