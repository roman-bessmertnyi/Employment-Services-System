using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class user_type
    {
        public user_type()
        {
            this.user_account = new List<user_account>();
        }

        public int id { get; set; }
        public string user_type_name { get; set; }
        public virtual ICollection<user_account> user_account { get; set; }
    }
}
