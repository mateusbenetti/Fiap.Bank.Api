using Microsoft.AspNetCore.Mvc;

namespace Fiap.Bank.Api.Controllers.v1.Veiculo.BuscarVeiculo
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : Controller
    {
        [HttpGet("BuscarVeiculo")]
        public IActionResult BuscarVeiculo()
        {
            return View();
        }
    }
}