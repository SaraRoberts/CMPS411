using System.ComponentModel.DataAnnotations;

namespace KSS.Areas.Admin.ViewModels
{
    public class CourseEdit
    {
        public int CourseId { get; set; }
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Name min length of 6, max Length of 30")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypicalPrice { get; set; }
        public bool BookAvailable { get; set; }
        public decimal BookPrice { get; set; }
        public int? PrereqId { get; set; }
        public int CategoryId { get; set; }
    }
}
