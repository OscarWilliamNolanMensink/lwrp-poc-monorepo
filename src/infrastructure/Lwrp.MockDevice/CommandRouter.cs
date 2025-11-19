namespace Lwrp.LivewireClient.MockDevice;

public class CommandRouter
{
    private readonly LoginHandler _login;
    private readonly VerHandler _ver;
    private readonly IpHandler _ip;
    private readonly SetHandler _set;

    public CommandRouter(PasswordStore store, DeviceState state)
    {
        _login = new LoginHandler(store);
        _ver = new VerHandler(state);
        _ip = new IpHandler(state);
        _set = new SetHandler(state);
    }

    public string Route(string line, bool isLocalhost)
    {
        var trimmed = line?.Trim();
        if (string.IsNullOrEmpty(trimmed))
            return string.Empty;

        var parts = trimmed.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 0) return string.Empty;

        var cmd = parts[0].ToUpperInvariant();

        switch (cmd)
        {
            case "LOGIN":
                return _login.HandleLogin(parts, isLocalhost);

            case "PASSWD":
                return _login.HandlePasswd(parts);

            case "VER":
                return _ver.HandleVer();

            case "IP":
                return _ip.HandleIp(parts);

            case "SET":
                return _set.HandleSet(parts);

            default:
                return "ERROR 1000 bad command\n";
        }
    }
}
