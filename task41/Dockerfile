FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task41/task41.csproj", "task41/"]
RUN dotnet restore "task41/task41.csproj"
COPY . .
WORKDIR "/src/task41"
RUN dotnet build "task41.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task41.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task41.dll"]
