namespace Lwrp.LivewireClient.MockDevice;

public class LoginHandler
{
    private readonly PasswordStore _passwords;

    public LoginHandler(PasswordStore store) => _passwords = store;

    public string HandleLogin(string[] parts, bool isLocalhost)
    {
        // LOGIN [password]
        if (isLocalhost)
            return "LOGIN OK\n";

        if (parts.Length == 1)
            return "LOGIN READONLY\n";

        var pw = parts[1];
        return _passwords.Validate(pw)
            ? "LOGIN OK\n"
            : "ERROR 1004 invalid password\n";
    }

    public string HandlePasswd(string[] parts)
    {
        // PASSWD [old] [new]
        string? oldPw = parts.Length > 1 ? parts[1] : null;
        string? newPw = parts.Length > 2 ? parts[2] : null;

        if (_passwords.Change(oldPw, newPw))
            return "PASSWD OK\n";

        return "ERROR 1004 invalid password\n";
    }
}
