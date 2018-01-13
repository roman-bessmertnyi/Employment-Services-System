using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employment_Services_System;
using Xunit;

namespace Employment_Services_System.Test
{
    public class seeker_profileTests
    {
        [Fact]
        public void seeker_profileTest()
        {
            seeker_profile _seeker_profile = new seeker_profile()
            {
                currency = "",
                current_salary = 1,
                first_name = "",
                last_name = "",
                is_annually_monthly = "1",
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
                    user_type = new user_type()
                    {
                        id = 1,
                        user_type_name = "seeker"
                    },
                    user_log = new user_log()
                    {
                        last_job_apply_date = DateTime.Now,
                        user_account_id = 1,
                        last_login_date = DateTime.Now,
                    }
                },
            };
            _seeker_profile.education_detail.Add(new education_detail()
            {
                certificate_degree_name = "",
                cgpa = 100,
                completion_date = DateTime.Now,
                institute_university_name = "",
                major = "",
                percentage = 100,
                starting_date = DateTime.Now,
                user_account_id = 1,
                seeker_profile = _seeker_profile
            });
            _seeker_profile.experience_detail.Add(new experience_detail()
            {
                user_account_id = 1,
                is_current_job = "1",
                start_date = DateTime.Now,
                end_date = DateTime.Now,
                job_title = "loltitle",
                company_name = "lolcompany",
                job_location_city = "dfjyjy",
                job_location_country = "stsrtj",
                job_location_state = "asthsrth",
                seeker_profile = _seeker_profile,
                description = "dhjdkdtuk" +
                "dtuksdsddtk" +
                "dykdk"
            });


            Xunit.Assert.NotNull(_seeker_profile);
        }
    }
}
