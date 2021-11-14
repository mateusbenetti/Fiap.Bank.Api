using System;

namespace Fiap.Bank.Domain.Entities
{
    public enum TipoVeiculo
    {
        Carro,
        Moto
    }

    public class Veiculo
    {
        public int Ano { get; set; }
        public Guid Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public TipoVeiculo Tipo { get; set; }
    }
}