using System.ComponentModel.DataAnnotations;

namespace KSS.Areas.Admin.ViewModels
{
    public class CourseCreate
    {
        [Required(ErrorMessage = "Course Name is required")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Name min length of 6, max Length of 30")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public int TypicalPrice { get; set; }
        public bool BookAvailable { get; set; }
        public double? BookPrice { get; set; }
        public int? PrereqId { get; set; }
        public int CategoryId { get; set; }
    }
}
