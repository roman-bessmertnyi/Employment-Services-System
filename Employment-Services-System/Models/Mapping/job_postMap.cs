using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class job_postMap : EntityTypeConfiguration<job_post>
    {
        public job_postMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.is_company_name_hidden)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.job_description)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.is_active)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("job_post");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.posted_by_id).HasColumnName("posted_by_id");
            this.Property(t => t.job_type_id).HasColumnName("job_type_id");
            this.Property(t => t.company_id).HasColumnName("company_id");
            this.Property(t => t.is_company_name_hidden).HasColumnName("is_company_name_hidden");
            this.Property(t => t.created_date).HasColumnName("created_date");
            this.Property(t => t.job_description).HasColumnName("job_description");
            this.Property(t => t.job_location_id).HasColumnName("job_location_id");
            this.Property(t => t.is_active).HasColumnName("is_active");

            // Relationships
            this.HasRequired(t => t.company)
                .WithMany(t => t.job_post)
                .HasForeignKey(d => d.company_id);
            this.HasRequired(t => t.job_location)
                .WithMany(t => t.job_post)
                .HasForeignKey(d => d.job_location_id);
            this.HasRequired(t => t.job_type)
                .WithMany(t => t.job_post)
                .HasForeignKey(d => d.job_type_id);
            this.HasRequired(t => t.user_account)
                .WithMany(t => t.job_post)
                .HasForeignKey(d => d.posted_by_id);

        }
    }
}
