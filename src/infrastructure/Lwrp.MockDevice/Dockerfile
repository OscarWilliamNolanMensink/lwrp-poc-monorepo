FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project file and restore
COPY Lwrp.MockDevice.csproj .
RUN dotnet restore Lwrp.MockDevice.csproj

# Copy the rest of the source
COPY . .

# Publish
RUN dotnet publish Lwrp.MockDevice.csproj -c Release -o /app/publish

# Runtime image
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Lwrp.MockDevice.dll"]
