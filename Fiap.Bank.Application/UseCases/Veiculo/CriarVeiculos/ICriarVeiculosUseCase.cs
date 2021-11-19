using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Application.UseCases.Veiculo.CriarVeiculos
{
    public interface ICriarVeiculosUseCase
    {
        Task ExecuteAsync(CancellationToken cancelationToken);
    }
}