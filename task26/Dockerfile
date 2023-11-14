FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task26/task26.csproj", "task26/"]
RUN dotnet restore "task26/task26.csproj"
COPY . .
WORKDIR "/src/task26"
RUN dotnet build "task26.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task26.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task26.dll"]
