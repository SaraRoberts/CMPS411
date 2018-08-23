using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; } //pk
        public int InstanceId { get; set; } //fk
        public int UserId { get; set; } //fk
        public char Status { get; set; }
    }
}
