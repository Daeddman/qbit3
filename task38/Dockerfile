FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task38/task38.csproj", "task38/"]
RUN dotnet restore "task38/task38.csproj"
COPY . .
WORKDIR "/src/task38"
RUN dotnet build "task38.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task38.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task38.dll"]
