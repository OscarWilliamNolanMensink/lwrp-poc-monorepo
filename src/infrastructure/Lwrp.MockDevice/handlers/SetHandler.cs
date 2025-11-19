namespace Lwrp.LivewireClient.MockDevice;

public class SetHandler
{
    private readonly DeviceState _state;

    public SetHandler(DeviceState state)
    {
        _state = state;
    }

    // client: SET <name1>:<value1> [<name2>:<value2>...]
    public string HandleSet(string[] parts)
    {
        if (parts.Length < 2)
            return "ERROR 1001 syntax error\n";

        // Just store the tokens as key:value pairs.
        // This is a simple implementation; it doesn't handle quoted values with spaces.
        for (int i = 1; i < parts.Length; i++)
        {
            var token = parts[i];
            var idx = token.IndexOf(':');
            if (idx <= 0 || idx == token.Length - 1)
                continue; // ignore malformed

            var name = token[..idx];
            var value = token[(idx + 1)..];

            _state.GlobalParameters[name] = value;
        }

        // Echo back exactly what was set (minus the "SET" keyword)
        var echo = string.Join(' ', parts.Skip(1));
        return $"SET {echo}\n";
    }
}
