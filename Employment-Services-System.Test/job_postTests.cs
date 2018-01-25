using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employment_Services_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Employment_Services_System.Tests
{
    public class job_postTests
    {
        [Fact]
        public void job_postTest()
        {
            job_post _job_post = new job_post()
            {
                id = 1,
                created_date = DateTime.Now,
                is_active = "1",
                is_company_name_hidden = "1",
                job_description = "desc",
                company = new company()
                {
                    id = 1,
                    company_name = "Name1",
                    business_stream_id = 1,
                    company_website_url = "name1.com",
                    establishment_date = DateTime.Now,
                    profile_description = "desc1",
                },
                job_location = new job_location()
                {
                    id = 1,
                    city = "city",
                    country = "country",
                    state = "state",
                    street_address = "dafuck11",
                    zip = "12345",
                },
                user_account = new user_account()
                {
                    id = 1,
                    contact_number = 123456,
                    date_of_birth = DateTime.Now,
                    email = "1@2.com",
                    email_notification_active = "1",
                    gender = "0",
                    is_active = "1",
                    password = "12345",
                    registration_date = DateTime.Now,
                    sms_notification_active = "1",
                    user_type_id = 1,
                },
                job_type = new job_type()
                {
                    id = 1,
                    job_type_name = "loljob",
                },
                posted_by_id = 1,
                job_location_id = 1,
                company_id = 1,
                job_type_id = 1
            };
            company_image _company_image = new company_image()
            {
                id = 1,
                company_id = 1,
                company_image_image = new byte[256],
                company = _job_post.company
            };
            _job_post.job_post_activity.Add(new job_post_activity()
            {
                apply_date = DateTime.Now,
                user_account = _job_post.user_account,
                user_account_id = _job_post.user_account.id,
                job_post = _job_post,
                job_post_id = _job_post.id
            });
            _job_post.job_post_skill_set.Add(new job_post_skill_set()
            {
                skill_level = 10,
                skill_set = new skill_set()
                {
                    id = 1,
                    skill_set_name = "skill name"
                },
                skill_set_id = 1,
                job_post = _job_post,
                job_post_id = _job_post.id
            });

            Xunit.Assert.NotNull(_job_post);
            Xunit.Assert.NotNull(_job_post.company);
            Xunit.Assert.NotNull(_job_post.job_location);
            Xunit.Assert.NotNull(_job_post.user_account);
            Xunit.Assert.NotNull(_job_post.job_type);
            Xunit.Assert.NotNull(_job_post.job_post_activity);
            Xunit.Assert.NotNull(_job_post.job_post_skill_set);
        }
    }
}