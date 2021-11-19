using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Fiap.Bank.Infra.Data.Entities
{
    public enum TipoVeiculo
    {
        Carro,
        Moto
    }

    public class VeiculoEntity
    {
        public int Ano { get; set; }

        public DateTime DataCadastro { get; set; }

        [BsonId]
        public Guid Id { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }

        [BsonElement]
        public TipoVeiculo Tipo { get; set; }
    }
}