using System.Diagnostics.CodeAnalysis;

namespace Fiap.Bank.Infra.Shared.Redis
{
    [ExcludeFromCodeCoverage]
    public class RedisConfiguration
    {
        public string CacheConnectionString { get; set; }
        public string CacheTokenKey { get; set; }
        public bool EnableCache { get; set; }
        public int MillisecondsBetweenAttempts { get; set; }
        public int MillisecondsToAwaitReconnect { get; set; }
        public int NumberOfRecoveryAttempts { get; set; }
        public bool PersistCache { get; set; }
        public int SecondsToNewReconnectionRequest { get; set; }
        public int TimeToExpireToken { get; set; }
    }
}