using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_valuationMap : EntityTypeConfiguration<CHINA_valuation>
    {
        public CHINA_valuationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.in_whs_key, t.in_item_key, t.gl_perod_id, t.gl_perod_year, t.pack_key, t.in_desc, t.gl_cmp_key });

            // Properties
            this.Property(t => t.in_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.in_item_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.gl_perod_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.gl_perod_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pack_key)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.in_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.UomKey)
                .HasMaxLength(2);

            this.Property(t => t.gl_acct_desc)
                .HasMaxLength(30);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("CHINA_valuation");
            this.Property(t => t.in_whs_key).HasColumnName("in_whs_key");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.gl_perod_id).HasColumnName("gl_perod_id");
            this.Property(t => t.gl_perod_year).HasColumnName("gl_perod_year");
            this.Property(t => t.pack_key).HasColumnName("pack_key");
            this.Property(t => t.qoh).HasColumnName("qoh");
            this.Property(t => t.in_desc).HasColumnName("in_desc");
            this.Property(t => t.UomKey).HasColumnName("UomKey");
            this.Property(t => t.NoPkg).HasColumnName("NoPkg");
            this.Property(t => t.UnitCost).HasColumnName("UnitCost");
            this.Property(t => t.OrigCost).HasColumnName("OrigCost");
            this.Property(t => t.gl_acct_desc).HasColumnName("gl_acct_desc");
            this.Property(t => t.ExtCost).HasColumnName("ExtCost");
            this.Property(t => t.OrigExtCost).HasColumnName("OrigExtCost");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
