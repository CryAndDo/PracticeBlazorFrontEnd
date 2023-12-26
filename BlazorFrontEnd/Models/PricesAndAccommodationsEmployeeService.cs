using System.ComponentModel.DataAnnotations;

namespace BlazorFrontEnd.Models
{
    public class PricesAndAccommodationsEmployeeService
    {
        public int IdPriceAccomodations { get; set; }
        [Required(ErrorMessage = "Необходимо ввести стоимость проживания")]
        [StringLength(50)]
        public decimal? Stoimos { get; set; }
        [Required(ErrorMessage = "Необходимо ввести дату заезда")]
        [StringLength(50)]
        public DateOnly? Start { get; set; }
        [Required(ErrorMessage = "Необходимо ввести дату отъезда")]
        [StringLength(50)]
        public DateOnly? Finish { get; set; }

        public int? IdFond { get; set; }

        public int? IdEmpleyee { get; set; }

        public bool StatusAccommodation { get; set; }
    }
}
