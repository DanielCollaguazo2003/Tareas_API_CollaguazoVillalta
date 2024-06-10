# Etapa base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["/Tareas_API.csproj", "Tareas_API/"]
RUN dotnet restore "Tareas_API/Tareas_API.csproj"
COPY . .
WORKDIR "/src/Tareas_API"
RUN dotnet build "./Tareas_API.csproj" -c Release -o /app/build

# Etapa de publicación
FROM build AS publish
RUN dotnet publish "Tareas_API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Etapa final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Modificar el punto de entrada para usar `dotnet run`
ENTRYPOINT ["dotnet", "run", "--project", "Tareas_API.csproj"]
