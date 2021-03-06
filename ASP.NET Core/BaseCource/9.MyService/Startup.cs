using _9.MyService.Middlewares;
using _9.MyService.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _9.MyService
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Transient - временный
            services.AddTransient<IHomeBuilder, OneFloorHomeBuilder>();
            services.AddTransient<HomeBuilderService>();
        }
        public void Configure(IApplicationBuilder app, HomeBuilderService service)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync(service.GetInfo());
            });
        }
    }
}
