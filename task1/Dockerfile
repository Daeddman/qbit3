FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["qbit_3/qbit_3.csproj", "qbit_3/"]
RUN dotnet restore "qbit_3/qbit_3.csproj"
COPY . .
WORKDIR "/src/qbit_3"
RUN dotnet build "qbit_3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "qbit_3.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "qbit_3.dll"]
