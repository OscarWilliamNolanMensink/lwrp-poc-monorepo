namespace Lwrp.LivewireClient;

public sealed class LwrpConnectionOptions
{
    public string Host { get; set; } = "localhost";
    public int Port { get; set; } = 10093; // docker-mapped port to the mock device
}
