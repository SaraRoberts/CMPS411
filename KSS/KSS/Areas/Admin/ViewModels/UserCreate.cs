using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSS.Areas.Admin.ViewModels
{
    public class UserCreate
    {
        [Required(ErrorMessage = "First Name is required")]
        [MaxLength(15)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [MaxLength(15)]
        public string LastName { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
        public int StaffId { get; set; }
    }
}
