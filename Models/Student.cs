using System.ComponentModel.DataAnnotations;

namespace UniversityQ10.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirtsName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        public string LastName { get; set; } = null!;

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Required]
        [Display(Name = "Identity Document")]
        public string Document { get; set; } = null!;

        public string FullName
        {
            get
            {
                return $"{FirtsName} {LastName}";
            }
        }
    }
}