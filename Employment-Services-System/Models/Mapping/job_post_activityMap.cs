using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class job_post_activityMap : EntityTypeConfiguration<job_post_activity>
    {
        public job_post_activityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.user_account_id, t.job_post_id });

            // Properties
            this.Property(t => t.user_account_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.job_post_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("job_post_activity");
            this.Property(t => t.user_account_id).HasColumnName("user_account_id");
            this.Property(t => t.job_post_id).HasColumnName("job_post_id");
            this.Property(t => t.apply_date).HasColumnName("apply_date");

            // Relationships
            this.HasRequired(t => t.job_post)
                .WithMany(t => t.job_post_activity)
                .HasForeignKey(d => d.job_post_id);
            this.HasRequired(t => t.user_account)
                .WithMany(t => t.job_post_activity)
                .HasForeignKey(d => d.user_account_id);

        }
    }
}
