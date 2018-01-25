using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Employment_Services_System.Models.Mapping;

namespace Employment_Services_System.Models
{
    public partial class EmploymentServicesDatabaseContext : DbContext
    {
        static EmploymentServicesDatabaseContext()
        {
            Database.SetInitializer<EmploymentServicesDatabaseContext>(null);
        }

        public EmploymentServicesDatabaseContext()
            : base("Name=EmploymentServicesDatabaseContext")
        {
        }

        public DbSet<business_stream> business_stream { get; set; }
        public DbSet<company> companies { get; set; }
        public DbSet<company_image> company_image { get; set; }
        public DbSet<education_detail> education_detail { get; set; }
        public DbSet<experience_detail> experience_detail { get; set; }
        public DbSet<job_location> job_location { get; set; }
        public DbSet<job_post> job_post { get; set; }
        public DbSet<job_post_activity> job_post_activity { get; set; }
        public DbSet<job_post_skill_set> job_post_skill_set { get; set; }
        public DbSet<job_type> job_type { get; set; }
        public DbSet<seeker_profile> seeker_profile { get; set; }
        public DbSet<seeker_skill_set> seeker_skill_set { get; set; }
        public DbSet<skill_set> skill_set { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<user_account> user_account { get; set; }
        public DbSet<user_log> user_log { get; set; }
        public DbSet<user_type> user_type { get; set; }
        public DbSet<View_1> View_1 { get; set; }
        public DbSet<View_Seekers> View_Seekers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new business_streamMap());
            modelBuilder.Configurations.Add(new companyMap());
            modelBuilder.Configurations.Add(new company_imageMap());
            modelBuilder.Configurations.Add(new education_detailMap());
            modelBuilder.Configurations.Add(new experience_detailMap());
            modelBuilder.Configurations.Add(new job_locationMap());
            modelBuilder.Configurations.Add(new job_postMap());
            modelBuilder.Configurations.Add(new job_post_activityMap());
            modelBuilder.Configurations.Add(new job_post_skill_setMap());
            modelBuilder.Configurations.Add(new job_typeMap());
            modelBuilder.Configurations.Add(new seeker_profileMap());
            modelBuilder.Configurations.Add(new seeker_skill_setMap());
            modelBuilder.Configurations.Add(new skill_setMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new user_accountMap());
            modelBuilder.Configurations.Add(new user_logMap());
            modelBuilder.Configurations.Add(new user_typeMap());
            modelBuilder.Configurations.Add(new View_1Map());
            modelBuilder.Configurations.Add(new View_SeekersMap());
        }
    }
}
