using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lwrp.LivewireClient.MockDevice;

public class MockLwrpServer
{
    private readonly CommandRouter _router;

    public MockLwrpServer(CommandRouter router)
    {
        _router = router;
    }

    public async Task StartAsync()
    {
        var listener = new TcpListener(IPAddress.Any, 93);
        listener.Start();

        while (true)
        {
            var client = await listener.AcceptTcpClientAsync();
            _ = HandleClient(client);
        }
    }

    private async Task HandleClient(TcpClient client)
    {
        using var stream = client.GetStream();
        using var reader = new StreamReader(stream);
        using var writer = new StreamWriter(stream) { AutoFlush = true };

        bool isLocalhost = ((IPEndPoint)client.Client.RemoteEndPoint!).Address.ToString() == "127.0.0.1";

        while (client.Connected)
        {
            var line = await reader.ReadLineAsync();
            if (line == null) break;

            var response = _router.Route(line, isLocalhost);
            await writer.WriteAsync(response);
        }
    }
}
