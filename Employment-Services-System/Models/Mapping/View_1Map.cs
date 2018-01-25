using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class View_1Map : EntityTypeConfiguration<View_1>
    {
        public View_1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.job_type, t.company_name, t.job_description, t.street_address });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.job_type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.company_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.job_description)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.street_address)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.skill_set_name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("View_1");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.job_type).HasColumnName("job_type");
            this.Property(t => t.company_name).HasColumnName("company_name");
            this.Property(t => t.job_description).HasColumnName("job_description");
            this.Property(t => t.street_address).HasColumnName("street_address");
            this.Property(t => t.skill_level).HasColumnName("skill_level");
            this.Property(t => t.skill_set_name).HasColumnName("skill_set_name");
        }
    }
}
