using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketApp.Repository
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Schema.Model.BusRoute, Domain.Model.BusRoute>();

            CreateMap<Domain.Command.CreateBusRouteCommand, Schema.Model.BusRoute>();
        }
    }
}
