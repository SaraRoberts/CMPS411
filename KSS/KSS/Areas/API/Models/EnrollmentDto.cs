using KSS.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.API.DTOs
{
    public class EnrollmentDto
    {
        public int InstanceId { get; set; } //FK reference to Id in Instance table
        public Instance Instance { get; set; }

        public int UserId { get; set; } //FK reference to Id in User table
        public User User { get; set; }

        public char Status { get; set; }
    }
}
