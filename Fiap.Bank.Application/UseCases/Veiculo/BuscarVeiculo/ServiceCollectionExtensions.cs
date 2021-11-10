using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Fiap.Bank.Application.UseCases.Veiculo.BuscarVeiculo
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBuscarVeiculoUseCase(this IServiceCollection services)
        {
            services.AddSingleton<IBuscarVeiculoUseCase, BuscarVeiculoUseCase>();

            return services;
        }
    }
}