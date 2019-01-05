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

        [MaxLength(15)]
        public string FirstName { get; set; }
        [MaxLength(15)]
        public string LastName { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
    }
}
