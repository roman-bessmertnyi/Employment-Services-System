using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Employment_Services_System.Models.Mapping
{
    public class user_accountMap : EntityTypeConfiguration<user_account>
    {
        public user_accountMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.password)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.gender)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.is_active)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sms_notification_active)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.email_notification_active)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("user_account");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.user_type_id).HasColumnName("user_type_id");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.date_of_birth).HasColumnName("date_of_birth");
            this.Property(t => t.gender).HasColumnName("gender");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.contact_number).HasColumnName("contact_number");
            this.Property(t => t.sms_notification_active).HasColumnName("sms_notification_active");
            this.Property(t => t.email_notification_active).HasColumnName("email_notification_active");
            this.Property(t => t.user_image).HasColumnName("user_image");
            this.Property(t => t.registration_date).HasColumnName("registration_date");

            // Relationships
            this.HasRequired(t => t.user_type)
                .WithMany(t => t.user_account)
                .HasForeignKey(d => d.user_type_id);

        }
    }
}
