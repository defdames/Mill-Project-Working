using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class aged_material4Map : EntityTypeConfiguration<aged_material4>
    {
        public aged_material4Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemKey, t.LotKey, t.Whse, t.Loc, t.QoH });

            // Properties
            this.Property(t => t.ItemKey)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PackKey)
                .HasMaxLength(6);

            this.Property(t => t.LotKey)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Whse)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Loc)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Commodity)
                .HasMaxLength(10);

            this.Property(t => t.ItemDes)
                .HasMaxLength(60);

            this.Property(t => t.ABCCode)
                .HasMaxLength(2);

            this.Property(t => t.UoM)
                .HasMaxLength(2);

            this.Property(t => t.ClassKey)
                .HasMaxLength(10);

            this.Property(t => t.en_grade_key)
                .HasMaxLength(10);

            this.Property(t => t.en_stats_key)
                .HasMaxLength(10);

            this.Property(t => t.in_item_revno)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("aged_material4");
            this.Property(t => t.ItemKey).HasColumnName("ItemKey");
            this.Property(t => t.PackKey).HasColumnName("PackKey");
            this.Property(t => t.LotKey).HasColumnName("LotKey");
            this.Property(t => t.Whse).HasColumnName("Whse");
            this.Property(t => t.Loc).HasColumnName("Loc");
            this.Property(t => t.QoH).HasColumnName("QoH");
            this.Property(t => t.ExtAmt).HasColumnName("ExtAmt");
            this.Property(t => t.ExtAmtLb).HasColumnName("ExtAmtLb");
            this.Property(t => t.Commodity).HasColumnName("Commodity");
            this.Property(t => t.ItemDes).HasColumnName("ItemDes");
            this.Property(t => t.ABCCode).HasColumnName("ABCCode");
            this.Property(t => t.UoM).HasColumnName("UoM");
            this.Property(t => t.ClassKey).HasColumnName("ClassKey");
            this.Property(t => t.LotDate).HasColumnName("LotDate");
            this.Property(t => t.trandate).HasColumnName("trandate");
            this.Property(t => t.en_grade_key).HasColumnName("en_grade_key");
            this.Property(t => t.an_pckablty_key).HasColumnName("an_pckablty_key");
            this.Property(t => t.en_stats_key).HasColumnName("en_stats_key");
            this.Property(t => t.in_item_revno).HasColumnName("in_item_revno");
        }
    }
}
