using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class agtshp_xref_tbl_usr_oldMap : EntityTypeConfiguration<agtshp_xref_tbl_usr_old>
    {
        public agtshp_xref_tbl_usr_oldMap()
        {
            // Primary Key
            this.HasKey(t => new { t.agent_ship_id, t.idfield });

            // Properties
            this.Property(t => t.agent_ship_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.customer)
                .HasMaxLength(30);

            this.Property(t => t.location)
                .HasMaxLength(35);

            this.Property(t => t.agent)
                .HasMaxLength(2);

            this.Property(t => t.shipto)
                .HasMaxLength(10);

            this.Property(t => t.shipname)
                .HasMaxLength(30);

            this.Property(t => t.status)
                .HasMaxLength(10);

            this.Property(t => t.city)
                .HasMaxLength(20);

            this.Property(t => t.state)
                .HasMaxLength(10);

            this.Property(t => t.country)
                .HasMaxLength(20);

            this.Property(t => t.remarks)
                .HasMaxLength(40);

            this.Property(t => t.revised_msg)
                .HasMaxLength(80);

            this.Property(t => t.userid)
                .HasMaxLength(20);

            this.Property(t => t.top_customer_name)
                .HasMaxLength(20);

            this.Property(t => t.agent2)
                .HasMaxLength(2);

            this.Property(t => t.idfield)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("agtshp_xref_tbl_usr_old");
            this.Property(t => t.agent_ship_id).HasColumnName("agent_ship_id");
            this.Property(t => t.customer).HasColumnName("customer");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.agent).HasColumnName("agent");
            this.Property(t => t.shipto).HasColumnName("shipto");
            this.Property(t => t.shipname).HasColumnName("shipname");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.revised_msg).HasColumnName("revised_msg");
            this.Property(t => t.userid).HasColumnName("userid");
            this.Property(t => t.datetime_stamp).HasColumnName("datetime_stamp");
            this.Property(t => t.top_customer_name).HasColumnName("top_customer_name");
            this.Property(t => t.agent2).HasColumnName("agent2");
            this.Property(t => t.idfield).HasColumnName("idfield");
        }
    }
}
