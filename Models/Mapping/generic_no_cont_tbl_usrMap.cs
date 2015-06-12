using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class generic_no_cont_tbl_usrMap : EntityTypeConfiguration<generic_no_cont_tbl_usr>
    {
        public generic_no_cont_tbl_usrMap()
        {
            // Primary Key
            this.HasKey(t => t.no_cont_pk);

            // Properties
            this.Property(t => t.no_cont_key)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.n_of_n)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("generic_no_cont_tbl_usr");
            this.Property(t => t.no_cont_pk).HasColumnName("no_cont_pk");
            this.Property(t => t.no_cont_key).HasColumnName("no_cont_key");
            this.Property(t => t.ctr_key).HasColumnName("ctr_key");
            this.Property(t => t.n_of_n).HasColumnName("n_of_n");
        }
    }
}
