using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class basket_material_abc8Map : EntityTypeConfiguration<basket_material_abc8>
    {
        public basket_material_abc8Map()
        {
            // Primary Key
            this.HasKey(t => new { t.en_item_abcc, t.in_desc, t.en_item_sstk, t.gl_perod_year, t.gl_perod_id, t.in_item_revno });

            // Properties
            this.Property(t => t.en_item_abcc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.in_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.cmnts)
                .HasMaxLength(255);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_comcd_key)
                .HasMaxLength(21);

            this.Property(t => t.en_class_key)
                .HasMaxLength(10);

            this.Property(t => t.in_item_revno)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("basket_material_abc8");
            this.Property(t => t.en_item_abcc).HasColumnName("en_item_abcc");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_desc).HasColumnName("in_desc");
            this.Property(t => t.SumOfEndBal).HasColumnName("SumOfEndBal");
            this.Property(t => t.en_item_sstk).HasColumnName("en_item_sstk");
            this.Property(t => t.cmnts).HasColumnName("cmnts");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
            this.Property(t => t.in_comcd_key).HasColumnName("in_comcd_key");
            this.Property(t => t.en_class_key).HasColumnName("en_class_key");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.T2001).HasColumnName("T2001");
            this.Property(t => t.T2000).HasColumnName("T2000");
            this.Property(t => t.in_item_revno).HasColumnName("in_item_revno");
            this.Property(t => t.T2002).HasColumnName("T2002");
            this.Property(t => t.in_whitm_scst).HasColumnName("in_whitm_scst");
        }
    }
}
