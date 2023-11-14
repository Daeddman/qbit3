FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task37/task37.csproj", "task37/"]
RUN dotnet restore "task37/task37.csproj"
COPY . .
WORKDIR "/src/task37"
RUN dotnet build "task37.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task37.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task37.dll"]
