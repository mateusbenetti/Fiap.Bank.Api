using Fiap.Bank.Infra.Shared.MongoDb;
using Fiap.Bank.Infra.Shared.Redis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Bank.Infra
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRedis(configuration)
                .AddMongoDb(configuration);

            return services;
        }
    }
}