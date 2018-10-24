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
        public int TypicalPrice { get; set; }
        public bool BookAvailable { get; set; }
        public double? BookPrice { get; set; }

        public int? PrereqId { get; set; } //FK references its own table
        public Course Prereq { get; set; }

        public int  CategoryId { get; set; } //FK reference to Category Table
        public Category CourseCategory { get; set;}

        public List<Course> Courses { get; set; }
        public List<Instance> Instances { get; set; }
    }
}
