using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employment_Services_System.Models
{
    public class UserAccountDetailsDTO
    {
        public int Id { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string IsActive { get; set; }
        public int ContactNumber { get; set; }
        public string SmsNotificationActive { get; set; }
        public string EmailNotificationActive { get; set; }
        public System.DateTime RegistrationDate { get; set; }
    }
}