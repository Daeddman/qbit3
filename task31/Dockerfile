FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task31/task31.csproj", "task31/"]
RUN dotnet restore "task31/task31.csproj"
COPY . .
WORKDIR "/src/task31"
RUN dotnet build "task31.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task31.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task31.dll"]
