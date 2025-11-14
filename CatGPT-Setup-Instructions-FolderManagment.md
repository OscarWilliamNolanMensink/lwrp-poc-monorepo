lwrp-poc-monorepo/
├─ LwrpPoC.sln                # Single solution referencing all .NET projects
├─ README.md
├─ docs/
│  ├─ requirements/
│  │  └─ triple-audio-assignment.md
│  ├─ protocol/
│  │  └─ lwrp-notes.md
│  └─ architecture/
│     └─ solution-design.md
│
├─ src/
│  ├─ api/                    # ASP.NET Core 8 API host (Swagger here)
│  │  └─ Lwrp.Api/
│  │     ├─ Controllers/
│  │     ├─ Endpoints/        # if you use minimal APIs
│  │     ├─ Configuration/    # Swagger, DI, logging, etc.
│  │     ├─ Program.cs
│  │     └─ appsettings.json
│  │
│  ├─ core/                   # Pure, framework-agnostic code
│  │  ├─ Lwrp.Domain/         # Entities, value objects, errors, abstractions
│  │  └─ Lwrp.Application/    # Use cases, services, command/query handlers
│  │
│  ├─ infrastructure/         # Concrete implementations
│  │  ├─ Lwrp.LivewireClient/ # LWRP protocol client (sockets, reconnect logic, etc.)
│  │  └─ Lwrp.Persistence/    # If you need DB or state persistence
│  │
│  ├─ ui/                     # Manual interaction UI
│  │  └─ Lwrp.WebUi/          # e.g. Blazor, Razor Pages or React+Vite
│  │     ├─ Pages/            # If Blazor/Razor
│  │     ├─ Components/
│  │     └─ (or src/ if React SPA)
│  │
│  └─ tools/
│     └─ python/
│        ├─ scripts/
│        │  ├─ load_test_lwrp.py
│        │  └─ analyze_logs.py
│        └─ requirements.txt
│
├─ tests/
│  ├─ unit/
│  │  ├─ Lwrp.Domain.UnitTests/
│  │  └─ Lwrp.Application.UnitTests/
│  │
│  ├─ integration/
│  │  ├─ Lwrp.Api.IntegrationTests/       # API tests (with TestServer / dockerized deps)
│  │  └─ Lwrp.Infrastructure.IntegrationTests/
│  │
│  └─ component/                          # End-to-end / component tests
│     ├─ Lwrp.ComponentTests.ApiToLwrp/   # API <-> LivewireClient <-> fake LWRP server
│     └─ Lwrp.ComponentTests.UiToApi/     # UI <-> API (e.g. Playwright or Cypress)
│
├─ ops/                                  # Hosting, CI/CD, Docker
│  ├─ docker/
│  │  ├─ api.Dockerfile
│  │  ├─ ui.Dockerfile
│  │  └─ docker-compose.yml              # API + UI + fake LWRP server + DB if needed
│  ├─ ci/
│  │  ├─ github/
│  │  │  └─ main.yml                     # build, test, docker build & push
│  │  └─ azure-pipelines.yml             # (if needed)
│  └─ scripts/
│     ├─ build-all.ps1
│     └─ build-all.sh
│
└─ .editorconfig


Sure, let’s build this step-by-step as if you’re starting from an empty folder. I’ll assume .NET 8 and that you’re OK with a Blazor Server UI (all .NET, keeps things simple).
You can copy-paste most of these commands into a terminal.

0. Prereqs
Make sure you have:


.NET SDK 8+


Git (optional but recommended)



1. Create root folder & solution
mkdir lwrp-poc-monorepo
cd lwrp-poc-monorepo

dotnet new sln -n LwrpPoC

Add basic folders:
mkdir src tests docs ops
mkdir docs/requirements docs/protocol docs/architecture
mkdir ops/docker ops/ci ops/scripts


2. Create core projects (Domain + Application)
2.1 Domain
mkdir -p src/core
cd src/core

dotnet new classlib -n Lwrp.Domain

2.2 Application
dotnet new classlib -n Lwrp.Application

Make Application depend on Domain:
dotnet add Lwrp.Application/Lwrp.Application.csproj reference Lwrp.Domain/Lwrp.Domain.csproj

