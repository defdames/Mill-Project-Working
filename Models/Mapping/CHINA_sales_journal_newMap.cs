using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_sales_journal_newMap : EntityTypeConfiguration<CHINA_sales_journal_new>
    {
        public CHINA_sales_journal_newMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DocType, t.DocKeyType, t.ar_bill_name, t.in_prod_key, t.ar_bill_key, t.gl_cmp_key, t.section });

            // Properties
            this.Property(t => t.DocKey)
                .HasMaxLength(10);

            this.Property(t => t.DocType)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.DocKeyType)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.KeyLineType)
                .HasMaxLength(14);

            this.Property(t => t.ar_bill_name)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.in_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_hdr_key)
                .HasMaxLength(10);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.in_item_key)
                .HasMaxLength(20);

            this.Property(t => t.im_pack_key)
                .HasMaxLength(6);

            this.Property(t => t.section)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("CHINA_sales_journal_new");
            this.Property(t => t.DocKey).HasColumnName("DocKey");
            this.Property(t => t.TranDateKey).HasColumnName("TranDateKey");
            this.Property(t => t.DocType).HasColumnName("DocType");
            this.Property(t => t.DocKeyType).HasColumnName("DocKeyType");
            this.Property(t => t.KeyLineType).HasColumnName("KeyLineType");
            this.Property(t => t.ar_bill_name).HasColumnName("ar_bill_name");
            this.Property(t => t.in_prod_key).HasColumnName("in_prod_key");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.so_hdr_key).HasColumnName("so_hdr_key");
            this.Property(t => t.LineAmt).HasColumnName("LineAmt");
            this.Property(t => t.MiscAmt).HasColumnName("MiscAmt");
            this.Property(t => t.NetAmt).HasColumnName("NetAmt");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.ar_tax_amtc).HasColumnName("ar_tax_amtc");
            this.Property(t => t.in_item_key).HasColumnName("in_item_key");
            this.Property(t => t.im_pack_key).HasColumnName("im_pack_key");
            this.Property(t => t.freight).HasColumnName("freight");
            this.Property(t => t.HANDLING).HasColumnName("HANDLING");
            this.Property(t => t.INSURANCE).HasColumnName("INSURANCE");
            this.Property(t => t.section).HasColumnName("section");
        }
    }
}
