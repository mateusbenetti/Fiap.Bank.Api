using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Diagnostics.CodeAnalysis;

namespace Fiap.Bank.Infra.Shared.MongoDb
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<MongoConfiguration>()
               .Bind(configuration.GetSection(nameof(MongoConfiguration)));

            services.AddSingleton(sp =>
            {
                var mongoConfiguration = sp.GetRequiredService<IOptions<MongoConfiguration>>().Value;
                return new MongoClient(mongoConfiguration.ConnectionString);
            });

            return services;
        }
    }
}