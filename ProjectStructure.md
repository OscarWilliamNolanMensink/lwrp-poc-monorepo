📦lwrp-poc-monorepo
 ┣ 📂docs
 ┃ ┣ 📂architecture
 ┃ ┣ 📂protocol
 ┃ ┗ 📂requirements
 ┣ 📂ops
 ┃ ┣ 📂ci
 ┃ ┣ 📂docker
 ┃ ┃ ┣ 📜api.Dockerfile
 ┃ ┃ ┣ 📜docker-compose.yml
 ┃ ┃ ┗ 📜ui.Dockerfile
 ┃ ┗ 📂scripts
 ┃ ┃ ┗ 📜bootsrap-lwrp.ps1
 ┣ 📂src
 ┃ ┣ 📂api
 ┃ ┃ ┗ 📂Lwrp.Api
 ┃ ┃ ┃ ┣ 📂Properties
 ┃ ┃ ┃ ┃ ┗ 📜launchSettings.json
 ┃ ┃ ┃ ┣ 📜appsettings.Development.json
 ┃ ┃ ┃ ┣ 📜appsettings.json
 ┃ ┃ ┃ ┣ 📜Lwrp.Api.csproj
 ┃ ┃ ┃ ┣ 📜Lwrp.Api.http
 ┃ ┃ ┃ ┗ 📜Program.cs
 ┃ ┣ 📂core
 ┃ ┃ ┣ 📂Lwrp.Application
 ┃ ┃ ┃ ┣ 📜Class1.cs
 ┃ ┃ ┃ ┗ 📜Lwrp.Application.csproj
 ┃ ┃ ┗ 📂Lwrp.Domain
 ┃ ┃ ┃ ┣ 📜Class1.cs
 ┃ ┃ ┃ ┗ 📜Lwrp.Domain.csproj
 ┃ ┣ 📂infrastructure
 ┃ ┃ ┣ 📂Lwrp.LivewireClient
 ┃ ┃ ┃ ┣ 📜Class1.cs
 ┃ ┃ ┃ ┗ 📜Lwrp.LivewireClient.csproj
 ┃ ┃ ┗ 📂Lwrp.Persistence
 ┃ ┃ ┃ ┣ 📜Class1.cs
 ┃ ┃ ┃ ┗ 📜Lwrp.Persistence.csproj
 ┃ ┣ 📂shared
 ┃ ┃ ┗ 📂Lwrp.Contracts
 ┃ ┃ ┃ ┣ 📜Class1.cs
 ┃ ┃ ┃ ┗ 📜Lwrp.Contracts.csproj
 ┃ ┗ 📂ui
 ┃ ┃ ┗ 📂Lwrp.WebUi
 ┃ ┃ ┃ ┣ 📂Components
 ┃ ┃ ┃ ┃ ┣ 📂Layout
 ┃ ┃ ┃ ┃ ┃ ┣ 📜MainLayout.razor
 ┃ ┃ ┃ ┃ ┃ ┣ 📜MainLayout.razor.css
 ┃ ┃ ┃ ┃ ┃ ┣ 📜NavMenu.razor
 ┃ ┃ ┃ ┃ ┃ ┗ 📜NavMenu.razor.css
 ┃ ┃ ┃ ┃ ┣ 📂Pages
 ┃ ┃ ┃ ┃ ┃ ┣ 📜Counter.razor
 ┃ ┃ ┃ ┃ ┃ ┣ 📜Error.razor
 ┃ ┃ ┃ ┃ ┃ ┣ 📜Home.razor
 ┃ ┃ ┃ ┃ ┃ ┗ 📜Weather.razor
 ┃ ┃ ┃ ┃ ┣ 📜App.razor
 ┃ ┃ ┃ ┃ ┣ 📜Routes.razor
 ┃ ┃ ┃ ┃ ┗ 📜_Imports.razor
 ┃ ┃ ┃ ┣ 📂Properties
 ┃ ┃ ┃ ┃ ┗ 📜launchSettings.json
 ┃ ┃ ┃ ┣ 📂wwwroot
 ┃ ┃ ┃ ┃ ┣ 📂bootstrap
 ┃ ┃ ┃ ┃ ┃ ┣ 📜bootstrap.min.css
 ┃ ┃ ┃ ┃ ┃ ┗ 📜bootstrap.min.css.map
 ┃ ┃ ┃ ┃ ┣ 📜app.css
 ┃ ┃ ┃ ┃ ┗ 📜favicon.png
 ┃ ┃ ┃ ┣ 📜appsettings.Development.json
 ┃ ┃ ┃ ┣ 📜appsettings.json
 ┃ ┃ ┃ ┣ 📜Lwrp.WebUi.csproj
 ┃ ┃ ┃ ┗ 📜Program.cs
 ┣ 📂tests
 ┃ ┣ 📂component
 ┃ ┃ ┣ 📂Lwrp.ComponentTests.ApiToLwrp
 ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┃ ┃ ┗ 📂Lwrp.ComponentTests.UiToApi
 ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┃ ┣ 📂integration
 ┃ ┃ ┣ 📂Lwrp.Api.IntegrationTests
 ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┃ ┃ ┗ 📂Lwrp.Infrastructure.IntegrationTests
 ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┃ ┗ 📂unit
 ┃ ┃ ┣ 📂Lwrp.Application.UnitTests
 ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┃ ┃ ┗ 📂Lwrp.Domain.UnitTests
 ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┣ 📜.gitignore
 ┣ 📜.global.json
 ┣ 📜CatGPT-Setup-Instructions-FolderManagment.md
 ┣ 📜LICENSE
 ┣ 📜LwrpPoC.sln
 ┣ 📜ProjectStructure.md
 ┗ 📜README.md