using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class Chinese_Account_MapMap : EntityTypeConfiguration<Chinese_Account_Map>
    {
        public Chinese_Account_MapMap()
        {
            // Primary Key
            this.HasKey(t => t.TOPRINT);

            // Properties
            this.Property(t => t.ORGACCOUNT)
                .HasMaxLength(255);

            this.Property(t => t.ACCOUNTNO)
                .HasMaxLength(255);

            this.Property(t => t.ACCOUNTNO1)
                .HasMaxLength(255);

            this.Property(t => t.ACCOUNTNAME)
                .HasMaxLength(255);

            this.Property(t => t.ACCOUNTNAME1)
                .HasMaxLength(255);

            this.Property(t => t.ACCOUNTNAME2)
                .HasMaxLength(255);

            this.Property(t => t.TOPRINT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Chinese_Account_Map");
            this.Property(t => t.ORGACCOUNT).HasColumnName("ORGACCOUNT");
            this.Property(t => t.ACCOUNTNO).HasColumnName("ACCOUNTNO");
            this.Property(t => t.ACCOUNTNO1).HasColumnName("ACCOUNTNO1");
            this.Property(t => t.ACCOUNTNO2).HasColumnName("ACCOUNTNO2");
            this.Property(t => t.ACCOUNTNAME).HasColumnName("ACCOUNTNAME");
            this.Property(t => t.ACCOUNTNAME1).HasColumnName("ACCOUNTNAME1");
            this.Property(t => t.ACCOUNTNAME2).HasColumnName("ACCOUNTNAME2");
            this.Property(t => t.TOPRINT).HasColumnName("TOPRINT");
        }
    }
}
