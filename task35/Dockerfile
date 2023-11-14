FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["task35/task35.csproj", "task35/"]
RUN dotnet restore "task35/task35.csproj"
COPY . .
WORKDIR "/src/task35"
RUN dotnet build "task35.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task35.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task35.dll"]