Add both to the solution:
cd ../..   # back to repo root

dotnet sln LwrpPoC.sln add \
  src/core/Lwrp.Domain/Lwrp.Domain.csproj \
  src/core/Lwrp.Application/Lwrp.Application.csproj


3. Create infrastructure projects
mkdir -p src/infrastructure
cd src/infrastructure

dotnet new classlib -n Lwrp.LivewireClient
dotnet new classlib -n Lwrp.Persistence

Set references:


LivewireClient usually needs Domain + Application:


dotnet add Lwrp.LivewireClient/Lwrp.LivewireClient.csproj reference \
  ../core/Lwrp.Domain/Lwrp.Domain.csproj \
  ../core/Lwrp.Application/Lwrp.Application.csproj



Persistence often needs Domain + Application too (up to you):

# Decide on persisstance
dotnet add Lwrp.Persistence/Lwrp.Persistence.csproj reference \
  ../core/Lwrp.Domain/Lwrp.Domain.csproj \
  ../core/Lwrp.Application/Lwrp.Application.csproj

Add to solution:
cd ../..

dotnet sln LwrpPoC.sln add \
  src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj \
  src/infrastructure/Lwrp.Persistence/Lwrp.Persistence.csproj


4. Create the API project (with Swagger)
4.1 Create the API
mkdir -p src/api
cd src/api

# Minimal Web API (includes Swagger plumbing by default on .NET 8)
dotnet new webapi -n Lwrp.Api

Move back & add to solution:
cd ../..

dotnet sln LwrpPoC.sln add src/api/Lwrp.Api/Lwrp.Api.csproj

4.2 Wire up project references for the API
API should depend on core + infrastructure:
dotnet add src/api/Lwrp.Api/Lwrp.Api.csproj reference \
  src/core/Lwrp.Domain/Lwrp.Domain.csproj \
  src/core/Lwrp.Application/Lwrp.Application.csproj \
  src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj \
  src/infrastructure/Lwrp.Persistence/Lwrp.Persistence.csproj

# Swagger is enabled but we dont have the api calls ATM so leave this till later
4.3 Ensure Swagger is enabled
The webapi template already wires up Swagger, but check Program.cs in Lwrp.Api:
You want something like:
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Swagger UI at /swagger
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

Now test it:
dotnet run --project src/api/Lwrp.Api/Lwrp.Api.csproj

Visit: https://localhost:5001/swagger (or the port shown in the console).

# Stopping here for first push (Need to research interface more first)
5. Create the UI project (manual interaction)
Let’s use Blazor Server hosted separately from the API.
mkdir -p src/ui
cd src/ui

dotnet new blazorserver -n Lwrp.WebUi

Add to solution:
cd ../..

dotnet sln LwrpPoC.sln add src/ui/Lwrp.WebUi/Lwrp.WebUi.csproj

If the UI needs to share models or DTOs, you can:


Put shared contracts in Lwrp.Application or a separate Lwrp.Contracts project.


Reference that from both Lwrp.Api and Lwrp.WebUi.


Example shared contracts library (optional but nice):
mkdir -p src/shared
cd src/shared

dotnet new classlib -n Lwrp.Contracts

cd ../..

dotnet sln LwrpPoC.sln add src/shared/Lwrp.Contracts/Lwrp.Contracts.csproj

dotnet add src/api/Lwrp.Api/Lwrp.Api.csproj reference src/shared/Lwrp.Contracts/Lwrp.Contracts.csproj
dotnet add src/ui/Lwrp.WebUi/Lwrp.WebUi.csproj reference src/shared/Lwrp.Contracts/Lwrp.Contracts.csproj

Inside Lwrp.WebUi, you’ll call your API via HttpClient to trigger LWRP actions.

6. Set up testing projects
We’ll use xUnit + coverlet (default “xunit” template).
6.1 Unit tests
mkdir -p tests/unit
cd tests/unit

dotnet new xunit -n Lwrp.Domain.UnitTests
dotnet new xunit -n Lwrp.Application.UnitTests

