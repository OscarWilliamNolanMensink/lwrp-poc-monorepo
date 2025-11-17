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
 ┃ ┃ ┃ ┣ 📂bin
 ┃ ┃ ┃ ┃ ┗ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂de
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂es
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂fr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂it
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ja
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ko
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pt-BR
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ru
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂tr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hans
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hant
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜appsettings.Development.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜appsettings.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜CoverletSourceRootsMapping_Lwrp.ComponentTests.ApiToLwrp
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.deps.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.staticwebassets.endpoints.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.deps.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Contracts.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Contracts.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.LivewireClient.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.LivewireClient.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Persistence.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Persistence.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.AspNetCore.OpenApi.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.OpenApi.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.PlatformAbstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.Utilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.CodeCoverage.Shim.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Newtonsoft.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜NuGet.Frameworks.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Swashbuckle.AspNetCore.Swagger.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Swashbuckle.AspNetCore.SwaggerGen.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Swashbuckle.AspNetCore.SwaggerUI.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.assert.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.core.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.execution.dotnet.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.reporters.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.utility.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜xunit.runner.visualstudio.dotnetcore.testadapter.dll
 ┃ ┃ ┃ ┣ 📂obj
 ┃ ┃ ┃ ┃ ┣ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┣ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ref
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.ComponentTests.ApiToLwrp.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.ComponentTests.ApiToLwrp.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v8.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Com.2830C9E5.Up2Date
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.assets.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.genruntimeconfig.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.ComponentTests.ApiToLwrp.sourcelink.json
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net9.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v9.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.ComponentTests.ApiToLwrp.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.csproj.nuget.dgspec.json
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.csproj.nuget.g.props
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.csproj.nuget.g.targets
 ┃ ┃ ┃ ┃ ┣ 📜project.assets.json
 ┃ ┃ ┃ ┃ ┗ 📜project.nuget.cache
 ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.ApiToLwrp.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┃ ┃ ┗ 📂Lwrp.ComponentTests.UiToApi
 ┃ ┃ ┃ ┣ 📂bin
 ┃ ┃ ┃ ┃ ┗ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂de
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂es
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂fr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂it
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ja
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ko
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pt-BR
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ru
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂tr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hans
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hant
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜appsettings.Development.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜appsettings.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜CoverletSourceRootsMapping_Lwrp.ComponentTests.UiToApi
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.deps.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Contracts.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Contracts.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.WebUi.deps.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.WebUi.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.WebUi.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.WebUi.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.WebUi.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.WebUi.staticwebassets.endpoints.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.WebUi.staticwebassets.runtime.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.PlatformAbstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.Utilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.CodeCoverage.Shim.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Newtonsoft.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜NuGet.Frameworks.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.assert.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.core.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.execution.dotnet.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.reporters.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.utility.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜xunit.runner.visualstudio.dotnetcore.testadapter.dll
 ┃ ┃ ┃ ┣ 📂obj
 ┃ ┃ ┃ ┃ ┣ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┣ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ref
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.ComponentTests.UiToApi.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.ComponentTests.UiToApi.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v8.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Com.32C3E66D.Up2Date
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.assets.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.genruntimeconfig.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.ComponentTests.UiToApi.sourcelink.json
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net9.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v9.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.ComponentTests.UiToApi.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.csproj.nuget.dgspec.json
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.csproj.nuget.g.props
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.csproj.nuget.g.targets
 ┃ ┃ ┃ ┃ ┣ 📜project.assets.json
 ┃ ┃ ┃ ┃ ┗ 📜project.nuget.cache
 ┃ ┃ ┃ ┣ 📜Lwrp.ComponentTests.UiToApi.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┃ ┣ 📂integration
 ┃ ┃ ┣ 📂Lwrp.Api.IntegrationTests
 ┃ ┃ ┃ ┣ 📂bin
 ┃ ┃ ┃ ┃ ┗ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂de
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂es
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂fr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂it
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ja
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ko
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pt-BR
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ru
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂tr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hans
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hant
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜appsettings.Development.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜appsettings.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜CoverletSourceRootsMapping_Lwrp.Api.IntegrationTests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.deps.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.deps.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.staticwebassets.endpoints.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Contracts.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Contracts.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.LivewireClient.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.LivewireClient.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Persistence.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Persistence.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.AspNetCore.OpenApi.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.OpenApi.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.PlatformAbstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.Utilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.CodeCoverage.Shim.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Newtonsoft.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜NuGet.Frameworks.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Swashbuckle.AspNetCore.Swagger.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Swashbuckle.AspNetCore.SwaggerGen.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Swashbuckle.AspNetCore.SwaggerUI.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.assert.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.core.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.execution.dotnet.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.reporters.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.utility.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜xunit.runner.visualstudio.dotnetcore.testadapter.dll
 ┃ ┃ ┃ ┣ 📂obj
 ┃ ┃ ┃ ┃ ┣ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ref
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Api.IntegrationTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Api.IntegrationTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v8.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.79D1670D.Up2Date
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.assets.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.genruntimeconfig.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Api.IntegrationTests.sourcelink.json
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.csproj.nuget.dgspec.json
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.csproj.nuget.g.props
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.csproj.nuget.g.targets
 ┃ ┃ ┃ ┃ ┣ 📜project.assets.json
 ┃ ┃ ┃ ┃ ┗ 📜project.nuget.cache
 ┃ ┃ ┃ ┣ 📜Lwrp.Api.IntegrationTests.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┃ ┃ ┗ 📂Lwrp.Infrastructure.IntegrationTests
 ┃ ┃ ┃ ┣ 📂bin
 ┃ ┃ ┃ ┃ ┗ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂de
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂es
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂fr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂it
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ja
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ko
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pt-BR
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ru
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂tr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hans
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hant
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜CoverletSourceRootsMapping_Lwrp.Infrastructure.IntegrationTests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.deps.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.LivewireClient.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.LivewireClient.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Persistence.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Persistence.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.PlatformAbstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.Utilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.CodeCoverage.Shim.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Newtonsoft.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜NuGet.Frameworks.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.assert.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.core.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.execution.dotnet.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.reporters.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.utility.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜xunit.runner.visualstudio.dotnetcore.testadapter.dll
 ┃ ┃ ┃ ┣ 📂obj
 ┃ ┃ ┃ ┃ ┣ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┣ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ref
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Infrastructure.IntegrationTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Infrastructure.IntegrationTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v8.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Inf.DC6C60B6.Up2Date
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.assets.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.genruntimeconfig.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Infrastructure.IntegrationTests.sourcelink.json
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net9.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v9.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Infrastructure.IntegrationTests.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.csproj.nuget.dgspec.json
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.csproj.nuget.g.props
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.csproj.nuget.g.targets
 ┃ ┃ ┃ ┃ ┣ 📜project.assets.json
 ┃ ┃ ┃ ┃ ┗ 📜project.nuget.cache
 ┃ ┃ ┃ ┣ 📜Lwrp.Infrastructure.IntegrationTests.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┃ ┗ 📂unit
 ┃ ┃ ┣ 📂Lwrp.Application.UnitTests
 ┃ ┃ ┃ ┣ 📂bin
 ┃ ┃ ┃ ┃ ┗ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂de
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂es
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂fr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂it
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ja
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ko
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pt-BR
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ru
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂tr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hans
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hant
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜CoverletSourceRootsMapping_Lwrp.Application.UnitTests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.deps.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.PlatformAbstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.Utilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.CodeCoverage.Shim.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Newtonsoft.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜NuGet.Frameworks.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.assert.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.core.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.execution.dotnet.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.reporters.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.utility.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜xunit.runner.visualstudio.dotnetcore.testadapter.dll
 ┃ ┃ ┃ ┣ 📂obj
 ┃ ┃ ┃ ┃ ┣ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ref
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Application.UnitTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Application.UnitTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v8.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.App.237A4403.Up2Date
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.assets.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.genruntimeconfig.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Application.UnitTests.sourcelink.json
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.csproj.nuget.dgspec.json
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.csproj.nuget.g.props
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.csproj.nuget.g.targets
 ┃ ┃ ┃ ┃ ┣ 📜project.assets.json
 ┃ ┃ ┃ ┃ ┗ 📜project.nuget.cache
 ┃ ┃ ┃ ┣ 📜Lwrp.Application.UnitTests.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┃ ┃ ┗ 📂Lwrp.Domain.UnitTests
 ┃ ┃ ┃ ┣ 📂bin
 ┃ ┃ ┃ ┃ ┗ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂de
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂es
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂fr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂it
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ja
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ko
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pl
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂pt-BR
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ru
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂tr
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hans
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂zh-Hant
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜CoverletSourceRootsMapping_Lwrp.Domain.UnitTests
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.deps.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.runtimeconfig.json
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CommunicationUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CoreUtilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.CrossPlatEngine.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.PlatformAbstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.TestPlatform.Utilities.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.CodeCoverage.Shim.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.Common.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Microsoft.VisualStudio.TestPlatform.ObjectModel.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Newtonsoft.Json.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜NuGet.Frameworks.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜testhost.exe
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.abstractions.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.assert.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.core.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.execution.dotnet.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.reporters.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜xunit.runner.utility.netcoreapp10.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜xunit.runner.visualstudio.dotnetcore.testadapter.dll
 ┃ ┃ ┃ ┣ 📂obj
 ┃ ┃ ┃ ┃ ┣ 📂Debug
 ┃ ┃ ┃ ┃ ┃ ┗ 📂net8.0
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂ref
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Domain.UnitTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📂refint
 ┃ ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Domain.UnitTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜.NETCoreApp,Version=v8.0.AssemblyAttributes.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Dom.BAE06B37.Up2Date
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.AssemblyInfo.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.AssemblyInfoInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.assets.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.csproj.AssemblyReference.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.csproj.CoreCompileInputs.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.csproj.FileListAbsolute.txt
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.dll
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.GeneratedMSBuildEditorConfig.editorconfig
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.genruntimeconfig.cache
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.GlobalUsings.g.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.pdb
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Lwrp.Domain.UnitTests.sourcelink.json
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.csproj.nuget.dgspec.json
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.csproj.nuget.g.props
 ┃ ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.csproj.nuget.g.targets
 ┃ ┃ ┃ ┃ ┣ 📜project.assets.json
 ┃ ┃ ┃ ┃ ┗ 📜project.nuget.cache
 ┃ ┃ ┃ ┣ 📜Lwrp.Domain.UnitTests.csproj
 ┃ ┃ ┃ ┗ 📜UnitTest1.cs
 ┣ 📜.gitignore
 ┣ 📜.global.json
 ┣ 📜CatGPT-Setup-Instructions-FolderManagment.md
 ┣ 📜LICENSE
 ┣ 📜LwrpPoC.sln
 ┣ 📜ProjectStructure.md
 ┗ 📜README.md