param(
    [string]$SolutionName = "LwrpPoC",
    [string]$dotNetFramework = "net8.0"
)

$ErrorActionPreference = "Stop"

Write-Host "Setting the repo root (two levels above ops/scripts)..."
$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$RepoRootParent = Join-Path $ScriptDir "..\.."
$RepoRoot = Resolve-Path $RepoRootParent
Set-Location $RepoRoot

Write-Host "Creating solution..."
dotnet new sln -n $SolutionName

Write-Host "Creating base folders..."
Write-Host "Folders may already exist but must not yet contain files."
New-Item -ItemType Directory -Path "src","tests","docs","ops" -Force | Out-Null
New-Item -ItemType Directory -Path "docs/requirements","docs/protocol","docs/architecture" -Force | Out-Null
New-Item -ItemType Directory -Path "ops/docker","ops/ci","ops/scripts" -Force | Out-Null

# Core
Write-Host "Creating core projects..."
New-Item -ItemType Directory -Path "src/core" -Force | Out-Null
Set-Location "src/core"

dotnet new classlib -n Lwrp.Domain --framework $dotNetFramework
dotnet new classlib -n Lwrp.Application --framework $dotNetFramework

Write-Host "Linking Application -> Domain..."
dotnet add "Lwrp.Application/Lwrp.Application.csproj" reference "Lwrp.Domain/Lwrp.Domain.csproj"

Set-Location ../..  # repo root

dotnet sln "$SolutionName.sln" add `
  "src/core/Lwrp.Domain/Lwrp.Domain.csproj" `
  "src/core/Lwrp.Application/Lwrp.Application.csproj"

# Infrastructure
Write-Host "Creating infrastructure projects..."
New-Item -ItemType Directory -Path "src/infrastructure" -Force | Out-Null
Set-Location "src/infrastructure"

dotnet new console -n Lwrp.MockDevice --framework $dotNetFramework
dotnet new classlib -n Lwrp.LivewireClient --framework $dotNetFramework
dotnet new classlib -n Lwrp.Persistence --framework $dotNetFramework

Write-Host "Linking infrastructure -> core..."
dotnet add "Lwrp.LivewireClient/Lwrp.LivewireClient.csproj" reference `
  "../core/Lwrp.Domain/Lwrp.Domain.csproj" `
  "../core/Lwrp.Application/Lwrp.Application.csproj"

dotnet add "Lwrp.Persistence/Lwrp.Persistence.csproj" reference `
  "../core/Lwrp.Domain/Lwrp.Domain.csproj" `
  "../core/Lwrp.Application/Lwrp.Application.csproj"

Write-Host "Adding infrastructure package references..."
dotnet add "Lwrp.LivewireClient/Lwrp.LivewireClient.csproj" package "Microsoft.Extensions.Options" --version "8.0.0"

Set-Location ../..

dotnet sln "$SolutionName.sln" add `
  "src/infrastructure/Lwrp.MockDevice/Lwrp.MockDevice.csproj" `
  "src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj" `
  "src/infrastructure/Lwrp.Persistence/Lwrp.Persistence.csproj"

# API
Write-Host "Creating API project..."
New-Item -ItemType Directory -Path "src/api" -Force | Out-Null
Set-Location "src/api"
dotnet new webapi -n Lwrp.Api --framework $dotNetFramework
Set-Location ../..

dotnet sln "$SolutionName.sln" add "src/api/Lwrp.Api/Lwrp.Api.csproj"

Write-Host "Adding API package references..."
dotnet add "src/api/Lwrp.Api/Lwrp.Api.csproj" package "Microsoft.AspNetCore.OpenApi" --version "8.0.22"
dotnet add "src/api/Lwrp.Api/Lwrp.Api.csproj" package "Swashbuckle.AspNetCore" --version "6.6.2"

Write-Host "Linking API -> core + infrastructure..."
dotnet add "src/api/Lwrp.Api/Lwrp.Api.csproj" reference `
  "src/core/Lwrp.Domain/Lwrp.Domain.csproj" `
  "src/core/Lwrp.Application/Lwrp.Application.csproj" `
  "src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj" `
  "src/infrastructure/Lwrp.Persistence/Lwrp.Persistence.csproj"

# UI + shared
Write-Host "Creating UI project..."
New-Item -ItemType Directory -Path "src/ui" -Force | Out-Null
Set-Location "src/ui"
dotnet new blazor -n Lwrp.WebUi --interactivity Server --framework $dotNetFramework
Set-Location ../..

dotnet sln "$SolutionName.sln" add "src/ui/Lwrp.WebUi/Lwrp.WebUi.csproj"

Write-Host "Creating shared contracts project..."
New-Item -ItemType Directory -Path "src/shared" -Force | Out-Null
Set-Location "src/shared"
dotnet new classlib -n Lwrp.Contracts --framework $dotNetFramework
Set-Location ../..

dotnet sln "$SolutionName.sln" add "src/shared/Lwrp.Contracts/Lwrp.Contracts.csproj"

Write-Host "Linking contracts to Application, API + UI..."
dotnet add "src/core/Lwrp.Application/Lwrp.Application.csproj" reference "src/shared/Lwrp.Contracts/Lwrp.Contracts.csproj"
dotnet add "src/api/Lwrp.Api/Lwrp.Api.csproj" reference "src/shared/Lwrp.Contracts/Lwrp.Contracts.csproj"
dotnet add "src/ui/Lwrp.WebUi/Lwrp.WebUi.csproj" reference "src/shared/Lwrp.Contracts/Lwrp.Contracts.csproj"

# Tests - unit
Write-Host "Creating unit test projects..."
New-Item -ItemType Directory -Path "tests/unit" -Force | Out-Null
Set-Location "tests/unit"

dotnet new xunit -n Lwrp.Domain.UnitTests --framework $dotNetFramework
dotnet new xunit -n Lwrp.Application.UnitTests --framework $dotNetFramework

dotnet add "Lwrp.Domain.UnitTests/Lwrp.Domain.UnitTests.csproj" reference `
  "../../src/core/Lwrp.Domain/Lwrp.Domain.csproj"

