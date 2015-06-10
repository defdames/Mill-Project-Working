using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class im_localgrp_tblMap : EntityTypeConfiguration<im_localgrp_tbl>
    {
        public im_localgrp_tblMap()
        {
            // Primary Key
            this.HasKey(t => t.im_localgrp_key);

            // Properties
            // Table & Column Mappings
            this.ToTable("im_localgrp_tbl");
            this.Property(t => t.im_localgrp_key).HasColumnName("im_localgrp_key");
            this.Property(t => t.im_entmst_key).HasColumnName("im_entmst_key");
        }
    }
}
