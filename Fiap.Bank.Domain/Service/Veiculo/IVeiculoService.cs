using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Domain.Service.Veiculo
{
    public interface IVeiculoService
    {
        Task CriarVeiculosAsync(CancellationToken cancelationToken);
    }
}