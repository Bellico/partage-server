FROM mcr.microsoft.com/dotnet/core-nightly/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./src/gateways/Partage.Gateway.Api/*.csproj ./src/gateways/Partage.Gateway.Api/
RUN dotnet restore ./src/gateways/Partage.Gateway.Api/

# Copy protos
COPY ./src/services/Link/Partage.Link.Api/Protos/link.proto ./src/services/Link/Partage.Link.Api/Protos/

# Copy everything else and build
COPY ./src/gateways/Partage.Gateway.Api/ ./src/gateways/Partage.Gateway.Api/
RUN dotnet publish ./src/gateways/Partage.Gateway.Api/ -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core-nightly/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "Partage.Gateway.Api.dll"]
