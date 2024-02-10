using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace portfolio.Models
{
    public class Project
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
    }
}