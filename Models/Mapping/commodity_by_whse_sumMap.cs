using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class commodity_by_whse_sumMap : EntityTypeConfiguration<commodity_by_whse_sum>
    {
        public commodity_by_whse_sumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemKey, t.PackKey, t.Commodity, t.GLAcct, t.ClassKey, t.PdMo, t.PdYr });

            // Properties
            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PackKey)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.UomKey)
                .HasMaxLength(2);

            this.Property(t => t.Commodity)
                .IsRequired()
                .HasMaxLength(21);

            this.Property(t => t.GLAcct)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ClassKey)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PdMo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PdYr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("commodity_by_whse_sum");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.PackKey).HasColumnName("PackKey");
            this.Property(t => t.UomKey).HasColumnName("UomKey");
            this.Property(t => t.Commodity).HasColumnName("Commodity");
            this.Property(t => t.GLAcct).HasColumnName("GLAcct");
            this.Property(t => t.ClassKey).HasColumnName("ClassKey");
            this.Property(t => t.Deca).HasColumnName("Deca");
            this.Property(t => t.Home).HasColumnName("Home");
            this.Property(t => t.Lans).HasColumnName("Lans");
            this.Property(t => t.Cle).HasColumnName("Cle");
            this.Property(t => t.Pott).HasColumnName("Pott");
            this.Property(t => t.Fwa).HasColumnName("Fwa");
            this.Property(t => t.Dtw).HasColumnName("Dtw");
            this.Property(t => t.Tide).HasColumnName("Tide");
            this.Property(t => t.Star).HasColumnName("Star");
            this.Property(t => t.Oth).HasColumnName("Oth");
            this.Property(t => t.Tot).HasColumnName("Tot");
            this.Property(t => t.PdMo).HasColumnName("PdMo");
            this.Property(t => t.PdYr).HasColumnName("PdYr");
            this.Property(t => t.Cons).HasColumnName("Cons");
        }
    }
}
