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
        public async Task TestFind_Returns_Ok()
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
        public async Task TestCreate_Returns_Ok()
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


        [Fact]
        public async Task TestCreateInvalid_Returns_BadRequest()
        {
            var requestUrl = "/api/busroute/create";
            var cmd = new CreateBusRouteCommand();


            var result = await _client.PostAsync(requestUrl, cmd.ToJsonStringContent());
            var resultString = await result.Content.ReadAsStringAsync();

            Assert.True(result.StatusCode == System.Net.HttpStatusCode.BadRequest);
        }

    }
}
