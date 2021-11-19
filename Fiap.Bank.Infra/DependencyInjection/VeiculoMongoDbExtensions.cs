using Fiap.Bank.Infra.Data.Entities;
using Fiap.Bank.Infra.Shared.MongoDb;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Fiap.Bank.Repository.DependencyInjection
{
    public static class VeiculoMongoDbExtensions
    {
        public static IServiceCollection AddVeiculoCollection(this IServiceCollection services)
        {
            return services.AddSingleton(sp =>
            {
                var mongoConfiguration = sp.GetRequiredService<IOptions<MongoConfiguration>>().Value;

                var mongoClient = sp.GetRequiredService<MongoClient>();

                var collection = mongoClient
                    .GetDatabase(mongoConfiguration.DatabaseName)
                    .GetCollection<VeiculoEntity>("Veiculos");

                return collection;
            });
        }
    }
}