FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task40/task40.csproj", "task40/"]
RUN dotnet restore "task40/task40.csproj"
COPY . .
WORKDIR "/src/task40"
RUN dotnet build "task40.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task40.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task40.dll"]
