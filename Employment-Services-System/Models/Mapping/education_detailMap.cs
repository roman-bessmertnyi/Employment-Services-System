using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class education_detailMap : EntityTypeConfiguration<education_detail>
    {
        public education_detailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.user_account_id, t.certificate_degree_name, t.major });

            // Properties
            this.Property(t => t.user_account_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.certificate_degree_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.major)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.institute_university_name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("education_detail");
            this.Property(t => t.user_account_id).HasColumnName("user_account_id");
            this.Property(t => t.certificate_degree_name).HasColumnName("certificate_degree_name");
            this.Property(t => t.major).HasColumnName("major");
            this.Property(t => t.institute_university_name).HasColumnName("institute_university_name");
            this.Property(t => t.starting_date).HasColumnName("starting_date");
            this.Property(t => t.completion_date).HasColumnName("completion_date");
            this.Property(t => t.percentage).HasColumnName("percentage");
            this.Property(t => t.cgpa).HasColumnName("cgpa");

            // Relationships
            this.HasRequired(t => t.seeker_profile)
                .WithMany(t => t.education_detail)
                .HasForeignKey(d => d.user_account_id);

        }
    }
}
