using System.ComponentModel.DataAnnotations;

namespace WebDemo.Models
{
    public class EmployeeViewModel
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        [Required]
        [Display(Name = "Salary")]
        public decimal Salary { get; set; }
    }
}