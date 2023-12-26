using System.ComponentModel.DataAnnotations;

namespace BlazorFrontEnd.Models
{
    public class EmployeeService
    {
        public int IdEmpleyee { get; set; }
        [Required(ErrorMessage = "Необходимо ввести имя")]
        [StringLength(50)]
        public string? Username { get; set; }
    }
}
