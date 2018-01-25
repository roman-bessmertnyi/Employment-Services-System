using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class business_streamMap : EntityTypeConfiguration<business_stream>
    {
        public business_streamMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.business_stream_name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("business_stream");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.business_stream_name).HasColumnName("business_stream_name");
        }
    }
}
