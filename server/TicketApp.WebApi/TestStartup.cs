using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TicketApp.Schema.Model;
using TicketApp.WebApi.Filters;

namespace TicketApp.WebApi
{
    public class TestStartup 
    {
        public TestStartup(IConfiguration configuration) 
        {
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Entities>(options => 
                options.UseInMemoryDatabase("TestDb"));

            services.AddMvc(options =>
            {
                options.Filters.Add(new ValidModelAttribute());
            });
            services.AddAutoMapper();

            Startup.RegisterServices(services);
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var context = app.ApplicationServices.GetService<Entities>();

            AddTestData(context);
            app.UseMvc();
        }


        private static void AddTestData(Entities context)
        {
            var testRoute1 = new BusRoute
            {
                Name = "Test1",
                Price = 1.0
            };

            var testRoute2 = new BusRoute
            {
                Name = "Test2",
                Price = 2.0
            };

            context.BusRoute.Add(testRoute1);
            context.BusRoute.Add(testRoute2);

            context.SaveChanges();
        }
    }
}
