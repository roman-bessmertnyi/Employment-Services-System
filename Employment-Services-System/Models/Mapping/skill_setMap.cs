using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class skill_setMap : EntityTypeConfiguration<skill_set>
    {
        public skill_setMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.skill_set_name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("skill_set");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.skill_set_name).HasColumnName("skill_set_name");
        }
    }
}
