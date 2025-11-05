# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and all project files
COPY ../MyProj.sln ./
COPY ../MyProj ./MyProj
COPY ../MyProjTests ./MyProjTests
COPY ../TodoApi ./TodoApi

# Restore dependencies
RUN dotnet restore MyProj.sln

# Build and publish the app
RUN dotnet publish MyProj/MyProj.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "MyProj.dll"]