dotnet add "Lwrp.Application.UnitTests/Lwrp.Application.UnitTests.csproj" reference `
  "../../src/core/Lwrp.Application/Lwrp.Application.csproj"

Set-Location ../..

dotnet sln "$SolutionName.sln" add `
  "tests/unit/Lwrp.Domain.UnitTests/Lwrp.Domain.UnitTests.csproj" `
  "tests/unit/Lwrp.Application.UnitTests/Lwrp.Application.UnitTests.csproj"

# Tests - integration
Write-Host "Creating integration test projects..."
New-Item -ItemType Directory -Path "tests/integration" -Force | Out-Null
Set-Location "tests/integration"

dotnet new xunit -n Lwrp.Api.IntegrationTests --framework $dotNetFramework
dotnet new xunit -n Lwrp.Infrastructure.IntegrationTests --framework $dotNetFramework

dotnet add "Lwrp.Api.IntegrationTests/Lwrp.Api.IntegrationTests.csproj" reference `
  "../../src/api/Lwrp.Api/Lwrp.Api.csproj"

dotnet add "Lwrp.Infrastructure.IntegrationTests/Lwrp.Infrastructure.IntegrationTests.csproj" reference `
  "../../src/infrastructure/Lwrp.MockDevice/Lwrp.MockDevice.csproj" `
  "../../src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj" `
  "../../src/infrastructure/Lwrp.Persistence/Lwrp.Persistence.csproj"

Set-Location ../..

dotnet sln "$SolutionName.sln" add `
  "tests/integration/Lwrp.Api.IntegrationTests/Lwrp.Api.IntegrationTests.csproj" `
  "tests/integration/Lwrp.Infrastructure.IntegrationTests/Lwrp.Infrastructure.IntegrationTests.csproj"

# Tests - component/E2E
Write-Host "Creating component/E2E test projects..."
New-Item -ItemType Directory -Path "tests/component" -Force | Out-Null
Set-Location "tests/component"

dotnet new xunit -n Lwrp.ComponentTests.ApiToLwrp --framework $dotNetFramework
dotnet new xunit -n Lwrp.ComponentTests.UiToApi --framework $dotNetFramework

dotnet add "Lwrp.ComponentTests.ApiToLwrp/Lwrp.ComponentTests.ApiToLwrp.csproj" reference `
  "../../src/api/Lwrp.Api/Lwrp.Api.csproj" `
  "../../src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj"  `
  "../../src/infrastructure/Lwrp.MockDevice/Lwrp.MockDevice.csproj"

dotnet add "Lwrp.ComponentTests.UiToApi/Lwrp.ComponentTests.UiToApi.csproj" reference `
  "../../src/ui/Lwrp.WebUi/Lwrp.WebUi.csproj"

Set-Location ../..

dotnet sln "$SolutionName.sln" add `
  "tests/component/Lwrp.ComponentTests.ApiToLwrp/Lwrp.ComponentTests.ApiToLwrp.csproj" `
  "tests/component/Lwrp.ComponentTests.UiToApi/Lwrp.ComponentTests.UiToApi.csproj"

# Docker
Write-Host "Creating Docker skeleton..."
@'
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . ./
RUN dotnet publish src/api/Lwrp.Api/Lwrp.Api.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Lwrp.Api.dll"]
'@ | Set-Content "ops/docker/api.Dockerfile"

@'
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . ./
RUN dotnet publish src/ui/Lwrp.WebUi/Lwrp.WebUi.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Lwrp.WebUi.dll"]
'@ | Set-Content "ops/docker/ui.Dockerfile"

@'
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
  mock-lwrp-device:
    build:
      context: ../../src/infrastructure/Lwrp.MockDevice
      dockerfile: Dockerfile
    ports:
      - "10093:93"
'@ | Set-Content "ops/docker/docker-compose.yml"

Write-Host "Running dotnet build + test..."
dotnet build
dotnet test

Write-Host "Bootstrap complete! Repo root: $(Get-Location)"
