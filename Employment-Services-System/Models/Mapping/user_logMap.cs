using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class user_logMap : EntityTypeConfiguration<user_log>
    {
        public user_logMap()
        {
            // Primary Key
            this.HasKey(t => t.user_account_id);

            // Properties
            this.Property(t => t.user_account_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("user_log");
            this.Property(t => t.user_account_id).HasColumnName("user_account_id");
            this.Property(t => t.last_login_date).HasColumnName("last_login_date");
            this.Property(t => t.last_job_apply_date).HasColumnName("last_job_apply_date");

            // Relationships
            this.HasRequired(t => t.user_account)
                .WithOptional(t => t.user_log);

        }
    }
}
