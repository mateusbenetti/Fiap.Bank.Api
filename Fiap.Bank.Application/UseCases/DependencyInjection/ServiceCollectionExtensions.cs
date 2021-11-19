using Fiap.Bank.Application.UseCases.Veiculo.BuscarVeiculo;
using Fiap.Bank.Application.UseCases.Veiculo.CriarVeiculos;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Fiap.Bank.Application.UseCases.DependencyInjection
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services
                .AddCriarVeiculosUseCase()
                .AddBuscarVeiculoUseCase();

            return services;
        }
    }
}