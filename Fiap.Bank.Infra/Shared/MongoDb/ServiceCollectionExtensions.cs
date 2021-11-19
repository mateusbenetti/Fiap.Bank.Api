using Fiap.Bank.Infra.Data;
using Fiap.Bank.Infra.Interface;
using Fiap.Bank.Repository.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Fiap.Bank.Infra.Shared.MongoDb
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddMongoDb(mongoConfiguration =>
                configuration.GetSection(nameof(MongoConfiguration)).Bind(mongoConfiguration)
            );
        }

        public static IServiceCollection AddMongoDb(this IServiceCollection services, Action<MongoConfiguration> config)
        {
            services.AddOptions<MongoConfiguration>()
                .Configure(config);

            services.AddSingleton(sp =>
            {
                var mongoConfiguration = sp.GetRequiredService<IOptions<MongoConfiguration>>().Value;
                return new MongoClient(mongoConfiguration.ConnectionString);
            });

            services.AddVeiculoCollection();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IVeiculoRepository, VeiculoRepository>();
            return services;
        }
    }
}