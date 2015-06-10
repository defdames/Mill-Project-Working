using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_localxf_tblMap : EntityTypeConfiguration<im_localxf_tbl>
    {
        public im_localxf_tblMap()
        {
            // Primary Key
            this.HasKey(t => new { t.im_localgrp_key, t.im_localins_key });

            // Properties
            this.Property(t => t.im_localgrp_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.im_localins_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("im_localxf_tbl");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.im_localins_key).HasColumnName("im_localins_key");
            this.Property(t => t.im_entmst_key).HasColumnName("im_entmst_key");
        }
    }
}
