FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task34/task34.csproj", "task34/"]
RUN dotnet restore "task34/task34.csproj"
COPY . .
WORKDIR "/src/task34"
RUN dotnet build "task34.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task34.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task34.dll"]
