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
            });

            Xunit.Assert.NotNull(_seeker_profile);
        }
    }
}
