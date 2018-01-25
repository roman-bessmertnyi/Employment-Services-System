using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class company_imageMap : EntityTypeConfiguration<company_image>
    {
        public company_imageMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.company_image_image)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("company_image");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.company_id).HasColumnName("company_id");
            this.Property(t => t.company_image_image).HasColumnName("company_image_image");

            // Relationships
            this.HasRequired(t => t.company)
                .WithMany(t => t.company_image)
                .HasForeignKey(d => d.company_id);

        }
    }
}
