using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fiap.Bank.Api.Contracts
{
    [DataContract]
    public class BuscarVeiculoResponse
    {
        [DataMember]
        public ICollection<VeiculosResponse> Veiculos { get; set; }
    }

    public class VeiculosResponse
    {
        [DataMember]
        public int Ano { get; set; }

        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Marca { get; set; }

        [DataMember]
        public string Modelo { get; set; }

        [DataMember]
        public string Placa { get; set; }
    }
}