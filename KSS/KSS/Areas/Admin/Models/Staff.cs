using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.Models
{
    public class Staff
    {
        public int StaffId { get; set; } //PK
        public string Picture { get; set; }
        public string Bio { get; set; }
    }
}
