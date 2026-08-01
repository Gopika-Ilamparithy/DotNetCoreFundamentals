using System.ComponentModel.DataAnnotations;

namespace Implementing_Custom_Validation_E_F.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be more than 50 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is required.")]
        [MinAge(18)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public Department Department { get; set; }

        [Required(ErrorMessage = "Skills are required.")]
        public Skills Skills { get; set; }

    }
}
