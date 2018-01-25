using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class business_stream
    {
        public business_stream()
        {
            this.companies = new List<company>();
        }

        public int id { get; set; }
        public string business_stream_name { get; set; }
        public virtual ICollection<company> companies { get; set; }
    }
}
