FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task36/task36.csproj", "task36/"]
RUN dotnet restore "task36/task36.csproj"
COPY . .
WORKDIR "/src/task36"
RUN dotnet build "task36.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task36.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task36.dll"]
