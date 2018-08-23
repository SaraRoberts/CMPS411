using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Models
{
    public class Instance
    {
        public int InstanceId { get; set; } //PK
        public DateTimeOffset StartDate { get; set; }
        public double Price { get; set; }
        public string Location { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; } //FK reference to CourseId in Course Table
        public Course Course { get; set; }

        public int Seats { get; set; }
    }
}
