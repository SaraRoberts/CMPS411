using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.Models
{
    public class AInstance
    {
        public int InstanceId { get; set; } 
        public DateTimeOffset StartDate { get; set; }
        public double Price { get; set; }
        public int CourseId { get; set; } 
        public ACourse Course { get; set; }
        public int LocationId { get; set; } 
        public ALocation Location { get; set; }
        public int Seats { get; set; }
        public virtual ICollection<AEnrollment> Enrollments { get; set; }
    }
}
