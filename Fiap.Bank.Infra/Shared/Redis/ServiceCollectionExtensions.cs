using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Fiap.Bank.Infra.Shared.Redis
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRedis(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<RedisConfiguration>().Bind(configuration.GetSection(nameof(RedisConfiguration)));
            services.AddDistributedRedisCache(a => a.Configuration = configuration.GetSection("RedisConfiguration:ConnectionString").Value);

            return services;
        }
    }
}