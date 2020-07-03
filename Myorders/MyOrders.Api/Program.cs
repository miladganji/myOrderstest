using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyOrders.Infra;

namespace MyOrders.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
          var host= CreateWebHostBuilder(args).Build();
            using (var scop =host.Services.CreateScope())
            {
                var services = scop.ServiceProvider;

                var context = services.GetRequiredService<ApplicationDbcontext>();
                context.Database.Migrate();
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
                
    }
}
