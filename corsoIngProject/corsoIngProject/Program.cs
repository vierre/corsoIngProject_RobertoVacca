using Microsoft.AspNetCore.Hosting;
using System;
using System.Threading.Tasks;

namespace corsoIngProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            Task restService = host.RunAsync();

            //System.Diagnostics.Process.Start("cmd", "/C start http://localhost:5000");
            restService.Wait();


        }
    }
}
