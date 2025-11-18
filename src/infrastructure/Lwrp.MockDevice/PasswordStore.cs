namespace Lwrp.LivewireClient.MockDevice;

public class PasswordStore
{
    private string? _password = null; // NULL = no password = full access

    public bool Validate(string? pw) =>
        _password == null || _password == pw;

    public bool Change(string? oldPw, string? newPw)
    {
        if (!Validate(oldPw)) return false;

        _password = string.IsNullOrWhiteSpace(newPw) ? null : newPw;
        return true;
    }

    public bool RequiresPassword => _password != null;
}
