using System.Collections.Generic;
using TicketApp.Domain.Command;
using TicketApp.Domain.Model;
using TicketApp.Repository;

namespace TicketApp.Service
{
    public class BusRouteService
    {
        private readonly BusRouteRepository _busRouteRepository;


        public BusRouteService(BusRouteRepository busRouteRepository)
        {
            _busRouteRepository = busRouteRepository;
        }


        public IEnumerable<BusRoute> Find()
        {
            return _busRouteRepository.Find();
        }


        public BusRoute Create(CreateBusRouteCommand cmd)
        {
            return _busRouteRepository.Create(cmd);
        }

    }
}
