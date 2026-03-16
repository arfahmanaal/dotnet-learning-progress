using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Range(5, 100)]
        public int Age { get; set; }

        [Required]
        [StringLength(5)]
        public string Grade { get; set; }
    }
}