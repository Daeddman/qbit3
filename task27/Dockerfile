FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task27/task27.csproj", "task27/"]
RUN dotnet restore "task27/task27.csproj"
COPY . .
WORKDIR "/src/task27"
RUN dotnet build "task27.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task27.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task27.dll"]
