using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int InstanceId { get; set; } //FK reference to Id in Instance table
        public Instance Instance { get; set; }

        public int UserId { get; set; } //FK reference to Id in User table
        public User User { get; set; }

        public char Status { get; set; }
        public bool BookBought { get; set; }
        public bool Paid { get; set; }
        public DateTime Confirmed { get; set; }
    }
}
