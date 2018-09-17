using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.Models
{
    public class Instance
    {
        public int InstanceId { get; set; } //PK
        public DateTimeOffset StartDate { get; set; }
        public double Price { get; set; }

        public int CourseId { get; set; } //FK reference to CourseId in Course Table
        public Course Course { get; set; }

        public int LocationId { get; set; } //FK reference to LocationId in Location table
        public Location Location { get; set; }

        public int Seats { get; set; }

        public int Instructor { get; set; } //FK reference to User Table
        public User User { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
