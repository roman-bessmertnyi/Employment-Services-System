using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class seeker_skill_setMap : EntityTypeConfiguration<seeker_skill_set>
    {
        public seeker_skill_setMap()
        {
            // Primary Key
            this.HasKey(t => new { t.user_account_id, t.skill_set_id });

            // Properties
            this.Property(t => t.user_account_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.skill_set_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("seeker_skill_set");
            this.Property(t => t.user_account_id).HasColumnName("user_account_id");
            this.Property(t => t.skill_set_id).HasColumnName("skill_set_id");
            this.Property(t => t.skill_level).HasColumnName("skill_level");

            // Relationships
            this.HasRequired(t => t.seeker_profile)
                .WithMany(t => t.seeker_skill_set)
                .HasForeignKey(d => d.user_account_id);
            this.HasRequired(t => t.skill_set)
                .WithMany(t => t.seeker_skill_set)
                .HasForeignKey(d => d.skill_set_id);

        }
    }
}
