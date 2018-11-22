using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.API.Models
{
    public class EnrollmentsDto
    {
        public int EnrollmentId { get; set; }

        public int InstanceId { get; set; } //FK reference to Id in Instance table
        public string InstanceStartDate { get; set; }
        //public Instance Instance { get; set; }
        public string LocationName { get; set; }
        public string LocationStreet { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        public int LocationZip { get; set; }
        public string CourseName { get; set; }
        public string CategoryName { get; set; }
        public string UserName { get; set; }

        public int UserId { get; set; } //FK reference to Id in User table
        //public User User { get; set; }

        public char Status { get; set; }
        public bool BookBought { get; set; }
        public bool Paid { get; set; }
        public DateTime? Confirmed { get; set; }
    }
}
