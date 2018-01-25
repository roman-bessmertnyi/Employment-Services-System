using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class View_SeekersMap : EntityTypeConfiguration<View_Seekers>
    {
        public View_SeekersMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.is_company_name_hidden, t.created_date, t.job_description, t.is_active, t.skill_level, t.job_type, t.email, t.registration_date, t.company_name, t.street_address });

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

            this.Property(t => t.skill_level)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.job_type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.company_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.street_address)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("View_Seekers");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.is_company_name_hidden).HasColumnName("is_company_name_hidden");
            this.Property(t => t.created_date).HasColumnName("created_date");
            this.Property(t => t.job_description).HasColumnName("job_description");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.skill_level).HasColumnName("skill_level");
            this.Property(t => t.job_type).HasColumnName("job_type");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.user_image).HasColumnName("user_image");
            this.Property(t => t.registration_date).HasColumnName("registration_date");
            this.Property(t => t.company_name).HasColumnName("company_name");
            this.Property(t => t.street_address).HasColumnName("street_address");
        }
    }
}
