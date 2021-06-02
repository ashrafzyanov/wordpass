using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using ASHR.Wordpass.Domain.Api.Entity;
using ASHR.Wordpass.Application.Handles;

namespace ASHR.Wordpass.Application
{
    public static class DI
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<Project, ProjectDTO>();
                cfg.CreateMap<AccessObject, AccessObjectDTO>();
            });
        }
    }
}
