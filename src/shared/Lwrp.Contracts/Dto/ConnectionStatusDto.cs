namespace Lwrp.Contracts;

public sealed record ConnectionStatusDto(
    bool IsHealthy,
    string? Message,
    DateTimeOffset CheckedAt);
