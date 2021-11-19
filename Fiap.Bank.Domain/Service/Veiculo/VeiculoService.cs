using Fiap.Bank.Infra.Interface;
using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Domain.Service.Veiculo
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task CriarVeiculosAsync(CancellationToken cancelationToken)
        {
            var veiculosResult = await _veiculoRepository.CriarVeiculosAsync(cancelationToken).ConfigureAwait(false);
        }
    }
}