using System.ComponentModel.DataAnnotations;

namespace BlazorFrontEnd.Models
{
    public class ServiceService
    {
        public int IdService { get; set; }
        [Required(ErrorMessage = "Необходимо ввести цену услуги")]
        [StringLength(50)]
        public decimal? Accommodation { get; set; }
        [Required(ErrorMessage = "Необходимо ввести название услуги")]
        [StringLength(50)]
        public string? Name { get; set; }
    }
}
