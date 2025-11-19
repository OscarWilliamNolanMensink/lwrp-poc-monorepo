namespace Lwrp.LivewireClient.MockDevice;

public class DeviceState
{
    // Fixed mock info for VER response
    public string LwrpVersion { get; init; } = "1.4.2";
    public string DeviceName { get; set; } = "MockDevice";
    public string SystemVersion { get; set; } = "1.1.1";

    public int NumberOfSources { get; set; } = 8;
    public int NumberOfDestinations { get; set; } = 8;
    public int NumberOfGpi { get; set; } = 4;
    public int NumberOfGpo { get; set; } = 4;

    // IP configuration
    public string IpAddress { get; set; } = "192.168.1.20";
    public string Netmask { get; set; } = "255.255.255.0";
    public string Gateway { get; set; } = "192.168.1.1";
    public string Hostname { get; set; } = "MockDevice";

    // Global parameters from SET command
    public Dictionary<string, string> GlobalParameters { get; } = new();
}
