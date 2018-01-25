using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class experience_detailMap : EntityTypeConfiguration<experience_detail>
    {
        public experience_detailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.user_account_id, t.start_date, t.end_date });

            // Properties
            this.Property(t => t.user_account_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.is_current_job)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.job_title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.company_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.job_location_city)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.job_location_state)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.job_location_country)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("experience_detail");
            this.Property(t => t.user_account_id).HasColumnName("user_account_id");
            this.Property(t => t.is_current_job).HasColumnName("is_current_job");
            this.Property(t => t.start_date).HasColumnName("start_date");
            this.Property(t => t.end_date).HasColumnName("end_date");
            this.Property(t => t.job_title).HasColumnName("job_title");
            this.Property(t => t.company_name).HasColumnName("company_name");
            this.Property(t => t.job_location_city).HasColumnName("job_location_city");
            this.Property(t => t.job_location_state).HasColumnName("job_location_state");
            this.Property(t => t.job_location_country).HasColumnName("job_location_country");
            this.Property(t => t.description).HasColumnName("description");

            // Relationships
            this.HasRequired(t => t.seeker_profile)
                .WithMany(t => t.experience_detail)
                .HasForeignKey(d => d.user_account_id);

        }
    }
}
