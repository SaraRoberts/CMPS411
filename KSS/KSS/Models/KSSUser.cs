using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;


namespace KSS.Models
{
    public class KSSUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public string CellPhone { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
