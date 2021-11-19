using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Fiap.Bank.Application.UseCases.Veiculo.CriarVeiculos
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCriarVeiculosUseCase(this IServiceCollection services)
        {
            services.AddSingleton<ICriarVeiculosUseCase, CriarVeiculosUseCase>();

            return services;
        }
    }
}