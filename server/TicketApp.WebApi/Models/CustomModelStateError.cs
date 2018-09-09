using System.Collections.Generic;

namespace TicketApp.WebApi.Models
{
    public class CustomModelStateError
    {
        public string FieldName { get; set; }
        public IEnumerable<string> FieldErrors { get; set; }
    }
}
