using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class CHINA_SALES_COMMISIONSMap : EntityTypeConfiguration<CHINA_SALES_COMMISIONS>
    {
        public CHINA_SALES_COMMISIONSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GL_CMP_KEY, t.SO_HDR_KEY, t.SO_DTL_KEY, t.SO_COMTR_CMVAL, t.SO_COMTR_BOOKED, t.in_prod_key, t.ar_ivhdr_Key });

            // Properties
            this.Property(t => t.GL_CMP_KEY)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.SO_HDR_KEY)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SO_DTL_KEY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_prod_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ar_ivhdr_Key)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CHINA_SALES_COMMISIONS");
            this.Property(t => t.GL_CMP_KEY).HasColumnName("GL_CMP_KEY");
            this.Property(t => t.SO_HDR_KEY).HasColumnName("SO_HDR_KEY");
            this.Property(t => t.SO_DTL_KEY).HasColumnName("SO_DTL_KEY");
            this.Property(t => t.SO_COMTR_CMVAL).HasColumnName("SO_COMTR_CMVAL");
            this.Property(t => t.SO_COMTR_BOOKED).HasColumnName("SO_COMTR_BOOKED");
            this.Property(t => t.in_prod_key).HasColumnName("in_prod_key");
            this.Property(t => t.ar_ivhdr_Key).HasColumnName("ar_ivhdr_Key");
        }
    }
}
