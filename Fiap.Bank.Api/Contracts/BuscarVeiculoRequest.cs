using System.Runtime.Serialization;

namespace Fiap.Bank.Api.Contracts
{
    [DataContract]
    public class BuscarVeiculoRequest
    {
        [DataMember]
        public string Agencia { get; set; }

        [DataMember]
        public string Conta { get; set; }

        [DataMember]
        public string CpfCliente { get; set; }
    }
}