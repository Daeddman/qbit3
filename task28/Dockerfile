FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task28/task28.csproj", "task28/"]
RUN dotnet restore "task28/task28.csproj"
COPY . .
WORKDIR "/src/task28"
RUN dotnet build "task28.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task28.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task28.dll"]
