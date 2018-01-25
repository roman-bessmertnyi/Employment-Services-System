using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class user_account
    {
        public user_account()
        {
            this.job_post = new List<job_post>();
            this.job_post_activity = new List<job_post_activity>();
        }

        public int id { get; set; }
        public int user_type_id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public System.DateTime date_of_birth { get; set; }
        public string gender { get; set; }
        public string is_active { get; set; }
        public int contact_number { get; set; }
        public string sms_notification_active { get; set; }
        public string email_notification_active { get; set; }
        public byte[] user_image { get; set; }
        public System.DateTime registration_date { get; set; }
        public virtual ICollection<job_post> job_post { get; set; }
        public virtual ICollection<job_post_activity> job_post_activity { get; set; }
        public virtual seeker_profile seeker_profile { get; set; }
        public virtual user_log user_log { get; set; }
        public virtual user_type user_type { get; set; }
    }
}
