# lwrp-poc-monorepo
This project provides a proof-of-concept .NET implementation for integrating with the Axia Livewire Routing Protocol (LWRP) — the control protocol used by Axia Livewire audio and GPIO devices in broadcast environments. 
- Connect to Livewire devices over TCP port
- Send and parse LWRP commands (VER, SRC, DST, GPI, GPO, etc.)
- Handle asynchronous indications from devices
- Manage audio routing, GPIO states, and device configuration
- Provide a foundation for building production-grade Livewire control systems

Because hardware nodes may not always be available during development, this repository also includes an optional LWRP emulator for local testing.


# TODOS

- What is persistence here?:
dotnet add Lwrp.Persistence/Lwrp.Persistence.csproj reference \
  ../core/Lwrp.Domain/Lwrp.Domain.csproj \
  ../core/Lwrp.Application/Lwrp.Application.csproj
Before I link it with another project I need to know what it is supposed to do.
- Research more on interface, I want to build a widget with React if possible to add to the project
- Fix Tree genorator to not include items in gitignore

# Thoughts
## Pure React UI

If you want a fully client-side React application, you could structure it as followed:

1. Client A — the human-facing UI

2. Server A - API awaiting calls. Maintaining TCP connection through loop calling.

2. Server B — the device-facing client that reports status back

In this setup, the API would regularly poll connected devices to retrieve their current state.

## Mock devices
One Mock devide has been created to test the project against. b 

## Make Script Updates Safe
The project-generation script currently overwrites files. I need to modify it so updates are optional and non-destructive, allowing new files to be added without resetting existing ones back to the initial setup.
