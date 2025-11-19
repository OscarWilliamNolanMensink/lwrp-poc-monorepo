namespace Lwrp.LivewireClient.MockDevice;

public class VerHandler
{
    private readonly DeviceState _state;

    public VerHandler(DeviceState state)
    {
        _state = state;
    }

    // client: VER
    // server: VER <name1>:<value1> ...
    public string HandleVer()
    {
        // Format according to spec; you can tweak values as needed.
        return
            $"VER LWRP:{_state.LwrpVersion} " +
            $"DEVN:{_state.DeviceName} " +
            $"SYSV:{_state.SystemVersion} " +
            $"NSRC:{_state.NumberOfSources} " +
            $"NDST:{_state.NumberOfDestinations} " +
            $"NGPI:{_state.NumberOfGpi} " +
            $"NGPO:{_state.NumberOfGpo}\n";
    }
}
