namespace Lwrp.LivewireClient;

public class LwrpConnectionOptions
{
    public string Host { get; set; } = "localhost";
    public int Port { get; set; } = 10093;

    public int MaxRetries { get; set; } = 3;
    public int BaseRetryDelayMs { get; set; } = 200;
    public int CommandTimeoutMs { get; set; } = 2000;
}

