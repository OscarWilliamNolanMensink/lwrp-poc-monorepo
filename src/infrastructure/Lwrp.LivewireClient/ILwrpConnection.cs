using System.Threading;

namespace Lwrp.LivewireClient;

public interface ILwrpConnection : IAsyncDisposable
{
    Task<string?> SendCommandAsync(string command, CancellationToken cancellationToken = default);
}
