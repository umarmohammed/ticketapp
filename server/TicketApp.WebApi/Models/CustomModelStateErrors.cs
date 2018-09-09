using System.Collections.Generic;

namespace TicketApp.WebApi.Models
{
    public class CustomModelStateErrors
    {
        public IEnumerable<CustomModelStateError> Errors { get; set; }
    }
}
