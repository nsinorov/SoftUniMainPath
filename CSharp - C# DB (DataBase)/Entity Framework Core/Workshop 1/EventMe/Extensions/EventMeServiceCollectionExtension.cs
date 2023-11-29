using EventMe.Core.Contracts;
using EventMe.Core.Services;
using EventMe.Infrastructure.Data;
using EventMe.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class EventMeServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IEventService, EventService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EventMeDbContext>(options =>
                           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IRepository, Repository>();

            return services;
        }
    }
}
