using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employment_Services_System.Models
{
    public class UserAccountDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public string UserType { get; set; }
    }
}