using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.Models
{
    public class Course
    {
        public int CourseId { get; set; } //PK
        public string Name { get; set; }
        public string Description { get; set; }
        public bool BookAvailable { get; set; }
        public decimal BookPrice { get; set; }
        public string Category { get; set; }

        public int? PrereqId { get; set; } //FK references its own table
        public Course Prereq { get; set; }

        public List<Course> Courses { get; set; }

        public List<Instance> Instances { get; set; }
    }
}
