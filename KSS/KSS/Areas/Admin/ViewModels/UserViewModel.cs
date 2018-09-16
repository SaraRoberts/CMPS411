using KSS.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public string Role { get; set; }

        public int InstanceId { get; set; } //PK
        public DateTimeOffset StartDate { get; set; }
        public double Price { get; set; }

        public int CourseId { get; set; } //FK reference to CourseId in Course Table
        public Course Course { get; set; }

        public int LocationId { get; set; } //FK reference to LocationId in Location table
        public Location Location { get; set; }

        public int Seats { get; set; }

        public List<Enrollment> Enrollments { get; set; }

        private string _fullName;

        public string FullName { get; set; }
       
    }
}
