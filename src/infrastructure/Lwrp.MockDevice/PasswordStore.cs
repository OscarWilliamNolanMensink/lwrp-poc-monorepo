namespace Lwrp.LivewireClient.MockDevice;

public class PasswordStore
{
    private string? _password = "password123"; // This should be updated an changed to a config file and/or in the docker set up.

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
