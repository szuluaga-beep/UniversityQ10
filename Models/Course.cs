using System.ComponentModel.DataAnnotations;

namespace UniversityQ10.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course name is required.")]
        [StringLength(50, ErrorMessage = "Course name cannot exceed {0} characters.")]
        [Display(Name = "Course Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Course code is required.")]
        [StringLength(10, ErrorMessage = "Course code cannot exceed 10 characters.")]
        [Display(Name = "Course Code")]
        public string Code { get; set; } = null!;

        [Range(0, 5, ErrorMessage = "Credits must be between 0 and 5.")]
        public int Credits { get; set; }
    }
}