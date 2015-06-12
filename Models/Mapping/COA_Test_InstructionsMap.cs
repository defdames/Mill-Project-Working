using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class COA_Test_InstructionsMap : EntityTypeConfiguration<COA_Test_Instructions>
    {
        public COA_Test_InstructionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.im_insmst_name, t.im_incls_key, t.im_adres_city, t.im_adres_state, t.im_insmst_key, t.en_ship_key, t.ar_ship_name, t.en_qcmst_cmnts });

            // Properties
            this.Property(t => t.im_insmst_name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_incls_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_adres_city)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.im_adres_state)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.im_insmst_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.en_ship_key)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ar_ship_name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.en_qcmst_cmnts)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("COA_Test_Instructions");
            this.Property(t => t.im_insmst_name).HasColumnName("im_insmst_name");
            this.Property(t => t.im_incls_key).HasColumnName("im_incls_key");
            this.Property(t => t.im_adres_city).HasColumnName("im_adres_city");
            this.Property(t => t.im_adres_state).HasColumnName("im_adres_state");
            this.Property(t => t.im_insmst_key).HasColumnName("im_insmst_key");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.ar_ship_name).HasColumnName("ar_ship_name");
            this.Property(t => t.en_qcmst_cmnts).HasColumnName("en_qcmst_cmnts");
        }
    }
}
