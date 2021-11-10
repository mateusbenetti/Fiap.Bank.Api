using Microsoft.AspNetCore.Mvc;

namespace Fiap.Bank.Api.Controllers.v1.Veiculo.DetalheVeiculo
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : Controller
    {
        [HttpGet("DetalheVeiculo")]
        public IActionResult DetalheVeiculo()
        {
            return View();
        }
    }
}