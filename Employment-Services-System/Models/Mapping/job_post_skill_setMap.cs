using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class job_post_skill_setMap : EntityTypeConfiguration<job_post_skill_set>
    {
        public job_post_skill_setMap()
        {
            // Primary Key
            this.HasKey(t => new { t.skill_set_id, t.job_post_id });

            // Properties
            this.Property(t => t.skill_set_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.job_post_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("job_post_skill_set");
            this.Property(t => t.skill_set_id).HasColumnName("skill_set_id");
            this.Property(t => t.job_post_id).HasColumnName("job_post_id");
            this.Property(t => t.skill_level).HasColumnName("skill_level");

            // Relationships
            this.HasRequired(t => t.job_post)
                .WithMany(t => t.job_post_skill_set)
                .HasForeignKey(d => d.job_post_id);
            this.HasRequired(t => t.skill_set)
                .WithMany(t => t.job_post_skill_set)
                .HasForeignKey(d => d.skill_set_id);

        }
    }
}
