using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class tblSpecPriceLogMap : EntityTypeConfiguration<tblSpecPriceLog>
    {
        public tblSpecPriceLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.AGENT)
                .HasMaxLength(255);

            this.Property(t => t.CUSTOMER)
                .HasMaxLength(255);

            this.Property(t => t.LOCATION)
                .HasMaxLength(255);

            this.Property(t => t.GRADE)
                .HasMaxLength(255);

            this.Property(t => t.PRICE_LB_PACK)
                .HasMaxLength(255);

            this.Property(t => t.QUANTITY)
                .HasMaxLength(255);

            this.Property(t => t.MS_MM)
                .HasMaxLength(255);

            this.Property(t => t.COMMENTS)
                .HasMaxLength(255);

            this.Property(t => t.AGENT_NAME)
                .HasMaxLength(255);

            this.Property(t => t.COPIES)
                .HasMaxLength(255);

            this.Property(t => t.MANAGER)
                .HasMaxLength(255);

            this.Property(t => t.LINK_FIELD)
                .HasMaxLength(255);

            this.Property(t => t.CONTRACT_NO)
                .HasMaxLength(255);

            this.Property(t => t.CUSTOMER_NO)
                .HasMaxLength(255);

            this.Property(t => t.CUSTOMER_LABEL)
                .HasMaxLength(50);

            this.Property(t => t.LOCATION_LABEL)
                .HasMaxLength(50);

            this.Property(t => t.AGREEMENT_ID)
                .HasMaxLength(50);

            this.Property(t => t.AGREEMENT_DESCRIPTION)
                .HasMaxLength(50);

            this.Property(t => t.PRODUCT_NO)
                .HasMaxLength(50);

            this.Property(t => t.FIXED_BASED_PRICE)
                .HasMaxLength(50);

            this.Property(t => t.ALLOW_PROMO)
                .HasMaxLength(50);

            this.Property(t => t.SOLD_BILL_SHIP)
                .HasMaxLength(50);

            this.Property(t => t.BREAKS)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tblSpecPriceLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EFFECT).HasColumnName("EFFECT");
            this.Property(t => t.AGENT).HasColumnName("AGENT");
            this.Property(t => t.CUSTOMER).HasColumnName("CUSTOMER");
            this.Property(t => t.LOCATION).HasColumnName("LOCATION");
            this.Property(t => t.GRADE).HasColumnName("GRADE");
            this.Property(t => t.PRICE_LB_PACK).HasColumnName("PRICE LB PACK");
            this.Property(t => t.QUANTITY).HasColumnName("QUANTITY");
            this.Property(t => t.EXPIRES).HasColumnName("EXPIRES");
            this.Property(t => t.MS_MM).HasColumnName("MS MM");
            this.Property(t => t.COMMENTS).HasColumnName("COMMENTS");
            this.Property(t => t.AGENT_NAME).HasColumnName("AGENT NAME");
            this.Property(t => t.COPIES).HasColumnName("COPIES");
            this.Property(t => t.MANAGER).HasColumnName("MANAGER");
            this.Property(t => t.LINK_FIELD).HasColumnName("LINK FIELD");
            this.Property(t => t.CONTRACT_NO).HasColumnName("CONTRACT NO");
            this.Property(t => t.CUSTOMER_NO).HasColumnName("CUSTOMER NO");
            this.Property(t => t.CUSTOMER_LABEL).HasColumnName("CUSTOMER LABEL");
            this.Property(t => t.LOCATION_LABEL).HasColumnName("LOCATION LABEL");
            this.Property(t => t.AGREEMENT_ID).HasColumnName("AGREEMENT ID");
            this.Property(t => t.AGREEMENT_DESCRIPTION).HasColumnName("AGREEMENT DESCRIPTION");
            this.Property(t => t.PRODUCT_NO).HasColumnName("PRODUCT NO");
            this.Property(t => t.FIXED_BASED_PRICE).HasColumnName("FIXED BASED PRICE");
            this.Property(t => t.ALLOW_PROMO).HasColumnName("ALLOW PROMO");
            this.Property(t => t.SOLD_BILL_SHIP).HasColumnName("SOLD BILL SHIP");
            this.Property(t => t.BREAKS).HasColumnName("BREAKS");
        }
    }
}
