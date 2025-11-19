using System.Net;

namespace Lwrp.LivewireClient.MockDevice;

public class IpHandler
{
    private readonly DeviceState _state;

    public IpHandler(DeviceState state)
    {
        _state = state;
    }

    // client: IP [address <d.d.d.d>] [netmask <d.d.d.d>] [gateway <d.d.d.d>] [hostname <name>]
    public string HandleIp(string[] parts)
    {
        // Query current configuration
        if (parts.Length == 1)
        {
            return
                $"IP address:{_state.IpAddress} " +
                $"netmask:{_state.Netmask} " +
                $"gateway:{_state.Gateway} " +
                $"hostname:{_state.Hostname}\n";
        }

        // Simple token-based parser: IP <key> <value> [<key> <value>...]
        // Example: IP address 10.0.0.5 netmask 255.255.0.0 hostname Mock-IO
        for (int i = 1; i < parts.Length; i += 2)
        {
            if (i + 1 >= parts.Length)
                return "ERROR 1001 syntax error\n"; // missing value

            var key = parts[i].ToLowerInvariant();
            var value = parts[i + 1];

            switch (key)
            {
                case "address":
                    if (!IsValidIp(value)) return "ERROR 1001 syntax error\n";
                    _state.IpAddress = value;
                    break;

                case "netmask":
                    if (!IsValidIp(value)) return "ERROR 1001 syntax error\n";
                    _state.Netmask = value;
                    break;

                case "gateway":
                    if (!IsValidIp(value)) return "ERROR 1001 syntax error\n";
                    _state.Gateway = value;
                    break;

                case "hostname":
                    if (!IsValidHostname(value))
                        return "ERROR 1001 syntax error\n"; // Bad hostname
                    _state.Hostname = value;
                    break;

                default:
                    // Spec says: client should ignore parameters it does not process.
                    // We'll just ignore unknown keys.
                    break;
            }
        }

        // Echo back resulting configuration
        return
            $"IP address:{_state.IpAddress} " +
            $"netmask:{_state.Netmask} " +
            $"gateway:{_state.Gateway} " +
            $"hostname:{_state.Hostname}\n";
    }

    private bool IsValidIp(string value)
    {
        return IPAddress.TryParse(value, out _)
               && value.Count(c => c == '.') == 3; // keep it IPv4-ish
    }

    private bool IsValidHostname(string value)
    {
        // Protocol: no spaces, max 12 chars
        if (string.IsNullOrWhiteSpace(value)) return false;
        if (value.Length > 12) return false;
        if (value.Any(char.IsWhiteSpace)) return false;
        return true;
    }
}
