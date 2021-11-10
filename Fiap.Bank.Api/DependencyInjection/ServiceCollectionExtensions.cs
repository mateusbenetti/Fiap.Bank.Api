using Fiap.Bank.Application.UseCases.DependencyInjection;
using Fiap.Bank.Config.DependencyInjection;
using Fiap.Bank.Infra;
using Fiap.Bank.Repository.DependencyInjection;
using Fiap.Bank.Repository.Service.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Fiap.Bank.Api.DependencyInjection
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddUseCases()
                .AddServices()
                .AddRepositories()
                .AddInfra(configuration)
                .AddConfiguration(configuration);

            return services;
        }
    }
}