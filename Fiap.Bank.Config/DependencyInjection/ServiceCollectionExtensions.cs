using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Bank.Config.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<BusinessConfiguration>().Bind(configuration.GetSection(nameof(BusinessConfiguration)));
            return services;
        }
    }
}