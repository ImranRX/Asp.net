using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult PersonalInfo()
        {
       
            var personalInfo = new PersonalInfo
            {
                FullName = "Md. Imran Khan",
                Address = "Bonosree,Rampura",
                PhoneNumber = "0123456789",
                Email = "Ik.imran223@gamil.com",

            };

            return View(personalInfo);
        }
        public ActionResult Projects()
        {
            
            var projects = new List<Project>
        {
            new Project
            {
                ProjectName = "Hospital Management system",
                Description = "A project showcasing in Java",
                Technologies = new List<string> { "Java" }
            },
            new Project
            {
                ProjectName = "Gym management system",
                Description = "A desktop application built with C#",
                Technologies = new List<string> { "C#", "MSSQL" }
            },
            new Project
            {
                ProjectName = "E-bike Management System",
                Description = "A consol application built with web technologies",
                Technologies = new List<string> { "Html","css","php","js" }
            }

        };

            return View(projects);
        }
        public ActionResult Index()
        {
            
            var profile = new Profile
            {
                Name = "Md. Imran Khan",
                ID = "20-42512-1",
                GitProfile = "https://github.com/ImranRx"
            };

            return View(profile);
        }

        public ActionResult Education()
        {
           
            var educations = new List<Education>
        {
            new Education { Degree = "SSC", Year = 2017, Institute = "Ideal School and College" },
            new Education { Degree = "HSC", Year = 2019, Institute = "Dhaka College" },
            new Education { Degree = "BSc", Year = 2020, Institute = "American International University-Bangladesh" }
        };

            return View(educations);
        }

        
    }
}