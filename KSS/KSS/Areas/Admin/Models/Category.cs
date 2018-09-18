using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.Models
{
    public class Category
    {
        public int CategoryId { get; set; } //PK
        public string Name { get; set; }

        public List<Course> Courses { get; set; }
    }
}
