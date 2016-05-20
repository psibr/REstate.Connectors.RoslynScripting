using REstate.Services;
using System.Threading.Tasks;
using Psibr.Platform.Logging;

namespace REstate.Connectors.RoslynScripting
{
    public class RoslynConnectorFactory
        : IConnectorFactory
    {
        private readonly IPlatformLogger _logger;

        public RoslynConnectorFactory(IPlatformLogger logger)
        {
            _logger = logger;
        }

        public string ConnectorKey { get; } = "REstate.Connectors.RoslynScripting";
        public bool IsActionConnector { get; } = true;
        public bool IsGuardConnector { get; } = true;
        public string ConnectorSchema { get; set; } = "{ }";

        public Task<IConnector> BuildConnector(string apiKey)
        {
            return Task.FromResult<IConnector>(new RoslynConnector(_logger, apiKey));
        }
    }
}