using corsoIngProject.Dal;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace corsoIngProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.Configure<Settings>(options =>
            {
                options.DatabaseName = "uni";
                options.CollectionName = "students";
            });

            services.AddSingleton<IStudentsRepo, StudentsRepo>();

        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
        }
    }
}
