using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class MSsubscription_agentsMap : EntityTypeConfiguration<MSsubscription_agents>
    {
        public MSsubscription_agentsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.publisher, t.publisher_db, t.publication, t.subscription_type, t.update_mode, t.failover_mode, t.spid, t.login_time, t.allow_subscription_copy, t.attach_state, t.attach_version });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.publisher)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.publisher_db)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.publication)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.subscription_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.queue_id)
                .HasMaxLength(128);

            this.Property(t => t.spid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.attach_state)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.attach_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.last_sync_summary)
                .HasMaxLength(128);

            this.Property(t => t.queue_server)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("MSsubscription_agents");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.publisher).HasColumnName("publisher");
            this.Property(t => t.publisher_db).HasColumnName("publisher_db");
            this.Property(t => t.publication).HasColumnName("publication");
            this.Property(t => t.subscription_type).HasColumnName("subscription_type");
            this.Property(t => t.queue_id).HasColumnName("queue_id");
            this.Property(t => t.update_mode).HasColumnName("update_mode");
            this.Property(t => t.failover_mode).HasColumnName("failover_mode");
            this.Property(t => t.spid).HasColumnName("spid");
            this.Property(t => t.login_time).HasColumnName("login_time");
            this.Property(t => t.allow_subscription_copy).HasColumnName("allow_subscription_copy");
            this.Property(t => t.attach_state).HasColumnName("attach_state");
            this.Property(t => t.attach_version).HasColumnName("attach_version");
            this.Property(t => t.last_sync_status).HasColumnName("last_sync_status");
            this.Property(t => t.last_sync_summary).HasColumnName("last_sync_summary");
            this.Property(t => t.last_sync_time).HasColumnName("last_sync_time");
            this.Property(t => t.queue_server).HasColumnName("queue_server");
        }
    }
}
