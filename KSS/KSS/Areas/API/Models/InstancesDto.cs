using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.API.Models
{
    public class InstancesDto
    {
        public int InstanceId { get; set; } //PK
        public string StartDate { get; set; }
        public double Price { get; set; }
        public bool Graded { get; set; }
        public string CourseCategory { get; set; }

        public int CourseId { get; set; } //FK reference to CourseId in Course Table
        //public Course Course { get; set; }
        public string CourseName { get; set; }

        public int LocationId { get; set; } //FK reference to LocationId in Location table
        //public Location Location { get; set; }
        public string LocationName { get; set; }
        public string LocationStreet { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        public int LocationZip { get; set; }
        public int Seats { get; set; }
        public bool? Full { get; set; } 

        public int InstructorId { get; set; } //FK reference to User Table
        //public User Instructor { get; set; }
        public string InstructorName { get; set; }

        public bool BookAvailable { get; set; }
        public double? BookPrice { get; set; }
        public string StartDateDOW { get; internal set; }
        public string StartDateDay { get; internal set; }
        public string StartDateTime { get; internal set; }
        public string StartDateMonthF3 { get; internal set; }

        //public List<Enrollment> Enrollments { get; set; }
    }
}
