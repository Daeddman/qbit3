FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task39/task39.csproj", "task39/"]
RUN dotnet restore "task39/task39.csproj"
COPY . .
WORKDIR "/src/task39"
RUN dotnet build "task39.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task39.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task39.dll"]
