FROM mcr.microsoft.com/dotnet/core-nightly/sdk:3.1 AS build-env
WORKDIR /app
EXPOSE 443
# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core-nightly/aspnet:3.1

WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "Partage.Link.Api.dll"]
