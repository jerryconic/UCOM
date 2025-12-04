using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models;


public class EmployeeViewModel
{
    [Key]
    [Required(ErrorMessage = "必須有編號")]    
    public int? Id { get; set; }

    [Required(ErrorMessage = "必須有員工姓名")]
    [MaxLength(20)]
    public string Name { get; set; }
    [Required(ErrorMessage = "必須有出生年月日")]
    public DateTime? Birthdate { get; set; }
    [Required(ErrorMessage = "必須有薪資")]
    [Range(0, 200000, ErrorMessage ="必須是 0 ~ 200000")]
    public int? Salary { get; set; }
}
