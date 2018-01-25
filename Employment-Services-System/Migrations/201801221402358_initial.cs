namespace Employment_Services_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.business_stream",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            business_stream_name = c.String(nullable: false, maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.id);
            
            //CreateTable(
            //    "dbo.company",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            company_name = c.String(nullable: false, maxLength: 100),
            //            profile_description = c.String(nullable: false, maxLength: 1000),
            //            business_stream_id = c.Int(nullable: false),
            //            establishment_date = c.DateTime(nullable: false),
            //            company_website_url = c.String(nullable: false, maxLength: 500),
            //        })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("dbo.business_stream", t => t.business_stream_id, cascadeDelete: true)
            //    .Index(t => t.business_stream_id);
            
            //CreateTable(
            //    "dbo.company_image",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            company_id = c.Int(nullable: false),
            //            company_image_image = c.Binary(nullable: false),
            //        })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("dbo.company", t => t.company_id, cascadeDelete: true)
            //    .Index(t => t.company_id);
            
            //CreateTable(
            //    "dbo.job_post",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            posted_by_id = c.Int(nullable: false),
            //            job_type_id = c.Int(nullable: false),
            //            company_id = c.Int(nullable: false),
            //            is_company_name_hidden = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            created_date = c.DateTime(nullable: false),
            //            job_description = c.String(nullable: false, maxLength: 500),
            //            job_location_id = c.Int(nullable: false),
            //            is_active = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //        })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("dbo.company", t => t.company_id, cascadeDelete: true)
            //    .ForeignKey("dbo.job_location", t => t.job_location_id, cascadeDelete: true)
            //    .ForeignKey("dbo.job_type", t => t.job_type_id, cascadeDelete: true)
            //    .ForeignKey("dbo.user_account", t => t.posted_by_id, cascadeDelete: true)
            //    .Index(t => t.posted_by_id)
            //    .Index(t => t.job_type_id)
            //    .Index(t => t.company_id)
            //    .Index(t => t.job_location_id);
            
            //CreateTable(
            //    "dbo.job_location",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            street_address = c.String(nullable: false, maxLength: 100),
            //            city = c.String(nullable: false, maxLength: 50),
            //            state = c.String(nullable: false, maxLength: 50),
            //            country = c.String(nullable: false, maxLength: 50),
            //            zip = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.id);
            
            //CreateTable(
            //    "dbo.job_post_activity",
            //    c => new
            //        {
            //            user_account_id = c.Int(nullable: false),
            //            job_post_id = c.Int(nullable: false),
            //            apply_date = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.user_account_id, t.job_post_id })
            //    .ForeignKey("dbo.job_post", t => t.job_post_id, cascadeDelete: true)
            //    .ForeignKey("dbo.user_account", t => t.user_account_id, cascadeDelete: true)
            //    .Index(t => t.user_account_id)
            //    .Index(t => t.job_post_id);
            
            //CreateTable(
            //    "dbo.user_account",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            user_type_id = c.Int(nullable: false),
            //            email = c.String(nullable: false, maxLength: 255),
            //            password = c.String(nullable: false, maxLength: 100),
            //            date_of_birth = c.DateTime(nullable: false),
            //            gender = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            is_active = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            contact_number = c.Int(nullable: false),
            //            sms_notification_active = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            email_notification_active = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            user_image = c.Binary(),
            //            registration_date = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("dbo.user_type", t => t.user_type_id, cascadeDelete: true)
            //    .Index(t => t.user_type_id);
            
            //CreateTable(
            //    "dbo.seeker_profile",
            //    c => new
            //        {
            //            user_account_id = c.Int(nullable: false),
            //            first_name = c.String(nullable: false, maxLength: 50),
            //            last_name = c.String(nullable: false, maxLength: 50),
            //            current_salary = c.Int(),
            //            is_annually_monthly = c.String(maxLength: 1, fixedLength: true),
            //            currency = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.user_account_id)
            //    .ForeignKey("dbo.user_account", t => t.user_account_id)
            //    .Index(t => t.user_account_id);
            
            //CreateTable(
            //    "dbo.education_detail",
            //    c => new
            //        {
            //            user_account_id = c.Int(nullable: false),
            //            certificate_degree_name = c.String(nullable: false, maxLength: 50),
            //            major = c.String(nullable: false, maxLength: 50),
            //            institute_university_name = c.String(nullable: false, maxLength: 50),
            //            starting_date = c.DateTime(nullable: false),
            //            completion_date = c.DateTime(),
            //            percentage = c.Int(),
            //            cgpa = c.Int(),
            //        })
            //    .PrimaryKey(t => new { t.user_account_id, t.certificate_degree_name, t.major })
            //    .ForeignKey("dbo.seeker_profile", t => t.user_account_id, cascadeDelete: true)
            //    .Index(t => t.user_account_id);
            
            //CreateTable(
            //    "dbo.experience_detail",
            //    c => new
            //        {
            //            user_account_id = c.Int(nullable: false),
            //            start_date = c.DateTime(nullable: false),
            //            end_date = c.DateTime(nullable: false),
            //            is_current_job = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            job_title = c.String(nullable: false, maxLength: 50),
            //            company_name = c.String(nullable: false, maxLength: 100),
            //            job_location_city = c.String(nullable: false, maxLength: 50),
            //            job_location_state = c.String(nullable: false, maxLength: 50),
            //            job_location_country = c.String(nullable: false, maxLength: 50),
            //            description = c.String(nullable: false, maxLength: 4000),
            //        })
            //    .PrimaryKey(t => new { t.user_account_id, t.start_date, t.end_date })
            //    .ForeignKey("dbo.seeker_profile", t => t.user_account_id, cascadeDelete: true)
            //    .Index(t => t.user_account_id);
            
            //CreateTable(
            //    "dbo.seeker_skill_set",
            //    c => new
            //        {
            //            user_account_id = c.Int(nullable: false),
            //            skill_set_id = c.Int(nullable: false),
            //            skill_level = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.user_account_id, t.skill_set_id })
            //    .ForeignKey("dbo.seeker_profile", t => t.user_account_id, cascadeDelete: true)
            //    .ForeignKey("dbo.skill_set", t => t.skill_set_id, cascadeDelete: true)
            //    .Index(t => t.user_account_id)
            //    .Index(t => t.skill_set_id);
            
            //CreateTable(
            //    "dbo.skill_set",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            skill_set_name = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.id);
            
            //CreateTable(
            //    "dbo.job_post_skill_set",
            //    c => new
            //        {
            //            skill_set_id = c.Int(nullable: false),
            //            job_post_id = c.Int(nullable: false),
            //            skill_level = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.skill_set_id, t.job_post_id })
            //    .ForeignKey("dbo.job_post", t => t.job_post_id, cascadeDelete: true)
            //    .ForeignKey("dbo.skill_set", t => t.skill_set_id, cascadeDelete: true)
            //    .Index(t => t.skill_set_id)
            //    .Index(t => t.job_post_id);
            
            //CreateTable(
            //    "dbo.user_log",
            //    c => new
            //        {
            //            user_account_id = c.Int(nullable: false),
            //            last_login_date = c.DateTime(nullable: false),
            //            last_job_apply_date = c.DateTime(),
            //        })
            //    .PrimaryKey(t => t.user_account_id)
            //    .ForeignKey("dbo.user_account", t => t.user_account_id)
            //    .Index(t => t.user_account_id);
            
            //CreateTable(
            //    "dbo.user_type",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            user_type_name = c.String(nullable: false, maxLength: 20),
            //        })
            //    .PrimaryKey(t => t.id);
            
            //CreateTable(
            //    "dbo.job_type",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            job_type_name = c.String(nullable: false, maxLength: 20),
            //        })
            //    .PrimaryKey(t => t.id);
            
            //CreateTable(
            //    "dbo.sysdiagrams",
            //    c => new
            //        {
            //            diagram_id = c.Int(nullable: false, identity: true),
            //            name = c.String(nullable: false, maxLength: 128),
            //            principal_id = c.Int(nullable: false),
            //            version = c.Int(),
            //            definition = c.Binary(),
            //        })
            //    .PrimaryKey(t => t.diagram_id);
            
            //CreateTable(
            //    "dbo.View_1",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            job_type = c.String(nullable: false, maxLength: 20),
            //            company_name = c.String(nullable: false, maxLength: 100),
            //            job_description = c.String(nullable: false, maxLength: 500),
            //            street_address = c.String(nullable: false, maxLength: 100),
            //            skill_level = c.Int(),
            //            skill_set_name = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => new { t.id, t.job_type, t.company_name, t.job_description, t.street_address });
            
            //CreateTable(
            //    "dbo.View_Seekers",
            //    c => new
            //        {
            //            id = c.Int(nullable: false),
            //            is_company_name_hidden = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            created_date = c.DateTime(nullable: false),
            //            job_description = c.String(nullable: false, maxLength: 500),
            //            is_active = c.String(nullable: false, maxLength: 1, fixedLength: true),
            //            skill_level = c.Int(nullable: false),
            //            job_type = c.String(nullable: false, maxLength: 20),
            //            email = c.String(nullable: false, maxLength: 255),
            //            registration_date = c.DateTime(nullable: false),
            //            company_name = c.String(nullable: false, maxLength: 100),
            //            street_address = c.String(nullable: false, maxLength: 100),
            //            user_image = c.Binary(),
            //        })
            //    .PrimaryKey(t => new { t.id, t.is_company_name_hidden, t.created_date, t.job_description, t.is_active, t.skill_level, t.job_type, t.email, t.registration_date, t.company_name, t.street_address });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.job_post", "posted_by_id", "dbo.user_account");
            DropForeignKey("dbo.job_post", "job_type_id", "dbo.job_type");
            DropForeignKey("dbo.job_post_activity", "user_account_id", "dbo.user_account");
            DropForeignKey("dbo.user_account", "user_type_id", "dbo.user_type");
            DropForeignKey("dbo.user_log", "user_account_id", "dbo.user_account");
            DropForeignKey("dbo.seeker_profile", "user_account_id", "dbo.user_account");
            DropForeignKey("dbo.seeker_skill_set", "skill_set_id", "dbo.skill_set");
            DropForeignKey("dbo.job_post_skill_set", "skill_set_id", "dbo.skill_set");
            DropForeignKey("dbo.job_post_skill_set", "job_post_id", "dbo.job_post");
            DropForeignKey("dbo.seeker_skill_set", "user_account_id", "dbo.seeker_profile");
            DropForeignKey("dbo.experience_detail", "user_account_id", "dbo.seeker_profile");
            DropForeignKey("dbo.education_detail", "user_account_id", "dbo.seeker_profile");
            DropForeignKey("dbo.job_post_activity", "job_post_id", "dbo.job_post");
            DropForeignKey("dbo.job_post", "job_location_id", "dbo.job_location");
            DropForeignKey("dbo.job_post", "company_id", "dbo.company");
            DropForeignKey("dbo.company_image", "company_id", "dbo.company");
            DropForeignKey("dbo.company", "business_stream_id", "dbo.business_stream");
            DropIndex("dbo.user_log", new[] { "user_account_id" });
            DropIndex("dbo.job_post_skill_set", new[] { "job_post_id" });
            DropIndex("dbo.job_post_skill_set", new[] { "skill_set_id" });
            DropIndex("dbo.seeker_skill_set", new[] { "skill_set_id" });
            DropIndex("dbo.seeker_skill_set", new[] { "user_account_id" });
            DropIndex("dbo.experience_detail", new[] { "user_account_id" });
            DropIndex("dbo.education_detail", new[] { "user_account_id" });
            DropIndex("dbo.seeker_profile", new[] { "user_account_id" });
            DropIndex("dbo.user_account", new[] { "user_type_id" });
            DropIndex("dbo.job_post_activity", new[] { "job_post_id" });
            DropIndex("dbo.job_post_activity", new[] { "user_account_id" });
            DropIndex("dbo.job_post", new[] { "job_location_id" });
            DropIndex("dbo.job_post", new[] { "company_id" });
            DropIndex("dbo.job_post", new[] { "job_type_id" });
            DropIndex("dbo.job_post", new[] { "posted_by_id" });
            DropIndex("dbo.company_image", new[] { "company_id" });
            DropIndex("dbo.company", new[] { "business_stream_id" });
            DropTable("dbo.View_Seekers");
            DropTable("dbo.View_1");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.job_type");
            DropTable("dbo.user_type");
            DropTable("dbo.user_log");
            DropTable("dbo.job_post_skill_set");
            DropTable("dbo.skill_set");
            DropTable("dbo.seeker_skill_set");
            DropTable("dbo.experience_detail");
            DropTable("dbo.education_detail");
            DropTable("dbo.seeker_profile");
            DropTable("dbo.user_account");
            DropTable("dbo.job_post_activity");
            DropTable("dbo.job_location");
            DropTable("dbo.job_post");
            DropTable("dbo.company_image");
            DropTable("dbo.company");
            DropTable("dbo.business_stream");
        }
    }
}
