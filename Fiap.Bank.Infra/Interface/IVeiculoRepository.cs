using Fiap.Bank.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Infra.Interface
{
    public enum AddVeiculoResult
    {
        Sucesso,
        VeiculoDuplicado
    }

    public interface IVeiculoRepository
    {
        Task<AddVeiculoResult> CriarVeiculosAsync(CancellationToken cancellationToken);

        Task<List<VeiculoEntity>> ListarVeiculosAsync(CancellationToken cancellationToken);
    }
}