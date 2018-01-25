using System;
using System.Collections.Generic;

namespace Employment_Services_System.Models
{
    public partial class company_image
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public byte[] company_image_image { get; set; }
        public virtual company company { get; set; }
    }
}
