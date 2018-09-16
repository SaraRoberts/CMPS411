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
        public string CourseName { get; set; }
        public int InstanceId { get; set; } //PK
        public string StartDate { get; set; }
        public double Price { get; set; }
        public string City { get; set; }
        public int Seats { get; set; }
        public string FullName { get; set; }
        public string FullInstance { get; set; } 
    }
}
