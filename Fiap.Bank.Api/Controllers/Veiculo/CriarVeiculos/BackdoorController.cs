using Fiap.Bank.Application.UseCases.Veiculo.CriarVeiculos;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Api.Controllers.v1.Veiculo.DetalheVeiculo
{
    [Route("api/[controller]")]
    [ApiController]
    public class BackdoorController : Controller
    {
        private readonly ICriarVeiculosUseCase _criarVeiculosUseCase;

        public BackdoorController(ICriarVeiculosUseCase criarVeiculosUseCase)
        {
            _criarVeiculosUseCase = criarVeiculosUseCase;
        }

        [HttpPost("CriarVeiculos")]
        public async Task<IActionResult> CriarVeiculos(CancellationToken cancellationToken)
        {
            await _criarVeiculosUseCase.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return Ok();
        }
    }
}