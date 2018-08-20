using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Models
{
    public class Instance
    {
        public int Id { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public double Price { get; set; }
        public string Location { get; set; }
        public int CourseId { get; set; }
    }
}
