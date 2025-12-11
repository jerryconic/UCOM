using System.ComponentModel.DataAnnotations;

namespace WebDemo.Models
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage ="必須填寫員工編號")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "必須填寫員工姓名")]
        [StringLength(20)]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "必須填寫出生年月日")]
        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "必須填寫薪資")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}