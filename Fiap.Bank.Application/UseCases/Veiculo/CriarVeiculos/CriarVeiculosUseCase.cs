using Fiap.Bank.Domain.Service.Veiculo;
using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Application.UseCases.Veiculo.CriarVeiculos
{
    public class CriarVeiculosUseCase : ICriarVeiculosUseCase
    {
        private readonly IVeiculoService _veiculoService;

        public CriarVeiculosUseCase(IVeiculoService veiculoService)

        {
            _veiculoService = veiculoService;
        }

        public async Task ExecuteAsync(CancellationToken cancelationToken)
        {
            await _veiculoService.CriarVeiculosAsync(cancelationToken);
        }
    }
}