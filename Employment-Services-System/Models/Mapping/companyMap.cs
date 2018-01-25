using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class companyMap : EntityTypeConfiguration<company>
    {
        public companyMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.company_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.profile_description)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.company_website_url)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("company");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.company_name).HasColumnName("company_name");
            this.Property(t => t.profile_description).HasColumnName("profile_description");
            this.Property(t => t.business_stream_id).HasColumnName("business_stream_id");
            this.Property(t => t.establishment_date).HasColumnName("establishment_date");
            this.Property(t => t.company_website_url).HasColumnName("company_website_url");

            // Relationships
            this.HasRequired(t => t.business_stream)
                .WithMany(t => t.companies)
                .HasForeignKey(d => d.business_stream_id);

        }
    }
}
