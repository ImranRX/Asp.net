using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace portfolio.Models
{
    public class PersonalInfo
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LinkedInProfile { get; set; }
        public string GitHubProfile { get; set; }
        public string Summary { get; set; }
        public List<string> Skills { get; set; }
        public List<Education> EducationHistory { get; set; }
        
    }
}