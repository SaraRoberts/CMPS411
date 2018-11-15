using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.API.Models
{
    public class EnrollDto
    {   
        public int InstanceId { get; set; }
        public int UserId { get; set; }
        public bool BookBought { get; set; }
        public bool Paid { get; set; }
    }
}
