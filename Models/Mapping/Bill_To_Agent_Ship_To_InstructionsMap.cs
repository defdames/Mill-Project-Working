using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Bill_To_Agent_Ship_To_InstructionsMap : EntityTypeConfiguration<Bill_To_Agent_Ship_To_Instructions>
    {
        public Bill_To_Agent_Ship_To_InstructionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_ship_key, t.ar_ship_name, t.shiptocity, t.shiptostate, t.ar_bill_key, t.billname, t.billtocity, t.billtostate, t.so_salsm_key, t.im_incls_key, t.im_insmst_key, t.im_insmst_name, t.text_value, t.gl_cmp_key });

            // Properties
            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.shiptocity)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.shiptostate)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_bill_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.billname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.billtocity)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.billtostate)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.so_salsm_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_incls_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_insmst_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_insmst_name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.text_value)
                .IsRequired()
                .HasMaxLength(1786);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Bill_To_Agent_Ship_To_Instructions");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.ar_ship_name).HasColumnName("ar_ship_name");
            this.Property(t => t.shiptocity).HasColumnName("shiptocity");
            this.Property(t => t.shiptostate).HasColumnName("shiptostate");
            this.Property(t => t.ar_bill_key).HasColumnName("ar_bill_key");
            this.Property(t => t.billname).HasColumnName("billname");
            this.Property(t => t.billtocity).HasColumnName("billtocity");
            this.Property(t => t.billtostate).HasColumnName("billtostate");
            this.Property(t => t.so_salsm_key).HasColumnName("so_salsm_key");
            this.Property(t => t.im_incls_key).HasColumnName("im_incls_key");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.im_insmst_name).HasColumnName("im_insmst_name");
            this.Property(t => t.text_value).HasColumnName("text_value");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
        }
    }
}
