using System.ComponentModel.DataAnnotations;

namespace BlazorFrontEnd.Models
{
    public class FondService
    {
        public int TableId { get; set; }
        [Required(ErrorMessage = "Необходимо ввести кол-во комнат")]
        [StringLength(50)]
        public int? TotalNumberOfGuestRooms { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage = "Необходимо ввести цену")]
        [StringLength(50)]
        public decimal? Price { get; set; }
    }
}
