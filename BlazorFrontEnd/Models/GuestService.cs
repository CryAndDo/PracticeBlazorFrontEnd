using System.ComponentModel.DataAnnotations;

namespace BlazorFrontEnd.Models
{
    public class GuestService
    {
        public int IdGuest { get; set; }
        [Required(ErrorMessage = "Необходимо ввести имя Сотрудника")]
        [StringLength(50)]
        public string? Username { get; set; }
       
    }
}
