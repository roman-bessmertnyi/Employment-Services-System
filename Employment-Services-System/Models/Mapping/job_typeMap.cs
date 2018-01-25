using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class job_typeMap : EntityTypeConfiguration<job_type>
    {
        public job_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.job_type_name)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("job_type");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.job_type_name).HasColumnName("job_type_name");
        }
    }
}
