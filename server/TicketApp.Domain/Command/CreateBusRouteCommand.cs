using System.ComponentModel.DataAnnotations;

namespace TicketApp.Domain.Command
{
    public class CreateBusRouteCommand
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
