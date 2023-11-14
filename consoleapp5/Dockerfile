FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["consoleapp5/consoleapp5.csproj", "consoleapp5/"]
RUN dotnet restore "consoleapp5/consoleapp5.csproj"
COPY . .
WORKDIR "/src/consoleapp5"
RUN dotnet build "consoleapp5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "consoleapp5.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "consoleapp5.dll"]
