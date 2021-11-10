using System.Diagnostics.CodeAnalysis;

namespace Fiap.Bank.Infra.Shared.MongoDb
{
    [ExcludeFromCodeCoverage]
    public class MongoConfiguration
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}