using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_cspxf_insMap : EntityTypeConfiguration<en_cspxf_ins>
    {
        public en_cspxf_insMap()
        {
            // Primary Key
            this.HasKey(t => new { t.en_cust_key, t.en_ship_key, t.en_prod_key, t.im_insmst_key });

            // Properties
            this.Property(t => t.en_cust_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.en_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_insmst_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sa_user_key)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("en_cspxf_ins");
            this.Property(t => t.en_cust_key).HasColumnName("en_cust_key");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.en_prod_key).HasColumnName("en_prod_key");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.im_insmst_joindt).HasColumnName("im_insmst_joindt");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
