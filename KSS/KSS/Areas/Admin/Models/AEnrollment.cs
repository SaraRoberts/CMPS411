using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.Models
{
    public class AEnrollment
    {
        public int EnrollmentId { get; set; }
        public int InstanceId { get; set; } 
        public AInstance Instance { get; set; }
        public string UserId { get; set; } 
        public KSSUser KSSUser { get; set; }
        public char Status { get; set; }
    }
}
