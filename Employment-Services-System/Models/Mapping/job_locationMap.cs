using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class job_locationMap : EntityTypeConfiguration<job_location>
    {
        public job_locationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.street_address)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.city)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.state)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.country)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.zip)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("job_location");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.street_address).HasColumnName("street_address");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.zip).HasColumnName("zip");
        }
    }
}
