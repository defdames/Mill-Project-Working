using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_checkMap : EntityTypeConfiguration<ap_check>
    {
        public ap_checkMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CheckNo, t.InvNo, t.InvDate, t.Discount, t.Reference, t.RemitName, t.RemitLine1, t.gl_cmp_key, t.void });

            // Properties
            this.Property(t => t.CheckNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvNo)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Reference)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.VendorId)
                .HasMaxLength(10);

            this.Property(t => t.RemitId)
                .HasMaxLength(10);

            this.Property(t => t.RemitName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.RemitLine1)
                .IsRequired()
                .HasMaxLength(67);

            this.Property(t => t.RemitLine2)
                .HasMaxLength(67);

            this.Property(t => t.RemitLine3)
                .HasMaxLength(67);

            this.Property(t => t.RemitCSZ)
                .HasMaxLength(67);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.void)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ap_check");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.InvNo).HasColumnName("InvNo");
            this.Property(t => t.InvDate).HasColumnName("InvDate");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.Reference).HasColumnName("Reference");
            this.Property(t => t.NetAmt).HasColumnName("NetAmt");
            this.Property(t => t.GrossAmt).HasColumnName("GrossAmt");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
            this.Property(t => t.CheckAmt).HasColumnName("CheckAmt");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.RemitId).HasColumnName("RemitId");
            this.Property(t => t.RemitName).HasColumnName("RemitName");
            this.Property(t => t.RemitLine1).HasColumnName("RemitLine1");
            this.Property(t => t.RemitLine2).HasColumnName("RemitLine2");
            this.Property(t => t.RemitLine3).HasColumnName("RemitLine3");
            this.Property(t => t.RemitCSZ).HasColumnName("RemitCSZ");
            this.Property(t => t.sumnet).HasColumnName("sumnet");
            this.Property(t => t.sumdisc).HasColumnName("sumdisc");
            this.Property(t => t.sumgross).HasColumnName("sumgross");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.void).HasColumnName("void");
        }
    }
}
