using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace KSS.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; } //PK

        [ForeignKey("Instance")]
        public int InstanceId { get; set; } //FK reference to InstanceId in Instance table
        public Instance Instance { get; set; }

        [ForeignKey("AspNetUsers")]
        public int Id { get; set; } //FK reference to UserId in KSSUer table
        public KSSUser KSSUser { get; set; } 

        public char Status { get; set; }
    }
}
