namespace Lwrp.LivewireClient.MockDevice;

public class CommandRouter
{
    private readonly LoginHandler _login;

    public CommandRouter(PasswordStore store)
    {
        _login = new LoginHandler(store);
    }

    public string Route(string line, bool isLocalhost)
    {
        var parts = line.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 0) return "";

        switch (parts[0].ToUpperInvariant())
        {
            case "LOGIN": return _login.HandleLogin(parts, isLocalhost);
            case "PASSWD": return _login.HandlePasswd(parts);

            default:
                return "ERROR 1000 bad command\n";
        }
    }
}
