using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class seeker_profileMap : EntityTypeConfiguration<seeker_profile>
    {
        public seeker_profileMap()
        {
            // Primary Key
            this.HasKey(t => t.user_account_id);

            // Properties
            this.Property(t => t.user_account_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.first_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.last_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.is_annually_monthly)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.currency)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("seeker_profile");
            this.Property(t => t.user_account_id).HasColumnName("user_account_id");
            this.Property(t => t.first_name).HasColumnName("first_name");
            this.Property(t => t.last_name).HasColumnName("last_name");
            this.Property(t => t.current_salary).HasColumnName("current_salary");
            this.Property(t => t.is_annually_monthly).HasColumnName("is_annually_monthly");
            this.Property(t => t.currency).HasColumnName("currency");

            // Relationships
            this.HasRequired(t => t.user_account)
                .WithOptional(t => t.seeker_profile);

        }
    }
}
