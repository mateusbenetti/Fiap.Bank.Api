using Fiap.Bank.Repository.Data;
using Fiap.Bank.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Fiap.Bank.Repository.DependencyInjection
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IVeiculoRepository, VeiculoRepository>();
            return services;
        }
    }
}