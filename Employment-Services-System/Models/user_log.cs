using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class user_log
    {
        public int user_account_id { get; set; }
        public System.DateTime last_login_date { get; set; }
        public Nullable<System.DateTime> last_job_apply_date { get; set; }
        public virtual user_account user_account { get; set; }
    }
}
