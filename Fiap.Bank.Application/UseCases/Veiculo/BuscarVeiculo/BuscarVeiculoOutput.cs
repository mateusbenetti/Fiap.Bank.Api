using System;
using System.Collections.Generic;

namespace Fiap.Bank.Application.UseCases.Veiculo.BuscarVeiculo
{
    public class BuscarVeiculoOutput
    {
        public ICollection<VeiculosOutPut> Veiculos { get; set; }
    }

    public class VeiculosOutPut
    {
        public int Ano { get; set; }
        public Guid Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
    }
}