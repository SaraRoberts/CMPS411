using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Models
{
    public class Instance
    {
        public int InstanceId { get; set; } //pk
        public DateTimeOffset StartDate { get; set; }
        public double Price { get; set; }
        public string Location { get; set; }
        public int CourseId { get; set; } //fk
        public int Seats { get; set; }
    }
}
