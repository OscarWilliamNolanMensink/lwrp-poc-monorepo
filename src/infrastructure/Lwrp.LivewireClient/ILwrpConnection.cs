using System.Threading;

namespace Lwrp.LivewireClient;

public interface ILwrpConnection : IAsyncDisposable
{
    Task<string?> SendCommandAsync(string command, CancellationToken cancellationToken = default);
     /// <summary>
    /// Remember the last successfully used password so that
    /// the connection can automatically re-login after a reconnect.
    /// </summary>
    void RememberPassword(string password);
}
