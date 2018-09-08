using Microsoft.AspNetCore.Mvc;
using TicketApp.Domain.Command;
using TicketApp.Service;

namespace TicketApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusRouteController : ControllerBase
    {
        private readonly BusRouteService _busRouteService;


        public BusRouteController(BusRouteService busRouteService)
        {
            _busRouteService = busRouteService;
        }


        public ActionResult Index()
        {
            return Ok(_busRouteService.Find());
        }


        public ActionResult Create(CreateBusRouteCommand cmd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(_busRouteService.Create(cmd));
        }
    }
}