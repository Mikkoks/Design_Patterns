FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Factory Patterns/Factory Patterns.csproj", "Factory Patterns/"]
RUN dotnet restore "Factory Patterns/Factory Patterns.csproj"
COPY . .
WORKDIR "/src/Factory Patterns"
RUN dotnet build "Factory Patterns.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Factory Patterns.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Factory Patterns.dll"]
