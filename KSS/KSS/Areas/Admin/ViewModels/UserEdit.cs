using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.ViewModels
{
    public class UserEdit
    {
        public int UserId { get; set; }
        //max chars
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //phone
        public string Phone { get; set; }
        //email
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
