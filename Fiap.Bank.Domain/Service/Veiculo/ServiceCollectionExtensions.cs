using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Bank.Domain.Service.Veiculo
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddVeiculoService(this IServiceCollection services)
        {
            services.AddSingleton<IVeiculoService, VeiculoService>();
            return services;
        }
    }
}