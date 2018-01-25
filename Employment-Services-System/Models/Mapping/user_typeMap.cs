using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class user_typeMap : EntityTypeConfiguration<user_type>
    {
        public user_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.user_type_name)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("user_type");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.user_type_name).HasColumnName("user_type_name");
        }
    }
}
