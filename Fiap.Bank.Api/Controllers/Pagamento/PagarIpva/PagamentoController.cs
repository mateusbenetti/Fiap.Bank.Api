using Microsoft.AspNetCore.Mvc;

namespace Fiap.Bank.Api.Controllers.v1.Pagamento.PagarIpva
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : Controller
    {
        [HttpPost("PagarIpva")]
        public IActionResult PagarIpva()
        {
            return Ok(buscarVeiculoResponse);
        }
    }
}