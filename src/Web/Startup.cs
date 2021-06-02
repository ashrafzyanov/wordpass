using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ASHR.Wordpass.Domain.Api.Service;
using ASHR.Wordpass.Domain.Service;
using ASHR.Wordpass.Application;
using ASHR.Wordpass.Controller.Api;

namespace ASHR.Wordpass.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddHttpContextAccessor();
            services.AddControllers().AddApplicationPart(typeof(WordpassApi).Assembly);
            services.AddTransient<IProjectService, ProjectService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
