using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class sa_usrgrp_tblMap : EntityTypeConfiguration<sa_usrgrp_tbl>
    {
        public sa_usrgrp_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sa_group_key, t.sa_user_key });

            // Properties
            this.Property(t => t.sa_group_key)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.sa_user_key)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("sa_usrgrp_tbl");
            this.Property(t => t.sa_group_key).HasColumnName("sa_group_key");
            this.Property(t => t.sa_user_key).HasColumnName("sa_user_key");
        }
    }
}
