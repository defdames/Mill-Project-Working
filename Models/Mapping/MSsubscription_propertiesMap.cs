using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class MSsubscription_propertiesMap : EntityTypeConfiguration<MSsubscription_properties>
    {
        public MSsubscription_propertiesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.publisher, t.publication, t.publication_type, t.publisher_security_mode, t.distributor_security_mode, t.use_ftp, t.dts_package_location, t.enabled_for_syncmgr, t.offload_agent, t.use_web_sync, t.internet_security_mode, t.internet_timeout });

            // Properties
            this.Property(t => t.publisher)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.publisher_db)
                .HasMaxLength(128);

            this.Property(t => t.publication)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.publication_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.publisher_login)
                .HasMaxLength(128);

            this.Property(t => t.publisher_password)
                .HasMaxLength(524);

            this.Property(t => t.publisher_security_mode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.distributor)
                .HasMaxLength(128);

            this.Property(t => t.distributor_login)
                .HasMaxLength(128);

            this.Property(t => t.distributor_password)
                .HasMaxLength(524);

            this.Property(t => t.distributor_security_mode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ftp_address)
                .HasMaxLength(128);

            this.Property(t => t.ftp_login)
                .HasMaxLength(128);

            this.Property(t => t.ftp_password)
                .HasMaxLength(524);

            this.Property(t => t.alt_snapshot_folder)
                .HasMaxLength(255);

            this.Property(t => t.working_directory)
                .HasMaxLength(255);

            this.Property(t => t.dts_package_name)
                .HasMaxLength(128);

            this.Property(t => t.dts_package_password)
                .HasMaxLength(524);

            this.Property(t => t.dts_package_location)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.offload_server)
                .HasMaxLength(128);

            this.Property(t => t.dynamic_snapshot_location)
                .HasMaxLength(255);

            this.Property(t => t.internet_url)
                .HasMaxLength(260);

            this.Property(t => t.internet_login)
                .HasMaxLength(128);

            this.Property(t => t.internet_password)
                .HasMaxLength(524);

            this.Property(t => t.internet_security_mode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.internet_timeout)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hostname)
                .HasMaxLength(128);

            this.Property(t => t.publisherlink)
                .HasMaxLength(128);

            this.Property(t => t.publisherlinkuser)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("MSsubscription_properties");
            this.Property(t => t.publisher).HasColumnName("publisher");
            this.Property(t => t.publisher_db).HasColumnName("publisher_db");
            this.Property(t => t.publication).HasColumnName("publication");
            this.Property(t => t.publication_type).HasColumnName("publication_type");
            this.Property(t => t.publisher_login).HasColumnName("publisher_login");
            this.Property(t => t.publisher_password).HasColumnName("publisher_password");
            this.Property(t => t.publisher_security_mode).HasColumnName("publisher_security_mode");
            this.Property(t => t.distributor).HasColumnName("distributor");
            this.Property(t => t.distributor_login).HasColumnName("distributor_login");
            this.Property(t => t.distributor_password).HasColumnName("distributor_password");
            this.Property(t => t.distributor_security_mode).HasColumnName("distributor_security_mode");
            this.Property(t => t.ftp_address).HasColumnName("ftp_address");
            this.Property(t => t.ftp_port).HasColumnName("ftp_port");
            this.Property(t => t.ftp_login).HasColumnName("ftp_login");
            this.Property(t => t.ftp_password).HasColumnName("ftp_password");
            this.Property(t => t.alt_snapshot_folder).HasColumnName("alt_snapshot_folder");
            this.Property(t => t.working_directory).HasColumnName("working_directory");
            this.Property(t => t.use_ftp).HasColumnName("use_ftp");
            this.Property(t => t.dts_package_name).HasColumnName("dts_package_name");
            this.Property(t => t.dts_package_password).HasColumnName("dts_package_password");
            this.Property(t => t.dts_package_location).HasColumnName("dts_package_location");
            this.Property(t => t.enabled_for_syncmgr).HasColumnName("enabled_for_syncmgr");
            this.Property(t => t.offload_agent).HasColumnName("offload_agent");
            this.Property(t => t.offload_server).HasColumnName("offload_server");
            this.Property(t => t.dynamic_snapshot_location).HasColumnName("dynamic_snapshot_location");
            this.Property(t => t.use_web_sync).HasColumnName("use_web_sync");
            this.Property(t => t.internet_url).HasColumnName("internet_url");
            this.Property(t => t.internet_login).HasColumnName("internet_login");
            this.Property(t => t.internet_password).HasColumnName("internet_password");
            this.Property(t => t.internet_security_mode).HasColumnName("internet_security_mode");
            this.Property(t => t.internet_timeout).HasColumnName("internet_timeout");
            this.Property(t => t.hostname).HasColumnName("hostname");
            this.Property(t => t.publisherlink).HasColumnName("publisherlink");
            this.Property(t => t.publisherlinkuser).HasColumnName("publisherlinkuser");
            this.Property(t => t.job_step_uid).HasColumnName("job_step_uid");
        }
    }
}