Reference the corresponding projects:
dotnet add Lwrp.Domain.UnitTests/Lwrp.Domain.UnitTests.csproj reference \
  ../../src/core/Lwrp.Domain/Lwrp.Domain.csproj

dotnet add Lwrp.Application.UnitTests/Lwrp.Application.UnitTests.csproj reference \
  ../../src/core/Lwrp.Application/Lwrp.Application.csproj

Add to solution:
cd ../..

dotnet sln LwrpPoC.sln add \
  tests/unit/Lwrp.Domain.UnitTests/Lwrp.Domain.UnitTests.csproj \
  tests/unit/Lwrp.Application.UnitTests/Lwrp.Application.UnitTests.csproj

6.2 Integration tests
mkdir -p tests/integration
cd tests/integration

dotnet new xunit -n Lwrp.Api.IntegrationTests
dotnet new xunit -n Lwrp.Infrastructure.IntegrationTests

References:


API integration tests need the API project (for WebApplicationFactory):


dotnet add Lwrp.Api.IntegrationTests/Lwrp.Api.IntegrationTests.csproj reference \
  ../../src/api/Lwrp.Api/Lwrp.Api.csproj



Infrastructure integration tests need infrastructure projects:


dotnet add Lwrp.Infrastructure.IntegrationTests/Lwrp.Infrastructure.IntegrationTests.csproj reference \
  ../../src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj \
  ../../src/infrastructure/Lwrp.Persistence/Lwrp.Persistence.csproj

Add to solution:
cd ../..

dotnet sln LwrpPoC.sln add \
  tests/integration/Lwrp.Api.IntegrationTests/Lwrp.Api.IntegrationTests.csproj \
  tests/integration/Lwrp.Infrastructure.IntegrationTests/Lwrp.Infrastructure.IntegrationTests.csproj

6.3 Component / E2E tests
You might use Playwright or similar here. For now, create placeholder projects:
mkdir -p tests/component
cd tests/component

dotnet new xunit -n Lwrp.ComponentTests.ApiToLwrp
dotnet new xunit -n Lwrp.ComponentTests.UiToApi

Add references:
dotnet add Lwrp.ComponentTests.ApiToLwrp/Lwrp.ComponentTests.ApiToLwrp.csproj reference \
  ../../src/api/Lwrp.Api/Lwrp.Api.csproj \
  ../../src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj

dotnet add Lwrp.ComponentTests.UiToApi/Lwrp.ComponentTests.UiToApi.csproj reference \
  ../../src/ui/Lwrp.WebUi/Lwrp.WebUi.csproj

Add to solution:
cd ../..

dotnet sln LwrpPoC.sln add \
  tests/component/Lwrp.ComponentTests.ApiToLwrp/Lwrp.ComponentTests.ApiToLwrp.csproj \
  tests/component/Lwrp.ComponentTests.UiToApi/Lwrp.ComponentTests.UiToApi.csproj

6.4 Run all tests
From the repo root:
dotnet test


7. Optional: basic Docker + compose skeleton
Create minimal files (you can fill them later):
cat > ops/docker/api.Dockerfile << 'EOF'
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish src/api/Lwrp.Api/Lwrp.Api.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Lwrp.Api.dll"]
EOF

(Same idea for ui.Dockerfile.)
Docker Compose skeleton:
cat > ops/docker/docker-compose.yml << 'EOF'
services:
  api:
    build:
      context: ../..
      dockerfile: ops/docker/api.Dockerfile
    ports:
      - "5000:8080"
  ui:
    build:
      context: ../..
      dockerfile: ops/docker/ui.Dockerfile
    ports:
      - "5001:8080"
EOF


8. Quick sanity checklist
From repo root:


dotnet build ✅


dotnet test ✅


dotnet run --project src/api/Lwrp.Api → Swagger at /swagger ✅


dotnet run --project src/ui/Lwrp.WebUi → UI loads & can call API ✅



If you want, next I can:


Show a minimal controller in Lwrp.Api that calls a stubbed Lwrp.LivewireClient service, and


A basic Blazor page that hits that endpoint so you have end-to-end “button → API → fake LWRP client → response” working.

