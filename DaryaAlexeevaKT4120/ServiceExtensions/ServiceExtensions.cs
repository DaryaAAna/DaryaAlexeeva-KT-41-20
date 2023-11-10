using DaryaAlexeevaKT4120.Interfaces.GroupsInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace DaryaAlexeevaKT4120.ServiceExtensions
{
    public static class ServiceExtensions 
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IGroupService, GroupService>();

            return services;
        }
    }
}
