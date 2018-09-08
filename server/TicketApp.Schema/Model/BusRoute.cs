using System;
using System.Collections.Generic;

namespace TicketApp.Schema.Model
{
    public partial class BusRoute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
    }
}
