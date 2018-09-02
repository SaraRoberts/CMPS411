using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.Models
{
    public class ACourse
    {
        public int CourseId { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Book { get; set; }
        public int? PrereqId { get; set; } 
        public ACourse Prereq { get; set; }
    }
}
