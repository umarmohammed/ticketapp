using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using TicketApp.Common;
using TicketApp.Domain.Command;
using TicketApp.Domain.Model;
using TicketApp.Schema.Model;

namespace TicketApp.Repository
{
    public class BusRouteRepository
    {
        private readonly IMapper _mapper;
        private readonly Entities _context;


        public BusRouteRepository(IMapper mapper, Entities context)
        {
            _mapper = mapper;
            _context = context;
        }


        public IEnumerable<Domain.Model.BusRoute> Find()
        {
            return _mapper
                .Map<IEnumerable<Domain.Model.BusRoute>>(_context.BusRoute.ToList());
        }


        public Domain.Model.BusRoute Create(CreateBusRouteCommand cmd)
        {
            Checks.NotNull(cmd, "cmd");

            var busRoute = _mapper.Map<Schema.Model.BusRoute>(cmd);
            var added = _context.Add(busRoute);
            _context.SaveChanges();
            return _mapper.Map<Domain.Model.BusRoute>(added.Entity);
        }

    }
}
