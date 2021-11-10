using Fiap.Bank.Api.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Api.Controllers.v1.Pagamento.BuscarComprovante
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        public PagamentoController()
        {
        }

        [HttpGet("BuscarComprovante")]
        public async Task<ActionResult> BuscarComprovante([FromBody] BuscarVeiculoRequest buscarVeiculoInput, CancellationToken cancellationToken)
        {
            var buscarVeiculoResponse = new BuscarVeiculoResponse();

            return Ok(buscarVeiculoResponse);
        }
    }
}