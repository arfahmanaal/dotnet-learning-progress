using System.ComponentModel.DataAnnotations;

namespace StudentManagementApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be 2 to 50 characters")]
        public string Name { get; set; }

        [Range(5, 25, ErrorMessage = "Age must be between 5 and 25")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Grade is required")]
        [StringLength(3, ErrorMessage = "Grade cannot exceed 3 characters")]
        public string Grade { get; set; }
    }
}