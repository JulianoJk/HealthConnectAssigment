FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HealthConnect/HealthConnect.csproj", "HealthConnect/"]
RUN dotnet restore "HealthConnect/HealthConnect.csproj"
COPY . .
WORKDIR "/src/HealthConnect"
RUN dotnet add package Microsoft.AspNetCore.Cors
RUN dotnet add package Microsoft.AspNetCore
RUN dotnet add package dotenv.net
RUN dotnet add package MySql.Data
RUN dotnet add package Microsoft.EntityFrameworkCore
RUN dotnet add package Microsoft.EntityFrameworkCore.Design
RUN dotnet add package Microsoft.EntityFrameworkCore.Tools
RUN dotnet build "HealthConnect.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HealthConnect.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HealthConnect.dll"]
