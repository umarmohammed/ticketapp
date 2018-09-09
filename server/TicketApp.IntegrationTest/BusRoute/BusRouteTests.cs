using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TicketApp.Common.Extensions;
using TicketApp.Domain.Command;
using TicketApp.WebApi;
using Xunit;

namespace TicketApp.IntegrationTest.BusRoute
{
    public class BusRouteTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;


        public BusRouteTests()
        {
            _server = new TestServer(
                new WebHostBuilder()
                    .UseStartup<TestStartup>());

            _client = _server.CreateClient();
        }


        [Fact]
        public async Task TestFind()
        {
            var requestUrl = "/api/busroute";

            var result = await _client.GetAsync(requestUrl);
            var resultString = await result.Content.ReadAsStringAsync();

            var busRoutes = 
                JsonConvert
                    .DeserializeObject<IEnumerable<Domain.Model.BusRoute>>(resultString);

            Assert.True(busRoutes.Count() == 2);
            Assert.True(result.IsSuccessStatusCode);
        }


        [Fact]
        public async Task TestCreate()
        {
            var requestUrl = "/api/busroute/create";
            var cmd = new CreateBusRouteCommand
            {
                Name = "test3",
                Price = 3.3
            };


            var result = await _client.PostAsync(requestUrl, cmd.ToJsonStringContent());
            var resultString = await result.Content.ReadAsStringAsync();

            var busRoute = JsonConvert.DeserializeObject<Domain.Model.BusRoute>(resultString);

            Assert.True(result.IsSuccessStatusCode);
        }

    }
}
