using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class ap_check_sapMap : EntityTypeConfiguration<ap_check_sap>
    {
        public ap_check_sapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.InvNo, t.InvDate, t.Discount, t.Reference, t.NetAmtSGD, t.GrossAmt, t.GrossAmtSGD, t.VendorId, t.RemitId, t.RemitLine1, t.RemitLine2, t.RemitLine3, t.RemitCSZ, t.sumnet, t.sumnetsgd, t.sumdisc, t.sumgross, t.sumgrosssgd, t.gl_cmp_key, t.gl_crncy_key });

            // Properties
            this.Property(t => t.InvNo)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Reference)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.VendorId)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.RemitId)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.RemitName)
                .HasMaxLength(60);

            this.Property(t => t.RemitLine1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.RemitLine2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.RemitLine3)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.RemitCSZ)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.sumnet)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sumnetsgd)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sumdisc)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sumgross)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.sumgrosssgd)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.gl_cmp_key)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.gl_crncy_key)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("ap_check_sap");
            this.Property(t => t.CheckNo).HasColumnName("CheckNo");
            this.Property(t => t.InvNo).HasColumnName("InvNo");
            this.Property(t => t.InvDate).HasColumnName("InvDate");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.Reference).HasColumnName("Reference");
            this.Property(t => t.NetAmt).HasColumnName("NetAmt");
            this.Property(t => t.NetAmtSGD).HasColumnName("NetAmtSGD");
            this.Property(t => t.GrossAmt).HasColumnName("GrossAmt");
            this.Property(t => t.GrossAmtSGD).HasColumnName("GrossAmtSGD");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
            this.Property(t => t.CheckAmt).HasColumnName("CheckAmt");
            this.Property(t => t.CheckAmtSGD).HasColumnName("CheckAmtSGD");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.RemitId).HasColumnName("RemitId");
            this.Property(t => t.RemitName).HasColumnName("RemitName");
            this.Property(t => t.RemitLine1).HasColumnName("RemitLine1");
            this.Property(t => t.RemitLine2).HasColumnName("RemitLine2");
            this.Property(t => t.RemitLine3).HasColumnName("RemitLine3");
            this.Property(t => t.RemitCSZ).HasColumnName("RemitCSZ");
            this.Property(t => t.sumnet).HasColumnName("sumnet");
            this.Property(t => t.sumnetsgd).HasColumnName("sumnetsgd");
            this.Property(t => t.sumdisc).HasColumnName("sumdisc");
            this.Property(t => t.sumgross).HasColumnName("sumgross");
            this.Property(t => t.sumgrosssgd).HasColumnName("sumgrosssgd");
            this.Property(t => t.gl_cmp_key).HasColumnName("gl_cmp_key");
            this.Property(t => t.gl_crncy_key).HasColumnName("gl_crncy_key");
        }
    }
}
