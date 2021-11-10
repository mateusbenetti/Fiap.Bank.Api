using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Application.UseCases.Veiculo.BuscarVeiculo
{
    public interface IBuscarVeiculoUseCase
    {
        Task<BuscarVeiculoOutput> ExecuteAsync(BuscarVeiculoInput buscarComprovanteInput, CancellationToken cancelationToken);
    }
}