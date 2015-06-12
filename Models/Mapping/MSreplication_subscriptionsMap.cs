using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class MSreplication_subscriptionsMap : EntityTypeConfiguration<MSreplication_subscriptions>
    {
        public MSreplication_subscriptionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.publisher, t.independent_agent, t.subscription_type, t.time, t.transaction_timestamp, t.update_mode, t.immediate_sync });

            // Properties
            this.Property(t => t.publisher)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.publisher_db)
                .HasMaxLength(128);

            this.Property(t => t.publication)
                .HasMaxLength(128);

            this.Property(t => t.subscription_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.distribution_agent)
                .HasMaxLength(128);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.transaction_timestamp)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.agent_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.subscription_guid)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.subid)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("MSreplication_subscriptions");
            this.Property(t => t.publisher).HasColumnName("publisher");
            this.Property(t => t.publisher_db).HasColumnName("publisher_db");
            this.Property(t => t.publication).HasColumnName("publication");
            this.Property(t => t.independent_agent).HasColumnName("independent_agent");
            this.Property(t => t.subscription_type).HasColumnName("subscription_type");
            this.Property(t => t.distribution_agent).HasColumnName("distribution_agent");
            this.Property(t => t.time).HasColumnName("time");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.transaction_timestamp).HasColumnName("transaction_timestamp");
            this.Property(t => t.update_mode).HasColumnName("update_mode");
            this.Property(t => t.agent_id).HasColumnName("agent_id");
            this.Property(t => t.subscription_guid).HasColumnName("subscription_guid");
            this.Property(t => t.subid).HasColumnName("subid");
            this.Property(t => t.immediate_sync).HasColumnName("immediate_sync");
        }
    }
}
