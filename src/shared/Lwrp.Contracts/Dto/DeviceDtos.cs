namespace Lwrp.Contracts;

public record VerInfo(
    string LwrpVersion,
    string DeviceName,
    string SystemVersion,
    int NumberOfSources,
    int NumberOfDestinations,
    int NumberOfGpi,
    int NumberOfGpo);

public record IpConfig(
    string Address,
    string Netmask,
    string Gateway,
    string Hostname);
