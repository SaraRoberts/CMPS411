using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace KSS.Areas.Admin.Models
{
    public class AKSSUser : IdentityUser 
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public string CellPhone { get; set; }
        public virtual ICollection<AEnrollment> Enrollments { get; set; }
    }
}