FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task32/task32.csproj", "task32/"]
RUN dotnet restore "task32/task32.csproj"
COPY . .
WORKDIR "/src/task32"
RUN dotnet build "task32.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task32.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task32.dll"]
