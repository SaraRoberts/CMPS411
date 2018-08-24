using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Models
{
    public class Course
    {
        public int CourseId { get; set; } //PK
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Book { get; set; }
        
        [ForeignKey("Course")]
        public int? PrereqId { get; set; } //FK references its own table
        public Course Prereq { get; set; }
    }
}
