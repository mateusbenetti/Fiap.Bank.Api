using Fiap.Bank.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Repository.Interface
{
    public enum AddVeiculoResult
    {
        Sucesso,
        VeiculoDuplicado
    }

    public interface IVeiculoRepository
    {
        Task<AddVeiculoResult> BuildVeiculosAsync(CancellationToken cancellationToken);

        Task<List<Veiculo>> ListarVeiculosAsync(CancellationToken cancellationToken);
    }
}