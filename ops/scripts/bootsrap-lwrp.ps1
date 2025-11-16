param(
    [string]$SolutionName = "LwrpPoC",
)

$ErrorActionPreference = "Stop"

Write-Host "Setting the root folder just above ops"
$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$RepoRootParent = Join-Path $ScriptDir "..\.."
$FullRootPath = Join-Path (Resolve-Path $RepoRootParent) $RootDir
New-Item -ItemType Directory -Path $FullRootPath -Force | Out-Null
Set-Location $FullRootPath

Write-Host "Creating solution..."
dotnet new sln -n $SolutionName

Write-Host "Creating base folders..."
Write-Host "Folders may alread exist but must not yet contain files."
New-Item -ItemType Directory -Path "src","tests","docs","ops" -Force | Out-Null
New-Item -ItemType Directory -Path "docs/requirements","docs/protocol","docs/architecture" -Force | Out-Null
New-Item -ItemType Directory -Path "ops/docker","ops/ci","ops/scripts" -Force | Out-Null

# Core
Write-Host "Creating core projects..."
New-Item -ItemType Directory -Path "src/core" -Force | Out-Null
Set-Location "src/core"

dotnet new classlib -n Lwrp.Domain
dotnet new classlib -n Lwrp.Application

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

dotnet new classlib -n Lwrp.LivewireClient 
dotnet new classlib -n Lwrp.Persistence

Write-Host "Linking infrastructure -> core..."
dotnet add "Lwrp.LivewireClient/Lwrp.LivewireClient.csproj" reference `
  "../core/Lwrp.Domain/Lwrp.Domain.csproj" `
  "../core/Lwrp.Application/Lwrp.Application.csproj"

dotnet add "Lwrp.Persistence/Lwrp.Persistence.csproj" reference `
  "../core/Lwrp.Domain/Lwrp.Domain.csproj" `
  "../core/Lwrp.Application/Lwrp.Application.csproj"

Set-Location ../..

dotnet sln "$SolutionName.sln" add `
  "src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj" `
  "src/infrastructure/Lwrp.Persistence/Lwrp.Persistence.csproj"

# API
Write-Host "Creating API project..."
New-Item -ItemType Directory -Path "src/api" -Force | Out-Null
Set-Location "src/api"
dotnet new webapi -n Lwrp.Api
Set-Location ../..

dotnet sln "$SolutionName.sln" add "src/api/Lwrp.Api/Lwrp.Api.csproj"

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
dotnet new blazorserver -n Lwrp.WebUi
Set-Location ../..

dotnet sln "$SolutionName.sln" add "src/ui/Lwrp.WebUi/Lwrp.WebUi.csproj"

Write-Host "Creating shared contracts project..."
New-Item -ItemType Directory -Path "src/shared" -Force | Out-Null
Set-Location "src/shared"
dotnet new classlib -n Lwrp.Contracts
Set-Location ../..

dotnet sln "$SolutionName.sln" add "src/shared/Lwrp.Contracts/Lwrp.Contracts.csproj"

Write-Host "Linking contracts to API + UI..."
dotnet add "src/api/Lwrp.Api/Lwrp.Api.csproj" reference "src/shared/Lwrp.Contracts/Lwrp.Contracts.csproj"
dotnet add "src/ui/Lwrp.WebUi/Lwrp.WebUi.csproj" reference "src/shared/Lwrp.Contracts/Lwrp.Contracts.csproj"

# Tests
Write-Host "Creating unit test projects..."
New-Item -ItemType Directory -Path "tests/unit" -Force | Out-Null
Set-Location "tests/unit"

dotnet new xunit -n Lwrp.Domain.UnitTests
dotnet new xunit -n Lwrp.Application.UnitTests

dotnet add "Lwrp.Domain.UnitTests/Lwrp.Domain.UnitTests.csproj" reference `
  "../../src/core/Lwrp.Domain/Lwrp.Domain.csproj"

dotnet add "Lwrp.Application.UnitTests/Lwrp.Application.UnitTests.csproj" reference `
  "../../src/core/Lwrp.Application/Lwrp.Application.csproj"

Set-Location ../..

dotnet sln "$SolutionName.sln" add `
  "tests/unit/Lwrp.Domain.UnitTests/Lwrp.Domain.UnitTests.csproj" `
  "tests/unit/Lwrp.Application.UnitTests/Lwrp.Application.UnitTests.csproj"

Write-Host "Creating integration test projects..."
New-Item -ItemType Directory -Path "tests/integration" -Force | Out-Null
Set-Location "tests/integration"

dotnet new xunit -n Lwrp.Api.IntegrationTests
dotnet new xunit -n Lwrp.Infrastructure.IntegrationTests

dotnet add "Lwrp.Api.IntegrationTests/Lwrp.Api.IntegrationTests.csproj" reference `
  "../../src/api/Lwrp.Api/Lwrp.Api.csproj"

dotnet add "Lwrp.Infrastructure.IntegrationTests/Lwrp.Infrastructure.IntegrationTests.csproj" reference `
  "../../src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj" `
  "../../src/infrastructure/Lwrp.Persistence/Lwrp.Persistence.csproj"

Set-Location ../..

dotnet sln "$SolutionName.sln" add `
  "tests/integration/Lwrp.Api.IntegrationTests/Lwrp.Api.IntegrationTests.csproj" `
  "tests/integration/Lwrp.Infrastructure.IntegrationTests/Lwrp.Infrastructure.IntegrationTests.csproj"

Write-Host "Creating component/E2E test projects..."
New-Item -ItemType Directory -Path "tests/component" -Force | Out-Null
Set-Location "tests/component"

dotnet new xunit -n Lwrp.ComponentTests.ApiToLwrp
dotnet new xunit -n Lwrp.ComponentTests.UiToApi

dotnet add "Lwrp.ComponentTests.ApiToLwrp/Lwrp.ComponentTests.ApiToLwrp.csproj" reference `
  "../../src/api/Lwrp.Api/Lwrp.Api.csproj" `
  "../../src/infrastructure/Lwrp.LivewireClient/Lwrp.LivewireClient.csproj"

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
COPY . .
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
COPY . .
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
'@ | Set-Content "ops/docker/docker-compose.yml"

Write-Host "Running dotnet build + test..."
dotnet build
dotnet test

Write-Host "Bootstrap complete! Repo root: $(Get-Location)"
