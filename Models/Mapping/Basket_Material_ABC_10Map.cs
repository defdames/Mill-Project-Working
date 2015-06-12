using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Basket_Material_ABC_10Map : EntityTypeConfiguration<Basket_Material_ABC_10>
    {
        public Basket_Material_ABC_10Map()
        {
            // Primary Key
            this.HasKey(t => new { t.en_item_abcc, t.in_desc, t.en_item_sstk, t.gl_perod_year, t.gl_perod_id });

            // Properties
            this.Property(t => t.en_item_abcc)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.in_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Basket_Material_ABC_10");
            this.Property(t => t.en_item_abcc).HasColumnName("en_item_abcc");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.in_desc).HasColumnName("in_desc");
            this.Property(t => t.SumOfEndBal).HasColumnName("SumOfEndBal");
            this.Property(t => t.en_item_sstk).HasColumnName("en_item_sstk");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
        }
    }
}
