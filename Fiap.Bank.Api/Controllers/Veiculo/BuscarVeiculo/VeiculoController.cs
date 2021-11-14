using Fiap.Bank.Api.Contracts;
using Fiap.Bank.Application.UseCases.Veiculo.BuscarVeiculo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Api.Controllers.v1.Veiculo.BuscarVeiculo
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IBuscarVeiculoUseCase _buscarVeiculoUseCase;

        public VeiculoController(IBuscarVeiculoUseCase buscarVeiculoUseCase)
        {
            _buscarVeiculoUseCase = buscarVeiculoUseCase;
        }

        [HttpGet("BuscarVeiculo")]
        public async Task<IActionResult> BuscarVeiculo([FromBody] BuscarVeiculoRequest buscarVeiculoRequest, CancellationToken cancellationToken)
        {
            var buscarVeiculoResponse = new BuscarVeiculoResponse();

            try
            {
                var input = new BuscarVeiculoInput()
                {
                    Agencia = buscarVeiculoRequest.Agencia,
                    Conta = buscarVeiculoRequest.Conta,
                    CpfCliente = buscarVeiculoRequest.CpfCliente
                };

                var outPut = await _buscarVeiculoUseCase.ExecuteAsync(input, cancellationToken).ConfigureAwait(false);

                buscarVeiculoResponse = new BuscarVeiculoResponse
                {
                    Veiculos = outPut.Veiculos.Select(p => new VeiculosResponse()
                    {
                        Ano = p.Ano,
                        Id = p.Id,
                        Marca = p.Marca,
                        Modelo = p.Modelo,
                        Placa = p.Placa
                    }).ToList()
                };
            }
            catch (Exception err)
            {
                BadRequest(err);
            }
            return Ok(buscarVeiculoResponse);
        }
    }
}